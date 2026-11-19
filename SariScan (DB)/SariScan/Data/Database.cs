using Microsoft.Data.SqlClient;

namespace SariScan;

/// <summary>Connects to SQL Server and creates the database, tables and starter data on first run.</summary>
public static class Database
{
    private const string DefaultConnection =
        @"Server=(localdb)\MSSQLLocalDB;Database=SariScan;Trusted_Connection=True;TrustServerCertificate=True;Connect Timeout=15";

    public static string ConnectionString { get; private set; } = DefaultConnection;

    public static SqlConnection Open()
    {
        var cn = new SqlConnection(ConnectionString);
        cn.Open();
        return cn;
    }

    public static void Initialize()
    {
        var builder = new SqlConnectionStringBuilder(LoadConnectionString());
        if (string.IsNullOrWhiteSpace(builder.InitialCatalog)) builder.InitialCatalog = "SariScan";
        string dbName = builder.InitialCatalog;
        if (!dbName.All(c => char.IsLetterOrDigit(c) || c == '_'))
            throw new InvalidOperationException("The database name may only contain letters, digits and underscores.");
        ConnectionString = builder.ConnectionString;

        // 1) Create the database if it does not exist yet
        var master = new SqlConnectionStringBuilder(ConnectionString) { InitialCatalog = "master" };
        using (var cn = new SqlConnection(master.ConnectionString))
        {
            cn.Open();
            using var cmd = cn.CreateCommand();
            cmd.CommandTimeout = 60;
            cmd.CommandText = $"IF DB_ID(N'{dbName}') IS NULL CREATE DATABASE [{dbName}];";
            cmd.ExecuteNonQuery();
        }

        // 2) Create tables and add starter data
        using var conn = Open();
        bool firstRun = Scalar<int>(conn, "SELECT CASE WHEN OBJECT_ID(N'dbo.Users', N'U') IS NULL THEN 1 ELSE 0 END") == 1;
        foreach (var sql in Schema) Exec(conn, sql);
        if (Scalar<int>(conn, "SELECT COUNT(*) FROM dbo.Users") == 0) SeedUsers(conn);
        if (firstRun) SeedProducts(conn);
    }

    private static string LoadConnectionString()
    {
        try
        {
            string path = Path.Combine(AppContext.BaseDirectory, "connection.txt");
            if (File.Exists(path))
            {
                foreach (var line in File.ReadAllLines(path))
                {
                    var t = line.Trim();
                    if (t.Length > 0 && !t.StartsWith("#")) return t;
                }
            }
        }
        catch { /* fall back to the default */ }
        return DefaultConnection;
    }

    private static void Exec(SqlConnection cn, string sql)
    {
        using var cmd = new SqlCommand(sql, cn);
        cmd.ExecuteNonQuery();
    }

    private static T Scalar<T>(SqlConnection cn, string sql)
    {
        using var cmd = new SqlCommand(sql, cn);
        return (T)Convert.ChangeType(cmd.ExecuteScalar(), typeof(T));
    }

    // ---------- Starter data ----------
    private static void SeedUsers(SqlConnection cn)
    {
        AddUser(cn, "owner", "owner123", "Store Owner", "Owner", true);
        AddUser(cn, "attendant", "attendant123", "Store Attendant", "Attendant", false);
    }

    private static void AddUser(SqlConnection cn, string username, string password, string fullName, string role, bool canUpdate)
    {
        var (hash, salt) = PasswordHasher.Hash(password);
        using var cmd = new SqlCommand(
            "INSERT INTO dbo.Users (Username, FullName, UserRole, CanUpdateStock, PasswordHash, Salt) VALUES (@u, @f, @r, @c, @h, @s)", cn);
        cmd.Parameters.AddWithValue("@u", username);
        cmd.Parameters.AddWithValue("@f", fullName);
        cmd.Parameters.AddWithValue("@r", role);
        cmd.Parameters.AddWithValue("@c", canUpdate);
        cmd.Parameters.AddWithValue("@h", hash);
        cmd.Parameters.AddWithValue("@s", salt);
        cmd.ExecuteNonQuery();
    }

    private static void SeedProducts(SqlConnection cn)
    {
        var items = new (string Name, string Cat, decimal Cost, decimal Price, int Qty, int Limit)[]
        {
            ("Lucky Me Pancit Canton Original", "Instant Noodles", 11.50m, 16.00m, 48, 12),
            ("Piattos Cheese 40g",              "Snacks",          14.00m, 18.00m, 32, 10),
            ("Skyflakes Crackers 10s",          "Biscuits",         8.00m, 10.00m,  9, 10),
            ("Coke Mismo 290ml",                "Beverages",       14.50m, 20.00m, 24, 12),
            ("Century Tuna Flakes in Oil 155g", "Canned Goods",    33.00m, 42.00m,  6,  8),
            ("Ligo Sardines Tomato 155g",       "Canned Goods",    18.00m, 24.00m,  0,  6),
            ("Great Taste White 3-in-1",        "Beverages",        5.50m,  8.00m, 60, 20),
            ("Tang Orange Sachet",              "Beverages",        7.00m, 10.00m,  5, 12),
            ("Safeguard Soap 55g",              "Toiletries",      24.00m, 32.00m, 15,  6),
            ("Surf Powder Sachet",              "Household",        6.50m,  9.00m,  4, 10),
            ("Chippy BBQ 27g",                  "Snacks",           6.50m,  9.00m, 40, 15),
            ("Maxx Menthol Candy",              "Candies",          0.90m,  1.00m,120, 50),
        };
        foreach (var i in items)
        {
            using var cmd = new SqlCommand(
                "INSERT INTO dbo.Products (Name, Category, PurchaseCost, SellingPrice, Quantity, LowStockLimit) VALUES (@n,@c,@cost,@p,@q,@l)", cn);
            cmd.Parameters.AddWithValue("@n", i.Name);
            cmd.Parameters.AddWithValue("@c", i.Cat);
            cmd.Parameters.AddWithValue("@cost", i.Cost);
            cmd.Parameters.AddWithValue("@p", i.Price);
            cmd.Parameters.AddWithValue("@q", i.Qty);
            cmd.Parameters.AddWithValue("@l", i.Limit);
            cmd.ExecuteNonQuery();
        }
        // Put the products that are already low into the restock queue
        Exec(cn, "INSERT INTO dbo.RestockQueue (ProductId) SELECT ProductId FROM dbo.Products WHERE Quantity <= LowStockLimit ORDER BY ProductId");
    }

    // ---------- Schema (same as Database/SariScan.sql) ----------
    private static readonly string[] Schema =
    {
        @"IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
          CREATE TABLE dbo.Users (
              UserId         INT IDENTITY(1,1) PRIMARY KEY,
              Username       NVARCHAR(50)  NOT NULL UNIQUE,
              FullName       NVARCHAR(100) NOT NULL,
              UserRole       NVARCHAR(20)  NOT NULL CHECK (UserRole IN (N'Owner', N'Attendant')),
              CanUpdateStock BIT           NOT NULL DEFAULT 0,
              PasswordHash   VARBINARY(32) NOT NULL,
              Salt           VARBINARY(16) NOT NULL
          );",

        @"IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
          CREATE TABLE dbo.Products (
              ProductId     INT IDENTITY(1,1) PRIMARY KEY,
              Name          NVARCHAR(150) NOT NULL UNIQUE,
              Category      NVARCHAR(50)  NOT NULL,
              PurchaseCost  DECIMAL(10,2) NULL CHECK (PurchaseCost IS NULL OR PurchaseCost >= 0),
              SellingPrice  DECIMAL(10,2) NOT NULL CHECK (SellingPrice >= 0),
              Quantity      INT           NOT NULL CHECK (Quantity >= 0),
              LowStockLimit INT           NOT NULL CHECK (LowStockLimit >= 0),
              CreatedAt     DATETIME2     NOT NULL DEFAULT SYSDATETIME(),
              UpdatedAt     DATETIME2     NOT NULL DEFAULT SYSDATETIME()
          );",

        @"IF OBJECT_ID(N'dbo.RestockQueue', N'U') IS NULL
          CREATE TABLE dbo.RestockQueue (
              QueueId     INT IDENTITY(1,1) PRIMARY KEY,
              ProductId   INT NOT NULL REFERENCES dbo.Products(ProductId) ON DELETE CASCADE,
              FlaggedAt   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
              QueueStatus NVARCHAR(20) NOT NULL DEFAULT N'Pending'
                          CHECK (QueueStatus IN (N'Pending', N'Restocked', N'Removed')),
              ResolvedAt  DATETIME2 NULL
          );",

        // A product can be Pending in the queue only once at a time
        @"IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'UX_RestockQueue_OnePending'
                         AND object_id = OBJECT_ID(N'dbo.RestockQueue'))
          CREATE UNIQUE INDEX UX_RestockQueue_OnePending ON dbo.RestockQueue (ProductId)
          WHERE QueueStatus = N'Pending';",

        @"IF OBJECT_ID(N'dbo.RestockLog', N'U') IS NULL
          CREATE TABLE dbo.RestockLog (
              LogId         INT IDENTITY(1,1) PRIMARY KEY,
              ProductId     INT NOT NULL REFERENCES dbo.Products(ProductId) ON DELETE CASCADE,
              QuantityAdded INT NOT NULL CHECK (QuantityAdded > 0),
              DeliveryDate  DATE NOT NULL,
              RecordedBy    NVARCHAR(50) NOT NULL,
              RecordedAt    DATETIME2 NOT NULL DEFAULT SYSDATETIME()
          );",
    };
}
