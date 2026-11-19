namespace SariScan;

public partial class RestockQueuePage : UserControl, IRefreshablePage
{
    public RestockQueuePage()
    {
        InitializeComponent();
        btnRemove.Click += btnRemove_Click;
    }

    public void RefreshData()
    {
        if (Ui.InDesigner) return;
        btnRestock.Enabled = Session.CanUpdateStock;
        btnRemove.Enabled = Session.IsOwner;
        LoadGrid();
    }

    private void LoadGrid()
    {
        try
        {
            var items = QueueRepository.GetPending();
            gridQueue.Rows.Clear();
            for (int i = 0; i < items.Count; i++)
            {
                var q = items[i];
                int row = gridQueue.Rows.Add(i + 1, q.Name, q.Category, q.Qty, q.Limit,
                    q.FlaggedAt.ToString("MMM d, yyyy  \u2022  h:mm tt"),
                    q.Qty == 0 ? "Out of Stock" : "Low Stock");
                gridQueue.Rows[row].Tag = q;
            }
            gridQueue.ClearSelection();
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }

    private QueueItem Selected()
    {
        if (gridQueue.SelectedRows.Count == 0 || gridQueue.SelectedRows[0].Tag is not QueueItem q)
        {
            Ui.Error("Select a product from the queue first.");
            return null;
        }
        return q;
    }

    private void btnRestock_Click(object sender, EventArgs e)
    {
        var q = Selected();
        if (q == null) return;
        if (Ui.RestockProduct(FindForm(), q.ProductId, q.Name, q.Qty)) LoadGrid();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        var q = Selected();
        if (q == null) return;
        if (!Ui.Confirm($"Remove \"{q.Name}\" from the restock queue?")) return;
        try
        {
            QueueRepository.Remove(q.QueueId);
            LoadGrid();
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }
}
