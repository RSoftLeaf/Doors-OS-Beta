    using System;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Windows_0
{
    public class CustomProgressBar : ProgressBar
    {
        public CustomProgressBar()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (this.Width == 0)
                this.Width++;
            Rectangle rec = new Rectangle(0, 0, this.Width, this.Height);
            double scaleFactor = (((double)Value - (double)Minimum) / ((double)Maximum - (double)Minimum));
            if (ProgressBarRenderer.IsSupported)
                ProgressBarRenderer.DrawHorizontalBar(e.Graphics, rec);
            //rec.Width = (int)((rec.Width * scaleFactor) - 4);
            //rec.Height -= 4;
            rec.Width = (int)((rec.Width * scaleFactor));

            if (rec.Width == 0)
                rec.Width = 1;
            LinearGradientBrush brush = new LinearGradientBrush(rec, this.ForeColor, this.BackColor, LinearGradientMode.Vertical);
            e.Graphics.FillRectangle(brush, 2, 2, rec.Width, rec.Height);
        }
    }
}
