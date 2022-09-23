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
    public partial class TaskManager : Form
    {
        bool boolDate = false;
        bool boolDriveMan = false;
        bool boolTaskSet = false;
        bool boolManager = false;
        bool boolUpdater = false;
        bool boolTaskManager = false;
        public TaskManager()
        {
            InitializeComponent();
        }

        private void btnDate_Click(object sender, EventArgs e)
        {
            boolDate = true;
            boolDriveMan = false;
            boolTaskSet = false;
            boolManager = false;
            boolUpdater = false;
            boolTaskManager = false;
            btnStop.Text = "Завершить";
        }

        private void btnDriveMan_Click(object sender, EventArgs e)
        {
            boolDate = false;
            boolDriveMan = true;
            boolTaskSet = false;
            boolManager = false;
            boolUpdater = false;
            boolTaskManager = false;
            btnStop.Text = "Завершить";
        }

        private void btnTaskSet_Click(object sender, EventArgs e)
        {
            boolDate = false;
            boolDriveMan = false;
            boolTaskSet = true;
            boolManager = false;
            boolUpdater = false;
            boolTaskManager = false;
            btnStop.Text = "Завершить";
        }

        private void Manager_Click(object sender, EventArgs e)
        {
            boolDate = false;
            boolDriveMan = false;
            boolTaskSet = false;
            boolManager = true;
            boolUpdater = false;
            boolTaskManager = false;
            btnStop.Text = "Завершить";
        }

        private void btnUpdater_Click(object sender, EventArgs e)
        {
            boolDate = false;
            boolDriveMan = false;
            boolTaskSet = false;
            boolManager = false;
            boolUpdater = true;
            boolTaskManager = false;
            btnStop.Text = "Завершить";
        }

        private void btnSyop_Click(object sender, EventArgs e)
        {
            if (boolDate)
            {
                Kalendar date = new Kalendar();
                date.Hide();
            }
            else if (boolDriveMan)
            {

            }
            else if (boolTaskSet)
            {

            }
            else if (boolManager)
            {

            }
            else if (boolUpdater)
            {

            }
            else if (boolTaskManager)
            {
                btnTaskManager.Visible = false;
                this.Close();
            }
        }
    }
}
