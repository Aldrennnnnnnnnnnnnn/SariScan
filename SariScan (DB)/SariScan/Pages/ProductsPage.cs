using Microsoft.Data.SqlClient;

namespace SariScan;

public partial class ProductsPage : UserControl, IRefreshablePage
{
    private readonly Dictionary<int, Product> _byId = new();
    private int? _selectedId;
    private bool _loading;

    public ProductsPage()
    {
        InitializeComponent();
        txtProductName.MaxLength = 150;

        txtSearch.TextChanged += (s, e) => LoadGrid(_selectedId);
        cboCategory.SelectedIndexChanged += (s, e) => LoadGrid(_selectedId);
        gridProducts.SelectionChanged += gridProducts_SelectionChanged;
        btnAdd.Click += btnAdd_Click;
        btnUpdate.Click += btnUpdate_Click;
        btnDelete.Click += btnDelete_Click;
        btnClear.Click += (s, e) => ClearForm();
    }

    public void RefreshData()
    {
        if (Ui.InDesigner) return;
        pnlForm.Enabled = Session.IsOwner;   // only the owner can add, edit or delete products
        LoadGrid(_selectedId);
    }

    private void LoadGrid(int? keepId)
    {
        if (Ui.InDesigner) return;
        try
        {
            string category = cboCategory.SelectedIndex > 0 ? cboCategory.SelectedItem.ToString() : null;
            var items = ProductRepository.Search(txtSearch.Text, category);

            _loading = true;
            gridProducts.Rows.Clear();
            _byId.Clear();
            foreach (var p in items)
            {
                int i = gridProducts.Rows.Add(p.Name, p.Category,
                    p.Cost.HasValue ? Theme.Peso(p.Cost.Value) : "\u2014",
                    Theme.Peso(p.Price), p.Qty, p.Limit, p.Status);
                gridProducts.Rows[i].Tag = p.Id;
                _byId[p.Id] = p;
            }

            gridProducts.ClearSelection();
            _selectedId = null;
            if (keepId.HasValue)
            {
                foreach (DataGridViewRow row in gridProducts.Rows)
                {
                    if ((int)row.Tag == keepId.Value)
                    {
                        row.Selected = true;
                        _selectedId = keepId;
                        break;
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
        finally
        {
            _loading = false;
        }
    }

    private void gridProducts_SelectionChanged(object sender, EventArgs e)
    {
        if (_loading || gridProducts.SelectedRows.Count == 0) return;
        int id = (int)gridProducts.SelectedRows[0].Tag;
        if (!_byId.TryGetValue(id, out var p)) return;

        _selectedId = id;
        txtProductName.Text = p.Name;
        cboFormCategory.SelectedItem = p.Category;
        nudCost.Value = p.Cost ?? 0;
        nudPrice.Value = p.Price;
        nudQuantity.Value = p.Qty;
        nudLimit.Value = p.Limit;
    }

    private void ClearForm()
    {
        txtProductName.Clear();
        if (cboFormCategory.Items.Count > 0) cboFormCategory.SelectedIndex = 0;
        nudCost.Value = 0;
        nudPrice.Value = 0;
        nudQuantity.Value = 0;
        nudLimit.Value = 0;
        gridProducts.ClearSelection();
        _selectedId = null;
        txtProductName.Focus();
    }

    /// <summary>Validates the form. Returns null (after showing a message) if something is wrong.</summary>
    private Product ReadForm(int id)
    {
        string name = txtProductName.Text.Trim();
        if (name.Length == 0)
        {
            Ui.Error("Please enter the product name.");
            txtProductName.Focus();
            return null;
        }
        if (cboFormCategory.SelectedItem == null)
        {
            Ui.Error("Please choose a category.");
            cboFormCategory.Focus();
            return null;
        }
        if (nudPrice.Value <= 0)
        {
            Ui.Error("The selling price must be greater than zero.");
            nudPrice.Focus();
            return null;
        }

        decimal? cost = nudCost.Value > 0 ? nudCost.Value : null;   // 0 means "no purchase cost entered"
        return new Product(id, name, (string)cboFormCategory.SelectedItem, cost,
            nudPrice.Value, (int)nudQuantity.Value, (int)nudLimit.Value);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        var p = ReadForm(0);
        if (p == null) return;
        try
        {
            ProductRepository.Add(p);
            ClearForm();
            LoadGrid(null);
            Ui.Info("Product added.");
        }
        catch (SqlException ex) when (ProductRepository.IsDuplicateName(ex))
        {
            Ui.Error("A product with that name already exists.");
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == null)
        {
            Ui.Error("Select a product from the list first.");
            return;
        }
        int id = _selectedId.Value;
        var p = ReadForm(id);
        if (p == null) return;
        try
        {
            ProductRepository.Update(p);
            LoadGrid(id);
            Ui.Info("Product updated.");
        }
        catch (SqlException ex) when (ProductRepository.IsDuplicateName(ex))
        {
            Ui.Error("Another product already has that name.");
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == null)
        {
            Ui.Error("Select a product from the list first.");
            return;
        }
        string name = _byId.TryGetValue(_selectedId.Value, out var p) ? p.Name : "this product";
        if (!Ui.Confirm($"Delete \"{name}\"?\n\nThis also removes it from the restock queue.")) return;
        try
        {
            ProductRepository.Delete(_selectedId.Value);
            ClearForm();
            LoadGrid(null);
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }
}
