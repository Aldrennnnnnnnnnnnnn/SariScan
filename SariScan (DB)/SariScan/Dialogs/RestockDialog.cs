namespace SariScan;

public partial class RestockDialog : Form
{
    private readonly int _currentQty;

    public RestockDialog() : this("Sample product", 12) { }

    public RestockDialog(string productName, int currentQty)
    {
        InitializeComponent();
        _currentQty = currentQty;
        lblProduct.Text = productName;
        lblCurrent.Text = $"Current stock: {currentQty} pcs";
        dtpDate.MaxDate = DateTime.Today;
        dtpDate.Value = DateTime.Today;
        UpdateTotal();
    }

    /// <summary>Quantity the owner entered.</summary>
    public int QuantityAdded => (int)nudQty.Value;

    /// <summary>Delivery date the owner picked.</summary>
    public DateTime DeliveryDate => dtpDate.Value.Date;

    private void nudQty_ValueChanged(object sender, EventArgs e) => UpdateTotal();

    private void UpdateTotal() =>
        lblNewTotal.Text = $"New stock total:  {_currentQty + (int)nudQty.Value} pcs";
}
