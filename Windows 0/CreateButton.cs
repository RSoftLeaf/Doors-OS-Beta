using MyMineSweeper;
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
    public partial class CreateButton : Form
    {
        shortcut Shortcut;
        Point point;
        Form1 form1 = new Form1(false, false);
        public CreateButton(Point location)
        {
            InitializeComponent();
            point = location;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Shortcut = new shortcut(35, 35, point.X, point.Y, textBox2.Text, textBox1.Text);
            Shortcut.UseVisualStyleBackColor = true;
            form1.Controls.Add(Shortcut);
        }
    }
}
