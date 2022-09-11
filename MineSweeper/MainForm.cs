using System.Drawing.Text;
namespace MyMineSweeper
{
    public partial class MainForm : Form
    {
        //����������
        #region VARIABLES 

        //Panel
        Panel pnlMain;
        //X Y ������
        int DimX = 10;
        int DimY = 10;
        //��������� ������ ������
        Grid[,] Grids;
        //��������� ������
        int GridWidth = 50;
        int GridHeight = 50;
        int GridMargin = 0;
        //��������� ������
        int PanelWidth;
        int PanelHeaderHeight;
        int PanelMainHeight;
        const int PanelMinimumWidth = 500;
        //��������� ������� �����
        int FormWidth;
        int FormHeight;
        //�����
        int BombsCount = 11;
        //�����
        int FlagsCount = 0;
        //��������� ������
        int XLocationButton;
        int YLocationButton;
        int ShirinaButton = 80;
        int DlinaButton = 80;
        //�����
        bool isGame = false;
        bool Victoryis = false;
        //Timer
        System.Windows.Forms.Timer Timer1 = new System.Windows.Forms.Timer();
        int TimerTick = 0;
        PrivateFontCollection MyFonts = new PrivateFontCollection();

        #endregion
        //End ����������
        public MainForm() // ����������� �����
        {
            MyFonts.AddFontFile("Fonts/Quantico-Bold.ttf");
            InitializeComponent();
            Timer1.Tick += Timer1_Tick;
            CheckEn();
            tbWrite();
            InitializeComponents();
        }
        /*
         Random random = new Random();
         int rndm = random.Next(1);
                    if (rndm == 0)
                    {
                        btnSmile.Image = Properties.Resources.Bam;
                    }
                    else
                    {

                    }
        */
        /*
        for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {

                }
            }
        
         */
        void GridsReadOnly(){
            for (int i = 0; i < DimX; i++){
                for (int j = 0; j < DimY; j++){
                    Grids[i, j].MouseDown -= Grids_MouseDown;
                }
            }
        }
        void tbWrite(){
            tbX.Text = DimX.ToString();
            tbY.Text = DimY.ToString();
            tbBombs.Text = BombsCount.ToString();
        }
        void CheckEn()
        {
            if (isGame)
            {
                tbX.Enabled = false;
                tbY.Enabled = false;
                tbBombs.Enabled = false;
            }
            else
            {
                tbX.Enabled = true;
                tbY.Enabled = true;
                tbBombs.Enabled = true;
            }
        }
        public void InitGrids() //�������� ����
        {
            Grids = new Grid[DimX, DimY];
            for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {
                    Grids[i, j] = new Grid(GridWidth, GridHeight, (GridWidth + GridMargin) * i, (GridHeight + GridMargin) * j);
                    Grids[i, j].UseVisualStyleBackColor = true;
                    Grids[i, j].MouseDown += new MouseEventHandler(Grids_MouseDown);
                    pnlMain.Controls.Add(Grids[i, j]);
                }
            }
        }
        void StartNewGame() // ����� ����� ����
        {
            if (pnlMain != null)
                ClearGrids();
            
            InitializeComponents(); //����� ��� ������������� ������, ������� � �.�. � �.�
            InitGrids();            //����� ��� ������������� ������ ---- �������� ����
            SetBombs();             //����� ��� ��������� ���� �� ����
            SetStatus();            //����� ��� ����������� ���� � �������� ������� ������ ������
            tbWrite();
            lbTimer.Text = "0000";
            RadioBTNEnabled(false);
            //Timer
            #region TIMER INITIALIZE

            Timer1.Interval = 1000;
            Timer1.Enabled = true;

            #endregion
        }
        void SetBombs() //����� ��� ��������� ���� -- ������� ���� �� ����
        {
            Random random = new Random(); //Random ��� ����������� ���� ������� �����
            int Bombs = 0;
            while (Bombs != BombsCount)
            {
                int X = random.Next(DimX);
                int Y = random.Next(DimY);
                if (!Grids[X, Y].IsBomb)
                {
                    Grids[X, Y].IsBomb = true;
                    Bombs++;
                }
            }


        }
        void ShowBombs(bool Victory) //����� ��� ����������� ����
        {
            for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {
                    Grids[i, j].ShowBomb(Victory);
                }
            }
        }
        void ChangeButtonStatus(bool Start, bool Victory)
        {
            if (Start)
            {
                btnSmile.Image = Properties.Resources.Game;
            }
            else
            {
                if (Victory)
                {
                    Victoryis = true;
                    btnSmile.Image = Properties.Resources.Win;
                }
                else
                {
                    Victoryis = false;
                    btnSmile.Image = Properties.Resources.Lose;
                }

            }
        }
        void GameOver(bool Victory)//����� ��������� ����� ����
        {
            if (Victory)
            {
                ShowBombs(true);
                ChangeButtonStatus(false, true);
            }
            else
            {
                ShowBombs(false);
                ChangeButtonStatus(false, false);
            }
            isGame = false;
            Timer1.Stop();
            TimerTick = 0;
            //
            tbX.Enabled = true;
            tbY.Enabled = true;
            tbBombs.Enabled = true;
            GridsReadOnly();
            RadioBTNEnabled(true);
        }
        public void OpenAllZero()
        {
            bool ZeroFound = true;
            while (ZeroFound)
            {
                ZeroFound = false;
                for (int i = 0; i < DimX; i++)
                {
                    for (int j = 0; j < DimY; j++)
                    {
                        if (Grids[i, j].Status == 0 && Grids[i, j].IsOpen)
                        {
                            if (i != 0)
                                if (!Grids[i - 1, j].IsOpen)
                                    if (Grids[i - 1, j].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (i != 0 && j != 0)
                                if (!Grids[i - 1, j - 1].IsOpen)
                                    if (Grids[i - 1, j - 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (i != 0 && j != DimY - 1)
                                if (!Grids[i - 1, j + 1].IsOpen)
                                    if (Grids[i - 1, j + 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (j != 0)
                                if (!Grids[i, j - 1].IsOpen)
                                    if (Grids[i, j - 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (j != DimY - 1)
                                if (!Grids[i, j + 1].IsOpen)
                                    if (Grids[i, j + 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (i != DimX - 1 && j != 0)
                                if (!Grids[i + 1, j - 1].IsOpen)
                                    if (Grids[i + 1, j - 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (i != DimX - 1 && j != DimY - 1)
                                if (!Grids[i + 1, j + 1].IsOpen)
                                    if (Grids[i + 1, j + 1].OpenGrid() == 0)
                                        ZeroFound = true;

                            if (i != DimX - 1)
                                if (!Grids[i + 1, j].IsOpen)
                                    if (Grids[i + 1, j].OpenGrid() == 0)
                                        ZeroFound = true;

                        }
                    }
                }
            }
        }
        void InitializeComponents()//������������� ������, �������...
        {
            //������������� �������
            #region DIMENTIONS INITIALIZE
            // ==============================================================================================
            PanelHeaderHeight = 100;
            PanelMainHeight = (GridHeight + GridMargin) * DimY;
            PanelWidth = (GridWidth + GridMargin) * DimX;
            if (PanelWidth < PanelMinimumWidth)
            {
                PanelWidth = PanelMinimumWidth;
            }
            FormWidth = PanelWidth + 40;
            FormHeight = PanelMainHeight + PanelHeaderHeight + 100;
            this.Size = new System.Drawing.Size(FormWidth, FormHeight);
            // ============================================================================================*/
            #endregion

            //������������� Header ������
            #region HEADER PANEL INITIALIZE 
            // ==============================================================================================


            //PanelHeaderHeight = (GridHeight + GridMargin) * DimY;
            pnlHeader.Size = new System.Drawing.Size(PanelWidth, PanelHeaderHeight);
            this.lbTimer.Location = new System.Drawing.Point(PanelWidth - 210, 4);
            lbTimer.Font = new Font(MyFonts.Families[0], 51);

            // ============================================================================================*/
            #endregion

            //������������� �������� ������
            #region MAIN PANEL INITIALIZE 
            // ==============================================================================================

            pnlMain = new System.Windows.Forms.Panel();
            pnlMain.BackColor = System.Drawing.Color.White;
            pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            pnlMain.Location = new System.Drawing.Point(12, 119);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new System.Drawing.Size(PanelWidth, PanelMainHeight);
            pnlMain.TabIndex = 1;
            Controls.Add(this.pnlMain);

            // ============================================================================================*/
            #endregion

            //������������� �������-������
            #region SMILE INITIALIZE
            // ==============================================================================================

            XLocationButton = PanelWidth / 2 - ShirinaButton / 2;
            YLocationButton = 10;
            btnSmile.Size = new System.Drawing.Size(ShirinaButton, DlinaButton);
            btnSmile.Location = new System.Drawing.Point(XLocationButton, YLocationButton);
            btnSmile.Click += new EventHandler(btnSmile_Game);

            // ============================================================================================*/
            #endregion

            //������������� ������ (����� ���� ������� �� ������ � -- ������)
            #region INITIALIZE BUTTONS



            #endregion

        }
        private void Timer1_Tick(object? sender, EventArgs e)
        {
            TimerTick++;
            lbTimer.Text = String.Format("{0:d4}", TimerTick);
        }
        public void SetStatus() //����� ��� ��������� ����-�� ���� � �������� ������� ������ ������
        {

            for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {
                    int Bombs = 0;
                    if (i != 0)
                        if (Grids[i - 1, j].IsBomb) Bombs++;
                    if (i != 0 && j != 0)
                        if (Grids[i - 1, j - 1].IsBomb) Bombs++;
                    if (i != 0 && j != DimY - 1)
                        if (Grids[i - 1, j + 1].IsBomb) Bombs++;
                    if (j != 0)
                        if (Grids[i, j - 1].IsBomb) Bombs++;
                    if (j != DimY - 1)
                        if (Grids[i, j + 1].IsBomb) Bombs++;
                    if (i != DimX - 1 && j != 0)
                        if (Grids[i + 1, j - 1].IsBomb) Bombs++;
                    if (i != DimX - 1 && j != DimY - 1)
                        if (Grids[i + 1, j + 1].IsBomb) Bombs++;
                    if (i != DimX - 1)
                        if (Grids[i + 1, j].IsBomb) Bombs++;



                    //�����
                    if (Grids[i, j].IsBomb)
                    {
                        Grids[i, j].Status = 10;
                    }
                    else
                    {
                        Grids[i, j].Status = Bombs;
                    }
                }
            }

        }
        private void Grids_MouseDown(object sender, MouseEventArgs e) //�������� ����� �������� ������ (�������� ����� ������� MOUSE1 ��� MOUSE2 + ��� ��� ������ ������)
        {
            Grid button = sender as Grid;
            if (e.Button == MouseButtons.Left) //MOUSE1
            {
                int x = button.OpenGrid();
                if (x == 10)
                {
                    GameOver(false);
                }
                else if (x == 0)
                {
                    OpenAllZero();
                    CheckWin();
                }
                else
                {
                    CheckWin();
                }
            }
            if (e.Button == MouseButtons.Right) //MOUSE2
            {
                button.SetFlag();
            }
        }
        void ClearGrids() //����� ������� ����
        {
            /*/
            for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {
                    Grids[i, j].Dispose();
                }
            }
            //   */
            pnlMain.Dispose();
        }
        public void CheckWin()//����� �������� ��������
        {
            bool isVictory = true;
            for (int i = 0; i < DimX; i++)
            {
                for (int j = 0; j < DimY; j++)
                {
                    if (!Grids[i, j].IsOpen && !Grids[i, j].IsBomb)
                    {
                        isVictory = false;
                    }
                }
            }
            if (isVictory)
            {
                GameOver(true);
            }
        }
        private void btnSmile_Game(object sender, EventArgs e) //����� ��� ������� �� �������
        {
            if (!isGame)
            {
                isGame = true;
                StartNewGame();
                ChangeButtonStatus(true, false);
            }
            CheckEn();
        }
        private void tbX_TextChanged(object sender, EventArgs e)
        {
            int DimXTemp = int.Parse(tbX.Text);
            if (BombsCount < DimXTemp * DimY && DimXTemp >= 10)
            {
                DimX = DimXTemp;
            }
            else
            {
                tbX.Text = DimX.ToString();
            }
        }
        private void tbY_TextChanged(object sender, EventArgs e)
        { 
            int DimYTemp = int.Parse(tbY.Text);
            if (BombsCount < DimX * DimYTemp && DimYTemp >= 10)
            {
                DimY = DimYTemp;
            }
            else
            {
                tbY.Text = DimY.ToString();
            }
        }
        private void tbBombs_TextChanged(object sender, EventArgs e)
        {
            int DimBombsTemp = int.Parse(tbBombs.Text);
            if (DimBombsTemp < DimX * DimY)
            {
                BombsCount = DimBombsTemp;
            }
            else
            {
                tbBombs.Text = BombsCount.ToString();
            }
        }
        void RadioBTNEnabled(bool En)
        {
            rbEasy.Enabled = En;
            rbMedium.Enabled = En;
            rbExpert.Enabled = En;
            rbCustom.Enabled = En;
        }
        void ChangeVisibility(bool Visible, int X, int Y, int B)
        {
            tbBombs.Visible = Visible;
            tbX.Visible = Visible;
            tbY.Visible = Visible;
            xlb.Visible = Visible;
            ylb.Visible = Visible;
            bmbslb.Visible = Visible;
            DimX = X;
            DimY = Y;
            BombsCount = B;
            tbX.Text = DimX.ToString();
            tbY.Text = DimY.ToString();
            tbBombs.Text = BombsCount.ToString();
        }
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibility(false, 10, 10, 11);
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibility(false, 16, 16, 40);
        }
        private void rbExpert_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibility(false, 30, 16, 99);
        }
        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            ChangeVisibility(true, DimX, DimY, BombsCount);
        }
    }
}