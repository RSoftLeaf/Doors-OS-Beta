using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Windows_0
{
    public partial class Provodnik : Form
    {
        public Provodnik()
        {
            InitializeComponent();
            label6.Text = $"{progressBar1.Maximum - progressBar1.Value} ГБ свободно из {progressBar1.Maximum}";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private async void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnSystem32.Dispose();
            await Task.Delay(800);
            SoundPlayer wavPlayerBSODONE = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
            SoundPlayer wavPlayerBSODTWO = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
            wavPlayerBSODONE.Play();
            MessageBox.Show("Critical error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            await Task.Delay(1000);
            Admin admin = new Admin();
            Provodnik provodnik = new Provodnik();
            settings settingss = new settings();
            Form1 form1 = new Form1(false);
            BSoD Sol = new BSoD();
            if (admin != null)
            {
                admin.Hide();
            }
            if (provodnik != null)
            {
                provodnik.Hide();
            }
            if (settingss != null)
            {
                settingss.Hide();
            }
            if (form1 != null)
            {
                form1.Hide();
            }
            Sol.Show();
            wavPlayerBSODTWO.Play();
            await Task.Delay(17000);
            Application.Restart();
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 Shind = new Form1(false);
            Shind.PhotoShop = @"/?\";
            Shind.SnapCamera = @"/?\";
            Shind.TotalCMD = @"/?\";
            Shind.CalcuLator = @"/?\";
            button1.Dispose();
        }
    }
}
