using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_0
{
    public partial class Avtorize : Form
    {
        string UserName = "Roma";
        string PassWord = "Romanus.netus";
        //System.Windows.Forms.Timer TmrForPass = new System.Windows.Forms.Timer();
        public Avtorize()
        {
            InitializeComponent();
            customProgressBar1.Value = 0;
        }

        
        private async void button1_Click(object sender, EventArgs e)
        {
            if (User.Text == UserName.ToString() && Pass.Text == PassWord.ToString())
            {
                for (int i = 0; i < 100; i++)
                {
                    
                }
                try
                {
                    for (int i = 0; i < customProgressBar1.Maximum; i++)
                    {
                        customProgressBar1.Value += 1;
                        await Task.Delay(10);
                    }
                }
                catch
                {

                }
                Form1 formWindows = new Form1(true, true);
                formWindows.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
        }

        private void ReStart_Click(object sender, EventArgs e)
        {
            //Application.Restart();
            Shutdown shutdown = new Shutdown("Перезагрузка");
            shutdown.Show();
        }

        private void Shotdown_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Shutdown shutdown = new Shutdown("Выключение");
            shutdown.Show();
        }

        private void customProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                Pass.UseSystemPasswordChar = false;
            else
                Pass.UseSystemPasswordChar = true;
        }
    }
}
