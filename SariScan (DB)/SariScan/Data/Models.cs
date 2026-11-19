namespace SariScan;

public record Product(int Id, string Name, string Category, decimal? Cost, decimal Price, int Qty, int Limit)
{
    public string Status => Qty == 0 ? "Out of Stock" : Qty <= Limit ? "Low Stock" : "In Stock";
}

public record QueueItem(int QueueId, int ProductId, string Name, string Category, int Qty, int Limit, DateTime FlaggedAt);

public record AppUser(int Id, string Username, string FullName, string Role, bool CanUpdateStock)
{
    public bool IsOwner => Role == "Owner";
}
