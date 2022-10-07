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
    //Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
    public partial class Start : Form
    {
        SoundPlayer startupPlayer = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\StartupAndShutdown\Startup.wav");
        int screenWidth;
        int screenHeight;
        Size formSize;
        public Start(string status)
        {
            InitializeComponent();
            if (status == "Release")
            {
                screenWidth = Screen.PrimaryScreen.Bounds.Width;
                screenHeight = Screen.PrimaryScreen.Bounds.Height;
                formSize = new System.Drawing.Size(screenWidth, screenHeight);
                this.Size = formSize;
                Async();
            }
            else if (status == "DEBUG")
            {

                Form1 mainForm = new Form1(false);
                mainForm.Show();
                this.Visible = false;
            }
        }
        async void Async()
        {
            label1.Location = new System.Drawing.Point((this.Size.Width / 2) - (label1.Size.Width / 2), (this.Size.Height / 2) - (label1.Size.Height / 2));
            await Task.Delay(2000);
            startupPlayer.Play();
            label1.Font = this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Text = "Добро пожаловать в бета-версию Doors OS!";
            label1.Location = new System.Drawing.Point((this.Size.Width / 2) - (label1.Size.Width / 2), (this.Size.Height / 2) - (label1.Size.Height / 2));
            await Task.Delay(4000);
            Avtorize avtorize = new Avtorize();
            avtorize.Show();
            this.Visible = false;
        }
    }
}
