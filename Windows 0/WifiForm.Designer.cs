namespace Windows_0
{
    partial class WifiForm
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
            this.ListNet = new System.Windows.Forms.ListView();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListNet
            // 
            this.ListNet.Location = new System.Drawing.Point(12, 49);
            this.ListNet.Name = "ListNet";
            this.ListNet.Size = new System.Drawing.Size(576, 439);
            this.ListNet.TabIndex = 0;
            this.ListNet.UseCompatibleStateImageBehavior = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(576, 31);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // WifiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 500);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ListNet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WifiForm";
            this.Text = "WifiForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView ListNet;
        private Button btnRefresh;
    }
}