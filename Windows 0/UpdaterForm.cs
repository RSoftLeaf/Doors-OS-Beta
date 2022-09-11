using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Updater
{
    public partial class UpdaterForm : Form
    {
        public UpdaterForm()
        {
            InitializeComponent();
        }

        private async void btnDownloadShindThree_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < pbThree.Value - 1; i++)
            {
                pbThree.Value += 1;
                await Task.Delay(100);
            }
            btnDownloadShindThree.Enabled = false;
            btnDownloadShindThree.Text = "Downloaded";
        }
    }
}
