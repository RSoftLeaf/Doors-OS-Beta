using Microsoft.VisualBasic.Devices;
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
    public partial class PowerForm : Form
    {
        int Procentss = 0;
        System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
        Form1 form1;
        public PowerForm(Form1 frm1)
        {
            InitializeComponent();
            timer.Tick += Timer_Tick;
            form1 = frm1;
            timer.Interval = 1000;
            customProgressBar1.Value = 100;
            this.Location = new Point(form1.screenWidth - this.Width, form1.screenHeight - this.Height - form1.panelTask.Height);
            this.Refresh();
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            customProgressBar1.Value = form1.PowerProcents;
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            //if (btnMain.Text == "Экономия энергии")
            {

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
