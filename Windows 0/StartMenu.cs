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
    public partial class StartMenu : Form
    {
        Shutdown shutdown;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void перезагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shutdown = new Shutdown("Перезагрузка");
            shutdown.Show();
        }

        private void завершениеРаботыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shutdown = new Shutdown("Завершение работы");
            shutdown.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cmsPower.Show(MousePosition);
            //cmsPower.Location = new System.Drawing.Point(40, 0);
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            Provodnik provodnik = new Provodnik();
            provodnik.Show();
            for (int i = 0; i < 50; i++)
            {
//                await Task.Delay(1);
                this.Size = new System.Drawing.Size(this.Size.Width, this.Size.Height - 2);
                this.Location = new System.Drawing.Point(this.Location.X, this.Location.Y + 2);
                if (i == 25)
                {
                    this.Hide();
                }
            }
            this.Hide();
        }
    }
}
