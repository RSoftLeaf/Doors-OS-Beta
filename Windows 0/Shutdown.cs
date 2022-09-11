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
    public partial class Shutdown : Form
    {
        SoundPlayer shutdownPlayer = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\StartupAndShutdown\Shutdown.wav");
        public Shutdown(string status)
        {
            InitializeComponent();
            label1.Text = status;
            label1.Location = new System.Drawing.Point((this.Size.Width / 2) - (label1.Size.Width / 2), (this.Size.Height / 2) - label1.Size.Height); 
            ProgressShutdown(status);
            shutdownPlayer.Play();
        }
        async void ProgressShutdown(string status)
        {
            while (progressBar1.Value < progressBar1.Maximum)
            {
                progressBar1.Value++;
                await Task.Delay(100);
            }
            progressBar1.Visible = false;
            label1.Visible = false;
            this.BackColor = Color.Black;
            await Task.Delay(1000);
            if (status == "Перезагрузка")
                Application.Restart();
            else
                Application.Exit();

        }
    }
}
