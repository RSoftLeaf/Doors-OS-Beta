namespace Windows_0
{
    partial class Avtorize
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Avtorize));
            this.User = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.TextBox();
            this.Shotdown = new System.Windows.Forms.Button();
            this.ReStart = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.customProgressBar1 = new Windows_0.CustomProgressBar();
            this.SuspendLayout();
            // 
            // User
            // 
            this.User.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.User.Location = new System.Drawing.Point(684, 164);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(707, 96);
            this.User.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(795, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(482, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(561, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(502, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Пароль";
            // 
            // Pass
            // 
            this.Pass.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pass.Location = new System.Drawing.Point(684, 266);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(707, 96);
            this.Pass.TabIndex = 1;
            // 
            // Shotdown
            // 
            this.Shotdown.Location = new System.Drawing.Point(1810, 1045);
            this.Shotdown.Name = "Shotdown";
            this.Shotdown.Size = new System.Drawing.Size(75, 23);
            this.Shotdown.TabIndex = 5;
            this.Shotdown.Text = "Shutdown";
            this.Shotdown.UseVisualStyleBackColor = true;
            this.Shotdown.Click += new System.EventHandler(this.Shotdown_Click);
            // 
            // ReStart
            // 
            this.ReStart.Location = new System.Drawing.Point(1729, 1045);
            this.ReStart.Name = "ReStart";
            this.ReStart.Size = new System.Drawing.Size(75, 23);
            this.ReStart.TabIndex = 4;
            this.ReStart.Text = "Restart";
            this.ReStart.UseVisualStyleBackColor = true;
            this.ReStart.Click += new System.EventHandler(this.ReStart_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(1283, 368);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 19);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Показать пароль";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // customProgressBar1
            // 
            this.customProgressBar1.Location = new System.Drawing.Point(795, 459);
            this.customProgressBar1.Name = "customProgressBar1";
            this.customProgressBar1.Size = new System.Drawing.Size(482, 23);
            this.customProgressBar1.TabIndex = 6;
            this.customProgressBar1.Click += new System.EventHandler(this.customProgressBar1_Click);
            // 
            // Avtorize
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.customProgressBar1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ReStart);
            this.Controls.Add(this.Shotdown);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.User);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Avtorize";
            this.Text = "Avtorize";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox User;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox Pass;
        private Button Shotdown;
        private Button ReStart;
        private CheckBox checkBox1;
        private CustomProgressBar customProgressBar1;
    }
}