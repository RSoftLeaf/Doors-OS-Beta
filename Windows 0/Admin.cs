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
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private async void Admin_Load(object sender, EventArgs e)
        {
            await Task.Delay(500);
            this.Close();
        }
    }
}
