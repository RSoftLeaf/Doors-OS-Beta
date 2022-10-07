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
    public partial class PowerWarning : Form
    {
        Form1 mainForm;
        public PowerWarning(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.Opacity = 0;
            SettingsOpacity();
        }
        async void SettingsOpacity()
        {
            for (int i = 0; i < 10; i++)
            {
                this.Opacity += 0.1;
                this.Refresh();
                await Task.Delay(1);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            mainForm.Power = true;
            this.Close();
        }
    }
}
