using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Tetris_PlayerVsPCGame : Form
    {
        #region Properties
        PlayerVsPC game1;
        TetrisAI game2;

        bool GameStart;
        bool PreventKeyRotation;

        Display Area1;
        Display Area2;
        int TimeGamePlayer, TimeGamePC;

        private int count;

        #endregion

        #region Method
        public Tetris_PlayerVsPCGame()
        {
            InitializeComponent();
            InitDislay();

            game1 = new PlayerVsPC(0, 0, 200, 140, Area1);
            game2 = new TetrisAI(400, 0, 200, 110, Area2);

            GameStart = false;

            game1.GetScore += Game1_GetScore;
            game2.GetScore += Game2_GetScore;
            game2.RunAI += Game2_RunAI;
        }

        private void Game2_GetScore(object sender, EventArgs e)
        {
            lbScorePC.Text = game2.Score.ToString();
            if (game1.Lose && game1.Score < game2.Score)
            {
                timer2.Stop();
                MessageBox.Show("YOU LOSE!!!");
                //Do something

            }
        }

        private void Game1_GetScore(object sender, EventArgs e)
        {
            if (game1.Score % 10 == 0)
                TimeGamePlayer = (int)(0.9 * TimeGamePlayer);
            lbScorePlayer.Text = game1.Score.ToString();
            if (game2.Lose && game1.Score > game2.Score)
            {
                timer1.Stop();
                MessageBox.Show("YOU WIN!!!");
                //Do something
            }
        }

        void InitDislay()
        {
            Area1 = new Display();
            Area1.Location = new Point(45, 50);
            Area1.Size = new Size(380, 480);
            Area1.Paint += Area1_Paint;
            this.Controls.Add(Area1);
            Area1.BackColor = Color.Transparent;
            Area1.BringToFront();
            lbScorePlayer.Font = new Font(SourceGame.FontGame.Families[0], 16, FontStyle.Italic);
            lbScorePlayer.BringToFront();
            pictureBox1.BringToFront();

            ptbCD.BringToFront();

            Area2 = new Display();
            Area2.Location = new Point(550, 50);
            Area2.Size = new Size(380, 480);
            Area2.Paint += Area2_Paint;
            this.Controls.Add(Area2);
            Area2.BackColor = Color.Transparent;
            Area2.BringToFront();
            lbScorePC.BringToFront();
            lbScorePC.Font = new Font(SourceGame.FontGame.Families[0], 16, FontStyle.Italic);
            pictureBox2.BringToFront();

            ptbCD.BringToFront();
        }

        private void Area2_Paint(object sender, PaintEventArgs e)
        {
            if (GameStart)
                game2.Paint(e.Graphics);
            if (game1.Lose && game2.Lose)
                GameStart = false;
        }

        private void Area1_Paint(object sender, PaintEventArgs e)
        {
            if (GameStart)
                game1.Paint(e.Graphics);
            if (game1.Lose && game2.Lose)
                GameStart = false;
        }

        void CheckWinLose(bool isPlayerLose)
        {
            if (!isPlayerLose && game1.Score > game2.Score)
            {
                timer1.Stop();
                MessageBox.Show("YOU WIN!!!");
                //Do something
            }
            else if (isPlayerLose && game1.Score < game2.Score)
            {
                timer2.Stop();
                MessageBox.Show("YOU LOSE!!!");
                //Do something
            }
            else if (game1.Lose && game2.Lose && game1.Score == game2.Score)
            {
                if (isPlayerLose)
                {
                    timer1.Stop();
                    MessageBox.Show("YOU WIN!!!");
                    //Do something
                }
                else
                {
                    timer2.Stop();
                    MessageBox.Show("YOU LOSE!!!");
                    //Do something
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = TimeGamePlayer;
            game1.UpdateGame();

            Area1.Invalidate();
            if (game1.Lose)
            {
                timer1.Stop();
                CheckWinLose(true);
            }
        }

        bool run = false;
        private void Game2_RunAI(object sender, EventArgs e)
        {

            game2.AdjustA();
            run = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!run)
                return;

            game2.UpdateBoard(0);
            if (game2.AIMoveDown())
            {
                game2.UpdateBoard(game2.BrickNumber);
                Area2.Invalidate();
            }
            else
            {
                run = false;
                game2.CreateNewBrick();
            }
            if (game2.Lose)
            {
                timer2.Stop();
                CheckWinLose(false);
            }
        }

        void StartGame() //Nếu muốn bắt đầu trò chơi thì gọi hàm này
        {
            Area1.Invalidate();
            Area2.Invalidate();

            GameStart = true;
            game1.Reset();

            PreventKeyRotation = false;
            TimeGamePlayer = 500;
            TimeGamePC = 40;
            timer2.Interval = TimeGamePC;
            game2.Reset();

            timer1.Start();
            timer2.Start();
        }

        private void Tetris_PlayerVsPCGame_KeyDown(object sender, KeyEventArgs e)
        {

            if (!GameStart || game1.Lose)
                return;

            game1.isKeyPress = true;
            game1.UpdateBoard(0);

            switch (e.KeyData)
            {
                case Keys.Left:
                    game1.MoveLeft();
                    break;
                case Keys.Right:
                    game1.MoveRight();
                    e.Handled = true;
                    break;
                case Keys.Up:
                    if (!PreventKeyRotation)
                    {
                        game1.Rotation();
                        PreventKeyRotation = true;
                    }
                    break;
                case Keys.Down:
                    if (!game1.PreventKey)
                        timer1.Interval = 10;
                    break;
            }
        }

        private void Tetris_PlayerVsPCGame_KeyUp(object sender, KeyEventArgs e)
        {
            game1.isKeyPress = false;
            game1.PreventKey = false;
            PreventKeyRotation = false;
        }

        private void Tetris_PlayerVsPCGame_Load(object sender, EventArgs e)
        {
            SourceGame.AlMusic.PlayLooping();
        }
        void CountDown()
        {
            timer1.Stop();
            timer2.Stop();
            count = 0;
            CD.Start();
            ptbCD.Visible = true;
        }

        private void CD_Tick(object sender, EventArgs e)
        {
            ++count;
            if(count==30)
            {
                CD.Stop();
                ptbCD.Visible = false;
                StartGame();
            }
        }

        private void Tetris_PlayerVsPCGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            SourceGame.AlMusic.Stop();
            if (SourceGame.isMusicMainMenuOn)
                SourceGame.MainMenuMusic.PlayLooping();
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            count = 0;
            timer1.Stop();
            timer2.Stop();
            ptbCD.Visible = true;
            CD.Start();
        }

        private void Tetris_PlayerVsPCGame_Shown(object sender, EventArgs e)
        {
            CountDown();
            //StartGame();
        }
        #endregion
    }
}