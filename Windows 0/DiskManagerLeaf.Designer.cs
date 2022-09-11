namespace Windows_0
{
    partial class DiskManagerLeaf
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbCDrive = new Windows_0.CustomProgressBar();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbCDriveReserve = new Windows_0.CustomProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCDriveReserveDownload = new Windows_0.CustomProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "129 GB";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.pbCDrive);
            this.panel2.Location = new System.Drawing.Point(192, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 74);
            this.panel2.TabIndex = 9;
            // 
            // pbCDrive
            // 
            this.pbCDrive.BackColor = System.Drawing.Color.Cyan;
            this.pbCDrive.Location = new System.Drawing.Point(3, 3);
            this.pbCDrive.Maximum = 128;
            this.pbCDrive.Name = "pbCDrive";
            this.pbCDrive.Size = new System.Drawing.Size(254, 23);
            this.pbCDrive.TabIndex = 2;
            this.pbCDrive.UseWaitCursor = true;
            this.pbCDrive.Value = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Controls.Add(this.pbCDriveReserve);
            this.panel3.Location = new System.Drawing.Point(458, 165);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(107, 74);
            this.panel3.TabIndex = 10;
            // 
            // pbCDriveReserve
            // 
            this.pbCDriveReserve.BackColor = System.Drawing.Color.Cyan;
            this.pbCDriveReserve.Location = new System.Drawing.Point(3, 3);
            this.pbCDriveReserve.Name = "pbCDriveReserve";
            this.pbCDriveReserve.Size = new System.Drawing.Size(100, 23);
            this.pbCDriveReserve.TabIndex = 2;
            this.pbCDriveReserve.Value = 100;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.pbCDriveReserveDownload);
            this.panel1.Location = new System.Drawing.Point(79, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(107, 74);
            this.panel1.TabIndex = 8;
            // 
            // pbCDriveReserveDownload
            // 
            this.pbCDriveReserveDownload.BackColor = System.Drawing.Color.Cyan;
            this.pbCDriveReserveDownload.Location = new System.Drawing.Point(3, 3);
            this.pbCDriveReserveDownload.Name = "pbCDriveReserveDownload";
            this.pbCDriveReserveDownload.Size = new System.Drawing.Size(100, 23);
            this.pbCDriveReserveDownload.TabIndex = 2;
            this.pbCDriveReserveDownload.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "C:\\\\";
            // 
            // DiskManagerLeaf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "DiskManagerLeaf";
            this.Text = "DiskManagerLeaf";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label3;
        private Panel panel2;
        private CustomProgressBar pbCDrive;
        private Panel panel3;
        private CustomProgressBar pbCDriveReserve;
        private Panel panel1;
        private CustomProgressBar pbCDriveReserveDownload;
        private Label label1;
    }
}