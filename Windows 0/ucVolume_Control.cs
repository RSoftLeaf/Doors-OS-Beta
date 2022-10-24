using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_0
{
    public partial class ucVolume_Control : UserControl
    {
        public ucVolume_Control()
        {
            InitializeComponent();
            this.Size = new Size(350, 50);
            this.BackColor = Color.Black;
            DoubleBuffered = true;
        }
        int pb_value = 40, pb_min = 0, pb_max = 100;
        public int Max { get { return pb_max; } set { pb_max = value; Invalidate(); } }
        public int Min { get { return pb_min; } set { pb_min = value; Invalidate(); } }
        public int Value { get { return pb_value; } set { pb_value = value; Invalidate(); } }
        public int gap = 10;
        Color b_color = Color.Aqua;
        public Color Bar_color { get { return b_color; } set { b_color = value; Invalidate(); } }
        private void ucVolume_Control_Paint(object sender, PaintEventArgs e)
        {
            int start_point = 40;
            SolidBrush sb = new SolidBrush(Color.DimGray);
            for (int j = 0; j < Max * ClientSize.Width / Max - 75 / gap; j++)
            {
                e.Graphics.FillRectangle(sb, new Rectangle(start_point, 0, gap - 5, ClientSize.Height));
                start_point += gap;
            }
            int buffer_point = 40;
            SolidBrush br = new SolidBrush(b_color);
            for (int i = 0; i < (pb_value * ClientSize.Width / Max - pb_value) / gap; i++)
            {
                e.Graphics.FillRectangle(br, new Rectangle(buffer_point, 0, gap - 2, ClientSize.Height));
                buffer_point += gap;
            }
            int thum_size = 25;
            SolidBrush thumb = new SolidBrush(Color.White);
            e.Graphics.FillRectangle(thumb, new Rectangle(buffer_point, 0, thum_size, ClientSize.Height));
            /*
            if (pb_value >= Min)
            {
                Image left_img = Properties.Resources.low_volume;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }
            if (pb_value <= 50)
            {
                Image right_img = Properties.Resources.mid_volume;
                e.Graphics.DrawImage(right_img, ClientSize.Width - 35, 0, ClientSize.Height, ClientSize.Height);
            }
            if (pb_value <= Min)
            {
                Image left_img = Properties.Resources.mute_volume;
                e.Graphics.DrawImage(left_img, 5, 0, ClientSize.Height, ClientSize.Height);
            }
            if (pb_value >= 50)
            {
            
            Image right_img = Properties.Resources.max_volume;
                e.Graphics.DrawImage(right_img, ClientSize.Width - 35, 0, ClientSize.Height, ClientSize.Height);
            */
            //}


        }
        bool mouse = false;
        private void ucVolume_Control_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            Bar_Value(thump_value(e.X));
        }

        private void ucVolume_Control_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouse)
                return;
            Bar_Value(thump_value(e.X));
        }

        private void ucVolume_Control_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void Bar_Value(float value)
        {
            if (value < Min) 
                value = Min;
            if (value > Max)
                value = Max;
            if (pb_value==value)
                return;
            pb_value=(int)value;
            this.Refresh();
        }
        private float thump_value(int x)
        {
            return Min + (Max - Min) * x / (float)(ClientSize.Width);
        }
    }
}
