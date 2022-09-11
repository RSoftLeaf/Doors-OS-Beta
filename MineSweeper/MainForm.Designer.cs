namespace MyMineSweeper
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbExpert = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.bmbslb = new System.Windows.Forms.Label();
            this.ylb = new System.Windows.Forms.Label();
            this.xlb = new System.Windows.Forms.Label();
            this.tbBombs = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbX = new System.Windows.Forms.TextBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.btnSmile = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlHeader.Controls.Add(this.rbCustom);
            this.pnlHeader.Controls.Add(this.rbExpert);
            this.pnlHeader.Controls.Add(this.rbMedium);
            this.pnlHeader.Controls.Add(this.rbEasy);
            this.pnlHeader.Controls.Add(this.bmbslb);
            this.pnlHeader.Controls.Add(this.ylb);
            this.pnlHeader.Controls.Add(this.xlb);
            this.pnlHeader.Controls.Add(this.tbBombs);
            this.pnlHeader.Controls.Add(this.tbY);
            this.pnlHeader.Controls.Add(this.tbX);
            this.pnlHeader.Controls.Add(this.lbTimer);
            this.pnlHeader.Controls.Add(this.btnSmile);
            this.pnlHeader.Location = new System.Drawing.Point(12, 12);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(760, 100);
            this.pnlHeader.TabIndex = 0;
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(115, 78);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(75, 19);
            this.rbCustom.TabIndex = 10;
            this.rbCustom.Text = "Вручную";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbExpert
            // 
            this.rbExpert.AutoSize = true;
            this.rbExpert.Location = new System.Drawing.Point(115, 53);
            this.rbExpert.Name = "rbExpert";
            this.rbExpert.Size = new System.Drawing.Size(69, 19);
            this.rbExpert.TabIndex = 9;
            this.rbExpert.Text = "Эксперт";
            this.rbExpert.UseVisualStyleBackColor = true;
            this.rbExpert.CheckedChanged += new System.EventHandler(this.rbExpert_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Location = new System.Drawing.Point(115, 28);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(73, 19);
            this.rbMedium.TabIndex = 8;
            this.rbMedium.Text = "Средний";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Checked = true;
            this.rbEasy.Location = new System.Drawing.Point(115, 3);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(64, 19);
            this.rbEasy.TabIndex = 1;
            this.rbEasy.TabStop = true;
            this.rbEasy.Text = "Легкий";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // bmbslb
            // 
            this.bmbslb.AutoSize = true;
            this.bmbslb.Location = new System.Drawing.Point(48, 70);
            this.bmbslb.Name = "bmbslb";
            this.bmbslb.Size = new System.Drawing.Size(44, 15);
            this.bmbslb.TabIndex = 7;
            this.bmbslb.Text = "Bombs";
            this.bmbslb.Visible = false;
            // 
            // ylb
            // 
            this.ylb.AutoSize = true;
            this.ylb.Location = new System.Drawing.Point(48, 42);
            this.ylb.Name = "ylb";
            this.ylb.Size = new System.Drawing.Size(14, 15);
            this.ylb.TabIndex = 6;
            this.ylb.Text = "Y";
            this.ylb.Visible = false;
            // 
            // xlb
            // 
            this.xlb.AutoSize = true;
            this.xlb.Location = new System.Drawing.Point(48, 12);
            this.xlb.Name = "xlb";
            this.xlb.Size = new System.Drawing.Size(14, 15);
            this.xlb.TabIndex = 5;
            this.xlb.Text = "X";
            this.xlb.Visible = false;
            // 
            // tbBombs
            // 
            this.tbBombs.Enabled = false;
            this.tbBombs.Location = new System.Drawing.Point(3, 62);
            this.tbBombs.Name = "tbBombs";
            this.tbBombs.Size = new System.Drawing.Size(39, 23);
            this.tbBombs.TabIndex = 4;
            this.tbBombs.Visible = false;
            this.tbBombs.TextChanged += new System.EventHandler(this.tbBombs_TextChanged);
            // 
            // tbY
            // 
            this.tbY.Enabled = false;
            this.tbY.Location = new System.Drawing.Point(3, 33);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(39, 23);
            this.tbY.TabIndex = 3;
            this.tbY.Visible = false;
            this.tbY.TextChanged += new System.EventHandler(this.tbY_TextChanged);
            // 
            // tbX
            // 
            this.tbX.Enabled = false;
            this.tbX.Location = new System.Drawing.Point(3, 4);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(39, 23);
            this.tbX.TabIndex = 2;
            this.tbX.Visible = false;
            this.tbX.TextChanged += new System.EventHandler(this.tbX_TextChanged);
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Georgia", 51F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTimer.Location = new System.Drawing.Point(568, 4);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(201, 77);
            this.lbTimer.TabIndex = 1;
            this.lbTimer.Text = "0000";
            // 
            // btnSmile
            // 
            this.btnSmile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSmile.Image = global::MyMineSweeper.Properties.Resources.Hi;
            this.btnSmile.Location = new System.Drawing.Point(334, 3);
            this.btnSmile.Name = "btnSmile";
            this.btnSmile.Size = new System.Drawing.Size(92, 92);
            this.btnSmile.TabIndex = 0;
            this.btnSmile.UseVisualStyleBackColor = true;
            this.btnSmile.Click += new System.EventHandler(this.btnSmile_Game);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Minesweeper";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pnlHeader;
        private Button btnSmile;
        private Label lbTimer;
        private Label bmbslb;
        private Label ylb;
        private Label xlb;
        private TextBox tbBombs;
        private TextBox tbY;
        private TextBox tbX;
        private RadioButton rbCustom;
        private RadioButton rbExpert;
        private RadioButton rbMedium;
        private RadioButton rbEasy;
    }
}