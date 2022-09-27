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
            System.Windows.Forms.Button btnConsoleMain;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartMenu));
            this.btnUser = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnProvodnik = new System.Windows.Forms.Button();
            this.cmsPower = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.перезагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.завершениеРаботыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSettingsMain = new System.Windows.Forms.Button();
            this.btnDiskManagerMain = new System.Windows.Forms.Button();
            this.btnTaskPanelMain = new System.Windows.Forms.Button();
            this.btnTaskManagerMain = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnProvodnikMain = new System.Windows.Forms.Button();
            btnConsoleMain = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.cmsPower.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConsoleMain
            // 
            btnConsoleMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            btnConsoleMain.Dock = System.Windows.Forms.DockStyle.Top;
            btnConsoleMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            btnConsoleMain.ForeColor = System.Drawing.Color.Black;
            btnConsoleMain.Image = ((System.Drawing.Image)(resources.GetObject("btnConsoleMain.Image")));
            btnConsoleMain.Location = new System.Drawing.Point(0, 120);
            btnConsoleMain.Margin = new System.Windows.Forms.Padding(0);
            btnConsoleMain.Name = "btnConsoleMain";
            btnConsoleMain.Size = new System.Drawing.Size(187, 30);
            btnConsoleMain.TabIndex = 8;
            btnConsoleMain.Text = "Console";
            btnConsoleMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            btnConsoleMain.UseVisualStyleBackColor = false;
            btnConsoleMain.Click += new System.EventHandler(this.btnConsoleMain_Click);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Controls.Add(this.btnSettingsMain);
            this.panel2.Controls.Add(this.btnDiskManagerMain);
            this.panel2.Controls.Add(btnConsoleMain);
            this.panel2.Controls.Add(this.btnTaskPanelMain);
            this.panel2.Controls.Add(this.btnTaskManagerMain);
            this.panel2.Controls.Add(this.btnDate);
            this.panel2.Controls.Add(this.btnProvodnikMain);
            this.panel2.Location = new System.Drawing.Point(40, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(187, 600);
            this.panel2.TabIndex = 2;
            // 
            // btnSettingsMain
            // 
            this.btnSettingsMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnSettingsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettingsMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSettingsMain.ForeColor = System.Drawing.Color.Black;
            this.btnSettingsMain.Image = ((System.Drawing.Image)(resources.GetObject("btnSettingsMain.Image")));
            this.btnSettingsMain.Location = new System.Drawing.Point(0, 180);
            this.btnSettingsMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnSettingsMain.Name = "btnSettingsMain";
            this.btnSettingsMain.Size = new System.Drawing.Size(187, 30);
            this.btnSettingsMain.TabIndex = 10;
            this.btnSettingsMain.Text = "Settings";
            this.btnSettingsMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettingsMain.UseVisualStyleBackColor = false;
            this.btnSettingsMain.Click += new System.EventHandler(this.btnSettingsMain_Click);
            // 
            // btnDiskManagerMain
            // 
            this.btnDiskManagerMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDiskManagerMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiskManagerMain.Enabled = false;
            this.btnDiskManagerMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDiskManagerMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDiskManagerMain.Image = ((System.Drawing.Image)(resources.GetObject("btnDiskManagerMain.Image")));
            this.btnDiskManagerMain.Location = new System.Drawing.Point(0, 150);
            this.btnDiskManagerMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnDiskManagerMain.Name = "btnDiskManagerMain";
            this.btnDiskManagerMain.Size = new System.Drawing.Size(187, 30);
            this.btnDiskManagerMain.TabIndex = 9;
            this.btnDiskManagerMain.Text = "Disk Manager";
            this.btnDiskManagerMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDiskManagerMain.UseVisualStyleBackColor = false;
            this.btnDiskManagerMain.Click += new System.EventHandler(this.btnDiskManagerMain_Click);
            // 
            // btnTaskPanelMain
            // 
            this.btnTaskPanelMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTaskPanelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskPanelMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaskPanelMain.ForeColor = System.Drawing.Color.Black;
            this.btnTaskPanelMain.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskPanelMain.Image")));
            this.btnTaskPanelMain.Location = new System.Drawing.Point(0, 90);
            this.btnTaskPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaskPanelMain.Name = "btnTaskPanelMain";
            this.btnTaskPanelMain.Size = new System.Drawing.Size(187, 30);
            this.btnTaskPanelMain.TabIndex = 6;
            this.btnTaskPanelMain.Text = "Task Panel Settings";
            this.btnTaskPanelMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaskPanelMain.UseVisualStyleBackColor = false;
            this.btnTaskPanelMain.Click += new System.EventHandler(this.btnTaskPanelMain_Click);
            // 
            // btnTaskManagerMain
            // 
            this.btnTaskManagerMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnTaskManagerMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskManagerMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTaskManagerMain.ForeColor = System.Drawing.Color.Black;
            this.btnTaskManagerMain.Image = ((System.Drawing.Image)(resources.GetObject("btnTaskManagerMain.Image")));
            this.btnTaskManagerMain.Location = new System.Drawing.Point(0, 60);
            this.btnTaskManagerMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnTaskManagerMain.Name = "btnTaskManagerMain";
            this.btnTaskManagerMain.Size = new System.Drawing.Size(187, 30);
            this.btnTaskManagerMain.TabIndex = 2;
            this.btnTaskManagerMain.Text = "Task Manager";
            this.btnTaskManagerMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaskManagerMain.UseVisualStyleBackColor = false;
            this.btnTaskManagerMain.Click += new System.EventHandler(this.btnTaskManagerMain_Click);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDate.ForeColor = System.Drawing.Color.Black;
            this.btnDate.Image = ((System.Drawing.Image)(resources.GetObject("btnDate.Image")));
            this.btnDate.Location = new System.Drawing.Point(0, 30);
            this.btnDate.Margin = new System.Windows.Forms.Padding(0);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(187, 30);
            this.btnDate.TabIndex = 1;
            this.btnDate.Text = "Calendar";
            this.btnDate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnProvodnikMain
            // 
            this.btnProvodnikMain.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnProvodnikMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProvodnikMain.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnProvodnikMain.ForeColor = System.Drawing.Color.Black;
            this.btnProvodnikMain.Image = ((System.Drawing.Image)(resources.GetObject("btnProvodnikMain.Image")));
            this.btnProvodnikMain.Location = new System.Drawing.Point(0, 0);
            this.btnProvodnikMain.Margin = new System.Windows.Forms.Padding(0);
            this.btnProvodnikMain.Name = "btnProvodnikMain";
            this.btnProvodnikMain.Size = new System.Drawing.Size(187, 30);
            this.btnProvodnikMain.TabIndex = 0;
            this.btnProvodnikMain.Text = "Manager";
            this.btnProvodnikMain.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProvodnikMain.UseVisualStyleBackColor = false;
            this.btnProvodnikMain.Click += new System.EventHandler(this.btnProvodnikMain_Click);
            // 
            // StartMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 600);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StartMenu";
            this.Text = "StartMenu";
            this.panel1.ResumeLayout(false);
            this.cmsPower.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        private Panel panel2;
        private Button btnSettingsMain;
        private Button btnDiskManagerMain;
        private Button btnConsoleMain;
        private Button btnTaskPanelMain;
        private Button btnTaskManagerMain;
        private Button btnDate;
        private Button btnProvodnikMain;
    }
}