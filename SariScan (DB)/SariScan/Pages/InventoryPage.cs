namespace SariScan;

public partial class InventoryPage : UserControl, IRefreshablePage
{
    public InventoryPage()
    {
        InitializeComponent();
        txtSearch.TextChanged += (s, e) => LoadGrid();
        cboCategory.SelectedIndexChanged += (s, e) => LoadGrid();
        cboStatus.SelectedIndexChanged += (s, e) => LoadGrid();
    }

    public void RefreshData()
    {
        if (Ui.InDesigner) return;
        btnRestock.Enabled = Session.CanUpdateStock;
        LoadGrid();
    }

    private void LoadGrid()
    {
        if (Ui.InDesigner) return;
        try
        {
            string category = cboCategory.SelectedIndex > 0 ? cboCategory.SelectedItem.ToString() : null;
            string status = cboStatus.SelectedIndex > 0 ? cboStatus.SelectedItem.ToString() : null;
            var items = ProductRepository.Search(txtSearch.Text, category, status);

            gridInventory.Rows.Clear();
            foreach (var p in items)
            {
                int i = gridInventory.Rows.Add(p.Name, p.Category, Theme.Peso(p.Price), p.Qty, p.Limit, p.Status);
                gridInventory.Rows[i].Tag = p;
            }
            gridInventory.ClearSelection();
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }

    private void btnRestock_Click(object sender, EventArgs e)
    {
        if (gridInventory.SelectedRows.Count == 0 || gridInventory.SelectedRows[0].Tag is not Product p)
        {
            Ui.Error("Select a product from the list first.");
            return;
        }
        if (Ui.RestockProduct(FindForm(), p.Id, p.Name, p.Qty)) LoadGrid();
    }
}
