namespace SariScan;

public partial class MainForm : Form
{
    private readonly Dictionary<string, UserControl> _pages = new();
    private readonly Button[] _navButtons;

    private static readonly Dictionary<string, (string Title, string Subtitle)> Info = new()
    {
        ["dashboard"] = ("Dashboard",        "A quick summary of your store's inventory and restocking"),
        ["products"]  = ("Products",         "Add, edit and remove product records"),
        ["inventory"] = ("Inventory",        "Check prices, quantities and stock status"),
        ["queue"]     = ("Restock Queue",    "Low-stock items in first-in, first-out order"),
        ["alerts"]    = ("Low Stock Alerts", "Products at or below their low-stock limit"),
    };

    public MainForm()
    {
        InitializeComponent();
        _navButtons = new[] { btnDashboard, btnProducts, btnInventory, btnQueue, btnAlerts };
        _pages["dashboard"] = dashboardPage;   // the page placed in the Designer is reused at runtime

        if (Session.User != null)
        {
            lblUserName.Text = Session.User.FullName;
            lblUserRole.Text = Session.User.IsOwner ? "Administrator" : "Attendant";
            lblAvatar.Text = Initials(Session.User.FullName);
        }

        Navigate("dashboard");
    }

    private static string Initials(string name)
    {
        var parts = name.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        if (parts.Length == 0) return "?";
        if (parts.Length == 1) return parts[0].Substring(0, 1).ToUpper();
        return (parts[0].Substring(0, 1) + parts[^1].Substring(0, 1)).ToUpper();
    }

    private void NavButton_Click(object sender, EventArgs e)
    {
        if (sender is Button b && b.Tag is string key) Navigate(key);
    }

    private void btnLogout_Click(object sender, EventArgs e)
    {
        DialogResult = DialogResult.Retry;   // tells LoginForm to show itself again
    }

    private static UserControl CreatePage(string key) => key switch
    {
        "dashboard" => new DashboardPage(),
        "products"  => new ProductsPage(),
        "inventory" => new InventoryPage(),
        "queue"     => new RestockQueuePage(),
        "alerts"    => new LowStockPage(),
        _ => throw new ArgumentException("Unknown page: " + key)
    };

    private void Navigate(string key)
    {
        if (!_pages.TryGetValue(key, out var page))
            _pages[key] = page = CreatePage(key);

        pnlContent.SuspendLayout();
        pnlContent.Controls.Clear();
        page.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(page);
        pnlContent.ResumeLayout();

        lblTitle.Text = Info[key].Title;
        lblPageSubtitle.Text = Info[key].Subtitle;

        foreach (var btn in _navButtons)
        {
            bool active = (string)btn.Tag == key;
            btn.BackColor = active ? Theme.SidebarActive : Theme.Sidebar;
            btn.ForeColor = active ? Theme.Accent : Theme.SidebarText;
            btn.Font = Theme.Ui(10.5f, active ? FontStyle.Bold : FontStyle.Regular);
            if (active) pnlIndicator.Top = btn.Top;
        }
        pnlIndicator.BringToFront();

        // Reload this page's data from SQL Server every time it is opened
        (page as IRefreshablePage)?.RefreshData();
    }
}
