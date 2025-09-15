using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class GradientPanel : Panel
{
    [Browsable(true)]
    [Category("Appearance")]
    [Description("اللون الأول للتدرج")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color Color1 { get; set; } = Color.FromArgb(44, 62, 80); // غامق

    [Browsable(true)]
    [Category("Appearance")]
    [Description("اللون الثاني للتدرج")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color Color2 { get; set; } = Color.FromArgb(189, 195, 199); // فاتح

    [Browsable(true)]
    [Category("Appearance")]
    [Description("اتجاه التدرج")]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Vertical;

    public GradientPanel()
    {
        this.DoubleBuffered = true;
        this.ResizeRedraw = true;
        this.Dock = DockStyle.Fill;
    }

    protected override void OnPaintBackground(PaintEventArgs e)
    {
        using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color1, Color2, GradientMode))
        {
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
