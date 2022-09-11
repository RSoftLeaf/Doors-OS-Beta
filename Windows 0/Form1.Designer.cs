namespace Windows_0
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTask = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnLook = new System.Windows.Forms.Button();
            this.tbProgram = new System.Windows.Forms.TextBox();
            this.btnpanelSnap = new System.Windows.Forms.Button();
            this.contextMenuStrip7 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnpanelPhotoShop = new System.Windows.Forms.Button();
            this.btnpanelCMD = new System.Windows.Forms.Button();
            this.btnpanelCalc = new System.Windows.Forms.Button();
            this.btnSTART = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перезагрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выключениеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCalc = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCMD = new System.Windows.Forms.Button();
            this.contextMenuStrip5 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip6 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPhotoShop = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.contextMenuStrip8 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.диспетчерЗадачToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFileManager = new System.Windows.Forms.Button();
            this.btnNotePad = new System.Windows.Forms.Button();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.panelTask.SuspendLayout();
            this.contextMenuStrip7.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.contextMenuStrip6.SuspendLayout();
            this.contextMenuStrip8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTask
            // 
            this.panelTask.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelTask.BackgroundImage")));
            this.panelTask.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelTask.Controls.Add(this.lbDate);
            this.panelTask.Controls.Add(this.lbTime);
            this.panelTask.Controls.Add(this.btnLook);
            this.panelTask.Controls.Add(this.tbProgram);
            this.panelTask.Controls.Add(this.btnpanelSnap);
            this.panelTask.Controls.Add(this.btnpanelPhotoShop);
            this.panelTask.Controls.Add(this.btnpanelCMD);
            this.panelTask.Controls.Add(this.btnpanelCalc);
            this.panelTask.Controls.Add(this.btnSTART);
            this.panelTask.Location = new System.Drawing.Point(-5, 1035);
            this.panelTask.Name = "panelTask";
            this.panelTask.Size = new System.Drawing.Size(1929, 44);
            this.panelTask.TabIndex = 4;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.BackColor = System.Drawing.Color.Transparent;
            this.lbDate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDate.Location = new System.Drawing.Point(1752, 20);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(79, 20);
            this.lbDate.TabIndex = 13;
            this.lbDate.Text = "00:00:0000";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.Transparent;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTime.Location = new System.Drawing.Point(1766, 0);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(44, 20);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "00:00";
            // 
            // btnLook
            // 
            this.btnLook.Location = new System.Drawing.Point(164, 12);
            this.btnLook.Name = "btnLook";
            this.btnLook.Size = new System.Drawing.Size(75, 23);
            this.btnLook.TabIndex = 12;
            this.btnLook.Text = "Найти";
            this.btnLook.UseVisualStyleBackColor = true;
            this.btnLook.Click += new System.EventHandler(this.btnLook_Click);
            // 
            // tbProgram
            // 
            this.tbProgram.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbProgram.Location = new System.Drawing.Point(52, 9);
            this.tbProgram.Name = "tbProgram";
            this.tbProgram.Size = new System.Drawing.Size(100, 29);
            this.tbProgram.TabIndex = 11;
            // 
            // btnpanelSnap
            // 
            this.btnpanelSnap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpanelSnap.BackgroundImage")));
            this.btnpanelSnap.ContextMenuStrip = this.contextMenuStrip7;
            this.btnpanelSnap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpanelSnap.Location = new System.Drawing.Point(367, 6);
            this.btnpanelSnap.Name = "btnpanelSnap";
            this.btnpanelSnap.Size = new System.Drawing.Size(35, 35);
            this.btnpanelSnap.TabIndex = 10;
            this.btnpanelSnap.UseVisualStyleBackColor = true;
            this.btnpanelSnap.Click += new System.EventHandler(this.button13_Click);
            // 
            // contextMenuStrip7
            // 
            this.contextMenuStrip7.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
            this.contextMenuStrip7.Name = "contextMenuStrip2";
            this.contextMenuStrip7.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem7.Text = "Open";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.toolStripMenuItem7_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem8.Text = "Open Admin";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // btnpanelPhotoShop
            // 
            this.btnpanelPhotoShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpanelPhotoShop.BackgroundImage")));
            this.btnpanelPhotoShop.ContextMenuStrip = this.contextMenuStrip7;
            this.btnpanelPhotoShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpanelPhotoShop.Location = new System.Drawing.Point(326, 7);
            this.btnpanelPhotoShop.Name = "btnpanelPhotoShop";
            this.btnpanelPhotoShop.Size = new System.Drawing.Size(35, 35);
            this.btnpanelPhotoShop.TabIndex = 8;
            this.btnpanelPhotoShop.UseVisualStyleBackColor = true;
            this.btnpanelPhotoShop.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnpanelCMD
            // 
            this.btnpanelCMD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpanelCMD.BackgroundImage")));
            this.btnpanelCMD.ContextMenuStrip = this.contextMenuStrip7;
            this.btnpanelCMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpanelCMD.Location = new System.Drawing.Point(285, 5);
            this.btnpanelCMD.Name = "btnpanelCMD";
            this.btnpanelCMD.Size = new System.Drawing.Size(35, 35);
            this.btnpanelCMD.TabIndex = 7;
            this.btnpanelCMD.UseVisualStyleBackColor = true;
            this.btnpanelCMD.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnpanelCalc
            // 
            this.btnpanelCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnpanelCalc.BackgroundImage")));
            this.btnpanelCalc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnpanelCalc.Location = new System.Drawing.Point(247, 6);
            this.btnpanelCalc.Name = "btnpanelCalc";
            this.btnpanelCalc.Size = new System.Drawing.Size(32, 32);
            this.btnpanelCalc.TabIndex = 6;
            this.btnpanelCalc.UseVisualStyleBackColor = true;
            this.btnpanelCalc.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSTART
            // 
            this.btnSTART.BackColor = System.Drawing.Color.Transparent;
            this.btnSTART.ContextMenuStrip = this.contextMenuStrip1;
            this.btnSTART.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSTART.Font = new System.Drawing.Font("Segoe UI Black", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnSTART.Image = ((System.Drawing.Image)(resources.GetObject("btnSTART.Image")));
            this.btnSTART.Location = new System.Drawing.Point(3, 0);
            this.btnSTART.Name = "btnSTART";
            this.btnSTART.Size = new System.Drawing.Size(43, 45);
            this.btnSTART.TabIndex = 0;
            this.btnSTART.UseVisualStyleBackColor = false;
            this.btnSTART.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSTART_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметрыToolStripMenuItem,
            this.выключениеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 68);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.параметрыToolStripMenuItem.Text = "Параметры";
            this.параметрыToolStripMenuItem.Click += new System.EventHandler(this.параметрыToolStripMenuItem_Click);
            // 
            // выключениеToolStripMenuItem
            // 
            this.выключениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.перезагрузкаToolStripMenuItem,
            this.выключениеToolStripMenuItem1});
            this.выключениеToolStripMenuItem.Name = "выключениеToolStripMenuItem";
            this.выключениеToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.выключениеToolStripMenuItem.Text = "Выключение";
            // 
            // перезагрузкаToolStripMenuItem
            // 
            this.перезагрузкаToolStripMenuItem.Name = "перезагрузкаToolStripMenuItem";
            this.перезагрузкаToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            this.перезагрузкаToolStripMenuItem.Text = "Перезагрузка";
            this.перезагрузкаToolStripMenuItem.Click += new System.EventHandler(this.перезагрузкаToolStripMenuItem_Click);
            // 
            // выключениеToolStripMenuItem1
            // 
            this.выключениеToolStripMenuItem1.Name = "выключениеToolStripMenuItem1";
            this.выключениеToolStripMenuItem1.Size = new System.Drawing.Size(208, 32);
            this.выключениеToolStripMenuItem1.Text = "Выключение";
            this.выключениеToolStripMenuItem1.Click += new System.EventHandler(this.выключениеToolStripMenuItem1_Click);
            // 
            // btnCalc
            // 
            this.btnCalc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalc.BackgroundImage")));
            this.btnCalc.ContextMenuStrip = this.contextMenuStrip2;
            this.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCalc.Location = new System.Drawing.Point(12, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(35, 35);
            this.btnCalc.TabIndex = 5;
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.button5_DoubleClick);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.openAdminToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(143, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // openAdminToolStripMenuItem
            // 
            this.openAdminToolStripMenuItem.Name = "openAdminToolStripMenuItem";
            this.openAdminToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.openAdminToolStripMenuItem.Text = "Open Admin";
            this.openAdminToolStripMenuItem.Click += new System.EventHandler(this.openAdminToolStripMenuItem_Click);
            // 
            // btnCMD
            // 
            this.btnCMD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCMD.BackgroundImage")));
            this.btnCMD.ContextMenuStrip = this.contextMenuStrip7;
            this.btnCMD.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCMD.Location = new System.Drawing.Point(12, 50);
            this.btnCMD.Name = "btnCMD";
            this.btnCMD.Size = new System.Drawing.Size(35, 35);
            this.btnCMD.TabIndex = 6;
            this.btnCMD.UseVisualStyleBackColor = true;
            this.btnCMD.Click += new System.EventHandler(this.button7_Click);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Name = "contextMenuStrip5";
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip3.Name = "contextMenuStrip2";
            this.contextMenuStrip3.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem1.Text = "Open";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem2.Text = "Open Admin";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip4.Name = "contextMenuStrip2";
            this.contextMenuStrip4.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem3.Text = "Open";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem4.Text = "Open Admin";
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip6.Name = "contextMenuStrip2";
            this.contextMenuStrip6.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem5.Text = "Open";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(142, 22);
            this.toolStripMenuItem6.Text = "Open Admin";
            // 
            // btnPhotoShop
            // 
            this.btnPhotoShop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPhotoShop.BackgroundImage")));
            this.btnPhotoShop.ContextMenuStrip = this.contextMenuStrip7;
            this.btnPhotoShop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnPhotoShop.Location = new System.Drawing.Point(12, 91);
            this.btnPhotoShop.Name = "btnPhotoShop";
            this.btnPhotoShop.Size = new System.Drawing.Size(35, 35);
            this.btnPhotoShop.TabIndex = 7;
            this.btnPhotoShop.UseVisualStyleBackColor = true;
            this.btnPhotoShop.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSettings.BackgroundImage")));
            this.btnSettings.ContextMenuStrip = this.contextMenuStrip7;
            this.btnSettings.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSettings.Location = new System.Drawing.Point(12, 132);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(35, 35);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnSnap
            // 
            this.btnSnap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSnap.BackgroundImage")));
            this.btnSnap.ContextMenuStrip = this.contextMenuStrip7;
            this.btnSnap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSnap.Location = new System.Drawing.Point(12, 173);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(35, 35);
            this.btnSnap.TabIndex = 9;
            this.btnSnap.UseVisualStyleBackColor = true;
            this.btnSnap.Click += new System.EventHandler(this.button12_Click);
            // 
            // contextMenuStrip8
            // 
            this.contextMenuStrip8.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.диспетчерЗадачToolStripMenuItem});
            this.contextMenuStrip8.Name = "contextMenuStrip8";
            this.contextMenuStrip8.Size = new System.Drawing.Size(167, 26);
            // 
            // диспетчерЗадачToolStripMenuItem
            // 
            this.диспетчерЗадачToolStripMenuItem.Name = "диспетчерЗадачToolStripMenuItem";
            this.диспетчерЗадачToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.диспетчерЗадачToolStripMenuItem.Text = "Диспетчер задач";
            // 
            // btnFileManager
            // 
            this.btnFileManager.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFileManager.BackgroundImage")));
            this.btnFileManager.ContextMenuStrip = this.contextMenuStrip7;
            this.btnFileManager.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFileManager.Location = new System.Drawing.Point(11, 214);
            this.btnFileManager.Name = "btnFileManager";
            this.btnFileManager.Size = new System.Drawing.Size(35, 35);
            this.btnFileManager.TabIndex = 10;
            this.btnFileManager.UseVisualStyleBackColor = true;
            this.btnFileManager.Click += new System.EventHandler(this.button14_Click);
            // 
            // btnNotePad
            // 
            this.btnNotePad.Image = ((System.Drawing.Image)(resources.GetObject("btnNotePad.Image")));
            this.btnNotePad.Location = new System.Drawing.Point(11, 255);
            this.btnNotePad.Name = "btnNotePad";
            this.btnNotePad.Size = new System.Drawing.Size(35, 35);
            this.btnNotePad.TabIndex = 11;
            this.btnNotePad.UseVisualStyleBackColor = true;
            this.btnNotePad.Click += new System.EventHandler(this.btnNotePad_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 296);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(36, 35);
            this.btnBrowser.TabIndex = 12;
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnNotePad);
            this.Controls.Add(this.btnFileManager);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPhotoShop);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.panelTask);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.contextMenuStrip7.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.contextMenuStrip8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panelTask;
        private Button btnSTART;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem параметрыToolStripMenuItem;
        private ToolStripMenuItem выключениеToolStripMenuItem;
        private ToolStripMenuItem перезагрузкаToolStripMenuItem;
        private ToolStripMenuItem выключениеToolStripMenuItem1;
        private Button btnCalc;
        private Button btnpanelCalc;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openAdminToolStripMenuItem;
        private Button btnCMD;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private ContextMenuStrip contextMenuStrip5;
        private ContextMenuStrip contextMenuStrip6;
        private ToolStripMenuItem toolStripMenuItem5;
        private ToolStripMenuItem toolStripMenuItem6;
        private ContextMenuStrip contextMenuStrip7;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private Button btnpanelCMD;
        private Button btnpanelPhotoShop;
        private Button btnPhotoShop;
        private Button btnSettings;
        private Button btnSnap;
        private Button btnpanelSnap;
        private ContextMenuStrip contextMenuStrip8;
        private ToolStripMenuItem диспетчерЗадачToolStripMenuItem;
        private Button btnFileManager;
        private Button btnLook;
        private TextBox tbProgram;
        private Button btnNotePad;
        private Label lbDate;
        private Label lbTime;
        private Button btnBrowser;
    }
}