namespace Windows_0
{
    partial class PowerWarning
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
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.Cyan;
            this.btnOk.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOk.Location = new System.Drawing.Point(12, 312);
            this.btnOk.Name = "btnOk";
            this.btnOk.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnOk.Size = new System.Drawing.Size(385, 76);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(664, 267);
            this.label1.TabIndex = 1;
            this.label1.Text = "Батарея разряжена. \r\nПодключите ПК к \r\n        зарядке";
            // 
            // btnOn
            // 
            this.btnOn.BackColor = System.Drawing.Color.Cyan;
            this.btnOn.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOn.Location = new System.Drawing.Point(403, 312);
            this.btnOn.Name = "btnOn";
            this.btnOn.Size = new System.Drawing.Size(385, 76);
            this.btnOn.TabIndex = 2;
            this.btnOn.Text = "Подключить";
            this.btnOn.UseVisualStyleBackColor = false;
            this.btnOn.Click += new System.EventHandler(this.btnOn_Click);
            // 
            // PowerWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.btnOn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PowerWarning";
            this.Text = "PowerWarning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnOk;
        private Label label1;
        private Button btnOn;
    }
}