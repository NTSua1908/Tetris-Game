using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class LandedLocation
    {
        public Point location;
        public LandedLocation(Point location)
        {
            this.location = location;
        }
    }
    class TetrisAI : Game
    {
        int[,] TempBoard;
        int[,] TempBoardWithoutHole;
        int[] HeighOfColmn;
        Point[] d, e, f; // Temp to test AI
        List<LandedLocation> ListOfLandedLocation;

        double MaxWeight;
        int heightAI;
        int MaxHeight;

        float WAggregateHeight = -0.510066f;
        float WCompleteLines = 0.760666f;
        //float WCompleteLines = 1;
        float WHoles = -0.35663f;
        float WBumpiness = -0.184483f;

        public TetrisAI(int x, int y, int x1, int y1, Display form) : base(x, y, x1, y1, form)
        {
            ListOfLandedLocation = new List<LandedLocation>();
        }

        void CopyToTempBoard()
        {
            for (int i = 0; i < HEIGHT; i++)
            {
                for (int j = 0; j < WIDTH; j++)
                {
                    TempBoard[i, j] = TempBoardWithoutHole[i, j];
                }
            }
        }

        public void Reset()
        {
            Score = 0;
            Lose = false;
            BrickNumber = -1;
            a = new Point[4]; //Current Brick
            b = new Point[4]; // Copy current brick
            c = new Point[4];
            d = new Point[4];
            e = new Point[4];
            f = new Point[4];

            board = new int[HEIGHT, WIDTH];
            TempBoard = new int[HEIGHT, WIDTH];
            TempBoardWithoutHole = new int[HEIGHT, WIDTH];
            HeighOfColmn = new int[WIDTH];
            CreateNewBrick();
            CreateNewBrick();
            //UpdateBoard(BrickNumber);

            CopyToTempBoard();
        }

        private event EventHandler runAI;
        public event EventHandler RunAI
        {
            add
            {
                runAI += value;
            }
            remove
            {
                runAI -= value;
            }
        }

        void StartAI()
        {
            if (runAI != null)
                runAI(this, new EventArgs());
        }

        void CopyEtoD()
        {
            for (int i = 0; i < 4; i++)
            {
                d[i] = e[i];
            }
        }
        void CopyDtoE()
        {
            for (int i = 0; i < 4; i++)
            {
                e[i] = d[i];
            }
        }

        public void CreateNewBrick()
        {
            if (BrickNumber != -1)
            {
                BrickNumber = BrickNumberNext;

                for (int i = 0; i < 4; i++)
                {
                    a[i] = c[i];
                }
                CopyAtoB();
                for (int i = 0; i < 4; i++)
                {
                    e[i] = c[i];
                }
                CopyEtoD();
            }
            else BrickNumber = 0;

            BrickNumberNext = random.Next(1, 16);
            BrickNumberNext %= 7;
            if (BrickNumberNext == 0)
                BrickNumberNext = 7;
            //if (BrickNumberNext == 8)
            //    BrickNumberNext = 1;

            for (int i = 0; i < 4; i++)
            {
                c[i].X = brick[BrickNumberNext - 1, i] % 2 + 3;
                c[i].Y = brick[BrickNumberNext - 1, i] / 2 + 1;
            }

            if (BrickNumber != -1 && BrickNumber != 0)
            {
                CheckAI();
            }
        }

        public void AIRotation()
        {
            Point p = a[1];
            for (int i = 0; i < 4; i++)
            {
                int x = a[i].Y - p.Y;
                int y = a[i].X - p.X;
                a[i].X = p.X - x;
                a[i].Y = p.Y + y;
            }
            CopyAtoB();
        }

        public void AdjustA()
        {
            for (int i = 0; i < 4; i++)
            {
                a[i].X = f[i].X;
                a[i].Y = f[i].Y - heightAI;
            }
            CopyAtoB();

  
            UpdateBoard(BrickNumber);

            form.Invalidate();
        }

        public bool AIMoveDown()
        {
            for (int i = 0; i < 4; i++)
            {
                a[i].Y += 1;
            }
            bool tf = check();
            if (!tf)
            {
                CopyBtoA();
                UpdateBoard(BrickNumber);
                CheckLine();
                if (isLose())
                    Lose = true;
            }
            else CopyAtoB();
            return tf;
            //CreateNewBrick();
        }

        void CreateTempBoarWithoutHole()
        {
            int index;
            for (int i = 0; i < Game.WIDTH; i++)
            {
                index = -1;
                for (int j = 0; j < Game.HEIGHT; j++)
                {
                    if (board[j, i] != 0)
                    {
                        index = j;
                        break;
                    }
                    TempBoardWithoutHole[j, i] = 0;
                }
                if (index != -1)
                {
                    for (int j = Game.HEIGHT - 1; j >= index; j--)
                    {
                        TempBoardWithoutHole[j, i] = 1;
                    }
                }
            }
        }

        public void CheckAI()
        {
            CreateTempBoarWithoutHole();
            bool Found;
            ListOfLandedLocation.Clear();

            MaxWeight = -9999999999d;
            MaxHeight = -1;

            for (int i = 0; i < WIDTH; i++)
            {
                Found = false;
                for (int j = 0; j < HEIGHT && !Found; j++)
                {
                    if (board[j, i] > 0)
                    {
                        Found = true;
                        LandedLocation l = new LandedLocation(new Point(i, j - 1));
                        ListOfLandedLocation.Add(l);
                    }
                }

                if (!Found)
                {
                    LandedLocation l = new LandedLocation(new Point(i, HEIGHT - 1));
                    ListOfLandedLocation.Add(l);
                }
                //MessageBox.Show(ListOfLandedLocation[i].location.Y.ToString());
            }

            for (int i = 0; i < ListOfLandedLocation.Count; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    d[j] = a[j];
                }
                CopyDtoE();
                CheckLanded(ListOfLandedLocation[i].location);
            }

            StartAI();
        }

        void TryRotation()
        {
            Point p = d[1];
            for (int i = 0; i < 4; i++)
            {
                int x = d[i].Y - p.Y;
                int y = d[i].X - p.X;
                d[i].X = p.X - x;
                d[i].Y = p.Y + y;
            }
            CopyDtoE();
        }

        int HeighOfBrick()
        {
            int min = d[0].Y;
            int max = d[0].Y;

            for (int i = 1; i < 4; i++)
            {
                if (min > d[i].Y)
                {
                    min = d[i].Y;
                }

                if (max < d[i].Y)
                {
                    max = d[i].Y;
                }
            }

            return max - min + 1;
        }

        int MinXOfBrickMaxY(Point[] d)
        {
            int max = 0;
            for (int i = 1; i < 4; i++)
            {
                if (d[max].Y < d[i].Y || d[max].Y == d[i].Y && d[max].X > d[i].X)
                {
                    max = i;
                }
            }

            return d[max].X;
        }

        int minY(Point[] d)
        {
            int min = d[0].Y;
            for (int i = 1; i < 4; i++)
            {
                if (min > d[i].Y)
                    min = d[i].Y;
            }

            return min;
        }

        bool checkD() //Check out of board
        {
            for (int i = 0; i < 4; i++)
            {
                if (d[i].X < 0 || d[i].X >= WIDTH || d[i].Y < 0 || d[i].Y >= HEIGHT)
                    return false;
                if (TempBoard[d[i].Y, d[i].X] != 0)
                    return false;
            }
            return true;
        }

        void CheckLanded(Point location)
        {
            for (int i = 0; i < 4; i++)
            {
                CopyEtoD();
                CopyToTempBoard();
                TryRotation();
                //Console.WriteLine(d[0].X.ToString() + "-" + d[0].Y.ToString() + " " + d[1].X.ToString() + "-" + d[1].Y.ToString() + " " + d[2].X.ToString() + "-" + d[2].Y.ToString() + " " + d[3].X.ToString() + "-" + d[3].Y.ToString());
                //MessageBox.Show(d[0].X.ToString() + "-" + d[0].Y.ToString() + " " + d[1].X.ToString() + "-" + d[1].Y.ToString() + " " + d[2].X.ToString() + "-" + d[2].Y.ToString() + " " + d[3].X.ToString() + "-" + d[3].Y.ToString());

                int x = MinXOfBrickMaxY(d);
                int y = minY(d);
                //x = ( - x) + x;
                //MessageBox.Show(d[0].X.ToString() + "-" + d[0].Y.ToString() + " " + d[1].X.ToString() + "-" + d[1].Y.ToString() + " " + d[2].X.ToString() + "-" + d[2].Y.ToString() + " " + d[3].X.ToString() + "-" + d[3].Y.ToString() + "  " + x);

                //Giảm X ve 0
                for (int j = 0; j < 4; j++)
                {
                    d[j].X -= x;
                    d[j].Y -= y;
                }
                //MessageBox.Show(d[0].X.ToString() + "-" + d[0].Y.ToString() + " " + d[1].X.ToString() + "-" + d[1].Y.ToString() + " " + d[2].X.ToString() + "-" + d[2].Y.ToString() + " " + d[3].X.ToString() + "-" + d[3].Y.ToString() + "  " + x);

                int height = HeighOfBrick() - 1;
                //location.Y -= height;
                BringBrickToLandedLocation(new Point(location.X, location.Y - height));
                //Console.WriteLine("I'm here");
                //Console.WriteLine(d[0].X.ToString() + "-" + d[0].Y.ToString() + " " + d[1].X.ToString() + "-" + d[1].Y.ToString() + " " + d[2].X.ToString() + "-" + d[2].Y.ToString() + " " + d[3].X.ToString() + "-" + d[3].Y.ToString());
                if (checkD())
                {
                    AddBrickToTempBoard();
                    CalculationWeight(d, location.Y - height);
                }
            }
        }

        void BringBrickToLandedLocation(Point location)
        {
            for (int i = 0; i < 4; i++)
            {
                d[i].X += location.X;
                d[i].Y += location.Y;
            }
        }

        void AddBrickToTempBoard()
        {
            for (int i = 0; i < 4; i++)
            {
                TempBoard[d[i].Y, d[i].X] = BrickNumber;
            }
        }

        int CheckLineTempBoard()
        {
            int k = HEIGHT - 1;
            for (int i = HEIGHT - 1; i >= 0; i--)
            {
                int count = 0;
                for (int j = 0; j < WIDTH; j++)
                {
                    if (TempBoard[i, j] != 0) count++;
                    TempBoard[k, j] = TempBoard[i, j];
                }
                if (count < WIDTH) k--;
            }
            return k + 1;
        }

        void CalculationWeight(Point[] backup, int heightAI)
        {
            bool IsFound;

            double AggregateHeight = 0d;
            double CompleteLines = 0d;
            double Holes = 0d;
            double Bumpiness = 0d;
            double TotalWeight = 0d;

            int MaxHeightTemp = 0 ;

            CompleteLines = CheckLineTempBoard();

            for (int i = 0; i < WIDTH; i++)
            {
                IsFound = false;
                for (int j = 0; j < HEIGHT && !IsFound; j++)
                {
                    if (TempBoard[j, i] > 0)
                    {
                        IsFound = true;
                        HeighOfColmn[i] = HEIGHT - j;

                        //if (CheckHole(i, j))
                        //    Holes++;
                        Holes += CountHoles(i, j);
                    }
                }
                if (!IsFound)
                    HeighOfColmn[i] = 0;

                AggregateHeight += HeighOfColmn[i];
                if (HeighOfColmn[i] > MaxHeightTemp)
                    MaxHeightTemp = HeighOfColmn[i];

                if (i > 0)
                {
                    Bumpiness += Math.Abs(HeighOfColmn[i - 1] - HeighOfColmn[i]);
                }
            }

            //Check Line
            //for (int i = 0; i < HEIGHT; i++)
            //{
            //    IsFound = true;
            //    for (int j = 0; j < WIDTH && IsFound; j++)
            //    {
            //        if (TempBoard[i, j] == 0)
            //            IsFound = false;
            //    }

            //    if (IsFound)
            //    {
            //        CompleteLines++;
            //    }
            //}

            TotalWeight = (this.WAggregateHeight * AggregateHeight) + (this.WCompleteLines * CompleteLines) + (this.WHoles * Holes) + (this.WBumpiness * Bumpiness);

            //MessageBox.Show("ToTal Weight = " + TotalWeight);

            if ((TotalWeight > MaxWeight) || ((TotalWeight == MaxWeight) && (MaxHeight > MaxHeightTemp)))// && ((MaxWeight - TotalWeight) > 0))
            {
                MaxWeight = TotalWeight;
                MaxHeight = MaxHeightTemp;
                for (int i = 0; i < 4; i++)
                {
                    f[i] = backup[i];
                }
                this.heightAI = heightAI;
            }
        }

        int CountHoles(int x, int y)
        {
            int count = 0;
            for (int i = HEIGHT - 1; i > y; i--)
            {
                if (TempBoard[i, x] == 0)
                    count++;
            }

            return count;
        }
    }
}
