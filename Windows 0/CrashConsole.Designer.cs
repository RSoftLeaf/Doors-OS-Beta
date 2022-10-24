namespace Windows_0
{
    partial class CrashConsole
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbMain = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbMain
            // 
            this.tbMain.BackColor = System.Drawing.Color.Black;
            this.tbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMain.ForeColor = System.Drawing.Color.White;
            this.tbMain.Location = new System.Drawing.Point(0, 0);
            this.tbMain.Multiline = true;
            this.tbMain.Name = "tbMain";
            this.tbMain.ReadOnly = true;
            this.tbMain.Size = new System.Drawing.Size(800, 450);
            this.tbMain.TabIndex = 0;
            this.tbMain.Text = "Crashed\r\nError 0x543879\r\nRestarting\r\nC:\\Shinda\\";
            // 
            // CrashConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbMain);
            this.Name = "CrashConsole";
            this.Text = "CrashConsole";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbMain;
    }
}