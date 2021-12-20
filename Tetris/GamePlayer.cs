using System;
using System.Drawing;
using System.Threading;

namespace Tetris
{
    class GamePlayer : Game
    {
        public bool isOtherPlayerReady = false;

        public GamePlayer(int x, int y, int x1, int y1, Display form) : base(x, y, x1, y1, form)
        {

        }

        public int[,] getBoard()
        {
            return board;
        }

        public void Reset()
        {
            Score = 0;
            Lose = false;
            a = new Point[4]; //Current Brick
            b = new Point[4]; // Copy current brick
            c = new Point[4];

            board = new int[HEIGHT, WIDTH];
            CreateNewBrick();
            Thread.Sleep(50);
            CreateNewBrick();
            UpdateBoard(BrickNumber);

            PreventKey = false;
        }

        private event EventHandler<BrickInfo> newBrickEvent;
        public event EventHandler<BrickInfo> NewBrickEvent
        {
            add
            {
                newBrickEvent += value;
            }
            remove
            {
                newBrickEvent -= value;
            }
        }

        void NewBrick(int n)
        {
            if (newBrickEvent != null)
            {
                newBrickEvent(this, new BrickInfo(n));
            }
        }

        void CreateNewBrick()
        {
            if (isKeyPress)
                PreventKey = true;
            BrickNumber = BrickNumberNext;
            for (int i = 0; i < 4; i++)
            {
                a[i] = c[i];
            }

            BrickNumberNext = random.Next(1, 8);
            NewBrick(BrickNumberNext);

            for (int i = 0; i < 4; i++)
            {
                c[i].X = brick[BrickNumberNext - 1, i] % 2 + 3;
                c[i].Y = brick[BrickNumberNext - 1, i] / 2;
            }

            CopyAtoB();
        }

        public void UpdateGame()
        {
            if (!update())
            {
                CheckLine();
                CreateNewBrick();
                //form.Invalidate(new Rectangle(LocationNextBrick.X, LocationNextBrick.Y, 100, 100));
                if (AddBrick())
                {
                    UpdateBoard(BrickNumber);
                    NewBoardEvent();
                    form.Invalidate();
                    rotation = true;
                }
                else
                {
                    UpdateBoard(BrickNumber);
                    NewBoardEvent();
                    Lose = true;
                }
            }
        }
    }

    public class BrickInfo : EventArgs
    {
        public int NextBrick;
        public BrickInfo(int n)
        {
            NextBrick = n;
        }
    }
}
