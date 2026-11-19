namespace SariScan;

/// <summary>One low-stock alert card. Design it in the Designer; LowStockPage creates one per product.</summary>
public partial class AlertCard : UserControl
{
    private Product _product;

    /// <summary>Raised after the owner restocked this product.</summary>
    public event EventHandler Restocked;

    public AlertCard()
    {
        InitializeComponent();
    }

    public void Bind(Product p)
    {
        _product = p;
        var color = p.Qty == 0 || p.Qty * 2 <= p.Limit ? Theme.Danger : Theme.Warning;
        double ratio = p.Limit == 0 ? 0 : Math.Min(1.0, (double)p.Qty / p.Limit);

        lblName.Text = p.Name;
        lblCategory.Text = p.Category;
        lblQty.Text = p.Qty == 0 ? "Out of stock" : $"{p.Qty} pcs left";
        lblQty.ForeColor = color;
        lblLimit.Text = $"Limit: {p.Limit}";
        lblStatus.Text = "\u25CF  " + p.Status;
        lblStatus.ForeColor = color;
        pnlFill.BackColor = color;
        pnlFill.Width = (int)(pnlTrack.Width * ratio);
        btnRestock.Enabled = Session.CanUpdateStock;
    }

    private void btnRestock_Click(object sender, EventArgs e)
    {
        if (_product == null) return;
        if (Ui.RestockProduct(FindForm(), _product.Id, _product.Name, _product.Qty))
            Restocked?.Invoke(this, EventArgs.Empty);
    }
}
