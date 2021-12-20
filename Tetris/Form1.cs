using System;
using System.Windows.Forms;
using System.Threading;
using Tetris;
using System.Drawing;

namespace MENU
{
    public partial class Form1 : Form
    {

        int[,] Board = new int[Game.HEIGHT, Game.WIDTH];
        int score;
        Point[] Brick = new Point[4];
        Point[] NextBrick = new Point[4];
        int NumberBrick;
        int NextNumberBrick;
        int flag;
        bool First = true;
        public void SplashStart()
        {
            Application.Run(new SplashScreen());

        }
        public static WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(5500);
            InitializeComponent();
            t.Abort();

            //wplayer.URL = @"D:\OOP\MenuGame\Resources\tetris-gameboy-01.wav";
            //wplayer.controls.play();
            //axWindowsMediaPlayer1.Hide();
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = Application.StartupPath + "\\Resources\\tetris-gameboy-01.wav";
            //sp.PlayLooping();
            //axWindowsMediaPlayer1.Hide();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Activate();
            LoadGame();

            if (SourceGame.isLogin)
                lbName.Text = SourceGame.UserName;
            else lbName.Text = "";
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = Application.StartupPath + @".\tetris-gameboy-01.wav";
            //sp.PlayLooping();


        }
        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.Play3;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.Play1;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Tetris.Properties.Resources.Leaderboard2;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Tetris.Properties.Resources.Leaderboard1;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Tetris.Properties.Resources.Exit2;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Tetris.Properties.Resources.Exit1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            LeaderBoard l2 = new LeaderBoard();
            l2.ShowDialog();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Mode l3 = new Mode();
            l3.StartPosition = FormStartPosition.CenterParent;
            l3.ShowDialog();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            SourceGame.MainMenuMusic.Stop();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = Application.StartupPath + "\\Resources\\tetris-gameboy-01.wav";
            //sp.PlayLooping();
            SourceGame.MainMenuMusic.Stop();
            SourceGame.isMusicMainMenuOn = false;
            pictureBox7.Visible = true;
            pictureBox8.Visible = false;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //SoundPlayer sp = new SoundPlayer();
            //sp.SoundLocation = Application.StartupPath + "\\Resources\\tetris-gameboy-01.wav";
            SourceGame.MainMenuMusic.PlayLooping();
            SourceGame.isMusicMainMenuOn = true;
            pictureBox7.Visible = false;
            pictureBox8.Visible = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
            if (!SourceGame.CheckSource())
            {
                MessageBox.Show("Can't load source game", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            SourceGame.MainMenuMusic.PlayLooping();
            lbName.Font = new Font(SourceGame.FontGame.Families[0], 20, FontStyle.Italic);
        }

        private void Option_Click(object sender, EventArgs e)
        {
            Option option = new Option();
            option.ShowDialog();
        }
        public static System.Media.SoundPlayer sound = new System.Media.SoundPlayer();

        private void Option_MouseHover(object sender, EventArgs e)
        {
            Option.Image = Tetris.Properties.Resources.OPTIONaf;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void Option_MouseLeave(object sender, EventArgs e)
        {
            Option.Image = Tetris.Properties.Resources.OPTION;
        }

        private void Continue_Click(object sender, EventArgs e)
        {
            if (SourceGame.isSavedGame)
                LoadGame();        
            Thread playgame = new Thread(() =>
            {
                Tetris_OnePlayerGame t = new Tetris_OnePlayerGame(Board, score, NextBrick, Brick, NumberBrick,NextNumberBrick );
                t.StartPosition = FormStartPosition.CenterParent;
                t.ShowDialog();
            });
            playgame.IsBackground = true;
            playgame.Start();
        }

        private void ptbNoContinue_Click(object sender, EventArgs e)
        {

        }
        void LoadGame()
        {
            
            int k = 1;

            string[] Lines = System.IO.File.ReadAllLines(Application.StartupPath + "\\Save\\FileSave.txt");

            flag = Convert.ToInt32(Lines[0]);
            First = false;

            if (flag == 0)
            {
                return;
            }
            else
            {
                SourceGame.isSavedGame = false;
                ptbNoContinue.Visible = false;
                Continue.Visible = true;
            }


            for (int i = 0; i < Game.HEIGHT; i++)
            {
                for (int j = 0; j < Game.WIDTH; j++)
                {
                    Board[i, j] = Convert.ToInt32(Lines[i+1][j]) - 48;
                }
            }
            k = Game.HEIGHT + 1;
            score = Convert.ToInt32(Lines[k]);
            for (int i = 0; i < 4; i++)
            {
                Brick[i].X = Convert.ToInt32(Lines[++k]);
                Brick[i].Y = Convert.ToInt32(Lines[++k]);
            }
            //MessageBox.Show("" + Brick[1].X + " " + Brick[1].Y);
            for (int i = 0; i < 4; i++)
            {
                NextBrick[i].X = Convert.ToInt32(Lines[++k]);
                NextBrick[i].Y = Convert.ToInt32(Lines[++k]);
            }

            int level = Convert.ToInt32(Lines[++k]);
            switch (level)
            {
                case 0: SourceGame.SelectedLevel = LevelGame.AUTO; break;
                case 1: SourceGame.SelectedLevel = LevelGame.EASY; break;
                case 2: SourceGame.SelectedLevel = LevelGame.MEDIUM; break;
                case 3: SourceGame.SelectedLevel = LevelGame.HARD; break;
                default:
                    break;
            }
            NumberBrick = Convert.ToInt32(Lines[++k]);
            NextNumberBrick = Convert.ToInt32(Lines[++k]);
            
        }

        private void Continue_MouseHover(object sender, EventArgs e)
        {
            Continue.Image = Tetris.Properties.Resources.COUNTINUEdaf; 
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void Continue_MouseLeave(object sender, EventArgs e)
        {
            Continue.Image = Tetris.Properties.Resources.COUNTINUEnm;
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Form1.wplayer.settings.volume == 0 || !SourceGame.isMusicMainMenuOn)
            {
                pictureBox7.Visible = true;
                pictureBox8.Visible = false;
            }
            else if (SourceGame.isMusicMainMenuOn)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
            }

            if (First)
                return;
            if (SourceGame.isSavedGame)
            {
                ptbNoContinue.Visible = false;
                Continue.Visible = true;
            }
            else
            {
                ptbNoContinue.Visible = true;
                Continue.Visible = false;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SourceGame.MainMenuMusic.Stop();
        }
    }
}
