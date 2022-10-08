using System.Diagnostics;
using Windows_0;
using System;
using Updater;
using System.Media;
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
               

        #endregion
        public Form1(bool play)
        {
            InitializeComponent();
            PhotoShop = @"C:\Shindaaaaa\SystemFiles.32\Programs\Photoshop\Photoshop.exe";
            CalcuLator = @"C:\Shindaaaaa\SystemFiles.32\Programs\Calculator\Calculator\bin\Debug\net6.0-windows\Calculator.exe";
            SnapCamera = @"C:\Shindaaaaa\SystemFiles.32\Programs\Snap Camera\Snap Camera.exe";
            TotalCMD = @"C:\Shindaaaaa\SystemFiles.32\Programs\TotalCMD\Totalcmd64.exe";
            timer = new System.Windows.Forms.Timer();
            tmrStartMenuFocus = new System.Windows.Forms.Timer();
            if (play == true)
            {
                WelcomeToDoors.Play();
            }
            Initialize(true);
            Sync();
            powerForm = new PowerForm(this);
        }

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
            label1.Text = customProgressBar1.Value.ToString() + ", " + PowerProcents.ToString();
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
            PowerTimer.Start();
            PowerTimer.Interval = 1000;

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
                    case DialogResult.Yes:  btnpanelCalc.Dispose(); break;
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
                DialogResult resDialogMes =  MessageBox.Show($"{SnapCamera}. Вы хотите удалить ярлык?", "Не найден ярлык", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);

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
            Form1 main = new Form1(false);
            main.Initialize(true);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form1 main = new Form1(false);
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

    }
}