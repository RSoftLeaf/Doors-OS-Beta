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
    public partial class settings : Form
    {

        public settings()
        {
            InitializeComponent();

        }

        private void settings_Load(object sender, EventArgs e)
        {
            label2.Text = $"{progressBar1.Value} ГБ занято из {progressBar1.Maximum}";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form1 shindows = new Form1(false, false);
            shindows.Size = new System.Drawing.Size(1920, 1080);
            shindows.WindowState = FormWindowState.Normal;
        }

        private void x2160ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 shindows = new Form1(false, false);
            shindows.Size = new System.Drawing.Size(1920, 1080);
            shindows.WindowState = FormWindowState.Normal;
        }

        private void x1080ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 shindows = new Form1(false, false);
            shindows.Size = new System.Drawing.Size(1540, 960);
            shindows.WindowState = FormWindowState.Normal;
        }
    }
}
