using System.Windows.Forms;

namespace Order_Manager
{
    public class DoubleBufferedTableLayoutPanel : TableLayoutPanel
    {
        public DoubleBufferedTableLayoutPanel()
        {
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint |
                          ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.ResizeRedraw, true);
            this.UpdateStyles();
        }
    }
}
