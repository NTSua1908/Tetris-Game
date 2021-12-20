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
using System.IO;
using System.Runtime.InteropServices;

namespace Tetris
{
    public partial class SaveForm : Form
    {
        int[,] board;
        int score;
        Point[] nextbrick;
        Point[] brick;
        int NumberBrick;
        int NextNumberBrick;
        public SaveForm(int [,] board, int score, Point [] nextbrick, Point[] brick, int NumberBrick, int NextNumberBrick) 
        {
            InitializeComponent();
            //this.FormBorderStyle = FormBorderStyle.None;
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.board = board;
            this.score = score;
            this.nextbrick = nextbrick;
            this.brick = brick;
            this.NumberBrick = NumberBrick;
            this.NextNumberBrick = NextNumberBrick;
        }

        //[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        //private static extern IntPtr CreateRoundRectRgn
        //(
        //    int nLeftRect,     // x-coordinate of upper-left corner
        //    int nTopRect,      // y-coordinate of upper-left corner
        //    int nRightRect,    // x-coordinate of lower-right corner
        //    int nBottomRect,   // y-coordinate of lower-right corner
        //    int nWidthEllipse, // height of ellipse
        //    int nHeightEllipse // width of ellipse
        //);
        private void ptbYes_MouseHover(object sender, EventArgs e)
        {
            ptbYes.Image = Tetris.Properties.Resources.Yesaf;
           // SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void ptbYes_MouseLeave(object sender, EventArgs e)
        {
            ptbYes.Image = Tetris.Properties.Resources.yes;
        }

        private void ptbNo_MouseHover(object sender, EventArgs e)
        {
            ptbNo.Image = Tetris.Properties.Resources.Noaf;
           // SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void ptbNo_MouseLeave(object sender, EventArgs e)
        {
            ptbNo.Image = Tetris.Properties.Resources.no;
        }

        private void ptbYes_Click(object sender, EventArgs e)
        {
            SaveGame();
            SourceGame.isSavedGame = true;
            this.Close();
        }
        public void SaveGame()
        {
            try
            {
                using (System.IO.StreamWriter write =
                new System.IO.StreamWriter(Application.StartupPath + "\\Save\\FileSave.txt"))
                {
                    write.WriteLine("1");
                    for (int i = 0; i < Game.HEIGHT; i++)
                    {
                        for (int j = 0; j < Game.WIDTH; j++)
                        {
                            write.Write(board[i, j]);
                        }
                        write.WriteLine();
                    }
                    write.WriteLine(score);
                    for (int i = 0; i < 4; i++)
                    {
                        write.WriteLine(brick[i].X);
                        write.WriteLine(brick[i].Y);
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        write.WriteLine(nextbrick[i].X);
                        write.WriteLine(nextbrick[i].Y);
                    }
                    switch (SourceGame.SelectedLevel)
                    {
                        case LevelGame.AUTO: write.WriteLine(0);
                            break;
                        case LevelGame.EASY:write.WriteLine(1);
                            break;
                        case LevelGame.MEDIUM:write.WriteLine(2);
                            break;
                        case LevelGame.HARD:write.WriteLine(3);
                            break;
                        default:
                            break;
                    }
                    write.WriteLine(NumberBrick);
                    write.WriteLine(NextNumberBrick);
                }
            }
            catch
            {
                MessageBox.Show("Save Error!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ptbNo_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter write =
                new System.IO.StreamWriter(Application.StartupPath + "\\Save\\FileSave.txt"))
            {
                write.WriteLine("0");
            }
            SourceGame.isSavedGame = false;
            this.Close();
        }
    }
}
