namespace SariScan;

public partial class DashboardPage : UserControl, IRefreshablePage
{
    public DashboardPage()
    {
        InitializeComponent();
        // No database calls here: this page is also shown inside the MainForm Designer.
        btnSearch.Click += (s, e) => RunSearch();
        txtSearch.TextChanged += (s, e) => RunSearch();
        txtSearch.KeyDown += (s, e) =>
        {
            if (e.KeyCode == Keys.Enter) { RunSearch(); e.SuppressKeyPress = true; }
        };
    }

    public void RefreshData()
    {
        if (Ui.InDesigner) return;
        try
        {
            var (total, low, pending) = ProductRepository.GetCounts();
            lblTotalValue.Text = total.ToString();
            lblLowValue.Text = low.ToString();
            lblQueueValue.Text = pending.ToString();

            var snapshot = ProductRepository.GetSnapshot(8);
            gridSnapshot.Rows.Clear();
            foreach (var p in snapshot)
                gridSnapshot.Rows.Add(p.Name, p.Category, Theme.Peso(p.Price), p.Qty, p.Status);
            lblSnapCount.Text = $"Showing {snapshot.Count} of {total} products";
            gridSnapshot.ClearSelection();

            RunSearch();
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }

    private void RunSearch()
    {
        if (Ui.InDesigner) return;
        string text = txtSearch.Text.Trim();
        if (text.Length == 0)
        {
            ShowMessage("Type a product name above to see its price and quantity.");
            return;
        }

        try
        {
            var p = ProductRepository.FindBest(text);
            if (p == null)
            {
                ShowMessage("No product found.");
                return;
            }
            lblResName.Text = p.Name;
            lblResPrice.Text = "Price:  " + Theme.Peso(p.Price);
            lblResQty.Text = $"Qty:  {p.Qty} pcs";
            lblResStatus.Text = "\u25CF  " + p.Status;
            lblResStatus.ForeColor = Theme.StatusColor(p.Status);
            lblResPrice.Visible = lblResQty.Visible = lblResStatus.Visible = true;
        }
        catch
        {
            ShowMessage("The database is not available.");
        }
    }

    private void ShowMessage(string text)
    {
        lblResName.Text = text;
        lblResPrice.Visible = lblResQty.Visible = lblResStatus.Visible = false;
    }
}
