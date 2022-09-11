using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;

namespace MyMineSweeper
{
    public class Grid : Button
    {
        #region VARIABLES

        public bool IsOpen { get; set; }
        public bool Flagged { get; set; }
        public int Status { get; set; }
        public bool IsBomb { get; set; }
        ImageList IMGList = new ImageList();
        PrivateFontCollection MyFonts = new PrivateFontCollection();

        #endregion

        public Grid()
        {
            IsBomb = false;
            IsOpen = false;
            Flagged = false;
            Status = 0;
        }
        public Grid(int SizeX, int SizeY, int LocationX, int LocationY)
        {
            MyFonts.AddFontFile("Fonts/Quantico-Bold.ttf");
            IMGList.Images.Add(Properties.Resources.flag);
            IMGList.Images.Add(Properties.Resources.Bam);
            IMGList.Images.Add(Properties.Resources.BamBoom);
            IMGList.Images.Add(Properties.Resources.mine);
            IMGList.ImageSize = new Size(SizeX - SizeX / 10, SizeY - SizeY / 10);
            IsBomb = false;
            IsOpen = false;
            Flagged = false;
            Status = 0;
            this.Size = new Size(SizeX, SizeY);
            this.Location = new Point(LocationX, LocationY);
            this.BackColor = Color.Gainsboro;
            this.Font = new System.Drawing.Font(MyFonts.Families[0], 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        }
        public void SetFlag()
        {
            if (Flagged == false)
            {
                Flagged = true;
                this.Image = IMGList.Images[0];
            }
            else
            {
                Flagged = false;
                this.Image = null;
            }
        }
        public int OpenGrid()
        {
            if (!this.Flagged && !this.IsOpen)
            {
                this.FlatStyle = FlatStyle.Flat;
                this.BackColor = Color.White;
                this.FlatAppearance.BorderSize = 0;
                this.IsOpen = true;
                if (Status != 0 && Status != 10)
                {
                    switch (Status)
                    {
                        case 1: this.ForeColor = Color.Blue; break;
                        case 2: this.ForeColor = Color.Green; break;
                        case 3: this.ForeColor = Color.Red; break;
                        case 4: this.ForeColor = Color.DarkBlue; break;
                        case 5: this.ForeColor = Color.DarkRed; break;
                        case 6: this.ForeColor = Color.DarkCyan; break;
                        case 7: this.ForeColor = Color.Black; break;
                        case 8: this.ForeColor = Color.DarkGray; break;
                    }
                    this.Text = Status.ToString();
                }
                return Status;
            }
            else
            {
                return -1;
            }
        }
        public void ShowBomb(bool Victory)
        {
            if (IsBomb)
            {
                if (Victory)
                {
                    this.Image = IMGList.Images[3];
                }
                else
                {
                    Random random = new Random();
                    int rndm = random.Next(2);
                    if (rndm == 0)
                    {
                        this.Image = IMGList.Images[1];
                    }
                    else
                    {
                        this.Image= IMGList.Images[2];
                    }
                }
            }
        }
    }
}
