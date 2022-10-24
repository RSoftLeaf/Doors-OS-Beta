using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_0
{
    public class shortcut : Button
    {
        string varShortcut;
        public shortcut(int SizeX, int SizeY, int LocationX, int LocationY, string name, string shortcut)
        {
            this.Size = new Size(SizeX, SizeY);
            this.Location = new Point(LocationX, LocationY);
            this.BackColor = Color.Gainsboro;
            this.Text = name;
            this.Click += Shortcut_Click;
            varShortcut = shortcut;
        }

        private void Shortcut_Click(object sender, EventArgs e)
        {
            Process.Start(varShortcut);
        }
    }
}
