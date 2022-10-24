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
    public partial class BSoD : Form
    {
        int Vitsotki = 0;
        Random random = new Random();
        public BSoD(bool crash)
        {
            InitializeComponent();
            if (crash)
            {
                label1.Text = "Crashed";
                label2.Visible = false;
                CrashConsole crashConsole = new CrashConsole();

                crashConsole.Location = new System.Drawing.Point(crashConsole.Location.X, crashConsole.Location.Y + 100);
                crashConsole.Show();

            }
            else
            {
                TaskDelay();
            }
        }
        async void TaskDelay()
        {
            while (Vitsotki != 101)
            {
                label2.Text = $"File recovery: {Vitsotki} %";
                await Task.Delay(random.Next(500));
                Vitsotki++;
            }
            Application.Restart();
        }

        private async void BSoD_Load(object sender, EventArgs e)
        {
           
        }
    }
}
