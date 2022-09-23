namespace Windows_0
{
    partial class TaskManager
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.btnDriveMan = new System.Windows.Forms.Button();
            this.btnUpdater = new System.Windows.Forms.Button();
            this.btnTaskSet = new System.Windows.Forms.Button();
            this.Manager = new System.Windows.Forms.Button();
            this.btnDate = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.MainPanel.Controls.Add(this.btnTaskManager);
            this.MainPanel.Controls.Add(this.btnDriveMan);
            this.MainPanel.Controls.Add(this.btnUpdater);
            this.MainPanel.Controls.Add(this.btnTaskSet);
            this.MainPanel.Controls.Add(this.Manager);
            this.MainPanel.Controls.Add(this.btnDate);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(232, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnTaskManager.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskManager.ForeColor = System.Drawing.Color.White;
            this.btnTaskManager.Location = new System.Drawing.Point(0, 115);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(232, 23);
            this.btnTaskManager.TabIndex = 5;
            this.btnTaskManager.Text = "Task Manager";
            this.btnTaskManager.UseVisualStyleBackColor = false;
            // 
            // btnDriveMan
            // 
            this.btnDriveMan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnDriveMan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDriveMan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDriveMan.ForeColor = System.Drawing.Color.White;
            this.btnDriveMan.Location = new System.Drawing.Point(0, 92);
            this.btnDriveMan.Name = "btnDriveMan";
            this.btnDriveMan.Size = new System.Drawing.Size(232, 23);
            this.btnDriveMan.TabIndex = 4;
            this.btnDriveMan.Text = "DiskManager";
            this.btnDriveMan.UseVisualStyleBackColor = false;
            this.btnDriveMan.Click += new System.EventHandler(this.btnDriveMan_Click);
            // 
            // btnUpdater
            // 
            this.btnUpdater.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnUpdater.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdater.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdater.ForeColor = System.Drawing.Color.White;
            this.btnUpdater.Location = new System.Drawing.Point(0, 69);
            this.btnUpdater.Name = "btnUpdater";
            this.btnUpdater.Size = new System.Drawing.Size(232, 23);
            this.btnUpdater.TabIndex = 3;
            this.btnUpdater.Text = "Updater";
            this.btnUpdater.UseVisualStyleBackColor = false;
            this.btnUpdater.Click += new System.EventHandler(this.btnUpdater_Click);
            // 
            // btnTaskSet
            // 
            this.btnTaskSet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnTaskSet.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaskSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaskSet.ForeColor = System.Drawing.Color.White;
            this.btnTaskSet.Location = new System.Drawing.Point(0, 46);
            this.btnTaskSet.Name = "btnTaskSet";
            this.btnTaskSet.Size = new System.Drawing.Size(232, 23);
            this.btnTaskSet.TabIndex = 2;
            this.btnTaskSet.Text = "TaskSettings.exe";
            this.btnTaskSet.UseVisualStyleBackColor = false;
            this.btnTaskSet.Click += new System.EventHandler(this.btnTaskSet_Click);
            // 
            // Manager
            // 
            this.Manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.Manager.Dock = System.Windows.Forms.DockStyle.Top;
            this.Manager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Manager.ForeColor = System.Drawing.Color.White;
            this.Manager.Location = new System.Drawing.Point(0, 23);
            this.Manager.Name = "Manager";
            this.Manager.Size = new System.Drawing.Size(232, 23);
            this.Manager.TabIndex = 1;
            this.Manager.Text = "Проводник";
            this.Manager.UseVisualStyleBackColor = false;
            this.Manager.Click += new System.EventHandler(this.Manager_Click);
            // 
            // btnDate
            // 
            this.btnDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(70)))));
            this.btnDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDate.ForeColor = System.Drawing.Color.White;
            this.btnDate.Location = new System.Drawing.Point(0, 0);
            this.btnDate.Name = "btnDate";
            this.btnDate.Size = new System.Drawing.Size(232, 23);
            this.btnDate.TabIndex = 0;
            this.btnDate.Text = "Date.exe";
            this.btnDate.UseVisualStyleBackColor = false;
            this.btnDate.Click += new System.EventHandler(this.btnDate_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(238, 415);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "Завершить все";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnSyop_Click);
            // 
            // TaskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(342, 450);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.MainPanel);
            this.Name = "TaskManager";
            this.Text = "TaskManager";
            this.MainPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel MainPanel;
        private Button btnDriveMan;
        private Button btnUpdater;
        private Button btnTaskSet;
        private Button Manager;
        private Button btnDate;
        private Button btnStop;
        private Button btnTaskManager;
    }
}