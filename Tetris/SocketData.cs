using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tetris
{
    [Serializable]
    public class SocketData
    {
        SocketCommand command;
        int [,] board;
        Point[] a;
        string mess;
        public SocketData(SocketCommand command, string Message, int[,] board, Point[] a)
        {
            this.command = command;
            mess = Message;
            this.board = board;
            this.a = a;
        }

        public string Mess { get => mess; set => mess = value; }
        public SocketCommand Command { get => command; set => command = value; }
        public int[,] Board { get => board; set => board = value; }
        public Point[] A { get => a; set => a = value; }
    }

    public enum SocketCommand
    {
        MESSAGE,
        BOARD,
        SEND_NEW_BRICK,
        READY,
        NOT_READY,
        DISCONNECTED,
        NEW_GAME,
        START_GAME
    }
}
