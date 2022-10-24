namespace Windows_0
{
    partial class Volume_Control
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
            this.ucVolume_Control1 = new Windows_0.ucVolume_Control();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ucVolume_Control1
            // 
            this.ucVolume_Control1.BackColor = System.Drawing.Color.Black;
            this.ucVolume_Control1.Bar_color = System.Drawing.Color.Aqua;
            this.ucVolume_Control1.Location = new System.Drawing.Point(220, 220);
            this.ucVolume_Control1.Max = 100;
            this.ucVolume_Control1.Min = 0;
            this.ucVolume_Control1.Name = "ucVolume_Control1";
            this.ucVolume_Control1.Size = new System.Drawing.Size(468, 50);
            this.ucVolume_Control1.TabIndex = 0;
            this.ucVolume_Control1.Value = 40;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Windows_0.Properties.Resources.mute_volume;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Location = new System.Drawing.Point(220, 276);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 41);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Windows_0.Properties.Resources.max_volume;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(645, 276);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(43, 41);
            this.panel2.TabIndex = 2;
            // 
            // Volume_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucVolume_Control1);
            this.Name = "Volume_Control";
            this.Text = "Volume_Control";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Volume_Control_MouseMove);
            this.ResumeLayout(false);

        }

        #endregion

        private ucVolume_Control ucVolume_Control1;
        private Panel panel1;
        private Panel panel2;
    }
}