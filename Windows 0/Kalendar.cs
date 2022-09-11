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
    }
}
