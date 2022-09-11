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
    public partial class TaskPanelSettings : Form
    {
        Form1 form;
        public TaskPanelSettings(Form1 mainform)
        {
            form = mainform;
            InitializeComponent();
        }

        private void pnlBig_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlBig.Checked)
            {
                form.Initialize(true);
                form.Refresh();
            }
        }

        private void pnlSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (pnlSmall.Checked)
            {
                form.Initialize(false);
                form.Refresh();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
