using Microsoft.Data.SqlClient;

namespace SariScan;

public static class QueueRepository
{
    /// <summary>Pending items in first-in, first-out order (oldest flagged first).</summary>
    public static List<QueueItem> GetPending()
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand(
            @"SELECT q.QueueId, p.ProductId, p.Name, p.Category, p.Quantity, p.LowStockLimit, q.FlaggedAt
              FROM dbo.RestockQueue q
              JOIN dbo.Products p ON p.ProductId = q.ProductId
              WHERE q.QueueStatus = N'Pending'
              ORDER BY q.QueueId", cn);
        using var r = cmd.ExecuteReader();
        var list = new List<QueueItem>();
        while (r.Read())
            list.Add(new QueueItem(r.GetInt32(0), r.GetInt32(1), r.GetString(2), r.GetString(3),
                                   r.GetInt32(4), r.GetInt32(5), r.GetDateTime(6)));
        return list;
    }

    /// <summary>Owner reviewed the item and takes it off the queue.</summary>
    public static void Remove(int queueId)
    {
        using var cn = Database.Open();
        using var cmd = new SqlCommand(
            "UPDATE dbo.RestockQueue SET QueueStatus = N'Removed', ResolvedAt = SYSDATETIME() WHERE QueueId = @id AND QueueStatus = N'Pending'", cn);
        cmd.Parameters.AddWithValue("@id", queueId);
        cmd.ExecuteNonQuery();
    }

    /// <summary>
    /// Keeps the queue correct for one product:
    /// - if the product is no longer low, its pending entry is closed (as resolveAs);
    /// - if it is at or below its limit and not already pending, it joins the end of the queue.
    /// </summary>
    public static void Sync(SqlConnection cn, SqlTransaction tx, int productId, string resolveAs)
    {
        using var cmd = new SqlCommand(
            @"UPDATE q SET QueueStatus = @res, ResolvedAt = SYSDATETIME()
              FROM dbo.RestockQueue q
              JOIN dbo.Products p ON p.ProductId = q.ProductId
              WHERE q.ProductId = @id AND q.QueueStatus = N'Pending' AND p.Quantity > p.LowStockLimit;

              INSERT INTO dbo.RestockQueue (ProductId)
              SELECT p.ProductId FROM dbo.Products p
              WHERE p.ProductId = @id AND p.Quantity <= p.LowStockLimit
                AND NOT EXISTS (SELECT 1 FROM dbo.RestockQueue q
                                WHERE q.ProductId = p.ProductId AND q.QueueStatus = N'Pending');", cn, tx);
        cmd.Parameters.AddWithValue("@id", productId);
        cmd.Parameters.AddWithValue("@res", resolveAs);
        cmd.ExecuteNonQuery();
    }
}
