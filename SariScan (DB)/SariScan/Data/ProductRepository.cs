using Microsoft.Data.SqlClient;

namespace SariScan;

public static class ProductRepository
{
    private const string Cols = "ProductId, Name, Category, PurchaseCost, SellingPrice, Quantity, LowStockLimit";

    private static Product Read(SqlDataReader r) => new(
        r.GetInt32(0), r.GetString(1), r.GetString(2),
        r.IsDBNull(3) ? null : r.GetDecimal(3), r.GetDecimal(4), r.GetInt32(5), r.GetInt32(6));

    private static List<Product> Query(string sql, Action<SqlCommand> bind = null)
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand(sql, cn);
        bind?.Invoke(cmd);
        using var r = cmd.ExecuteReader();
        var list = new List<Product>();
        while (r.Read()) list.Add(Read(r));
        return list;
    }

    /// <summary>Search by name or category, optionally filtered by category and stock status.</summary>
    public static List<Product> Search(string text = null, string category = null, string status = null)
    {
        var sql = $"SELECT {Cols} FROM dbo.Products WHERE 1 = 1";
        bool hasText = !string.IsNullOrWhiteSpace(text);
        if (hasText) sql += " AND (CHARINDEX(@t, Name) > 0 OR CHARINDEX(@t, Category) > 0)";
        if (!string.IsNullOrEmpty(category)) sql += " AND Category = @c";
        sql += status switch
        {
            "In Stock"     => " AND Quantity > LowStockLimit",
            "Low Stock"    => " AND Quantity > 0 AND Quantity <= LowStockLimit",
            "Out of Stock" => " AND Quantity = 0",
            _ => ""
        };
        sql += " ORDER BY Name";

        return Query(sql, cmd =>
        {
            if (hasText) cmd.Parameters.AddWithValue("@t", text.Trim());
            if (!string.IsNullOrEmpty(category)) cmd.Parameters.AddWithValue("@c", category);
        });
    }

    /// <summary>Best match for the Quick Product Search (name that contains the text, earliest match first).</summary>
    public static Product FindBest(string text)
    {
        var list = Query($"SELECT TOP 1 {Cols} FROM dbo.Products WHERE CHARINDEX(@t, Name) > 0 ORDER BY CHARINDEX(@t, Name), Name",
            cmd => cmd.Parameters.AddWithValue("@t", text.Trim()));
        return list.FirstOrDefault();
    }

    /// <summary>Short list for the dashboard: low-stock items first.</summary>
    public static List<Product> GetSnapshot(int top) =>
        Query($"SELECT TOP ({top}) {Cols} FROM dbo.Products ORDER BY CASE WHEN Quantity <= LowStockLimit THEN 0 ELSE 1 END, Quantity, Name");

    public static List<Product> GetLowStock() =>
        Query($"SELECT {Cols} FROM dbo.Products WHERE Quantity <= LowStockLimit ORDER BY Quantity, Name");

    public static (int Total, int Low, int Pending) GetCounts()
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand(
            @"SELECT (SELECT COUNT(*) FROM dbo.Products),
                     (SELECT COUNT(*) FROM dbo.Products WHERE Quantity <= LowStockLimit),
                     (SELECT COUNT(*) FROM dbo.RestockQueue WHERE QueueStatus = N'Pending')", cn);
        using var r = cmd.ExecuteReader();
        r.Read();
        return (r.GetInt32(0), r.GetInt32(1), r.GetInt32(2));
    }

    public static int Add(Product p)
    {
        using var cn = Database.Open();
        using var tx = cn.BeginTransaction();
        using var cmd = new SqlCommand(
            @"INSERT INTO dbo.Products (Name, Category, PurchaseCost, SellingPrice, Quantity, LowStockLimit)
              OUTPUT INSERTED.ProductId
              VALUES (@n, @c, @cost, @price, @q, @l)", cn, tx);
        Bind(cmd, p);
        int id = (int)cmd.ExecuteScalar();
        QueueRepository.Sync(cn, tx, id, "Removed");
        tx.Commit();
        return id;
    }

    public static void Update(Product p)
    {
        using var cn = Database.Open();
        using var tx = cn.BeginTransaction();
        using var cmd = new SqlCommand(
            @"UPDATE dbo.Products
              SET Name = @n, Category = @c, PurchaseCost = @cost, SellingPrice = @price,
                  Quantity = @q, LowStockLimit = @l, UpdatedAt = SYSDATETIME()
              WHERE ProductId = @id", cn, tx);
        Bind(cmd, p);
        cmd.Parameters.AddWithValue("@id", p.Id);
        if (cmd.ExecuteNonQuery() == 0) throw new InvalidOperationException("That product no longer exists.");
        QueueRepository.Sync(cn, tx, p.Id, "Removed");
        tx.Commit();
    }

    public static void Delete(int productId)
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand("DELETE FROM dbo.Products WHERE ProductId = @id", cn);
        cmd.Parameters.AddWithValue("@id", productId);
        cmd.ExecuteNonQuery();   // queue and restock history rows are removed by ON DELETE CASCADE
    }

    /// <summary>Adds delivered quantity to the stock, logs it, then updates the restock queue.</summary>
    public static void Restock(int productId, int quantityAdded, DateTime deliveryDate, string recordedBy)
    {
        using var cn = Database.Open();
        using var tx = cn.BeginTransaction();

        using (var cmd = new SqlCommand(
            "UPDATE dbo.Products SET Quantity = Quantity + @add, UpdatedAt = SYSDATETIME() WHERE ProductId = @id", cn, tx))
        {
            cmd.Parameters.AddWithValue("@add", quantityAdded);
            cmd.Parameters.AddWithValue("@id", productId);
            if (cmd.ExecuteNonQuery() == 0) throw new InvalidOperationException("That product no longer exists.");
        }
        using (var cmd = new SqlCommand(
            "INSERT INTO dbo.RestockLog (ProductId, QuantityAdded, DeliveryDate, RecordedBy) VALUES (@id, @add, @d, @by)", cn, tx))
        {
            cmd.Parameters.AddWithValue("@id", productId);
            cmd.Parameters.AddWithValue("@add", quantityAdded);
            cmd.Parameters.AddWithValue("@d", deliveryDate.Date);
            cmd.Parameters.AddWithValue("@by", recordedBy);
            cmd.ExecuteNonQuery();
        }
        QueueRepository.Sync(cn, tx, productId, "Restocked");
        tx.Commit();
    }

    public static bool IsDuplicateName(SqlException ex) => ex.Number is 2627 or 2601;

    private static void Bind(SqlCommand cmd, Product p)
    {
        cmd.Parameters.AddWithValue("@n", p.Name);
        cmd.Parameters.AddWithValue("@c", p.Category);
        cmd.Parameters.AddWithValue("@cost", (object)p.Cost ?? DBNull.Value);
        cmd.Parameters.AddWithValue("@price", p.Price);
        cmd.Parameters.AddWithValue("@q", p.Qty);
        cmd.Parameters.AddWithValue("@l", p.Limit);
    }
}
