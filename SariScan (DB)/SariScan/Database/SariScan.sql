-- SariScan database script (optional).
-- The app creates all of this automatically on first run. Use this script only if you prefer
-- to create the database yourself in SQL Server Management Studio (SSMS).
-- The app will still add the default users on first run if the Users table is empty.

IF DB_ID(N'SariScan') IS NULL CREATE DATABASE SariScan;
GO
USE SariScan;
GO

IF OBJECT_ID(N'dbo.Users', N'U') IS NULL
CREATE TABLE dbo.Users (
    UserId         INT IDENTITY(1,1) PRIMARY KEY,
    Username       NVARCHAR(50)  NOT NULL UNIQUE,
    FullName       NVARCHAR(100) NOT NULL,
    UserRole       NVARCHAR(20)  NOT NULL CHECK (UserRole IN (N'Owner', N'Attendant')),
    CanUpdateStock BIT           NOT NULL DEFAULT 0,
    PasswordHash   VARBINARY(32) NOT NULL,
    Salt           VARBINARY(16) NOT NULL
);
GO

IF OBJECT_ID(N'dbo.Products', N'U') IS NULL
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
);
GO

IF OBJECT_ID(N'dbo.RestockQueue', N'U') IS NULL
CREATE TABLE dbo.RestockQueue (
    QueueId     INT IDENTITY(1,1) PRIMARY KEY,           -- FIFO order = QueueId order
    ProductId   INT NOT NULL REFERENCES dbo.Products(ProductId) ON DELETE CASCADE,
    FlaggedAt   DATETIME2 NOT NULL DEFAULT SYSDATETIME(),
    QueueStatus NVARCHAR(20) NOT NULL DEFAULT N'Pending'
                CHECK (QueueStatus IN (N'Pending', N'Restocked', N'Removed')),
    ResolvedAt  DATETIME2 NULL
);
GO

-- A product can be Pending in the queue only once at a time
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE name = N'UX_RestockQueue_OnePending'
               AND object_id = OBJECT_ID(N'dbo.RestockQueue'))
CREATE UNIQUE INDEX UX_RestockQueue_OnePending ON dbo.RestockQueue (ProductId)
WHERE QueueStatus = N'Pending';
GO

IF OBJECT_ID(N'dbo.RestockLog', N'U') IS NULL
CREATE TABLE dbo.RestockLog (
    LogId         INT IDENTITY(1,1) PRIMARY KEY,
    ProductId     INT NOT NULL REFERENCES dbo.Products(ProductId) ON DELETE CASCADE,
    QuantityAdded INT NOT NULL CHECK (QuantityAdded > 0),
    DeliveryDate  DATE NOT NULL,
    RecordedBy    NVARCHAR(50) NOT NULL,
    RecordedAt    DATETIME2 NOT NULL DEFAULT SYSDATETIME()
);
GO

-- Handy queries
-- Give the attendant permission to update stock:
--   UPDATE dbo.Users SET CanUpdateStock = 1 WHERE Username = N'attendant';
-- See the restock queue in FIFO order:
--   SELECT q.QueueId, p.Name, p.Quantity, p.LowStockLimit, q.FlaggedAt
--   FROM dbo.RestockQueue q JOIN dbo.Products p ON p.ProductId = q.ProductId
--   WHERE q.QueueStatus = N'Pending' ORDER BY q.QueueId;
