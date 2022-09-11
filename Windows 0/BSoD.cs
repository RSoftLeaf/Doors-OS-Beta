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
        public BSoD()
        {
            InitializeComponent();
        }

        private async void BSoD_Load(object sender, EventArgs e)
        {
            while (Vitsotki != 100)
            {
                label2.Text = $"File recovery: {Vitsotki} %";
                await Task.Delay(random.Next(300));
                Vitsotki++;
            }
        }
    }
}
