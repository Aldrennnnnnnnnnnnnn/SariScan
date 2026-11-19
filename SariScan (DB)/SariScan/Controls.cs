using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SariScan;

// These custom controls appear in the Visual Studio Toolbox (under "SariScan Components")
// after you build the project once. Drag them onto any form.

/// <summary>White rounded "card" container with a soft border.</summary>
public class CardPanel : Panel
{
    private int _radius = 12;
    private Color _borderColor = Theme.Border;

    [DefaultValue(12)]
    public int Radius { get => _radius; set { _radius = value; Invalidate(); } }

    public Color BorderColor { get => _borderColor; set { _borderColor = value; Invalidate(); } }
    private bool ShouldSerializeBorderColor() => _borderColor != Theme.Border;
    private void ResetBorderColor() => BorderColor = Theme.Border;

    public CardPanel()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        BackColor = Color.White;
        Padding = new Padding(16);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.Clear(Parent?.BackColor ?? Theme.Background);
        if (Width < 6 || Height < 6) return;   // too small to draw safely

        g.SmoothingMode = SmoothingMode.AntiAlias;
        int r = Math.Max(1, Math.Min(_radius, Math.Min(Width, Height) / 2 - 1));
        using var path = Theme.RoundedRect(new Rectangle(0, 0, Width - 1, Height - 1), r);
        using var fill = new SolidBrush(BackColor);
        using var pen = new Pen(_borderColor);
        g.FillPath(fill, path);
        g.DrawPath(pen, path);
    }
}

/// <summary>Round badge with initials (BackColor = circle color).</summary>
public class AvatarLabel : Label
{
    public AvatarLabel()
    {
        SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |
                 ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw, true);
        AutoSize = false;
        Size = new Size(38, 38);
        BackColor = Theme.Accent;
        ForeColor = Theme.Sidebar;
        Font = Theme.Ui(10, FontStyle.Bold);
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        var g = e.Graphics;
        g.Clear(Parent?.BackColor ?? Color.White);
        if (Width < 4 || Height < 4) return;
        g.SmoothingMode = SmoothingMode.AntiAlias;
        using var b = new SolidBrush(BackColor);
        g.FillEllipse(b, 0, 0, Width - 1, Height - 1);
        TextRenderer.DrawText(g, Text, Font, ClientRectangle, ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
    }
}

/// <summary>
/// DataGridView with the SariScan look. Add columns in the Designer as usual.
/// A column whose name ends with "Status" is shown as a colored "● Status" label.
/// </summary>
public class StyledGrid : DataGridView
{
    public StyledGrid()
    {
        DoubleBuffered = true;
        BackgroundColor = Color.White;
        BorderStyle = BorderStyle.None;
        CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        GridColor = Theme.Border;
        EnableHeadersVisualStyles = false;
        ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
        ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
        ColumnHeadersHeight = 40;
        ColumnHeadersDefaultCellStyle.BackColor = Theme.HeaderRow;
        ColumnHeadersDefaultCellStyle.ForeColor = Theme.TextMuted;
        ColumnHeadersDefaultCellStyle.Font = Theme.Ui(9f, FontStyle.Bold);
        ColumnHeadersDefaultCellStyle.SelectionBackColor = Theme.HeaderRow;
        ColumnHeadersDefaultCellStyle.SelectionForeColor = Theme.TextMuted;
        ColumnHeadersDefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
        ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
        RowHeadersVisible = false;
        AllowUserToAddRows = false;
        AllowUserToDeleteRows = false;
        AllowUserToResizeRows = false;
        AllowUserToResizeColumns = false;
        ReadOnly = true;
        SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        MultiSelect = false;
        RowTemplate.Height = 42;
        AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        DefaultCellStyle.Font = Theme.Ui(10f);
        DefaultCellStyle.ForeColor = Theme.TextDark;
        DefaultCellStyle.Padding = new Padding(8, 0, 8, 0);
        DefaultCellStyle.SelectionBackColor = Theme.WarningBg;
        DefaultCellStyle.SelectionForeColor = Theme.TextDark;
        AlternatingRowsDefaultCellStyle.BackColor = Theme.AltRow;
        AlternatingRowsDefaultCellStyle.SelectionBackColor = Theme.WarningBg;
    }

    protected override void OnCellFormatting(DataGridViewCellFormattingEventArgs e)
    {
        base.OnCellFormatting(e);
        if (e.ColumnIndex < 0) return;
        var col = Columns[e.ColumnIndex];

        if (e.RowIndex < 0)
        {
            // header cell: follow the column's alignment
            if (col.DefaultCellStyle.Alignment != DataGridViewContentAlignment.NotSet)
                e.CellStyle.Alignment = col.DefaultCellStyle.Alignment;
            return;
        }

        if (col.Name.EndsWith("Status", StringComparison.OrdinalIgnoreCase) && e.Value is string v && !v.StartsWith("\u25CF"))
        {
            var color = Theme.StatusColor(v);
            e.Value = "\u25CF  " + v;
            e.CellStyle.ForeColor = color;
            e.CellStyle.SelectionForeColor = color;
            e.CellStyle.Font = Theme.Ui(9.5f, FontStyle.Bold);
            e.FormattingApplied = true;
        }
    }
}
