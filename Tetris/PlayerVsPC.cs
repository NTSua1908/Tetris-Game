using System.Drawing;

namespace Tetris
{
    class PlayerVsPC : Game
    {
        public PlayerVsPC(int x, int y, int x1, int y1, Display form) : base(x, y, x1, y1, form)
        {

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
            CreateNewBrick();
            UpdateBoard(BrickNumber);
            PreventKey = false;
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
                if (!isLose())
                {
                    UpdateBoard(BrickNumber);
                    form.Invalidate();
                    rotation = true;
                }
                else
                {
                    //MessageBox.Show("LOSE");
                    //UpdateBoard(BrickNumber);
                    Lose = true;
                }
            }
        }
    }
}

