using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using Tetris;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using MENU;
using System.Threading;

namespace Tetris
{
    public partial class Tetris_OnePlayerGame : Form
    {
        #region Properties
        GameOnePlayer game;
        bool GameStart;

        Display Area;

        int TimeGame;

        bool PreventKeyRotation;

        private int count;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        #endregion
        public Tetris_OnePlayerGame(int[,] board, int score, Point []Nextbrick, Point []Brick, int NumberBrick, int NextNumberBrick)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitDislay();
            game = new GameOnePlayer(board, score, Nextbrick, Brick, NumberBrick, NextNumberBrick, 0, 50, 180, 10, Area);
        }
        public Tetris_OnePlayerGame()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            InitDislay();
            game = new GameOnePlayer(0, 50, 180, 10, Area);
            game.Reset();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //if (!SourceGame.LoadImage())
            //{
            //    MessageBox.Show("Can't load image ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    this.Close();
            //}   
            CountDown();
        }
        void CountDown()
        {
            timer.Stop();
            count = 0;
            CD.Start();
            ptbCD.Visible = true;
        }

        void StartGame()
        {
            GetLevel();
            game.GetScore += Game_GetScore;
            GameStart = true;
            this.Invalidate();
            timer.Interval = TimeGame;
            timer.Start();
        }
        void GetLevel()
        {
            switch (SourceGame.SelectedLevel)
            {
                case LevelGame.AUTO:
                    TimeGame = 500;
                    break;
                case LevelGame.EASY:
                    TimeGame = 500;
                    break;
                case LevelGame.MEDIUM:
                    TimeGame = 250;
                    break;
                case LevelGame.HARD:
                    TimeGame = 100;
                    break;
            }
        }

        private void Game_GetScore(object sender, EventArgs e)
        {
            if (SourceGame.SelectedLevel == LevelGame.AUTO && game.Score % 10 == 0)
                TimeGame = (int)(0.9 * TimeGame);
        }

        void InitDislay()
        {
            Area = new Display();
            Area.Location = new Point(15, 60);
            Area.Size = new Size(300, 480);
            Area.Paint += Area_Paint;
            this.Controls.Add(Area);
            Area.BackColor = Color.Transparent;
            Area.BringToFront();
            lbScore.Font = new Font(SourceGame.FontGame.Families[0], 16, FontStyle.Italic);
            lbScore.BringToFront();
            ptbCD.BringToFront();
        }

        void Play()
        {
            PreventKeyRotation = false;
            game.Reset();
            GameStart = true;
            this.Invalidate();
            timer.Start();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Area_Paint(object sender, PaintEventArgs e)
        {
            if (GameStart)
                game.Paint(e.Graphics);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Interval = TimeGame;
            game.UpdateGame();

            lbScore.Text = game.Score.ToString();

            Area.Invalidate();
            if (game.Lose)
            {
                timer.Stop();
                if (!SourceGame.isLogin)
                {
                    Name name = new Name(game.Score);
                    name.StartPosition = FormStartPosition.CenterParent;
                    name.ShowDialog();
                }
                else
                {
                    InsertScore();
                    LeaderBoard leader = new LeaderBoard();
                    leader.ShowDialog();
                }

                //Thread los = new Thread(() =>
                //{
                    Lose lose = new Lose();
                    lose.Restart += L4_Restart;
                    lose.Exit += L4_Exit;
                    lose.StartPosition = FormStartPosition.CenterParent;
                    lose.ShowDialog();
                //});
                //los.IsBackground = true;
                //los.Start();                
            }
        }

        void InsertScore()
        {
            string ConnectStr = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
            SqlConnection connection = new SqlConnection(ConnectStr);
            connection.Open();
            string query = "SET IDENTITY_INSERT Point ON; INSERT INTO Point(UserID, Point) VALUES (@UserID, @Point) ; SET IDENTITY_INSERT Point OFF; ";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@UserID", SourceGame.UserID);
                command.Parameters.AddWithValue("@Point", game.Score);

                command.ExecuteNonQuery();
            }
            connection.Close();

            
        }

        private void Tetris_OnePlayerGame_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show();
            if (!GameStart || game.Lose)
                return;

            game.isKeyPress = true;
            game.UpdateBoard(0);

            switch (e.KeyData)
            {
                case Keys.Left:
                    game.MoveLeft();
                    break;
                case Keys.Right:
                    game.MoveRight();
                    break;
                case Keys.Up:
                    if (!PreventKeyRotation)
                    {
                        game.Rotation();
                        PreventKeyRotation = true;
                    }
                    break;
                case Keys.Down:
                    if (!game.PreventKey)
                        timer.Interval = 10;
                    break;
            }
        }

        private void Tetris_OnePlayerGame_KeyUp(object sender, KeyEventArgs e)
        {
            game.isKeyPress = false;
            game.PreventKey = false;
            PreventKeyRotation = false;
        }
        private void Tetris_OnePlayer_Load_1(object sender, EventArgs e)
        {
            
            SourceGame.OnePlayerMusic.PlayLooping();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer.Stop();

            MainMenu l4 = new MainMenu(CD,timer, game.GetBoard(), game.getscore(), game.getBricknext(), game.getBrick(), game.BrickNumber, game.BrickNumberNext);
            l4.Restart += L4_Restart;
            l4.Exit += L4_Exit;
            l4.StartPosition = FormStartPosition.CenterParent;
            l4.ShowDialog();

            CountDown();
        }

        private void L4_Exit(object sender, EventArgs e)
        {
            SourceGame.OnePlayerMusic.Stop();
            this.Close();
        }
        private void L4_Restart(object sender, EventArgs e)
        {
            Play();
        }
        private void CD_Tick(object sender, EventArgs e)
        {
            ++count;
            if(count == 30)
            {
                CD.Stop();
                ptbCD.Visible = false;
                StartGame();
            }
            //MessageBox.Show(count.ToString());
            //ptbCD.Visible = true;
        }
    }
}
