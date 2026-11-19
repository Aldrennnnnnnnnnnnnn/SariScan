namespace SariScan;

public partial class LowStockPage : UserControl, IRefreshablePage
{
    public LowStockPage()
    {
        InitializeComponent();
    }

    public void RefreshData()
    {
        if (Ui.InDesigner) return;
        try
        {
            var low = ProductRepository.GetLowStock();
            lblBanner.Text = low.Count == 0
                ? "\u2713   All products are above their low-stock limits."
                : $"\u26A0   {low.Count} product{(low.Count == 1 ? " is" : "s are")} at or below the low-stock limit.";

            flowAlerts.SuspendLayout();
            foreach (var old in flowAlerts.Controls.Cast<Control>().ToList())
            {
                flowAlerts.Controls.Remove(old);
                old.Dispose();
            }
            foreach (var p in low)
            {
                var card = new AlertCard();
                card.Bind(p);
                card.Restocked += (s, e) => BeginInvoke(new Action(RefreshData));
                flowAlerts.Controls.Add(card);
            }
            flowAlerts.ResumeLayout();
        }
        catch (Exception ex)
        {
            Ui.Error(ex);
        }
    }
}
