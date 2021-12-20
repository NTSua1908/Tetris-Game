using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Tetris
{
    public class Game
    {
        #region Properties
        protected Point Location;
        protected Point LocationNextBrick;

        protected Point[] a, b, c;

        protected bool rotation;
        public int Score;

        public static int HEIGHT = 22;
        public static int WIDTH = 10;

        protected int[,] board;

        public bool Lose;
        public bool PreventKey = false;
        public bool isKeyPress = false;

        protected int[,] brick;
        public int BrickNumber = -1;
        public int BrickNumberNext = -1;
        static protected Random random = new Random();

        //protected Image[] img;
        //protected Brush[] brush;

        protected Display form;

        #endregion

        #region Method
        public Game(int x, int y, int x1, int y1, Display form)
        {
            Location.X = x;
            Location.Y = y;
            LocationNextBrick.X = x1;
            LocationNextBrick.Y = y1;

            this.form = form;

            init();
        }

        private event EventHandler newBoard;
        public event EventHandler NewBoard
        {
            add
            {
                newBoard += value;
            }
            remove
            {
                newBoard -= value;
            }
        }

        public int[,] GetBoard()
        {
            return board;
        }
        public int getscore()
        {
            return Score;
        }
        public Point[] getBricknext()
        {
            return c;
        }
        public Point[] getBrick()
        {
            return a;
        }

        protected void NewBoardEvent()
        {
            if (newBoard != null)
                newBoard(this, new EventArgs());
        }

        protected void init()
        {
            rotation = true;
            //brush = new Brush[7] { Brushes.Red, Brushes.Yellow, Brushes.Black, Brushes.Blue, Brushes.Orange, Brushes.Red, Brushes.Green };

            brick = new int[,]
            {
                { 1,3,5,7 }, // I
                { 2,4,5,7 }, // Z
                { 3,5,4,6 }, // S
                { 3,5,4,7 }, // T
                { 2,3,5,7 }, // L
                { 3,5,7,6 }, // J
                { 2,3,4,5 }, // O }
            };



            //img = new Image[8];

        }

        protected void CopyBtoA()
        {
            for (int i = 0; i < 4; i++)
            {
                a[i] = b[i];
            }
        }

        protected void CopyAtoB()
        {
            for (int i = 0; i < 4; i++)
            {
                b[i] = a[i];
            }
        }

        public void MoveLeft()
        {
            for (int i = 0; i < 4; i++)
            {
                a[i].X--;
            }
            if (!check())
            {
                CopyBtoA();
            }
            else
            {
                CopyAtoB();
                UpdateBoard(BrickNumber);
                NewBoardEvent();
                //form.Invalidate(new Rectangle(Location.X, Location.Y, 200, 300));
                form.Invalidate();
            }
        }

        public void MoveRight()
        {
            for (int i = 0; i < 4; i++)
            {
                a[i].X++;
            }
            if (!check())
            {
                CopyBtoA();
            }
            else
            {
                CopyAtoB();
                UpdateBoard(BrickNumber);
                NewBoardEvent();
                form.Invalidate();
            }
        }

        public void Rotation()
        {
            if (!rotation || BrickNumber == 7)
                return;
            rotation = false;
            Point p = a[1];
            for (int i = 0; i < 4; i++)
            {
                int x = a[i].Y - p.Y;
                int y = a[i].X - p.X;
                a[i].X = p.X - x;
                a[i].Y = p.Y + y;
            }
            if (!check())
            {
                CopyBtoA();
            }
            else
            {
                UpdateBoard(BrickNumber);
                NewBoardEvent();
                form.Invalidate();
                CopyAtoB();
            }
        }


        public void Paint(Graphics g)
        {
            bool tf;
            for (int i = 0; i < 4; i++)
            {
                tf = true;
                for (int j = 0; j < 4; j++)
                {
                    if (i != j && a[i].X == a[j].X && a[i].Y > a[j].Y)
                    {
                        tf = false;
                        break;
                    }
                }
                if (tf)
                {
                    switch (BrickNumber)
                    {
                        case 1:
                            g.DrawImage(Tetris.Properties.Resources.HQPurple, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 2:
                            g.DrawImage(Tetris.Properties.Resources.HQRed, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 3:
                            g.DrawImage(Tetris.Properties.Resources.HQGreen, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 4:
                            g.DrawImage(Tetris.Properties.Resources.HQYellow, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 5:
                            g.DrawImage(Tetris.Properties.Resources.HQAqua, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 6:
                            g.DrawImage(Tetris.Properties.Resources.HQOrgane, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                        case 7:
                            g.DrawImage(Tetris.Properties.Resources.HQBlue, a[i].X * 24, a[i].Y * 24 - 110);
                            break;
                    }
                }
            }
            for (int i = 2; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    if (board[i, j] != 0)
                    {
                        switch (board[i, j])
                        {
                            case 0:
                                g.DrawImage(Tetris.Properties.Resources.Brick1, j * 24, (i - 2) * 24);
                                break;
                            case 1:
                                g.DrawImage(Tetris.Properties.Resources.Brick2, j * 24, (i - 2) * 24);
                                break;
                            case 2:
                                g.DrawImage(Tetris.Properties.Resources.Brick3, j * 24, (i - 2) * 24);
                                break;
                            case 3:
                                g.DrawImage(Tetris.Properties.Resources.Brick4, j * 24, (i - 2) * 24);
                                break;
                            case 4:
                                g.DrawImage(Tetris.Properties.Resources.Brick5, j * 24, (i - 2) * 24);
                                break;
                            case 5:
                                g.DrawImage(Tetris.Properties.Resources.Brick6, j * 24, (i - 2) * 24);
                                break;
                            case 6:
                                g.DrawImage(Tetris.Properties.Resources.Brick7, j * 24, (i - 2) * 24);
                                break;
                            case 7:
                                g.DrawImage(Tetris.Properties.Resources.Brick8, j * 24, (i - 2) * 24);
                                break;
                        }

                    }

                }
            }
            rotation = true;

            for (int i = 0; i < 4; i++)
            {
                //g.DrawImage(SourceGame.img[BrickNumberNext], c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                switch (BrickNumberNext)
                {
                    case 0:
                        g.DrawImage(Tetris.Properties.Resources.Brick1, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 1:
                        g.DrawImage(Tetris.Properties.Resources.Brick2, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 2:
                        g.DrawImage(Tetris.Properties.Resources.Brick3, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 3:
                        g.DrawImage(Tetris.Properties.Resources.Brick4, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 4:
                        g.DrawImage(Tetris.Properties.Resources.Brick5, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 5:
                        g.DrawImage(Tetris.Properties.Resources.Brick6, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 6:
                        g.DrawImage(Tetris.Properties.Resources.Brick7, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                    case 7:
                        g.DrawImage(Tetris.Properties.Resources.Brick8, c[i].X * 24 + LocationNextBrick.X, c[i].Y * 24 + LocationNextBrick.Y);
                        break;
                }
            }
        }

        protected bool check() //Check out of board
        {
            for (int i = 0; i < 4; i++)
            {
                if (a[i].X < 0 || a[i].X >= WIDTH || a[i].Y < 0 || a[i].Y >= HEIGHT)
                    return false;
                if (board[a[i].Y, a[i].X] != 0)
                    return false;
            }
            return true;
        }


        protected bool MoveDown()
        {
            rotation = false;
            for (int i = 0; i < 4; i++)
            {
                a[i].Y += 1;
            }
            rotation = check();
            return rotation;
        }

        public void UpdateBoard(int x)
        {
            for (int i = 0; i < 4; i++)
            {
                board[a[i].Y, a[i].X] = x;
            }
        }

        protected bool update()
        {
            UpdateBoard(0);

            bool move = MoveDown();
            if (!move)
                CopyBtoA();
            else CopyAtoB();
            UpdateBoard(BrickNumber);
            NewBoardEvent();
            return move;
        }

        protected void AddScore(int line)
        {
            int score = 1;
            for (int i = 0; i < line; i++)
            {
                score *= 2;
            }
            Score += score;
        }

        protected void CheckLine()
        {
            int k = HEIGHT-1;
            for (int i = HEIGHT - 1; i >= 0; i--)
            {
                int count = 0;
                for (int j = 0; j < WIDTH; j++)
                {
                    if (board[i, j] != 0) count++;
                    board[k, j] = board[i, j];
                }
                if (count < WIDTH) k--;
            }
            if (k != -1)
            {
                AddScore(k+1);
                for (int i = 0; i < WIDTH; i++)
                {
                    board[0, i] = 0;
                }
                GetScoreEvent();
            }
        }

        void GetScoreEvent()
        {
            if (getScore != null)
            {
                getScore(this, new EventArgs());
            }
        }

        protected event EventHandler getScore;
        public event EventHandler GetScore
        {
            add
            {
                getScore += value;
            }
            remove
            {
                getScore -= value;
            }
        }

        protected bool AddBrick()
        {
            //MessageBox.Show("" + a[0]);
            for (int i = 0; i < 4; i++)
            {
                if (!check())
                {
                    Rotation();
                }
                else return true;
            }
            return false;
        }

        protected bool isLose()
        {
            for (int i = 0; i < WIDTH; i++)
            {
                if (board[1, i] != 0)
                    return true;
            }

            return false;
        }

        #endregion
    }
}

