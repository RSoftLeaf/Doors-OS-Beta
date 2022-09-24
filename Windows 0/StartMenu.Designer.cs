namespace Windows_0
{
    partial class StartMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProvodnik = new System.Windows.Forms.Button();
            this.cmsPower = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перезагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершениеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.cmsPower.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.Transparent;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.Location = new System.Drawing.Point(0, 482);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(40, 40);
            this.btnUser.TabIndex = 0;
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btnStart);
            this.panel1.Controls.Add(this.btnProvodnik);
            this.panel1.Controls.Add(this.btnUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(40, 600);
            this.panel1.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Transparent;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Image = ((System.Drawing.Image)(resources.GetObject("btnStart.Image")));
            this.btnStart.Location = new System.Drawing.Point(0, 560);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(40, 40);
            this.btnStart.TabIndex = 3;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnProvodnik
            // 
            this.btnProvodnik.BackColor = System.Drawing.Color.Transparent;
            this.btnProvodnik.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnProvodnik.Image = ((System.Drawing.Image)(resources.GetObject("btnProvodnik.Image")));
            this.btnProvodnik.Location = new System.Drawing.Point(0, 521);
            this.btnProvodnik.Name = "btnProvodnik";
            this.btnProvodnik.Size = new System.Drawing.Size(40, 40);
            this.btnProvodnik.TabIndex = 2;
            this.btnProvodnik.UseVisualStyleBackColor = false;
            this.btnProvodnik.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmsPower
            // 
            this.cmsPower.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузкаToolStripMenuItem,
            this.завершениеРаботыToolStripMenuItem});
            this.cmsPower.Name = "cmsPower";
            this.cmsPower.Size = new System.Drawing.Size(188, 48);
            // 
            // перезагрузкаToolStripMenuItem
            // 
            this.перезагрузкаToolStripMenuItem.Name = "перезагрузкаToolStripMenuItem";
            this.перезагрузкаToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.перезагрузкаToolStripMenuItem.Text = "Перезагрузка";
            this.перезагрузкаToolStripMenuItem.Click += new System.EventHandler(this.перезагрузкаToolStripMenuItem_Click);
            // 
            // завершениеРаботыToolStripMenuItem
            // 
            this.завершениеРаботыToolStripMenuItem.Name = "завершениеРаботыToolStripMenuItem";
            this.завершениеРаботыToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.завершениеРаботыToolStripMenuItem.Text = "Завершение работы";
            this.завершениеРаботыToolStripMenuItem.Click += new System.EventHandler(this.завершениеРаботыToolStripMenuItem_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.panel1.ResumeLayout(false);
            this.cmsPower.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnUser;
        private Panel panel1;
        private Button btnStart;
        private Button btnProvodnik;
        private ContextMenuStrip cmsPower;
        private ToolStripMenuItem перезагрузкаToolStripMenuItem;
        private ToolStripMenuItem завершениеРаботыToolStripMenuItem;
    }
}