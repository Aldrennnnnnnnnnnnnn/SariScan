using System.Drawing;
using System.Drawing.Drawing2D;

namespace SariScan;

/// <summary>Shared colors, fonts and small helpers. The forms themselves are designed in the Visual Studio Designer.</summary>
public static class Theme
{
    // Palette: deep green (sidebar) + amber (accent) on a warm cream background
    public static readonly Color Sidebar       = Color.FromArgb(31, 61, 43);
    public static readonly Color SidebarActive = Color.FromArgb(47, 90, 63);
    public static readonly Color SidebarText   = Color.FromArgb(220, 232, 224);
    public static readonly Color Accent        = Color.FromArgb(245, 166, 35);
    public static readonly Color Background    = Color.FromArgb(246, 243, 236);
    public static readonly Color Border        = Color.FromArgb(229, 224, 213);
    public static readonly Color HeaderRow     = Color.FromArgb(241, 237, 227);
    public static readonly Color AltRow        = Color.FromArgb(251, 250, 246);
    public static readonly Color TextDark      = Color.FromArgb(31, 41, 55);
    public static readonly Color TextMuted     = Color.FromArgb(107, 114, 128);
    public static readonly Color Success       = Color.FromArgb(46, 125, 50);
    public static readonly Color Warning       = Color.FromArgb(178, 106, 0);
    public static readonly Color WarningBg     = Color.FromArgb(255, 248, 230);
    public static readonly Color Danger        = Color.FromArgb(198, 40, 40);

    public static Font Ui(float size, FontStyle style = FontStyle.Regular) => new("Segoe UI", size, style);

    public static string Peso(decimal value) => "\u20B1" + value.ToString("N2");

    public static Color StatusColor(string status) => status switch
    {
        "Low Stock"    => Warning,
        "Out of Stock" => Danger,
        _              => Success
    };

    public static GraphicsPath RoundedRect(Rectangle r, int radius)
    {
        int d = Math.Max(2, radius * 2);
        var p = new GraphicsPath();
        p.AddArc(r.X, r.Y, d, d, 180, 90);
        p.AddArc(r.Right - d, r.Y, d, d, 270, 90);
        p.AddArc(r.Right - d, r.Bottom - d, d, d, 0, 90);
        p.AddArc(r.X, r.Bottom - d, d, d, 90, 90);
        p.CloseFigure();
        return p;
    }
}
