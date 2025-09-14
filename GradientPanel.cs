using System.ComponentModel;
using System.Drawing.Drawing2D;

namespace Order_Manager
{
    public class GradientPanel : Panel
    {
        [Browsable(true)]
        [Category("Appearance")]
        [Description("اللون الأول للتدرج")]
        [DefaultValue(typeof(Color), "#2c3e50")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color Color1 { get; set; } = ColorTranslator.FromHtml("#2c3e50");

        [Browsable(true)]
        [Category("Appearance")]
        [Description("اللون الثاني للتدرج")]
        [DefaultValue(typeof(Color), "#bdc3c7")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color Color2 { get; set; } = ColorTranslator.FromHtml("#bdc3c7");

        [Browsable(true)]
        [Category("Appearance")]
        [Description("اتجاه التدرج")]
        [DefaultValue(LinearGradientMode.Horizontal)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public LinearGradientMode GradientMode { get; set; } = LinearGradientMode.Horizontal;

        public GradientPanel()
        {
            this.DoubleBuffered = true;   // يمنع الفليكر
            this.ResizeRedraw = true;     // يعيد الرسم عند تغيير الحجم
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color1, Color2, GradientMode))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
