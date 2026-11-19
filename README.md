# SariScan – Windows Forms + Microsoft SQL Server

Inventory and Price Checker for a small sari-sari store.

## Run
1. Open `SariScan.csproj` in Visual Studio 2022 (needs internet once, to download the `Microsoft.Data.SqlClient` package).
2. Press "F5". On first run the app creates the "SariScan" database, its tables, two users and 12 sample products.

## Database setup
The connection string is the first non-comment line of "connection.txt" (in the project folder).
It defaults to "LocalDB", which comes with Visual Studio:

    Server=(localdb)\MSSQLLocalDB;Database=SariScan;Trusted_Connection=True;TrustServerCertificate=True

Using SQL Server Express or a full SQL Server instead? Replace that line with one of the examples inside `connection.txt`,
then run again. If your account is not allowed to create databases, create it first by running `Database/SariScan.sql`
in SQL Server Management Studio.

## Sign in
| Username | Password | Role |
| --- | --- | --- |
| `owner` | `owner123` | Store Owner – full access |
| `attendant` | `attendant123` | Attendant – view only (can restock if the owner grants permission) |

To let the attendant update stock, run in SSMS:
`UPDATE dbo.Users SET CanUpdateStock = 1 WHERE Username = N'attendant';`

Passwords are stored as salted PBKDF2 hashes, never as plain text.

## What each screen does
- Dashboard – total products, low-stock count, pending restock count, Quick Product Search (type a name), and a snapshot of 8 products (low-stock first).
- Products – pick a row to edit it; Add / Update / Delete / Clear. Name must be unique; selling price must be above zero; purchase cost is optional (leave at 0 for none). Owner only.
- Inventory – search by name or category, filter by category and stock status, Restock Selected.
- Restock Queue – low-stock products in first-in, first-out order. Restock Selected records a delivery; Remove from Queue is for items the owner has reviewed.
- Low Stock Alerts – a card for every product at or below its low-stock limit.
- Restock dialog – enter quantity received and delivery date; the stock is increased and the delivery is saved in `RestockLog`.

## Restock queue rules
- A product is added to the queue when its quantity is equal to or below its low-stock limit (after adding, editing or restocking it).
- It is added only once while it is pending (enforced by a unique index in SQL Server).
- When a product goes back above its limit (restock or edit), its queue entry is closed automatically.
- If the owner removes an item that is still low, it can join the queue again the next time that product is saved or restocked.

## Folders
- `Data/` – database code (`Database.cs`, repositories, `Session.cs`, `PasswordHasher.cs`)
- `Pages/`, `Dialogs/`, `LoginForm`, `MainForm` – the Designer screens (each has `X.cs` and `X.Designer.cs`)
- `Controls.cs`, `Theme.cs` – custom controls, colors
- `Database/SariScan.sql` – optional manual database script
