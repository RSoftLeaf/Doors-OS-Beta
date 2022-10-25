using System.Diagnostics;
using Windows_0;
using System;
using Updater;
using System.Media;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Windows_0.Properties;


namespace Windows_0
{
    public partial class Form1 : Form
    {
        #region VARIABLES

        char FullScreen = 'T';
        string program;
        public string PhotoShop { get; set; }
        public string CalcuLator { get; set; }
        public string SnapCamera { get; set; }
        public string TotalCMD { get; set; }
        SoundPlayer Error = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\Error\Windows-10-Error-Sound.wav");
        SoundPlayer WelcomeToDoors = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\Welcome\Welcome.wav");
        //SoundPlayer spAudio=new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\Power\w10PowerSound.wav");
        SoundPlayer spAudio = new SoundPlayer(@"C:\Shindaaaaa\SystemFiles.32\Audio\Power\w10PowerSound2.wav");
        System.Windows.Forms.Timer timer;
        System.Windows.Forms.Timer tmrStartMenuFocus;
        System.Windows.Forms.Timer tmrStartMenuFocudfs;
        public int panelStartLength { get; set; }
        public int panelButtonsLength { get; set; }
        public int panelTextSize { get; set; }
        public int[] panelUpLabelLocation { get; set; }
        bool whiled;
        System.Drawing.Size defPanelSize = new System.Drawing.Size(1929, 44);
        System.Drawing.Size smallPanelSize = new System.Drawing.Size(1929, 40);
        System.Drawing.Point defbtnLookLocation = new System.Drawing.Point(164, 12);
        System.Drawing.Point smallbtnLookLocation = new System.Drawing.Point(164, 10);
        System.Drawing.Size defbtnStartSize = new System.Drawing.Size(43, 44);
        System.Drawing.Size smallbtnStartSize = new System.Drawing.Size(35, 35);
        System.Drawing.Point defPanelTaskLocation = new System.Drawing.Point(-5, 1035);
        System.Drawing.Point smallPanelTaskLocation = new System.Drawing.Point(-5, 1044);
        StartMenu varStartMenu = new StartMenu();
        PowerForm powerForm;
        public int PowerProcents = 100;
        System.Windows.Forms.Timer PowerTimer = new System.Windows.Forms.Timer();
        public bool Power = false;
        public int screenWidth = Screen.PrimaryScreen.Bounds.Width;
        public int screenHeight = Screen.PrimaryScreen.Bounds.Height;
        public MyMethods myMethods = new MyMethods();
        public string langCode;
        int screenWidthBounds;
        int screenHeightBounds;
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));

        #endregion
        public Form1(bool play, bool Power)
        {
            InitializeComponent();
            PhotoShop = @"C:\Shindaaaaa\SystemFiles.32\Programs\Photoshop\Photoshop.exe";
            CalcuLator = @"C:\Shindaaaaa\SystemFiles.32\Programs\Calculator\Calculator\bin\Debug\net6.0-windows\Calculator.exe";
            SnapCamera = @"C:\Shindaaaaa\SystemFiles.32\Programs\Snap Camera\Snap Camera.exe";
            TotalCMD = @"C:\Shindaaaaa\SystemFiles.32\Programs\TotalCMD\Totalcmd64.exe";
            timer = new System.Windows.Forms.Timer();
            tmrStartMenuFocus = new System.Windows.Forms.Timer();
            screenHeightBounds = Screen.PrimaryScreen.Bounds.Height;
            screenWidthBounds = Screen.PrimaryScreen.Bounds.Width;
            if (play == true)
            {
                WelcomeToDoors.Play();
            }
            Initialize(true);
            Sync();
            if (Power)
            {
                powerForm = new PowerForm(this);
                PowerTimer.Start();
            }
        }
        #region NOTCODE

        /*
        #region LANGUAGES

            

            "00000419" Русский
            "00000422" Украинский
            "00000409" Английский (США)
            "00000407" Немецкий(стандартный)

           
            #endregion

            //if (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Control)
            switch (InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName)
            {
                case "ru":
                    langCode = "00000419";
                    break;
                case "uk":
                    langCode = "00000422";
                    break;
                case "en":
                    langCode = "00000409";
                    break;
                case "ge":
                    langCode = "00000407";
                    break;
            }
            if (e.KeyCode == Keys.C)
            {
                switch (langCode)
                {
                    case "00000419":
                        {
                            langCode = "00000422";
                            myMethods.ChangeLanguage();
                            break;
                        }
                    case "00000422":
                        {
                              langCode = "00000409";
                myMethods.ChangeLanguage();
                break;
}
                    case "00000409":
                        {
    langCode = "00000407";
    myMethods.ChangeLanguage();
    break;
}
                    case "00000407":
                        {
    langCode = "00000419";
    myMethods.ChangeLanguage();
    break;
}
                }
        #region LANGUAGES

            /*

            "00000419" Русский
            "00000422" Украинский
            "00000409" Английский (США)
            "00000407" Немецкий(стандартный)

           */
        //#endregion

        /*
        //if (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Control)
        MessageBox.Show(iso6391TwoLetterCode);
        switch (iso6391TwoLetterCode)
        {
            case "ru":
                langCode = "00000419";
                break;
            case "uk":
                langCode = "00000422";
                break;
            case "en":
                langCode = "00000409";
                break;
            case "de":
                langCode = "00000407";
                break;
        }
        MessageBox.Show("Начало: " + langCode);
        switch (langCode)
        {
            case "00000419":
                {
                    myMethods.ChangeLanguage(langCode);
                    langCode = "00000422";

                    break;
                }
            case "00000422":
                {
                    myMethods.ChangeLanguage(langCode);
                    langCode = "00000409";

                    break;
                }
            case "00000409":
                {
                    myMethods.ChangeLanguage(langCode);
                    langCode = "00000407";

                    break;
                }
            case "00000407":
                {
                    myMethods.ChangeLanguage(langCode);
                    langCode = "00000419";
                    break;
                }
        }
        MessageBox.Show("Конец: " + langCode);
        */
        //myMethods.ChangeLanguage();

        ///*

        #endregion

        private void PowerTimer_Tick(object sender, EventArgs e)
        {
            if (!Power)
            {
                if (customProgressBar1.Value > 0)
                {
                    customProgressBar1.Value--;
                    PowerProcents--;
                }
                if (PowerProcents == 0)
                {
                    Shutdown shutdown = new Shutdown("Гибернация (нет)");
                    shutdown.Show();
                    PowerTimer.Stop();
                }
                if (PowerProcents == 85)
                {
                    PowerWarning powerWarning = new PowerWarning(this);
                    powerWarning.Show();
                    powerWarning.Location = new System.Drawing.Point(this.Size.Width / 2 - powerWarning.Size.Width / 2, this.Size.Height / 2 - powerWarning.Size.Width / 2);
                    spAudio.Play();
                }
            }
            else
            {
                if (customProgressBar1.Value < 100)
                {
                    customProgressBar1.Value++;
                    PowerProcents++;
                }
            }
            //lb.Text = customProgressBar1.Value.ToString() + ", " + PowerProcents.ToString();

        }

        public void Initialize(bool panelBig)
        {
            #region EMPTY
            //-------------------------------------------------------------



            //-----------------------------------------------------------*/
            #endregion

            #region TASK PANEL
            //-------------------------------------------------------------

            switch (panelBig)
            {

                case true:
                    {
                        panelStartLength = 43; //Default == (Wigth == 43, Length == 45)
                        panelButtonsLength = 35; //Default == 35
                        panelTextSize = 11; //Default == 11
                        panelUpLabelLocation = new int[2];
                        panelUpLabelLocation[0] = 1766; // Default == (X == 1766, Y == 0)
                        panelUpLabelLocation[1] = 0;    // Default == (X == 1766, Y == 0)

                        btnpanelCalc.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelCMD.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelPhotoShop.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelSnap.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        lbTime.Font = new System.Drawing.Font("Segoe UI Black", panelTextSize, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point);
                        lbTime.Location = new System.Drawing.Point(panelUpLabelLocation[0], panelUpLabelLocation[1]);
                        btnLook.Location = defbtnLookLocation;
                        btnSTART.Size = defbtnStartSize;
                        panelTask.Size = defPanelSize;
                        panelTask.Location = defPanelTaskLocation;
                        break;
                    }
                case false:
                    {
                        panelStartLength = 40; //Default == (Wigth == 43, Length == 45)
                        panelButtonsLength = 30; //Default == 35
                        panelTextSize = 9; //Default == 11
                        panelUpLabelLocation = new int[2];
                        panelUpLabelLocation[0] = 1766; // Default == (X == 1766, Y == 0)
                        panelUpLabelLocation[1] = 0;    // Default == (X == 1766, Y == 0)

                        btnpanelCalc.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelCMD.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelPhotoShop.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        btnpanelSnap.Size = new System.Drawing.Size(panelButtonsLength, panelButtonsLength);
                        lbTime.Font = new System.Drawing.Font("Segoe UI Black", panelTextSize, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Regular))), System.Drawing.GraphicsUnit.Point);
                        lbTime.Location = new System.Drawing.Point(panelUpLabelLocation[0], panelUpLabelLocation[1]);
                        btnLook.Location = smallbtnLookLocation;
                        btnSTART.Size = smallbtnStartSize;
                        panelTask.Size = smallPanelSize;
                        panelTask.Location = smallPanelTaskLocation;
                        break;
                    }
            }

            //-----------------------------------------------------------*/
            #endregion

            #region TIMER INITIALIZE
            //-------------------------------------------------------------

            timer.Tick += Timer_Tick;
            tmrStartMenuFocus.Tick += TmrStartMenuFocus_Tick;
            tmrStartMenuFocus.Start();
            timer.Interval = 1000;
            tmrStartMenuFocus.Interval = 10;
            PowerTimer.Tick += PowerTimer_Tick;
            PowerTimer.Interval = 100;

            //-----------------------------------------------------------*/
            #endregion

            #region MAIN INITIALIZE
            //-------------------------------------------------------------

            #region Form1
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(screenHeightBounds, screenWidthBounds);
            this.Controls.Add(this.pnlShortcut);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnFileExplorer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnNotePad);
            this.Controls.Add(this.btnFileManager);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnPhotoShop);
            this.Controls.Add(this.btnCMD);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.panelTask);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTask.ResumeLayout(false);
            this.panelTask.PerformLayout();
            this.contextMenuStrip9.ResumeLayout(false);
            this.contextMenuStrip7.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.contextMenuStrip6.ResumeLayout(false);
            this.contextMenuStrip8.ResumeLayout(false);
            this.cmsTaskPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            #endregion

            #region LOCATIONS AND SIZES

            this.contextMenuStrip9.Size = new System.Drawing.Size(167, 48);
            this.диспетчерЗадачToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.выйтиToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.btnPanelSettings.Location = new System.Drawing.Point(379, 4);
            this.btnPanelSettings.Size = new System.Drawing.Size(35, 35);

            this.contextMenuStrip7.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Size = new System.Drawing.Size(142, 22);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Size = new System.Drawing.Size(142, 22);
            // 
            // tbProgram
            // 
            this.tbProgram.Location = new System.Drawing.Point(43, 0);
            this.tbProgram.Size = new System.Drawing.Size(100, 44);
            this.btnpanelCalc.Location = new System.Drawing.Point(221, 6);
            this.btnpanelCalc.Size = new System.Drawing.Size(32, 32);
            // 
            // btnSTART
            // 
            this.btnSTART.Location = new System.Drawing.Point(0, 0);
            this.btnSTART.Size = new System.Drawing.Size(43, 44);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 68);
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            // 
            // выключениеToolStripMenuItem
            // 
            this.выключениеToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            // 
            // перезагрузкаToolStripMenuItem
            // 
            this.перезагрузкаToolStripMenuItem.Size = new System.Drawing.Size(208, 32);
            // 
            // выключениеToolStripMenuItem1
            // 
            this.выключениеToolStripMenuItem1.Size = new System.Drawing.Size(208, 32);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(12, 12);
            this.btnCalc.Size = new System.Drawing.Size(35, 35);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Size = new System.Drawing.Size(143, 48);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            // 
            // openAdminToolStripMenuItem
            // 
            this.openAdminToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            // 
            // btnCMD
            // 
            this.btnCMD.Location = new System.Drawing.Point(12, 50);
            this.btnCMD.Size = new System.Drawing.Size(35, 35);
            // 
            // contextMenuStrip5
            // 
            this.contextMenuStrip5.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Size = new System.Drawing.Size(142, 22);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Size = new System.Drawing.Size(142, 22);
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Size = new System.Drawing.Size(142, 22);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Size = new System.Drawing.Size(142, 22);
            // 
            // contextMenuStrip6
            // 
            this.contextMenuStrip6.Size = new System.Drawing.Size(143, 48);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Size = new System.Drawing.Size(142, 22);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Size = new System.Drawing.Size(142, 22);
            // 
            // btnPhotoShop
            // 
            this.btnPhotoShop.Location = new System.Drawing.Point(12, 91);
            this.btnPhotoShop.Size = new System.Drawing.Size(35, 35);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 132);
            this.btnSettings.Size = new System.Drawing.Size(35, 35);
            // 
            // btnSnap
            // 
            this.btnSnap.Location = new System.Drawing.Point(12, 173);
            this.btnSnap.Size = new System.Drawing.Size(35, 35);
            // 
            // contextMenuStrip8
            // 
            this.contextMenuStrip8.Size = new System.Drawing.Size(167, 26);
            // 
            // диспетчерЗадачToolStripMenuItem
            // 
            this.диспетчерЗадачToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            // 
            // btnFileManager
            // 
            this.btnFileManager.Location = new System.Drawing.Point(11, 214);
            this.btnFileManager.Size = new System.Drawing.Size(35, 35);
            // 
            // btnNotePad
            // 
            this.btnNotePad.Location = new System.Drawing.Point(11, 255);
            this.btnNotePad.Size = new System.Drawing.Size(35, 35);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(12, 296);
            this.btnBrowser.Size = new System.Drawing.Size(36, 35);
            //
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 195);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(1220, 537);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 500);
            this.panel2.TabIndex = 14;
            this.panel2.Visible = false;
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.Location = new System.Drawing.Point(12, 337);
            this.btnFileExplorer.Size = new System.Drawing.Size(36, 35);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(492, 826);
            this.button1.Size = new System.Drawing.Size(75, 23);
            // 
            // cmsTaskPanel
            // 
            this.cmsTaskPanel.Size = new System.Drawing.Size(149, 54);
            // 
            // taskManagerToolStripMenuItem
            // 
            this.taskManagerToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Size = new System.Drawing.Size(145, 6);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(573, 826);
            this.button2.Size = new System.Drawing.Size(75, 23);
            // 
            // pnlShortcut
            // 
            this.pnlShortcut.Location = new System.Drawing.Point(13, 378);
            this.pnlShortcut.Size = new System.Drawing.Size(35, 35);
            //
            // this.This();
            //
            Size Sizepanel = new Size(40, 40);
            this.panelTask.Size = new Size(1920, 40);
            this.btnPanelSettings.Size = Sizepanel;
            this.btnpanelCalc.Size = Sizepanel;
            this.btnpanelPhotoShop.Size = Sizepanel;
            this.btnpanelCMD.Size = Sizepanel;
            #endregion

            //-----------------------------------------------------------*/
            #endregion
        }

        private void TmrStartMenuFocus_Tick(object sender, EventArgs e)
        {
            if (!varStartMenu.Focus())
            {
                varStartMenu.Close();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
            lbDate.Text = String.Format("{0:d2}.{1:d2}.{2:d4}", date.Day, date.Month, date.Year);
            //TmrAsync(date);
            lbTime.Text = String.Format("{0:d2}:{1:d2}:{2:d2}", date.Hour, date.Minute, date.Second);
            lbTime.Refresh();
        }
        async void TmrAsync(DateTime date)
        {
            for (int i = 0; i < 999; i++)
            {
                lbTime.Text = String.Format("{0:d2}:{1:d2}:{2:d2}.{3:d3}", date.Hour, date.Minute, date.Second, i);
                lbTime.Refresh();
            }
        }
        async void Sync()
        {
            DateTime dateTime;
            int Millisecond;
            while (true)
            {
                dateTime = DateTime.Now;
                Millisecond = dateTime.Millisecond;
                if (Millisecond == 0)
                {
                    timer.Start();
                    break;
                }
            }
            //await Task.Delay(1000 - Millisecond);
            //dateTime = DateTime.Now;
            //Millisecond = dateTime.Millisecond - 716;
        }
        private void выключениеToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Shutdown shutdown = new Shutdown("Выключение");
            shutdown.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            contextMenuStrip1.Show();
        }

        private void button5_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                Process.Start(CalcuLator);
            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{CalcuLator}. Не найден исполняемый файл");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (FullScreen)
            {
                case 'F':
                    FullScreen = 'T';
                    this.WindowState = FormWindowState.Maximized;
                    break;
                case 'T':
                    FullScreen = 'F';
                    this.WindowState = FormWindowState.Normal;
                    break;

            }


        }

        private void button6_Click(object sender, EventArgs e) /////////////////////////////////////////////------------------------------------------------//////////////////////////
        {
            try
            {
                Process.Start(CalcuLator);
            }
            catch
            {
                Error.Play();
                DialogResult resDialogMes = MessageBox.Show($"{CalcuLator}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                switch (resDialogMes)
                {
                    case DialogResult.Yes: btnpanelCalc.Dispose(); break;
                    case DialogResult.No: MessageBox.Show("OK"); break;
                }
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(CalcuLator);
            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{CalcuLator}. Не найден исполняемый файл");
            }
        }

        private async void openAdminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Admin admin = new Admin();
                admin.Show();
                await Task.Delay(1000);
                Process.Start(CalcuLator);

            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{CalcuLator}. Не найден исполняемый файл");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            try
            {
                Process.Start(TotalCMD);

            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл");
            }

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(TotalCMD);

            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл");
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(TotalCMD);

            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл");
            }
        }

        private async void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

            try
            {
                Admin admin = new Admin();
                admin.Show();
                await Task.Delay(1000);
                Process.Start(TotalCMD);

            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(TotalCMD);
            }
            catch
            {
                Error.Play();
                DialogResult resDialogMes = MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                switch (resDialogMes)
                {
                    case DialogResult.Yes: btnpanelCMD.Dispose(); break;
                    case DialogResult.No: MessageBox.Show("OK"); break;
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(PhotoShop);
            }
            catch
            {
                Error.Play();
                DialogResult resDialogMes = MessageBox.Show($"{PhotoShop}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                switch (resDialogMes)
                {
                    case DialogResult.Yes: btnpanelPhotoShop.Dispose(); break;
                    case DialogResult.No: MessageBox.Show("OK"); break;
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            settings settingsForm = new settings();
            settingsForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(PhotoShop);
            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{PhotoShop}. Не найден исполняемый файл");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SnapCamera);
            }
            catch
            {
                Error.Play();
                MessageBox.Show($"{SnapCamera} . Не найден исполняемый файл");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(SnapCamera);
            }
            catch
            {
                Error.Play();
                DialogResult resDialogMes = MessageBox.Show($"{SnapCamera}. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                switch (resDialogMes)
                {
                    case DialogResult.Yes: btnpanelSnap.Dispose(); break;
                    case DialogResult.No: MessageBox.Show("OK"); break;
                }
            }
        }

        private void параметрыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settings form = new settings();
            form.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Provodnik provod = new Provodnik();
            provod.Show();
        }

        private async void перезагрузкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown shutdown = new Shutdown("Перезагрузка");
            shutdown.Show();
        }

        private void btnSTART_MouseDown(object sender, MouseEventArgs e)
        {
            //Location = new Point(btnSTART.Location.X, btnSTART.Location.Y);
            //contextMenuStrip1.Show(panelTask.Location.X, panelTask.Location.Y - btnSTART.Height / 2);
        }
        private void btnLook_Click(object sender, EventArgs e)
        {
            program = tbProgram.Text;
            tbProgram.Text = "";
            switch (program)
            {
                case "snap camera":
                    {
                        try
                        {
                            Process.Start(SnapCamera);
                        }
                        catch
                        {
                            Error.Play();
                            DialogResult resDialogMes = MessageBox.Show($"{SnapCamera} . Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

                            switch (resDialogMes)
                            {
                                case DialogResult.Yes: btnpanelSnap.Dispose(); break;
                                case DialogResult.No: MessageBox.Show("OK"); break;
                            }
                        }
                        break;
                    }
                case "totalCMD":
                    {
                        try
                        {
                            Process.Start(TotalCMD);
                        }
                        catch
                        {
                            Error.Play();
                            DialogResult resDialogMes = MessageBox.Show($"{TotalCMD}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            switch (resDialogMes)
                            {
                                case DialogResult.Yes: btnpanelCMD.Dispose(); break;
                                case DialogResult.No: MessageBox.Show("OK"); break;
                            }
                        }
                        break;
                    }
                case "File Manager":
                    {
                        Provodnik provod = new Provodnik();
                        provod.Show();
                        break;
                    }
                case "Settings":
                    {
                        settings sets = new settings();
                        sets.Show();
                        break;
                    }
                case "Photoshop":
                    {
                        try
                        {
                            Process.Start(PhotoShop);
                        }
                        catch
                        {
                            Error.Play();
                            DialogResult resDialogMes = MessageBox.Show($"{PhotoShop}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            switch (resDialogMes)
                            {
                                case DialogResult.Yes: btnpanelPhotoShop.Dispose(); break;
                                case DialogResult.No: MessageBox.Show("OK"); break;
                            }
                        }
                        break;
                    }
                case "DateNow":
                    {
                        Kalendar kalnd = new Kalendar();
                        kalnd.Show();
                        break;
                    }
                case "Calculator":
                    {
                        try
                        {
                            Process.Start(CalcuLator);
                        }
                        catch
                        {
                            Error.Play();
                            DialogResult resDialogMes = MessageBox.Show($"{CalcuLator}. Не найден исполняемый файл. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                            switch (resDialogMes)
                            {
                                case DialogResult.Yes: btnpanelCalc.Dispose(); break;
                                case DialogResult.No: MessageBox.Show("OK"); break;
                            }
                        }
                        break;
                    }
                case "Updater":
                    {
                        UpdateShindos update = new UpdateShindos();
                        update.Show();
                        break;
                    }
                case "cmd":
                    {
                        CNS console = new CNS();
                        console.Show();
                        break;
                    }
                case "Panel Settings":
                    {
                        panelButtonsLength = 30; //Default == 35
                        TaskPanelSettings taskPanelSettings = new TaskPanelSettings(this);
                        taskPanelSettings.Show();
                        if (panelTask.Size == smallPanelSize)
                        {

                        }
                        else if (panelTask.Size == defPanelSize)
                        {

                        }
                        break;
                    }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1(false, false);
            main.Initialize(true);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1(false, false);
            main.Initialize(false);
        }

        private void btnNotePad_Click(object sender, EventArgs e)
        {

        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Avtorize av = new Avtorize();
            av.Show();
        }

        private void диспетчерЗадачToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TaskManager taskManager = new TaskManager();
            taskManager.Show();
        }

        private async void btnSTART_Click(object sender, EventArgs e)
        {
            myMethods.SetOpacity(new StartMenu(), new Point(panel1.Location.X, panel1.Location.Y + 100));
        }

        private void customProgressBar1_Click(object sender, EventArgs e)
        {
            //PowerForm powerfrm = new PowerForm(this);
            //powerfrm.Show();
            myMethods.SetOpacity(new PowerForm(this), new Point(panel2.Location.X, panel2.Location.Y));

        }

        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            Explorer fileExplorer = new Explorer(this);
            fileExplorer.Show();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            InputLanguage.CurrentInputLanguage = myMethods.defLang;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            myMethods.ChangeLanguage();
            lbLang.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName;
        }



        private void button1_Click_2(object sender, EventArgs e)
        {

            myMethods.ChangeLanguage();
            lbLang.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbLang.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
        }

        private void taskManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TaskManager tm = new TaskManager();
            tm.Show();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        public void ChangeLangLabel()
        {
            myMethods.ChangeLanguage();
            lbLang.Text = InputLanguage.CurrentInputLanguage.Culture.TwoLetterISOLanguageName.ToUpper();
            lbLang.Refresh();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            CreateButton createButton = new CreateButton(pnlShortcut.Location);
            createButton.Show();
        }

        private void btnPanelExplorer_Click(object sender, EventArgs e)
        {

        }

        private void btnPanelSettings_Click(object sender, EventArgs e)
        {

        }
    }
}