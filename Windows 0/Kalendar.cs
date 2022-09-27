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
    public partial class Kalendar : Form
    {
        #region VARIABLES

        Size lastSize;
        bool FormDocked = false;

        #endregion
        public Kalendar()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Kalendar_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            label1.Text = $"{date}";
        }

        private void Kalendar_LocationChanged(object sender, EventArgs e)
        {
            int LocRightX = this.Location.X + this.Size.Width;
            this.Text = LocRightX.ToString() + " FormDocked = " + FormDocked + " Last Size = " + lastSize;
            if (LocRightX >= 1900)
            {
                if (!FormDocked)
                {
                    lastSize = this.Size;
                }
                this.Location = new Point(1920 / 2, 0);
                this.Size = new Size(1920 / 2, 1080 - 44);
                FormDocked = true;
            }
            else
            {
                if (FormDocked)
                {
                    FormDocked = false;

                }
                else
                {
                    this.Size = lastSize;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = lastSize;
        }
    }
}
