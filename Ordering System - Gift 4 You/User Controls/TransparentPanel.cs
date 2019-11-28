namespace Ordering_System___Gift_4_You
{ 
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    
    /// <summary>
    /// A helper class that will allow to change the opacity of a Panel
    /// </summary>
    public class TransparentPanel : Panel
    {
        private const int WS_EX_TRANSPARENT = 0x20;

        public TransparentPanel()
        {
            SetStyle(ControlStyles.Opaque, true);
        }

        private int opacity = 50;

        [DefaultValue(50)]
        public int Opacity
        {
            get { return opacity; }
            set
            {
                if (value < 0 || value > 100)
                    throw new ArgumentException("Opacity must be between 0 and 100");
                opacity = value;
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | WS_EX_TRANSPARENT;
                return cp;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (var brush = new SolidBrush(Color.FromArgb(Opacity * 255 / 100, this.BackColor)))
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            base.OnPaint(e);
        }
    }
}
