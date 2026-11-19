using System.ComponentModel;

namespace SariScan;

/// <summary>Pages that reload their data from the database each time they are shown.</summary>
public interface IRefreshablePage
{
    void RefreshData();
}

/// <summary>Small message-box helpers shared by all screens.</summary>
public static class Ui
{
    /// <summary>True while a form is open in the Visual Studio Designer (so we skip database calls).</summary>
    public static bool InDesigner => LicenseManager.UsageMode == LicenseUsageMode.Designtime;

    public static void Info(string message) =>
        MessageBox.Show(message, "SariScan", MessageBoxButtons.OK, MessageBoxIcon.Information);

    public static void Error(string message) =>
        MessageBox.Show(message, "SariScan", MessageBoxButtons.OK, MessageBoxIcon.Warning);

    public static void Error(Exception ex) =>
        Error("Something went wrong while using the database:\n\n" + ex.Message);

    public static bool Confirm(string message) =>
        MessageBox.Show(message, "SariScan", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    /// <summary>Shows the restock dialog and, if confirmed, saves the new stock. Returns true when stock was updated.</summary>
    public static bool RestockProduct(IWin32Window owner, int productId, string name, int currentQty)
    {
        using var dlg = new RestockDialog(name, currentQty);
        if (dlg.ShowDialog(owner) != DialogResult.OK) return false;
        try
        {
            ProductRepository.Restock(productId, dlg.QuantityAdded, dlg.DeliveryDate, Session.Username);
            return true;
        }
        catch (Exception ex)
        {
            Error(ex);
            return false;
        }
    }
}
