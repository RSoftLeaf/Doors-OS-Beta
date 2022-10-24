using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_0
{
    public partial class CNS : Form
    {
        string command = "";
        public CNS()
        {
            InitializeComponent();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            command = tbConsole.Text;
            tbConsole.Clear();
            tbConsoleFull.Text = $"{command}\r\n";
            if (command == @"Del c:\")
            {
                for (int i = 0; i < 4; i++)
                {
                    tbConsoleFull.Text = $"Deleting {i}%\r\n";
                }
                await Task.Delay(1000);
                SoundPlayer wavPlayerBSODONE = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
                SoundPlayer wavPlayerBSODTWO = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
                wavPlayerBSODONE.Play();
                MessageBox.Show("Critical error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                await Task.Delay(1000);
                Admin admin = new Admin();
                Provodnik provodnik = new Provodnik();
                settings settingss = new settings();
                Form1 form1 = new Form1(false, false);
                BSoD bSoD = new BSoD(false);
                bSoD.Show();
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
                wavPlayerBSODTWO.Play();

            }
            else if (command == "crash")
            {
                for (int i = 0; i < 100; i++)
                {
                    tbConsoleFull.Text += "Critical error";
                    await Task.Delay(10);
                }
                tbConsoleFull.ForeColor = Color.DarkRed;
                await Task.Delay(1000);
                SoundPlayer wavPlayerBSODONE = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
                SoundPlayer wavPlayerBSODTWO = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\BSoD\blue-screen.wav");
                wavPlayerBSODONE.Play();
                MessageBox.Show("Critical error", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                await Task.Delay(1000);
                Admin admin = new Admin();
                Provodnik provodnik = new Provodnik();
                settings settingss = new settings();
                Form1 form1 = new Form1(false, false);
                BSoD bSoD = new BSoD(true);
                bSoD.Show();
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
                wavPlayerBSODTWO.Play();
            }
            else if (command == "help")
            {
                tbConsoleFull.Text = "Del c:\\\r\n" +
                                     "crash\r\n";
            }
        }
    }
}
