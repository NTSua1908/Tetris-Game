using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    class GameOtherPlayer : Game
    {
        bool first;
        int Number;

        public GameOtherPlayer(int x, int y, int x1, int y1, Display form) : base(x, y, x1, y1, form)
        {

        }

        public void Reset()
        {
            first = true;
            BrickNumberNext = -2;
            Score = 0;
            Lose = false;
            c = new Point[4];
            a = new Point[4];

            board = new int[HEIGHT, WIDTH];

        }

        private event EventHandler startGame;
        public event EventHandler StartGame
        {
            add
            {
                startGame += value;
            }
            remove
            {
                startGame -= value;
            }
        }

        public void setBoard(int [,] board)
        {
            this.board = board;
        }

        public void setA(Point[] a)
        {
            this.a = a;
            BrickNumber = Number;
            //MessageBox.Show("" + a[1].X + " " + a[1].Y);
            form.Invalidate();
        }

        void GameOn()
        {
            if (startGame != null)
            {
                startGame(this, new EventArgs());
            }
        }

        public void SetNewBrick(int BrickNumberRecieved)
        {
            if (!first)
            {
                Number = BrickNumberNext;
                BrickNumberNext = BrickNumberRecieved;
            }
            else if (BrickNumberNext == -2)
            {
                BrickNumberNext = -1;
                Number = BrickNumberRecieved;
            }
            else if (BrickNumberNext == -1)
                BrickNumberNext = BrickNumberRecieved;

            for (int i = 0; i < 4; i++)
            {
                c[i].X = brick[BrickNumberNext - 1, i] % 2 + 3;
                c[i].Y = brick[BrickNumberNext - 1, i] / 2;
            }

            if (BrickNumberNext != -1 && BrickNumberNext != -2 && first)
            {
                GameOn();
                first = false;
            }
        }
    }
}
