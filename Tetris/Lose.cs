using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tetris;

namespace Tetris
{
    public partial class Lose : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Lose()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pictureBox3.Image = Tetris.Properties.Resources.RESTARTAF;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox3.Image = Tetris.Properties.Resources.RESTART1;
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.QUITAF;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Tetris.Properties.Resources.QUIT1;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (restart != null)
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
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (exit != null)
                exit(this, new EventArgs());
            if (SourceGame.isMusicMainMenuOn)
                SourceGame.MainMenuMusic.Play();
            this.Close();
        }
    }
}
