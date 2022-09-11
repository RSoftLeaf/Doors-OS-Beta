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
    public partial class UpdateShindos : Form
    {
        public UpdateShindos()
        {
            InitializeComponent();
        }

        private async void btnDownloadShindThree_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pbThree.Maximum - 1; i++)
            {
                pbThree.Value += 1;
            }
            btnDownloadShindThree.Enabled = false;
            btnDownloadShindThree.Text = "Downloaded";
        }
    }
}
