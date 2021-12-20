using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris;

namespace Tetris
{
    public partial class MainMenu : Form
    {
        Timer t;
        Timer CD;
        int[,] board;
        int score;
        Point []nextbrick;
        Point[] brick;
        int NumberBrick;
        int NextNumberBrick;
        public MainMenu(Timer CD,Timer t, int [,] board, int score, Point[] nextbrick,Point[] brick, int NumberBrick, int NextNumberBrick)
        {
            InitializeComponent();
            this.CD = CD;
            this.t = t;
            this.board = board;
            this.score = score;
            this.nextbrick = nextbrick;
            this.brick = brick;
            this.NumberBrick = NumberBrick;
            this.NextNumberBrick = NextNumberBrick;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            t.Start();
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if(restart != null)
                restart(this, new EventArgs());
            this.Close();
        }

        private event EventHandler restart;
        public event EventHandler Restart
        {
            add
            {
                restart += value;
            }
            remove
            {
                restart -= value;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            SourceGame.OnePlayerMusic.Stop();
            pictureBox8.Visible = true;
            pictureBox7.Visible = false;
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            SourceGame.OnePlayerMusic.PlayLooping();
            pictureBox8.Visible = false;
            pictureBox7.Visible = true;
        }

        private event EventHandler exit;
        public event EventHandler Exit
        {
            add
            {
                exit += value;
            }
            remove
            {
                exit -= value;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            SaveForm sf = new SaveForm(board, score, nextbrick, brick, NumberBrick, NextNumberBrick);
            sf.StartPosition = FormStartPosition.CenterParent;
            sf.ShowDialog();
            if (exit != null)
               exit(this, new EventArgs());
            if (SourceGame.isMusicMainMenuOn)
                SourceGame.MainMenuMusic.PlayLooping();
            this.Close();
            
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.RESUMEaf;
            //SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.RESUME1;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Tetris.Properties.Resources.RESTART1;
        }
        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Tetris.Properties.Resources.QUITAF;
            //SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Tetris.Properties.Resources.QUIT1;
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pictureBox5.Image = Tetris.Properties.Resources.RESTARTAF;
            //SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }
    }
}
