namespace Windows_0
{
    partial class TaskPanelSettings
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
            this.pnlBig = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSmall = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBig
            // 
            this.pnlBig.AutoSize = true;
            this.pnlBig.BackColor = System.Drawing.Color.Silver;
            this.pnlBig.Location = new System.Drawing.Point(321, 27);
            this.pnlBig.Name = "pnlBig";
            this.pnlBig.Size = new System.Drawing.Size(150, 19);
            this.pnlBig.TabIndex = 0;
            this.pnlBig.TabStop = true;
            this.pnlBig.Text = "Большая панель задач";
            this.pnlBig.UseVisualStyleBackColor = false;
            this.pnlBig.CheckedChanged += new System.EventHandler(this.pnlBig_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(321, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Внешний вид";
            // 
            // pnlSmall
            // 
            this.pnlSmall.AutoSize = true;
            this.pnlSmall.BackColor = System.Drawing.Color.Silver;
            this.pnlSmall.Location = new System.Drawing.Point(321, 52);
            this.pnlSmall.Name = "pnlSmall";
            this.pnlSmall.Size = new System.Drawing.Size(161, 19);
            this.pnlSmall.TabIndex = 2;
            this.pnlSmall.TabStop = true;
            this.pnlSmall.Text = "Маленькая панель задач";
            this.pnlSmall.UseVisualStyleBackColor = false;
            this.pnlSmall.CheckedChanged += new System.EventHandler(this.pnlSmall_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(-4, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 212);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Внутренние настройки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(381, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Открытие";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.BackColor = System.Drawing.Color.Silver;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(381, 130);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 19);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Нажатие";
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.Silver;
            this.radioButton2.Enabled = false;
            this.radioButton2.Location = new System.Drawing.Point(381, 105);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 19);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "Двойное нажатие";
            this.radioButton2.UseVisualStyleBackColor = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // TaskPanelSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 177);
            this.Controls.Add(this.pnlSmall);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlBig);
            this.Controls.Add(this.panel1);
            this.Name = "TaskPanelSettings";
            this.Text = "TaskPanelSettings";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton pnlBig;
        private Label label1;
        private RadioButton pnlSmall;
        private Panel panel1;
        private RadioButton radioButton1;
        private Label label3;
        private RadioButton radioButton2;
        private Label label2;
    }
}