using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris;

namespace MENU
{
    public partial class Mode : Form
    {
        public Mode()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pictureBox6.Image = Tetris.Properties.Resources.OnePlayerAf;
            FlamePrincess.Visible = true;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Tetris.Properties.Resources.OnePlayer;
            FlamePrincess.Visible = false;
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pictureBox7.Image = Tetris.Properties.Resources.PVPaf;
            PvP.Visible = true;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Tetris.Properties.Resources.TwoPlayer;
            PvP.Visible = false;
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pictureBox8.Image = Tetris.Properties.Resources.Alaf;
            ptbPlayer.Visible = true;
            ptbAI.Visible = true;
            SFX.URL = Application.StartupPath + "\\music\\Button.wav";

        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Tetris.Properties.Resources.PvE;
            ptbPlayer.Visible = false;
            ptbAI.Visible = false;
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Thread playgame = new Thread(() =>
            //
                Difficulties game = new Difficulties();
                game.StartPosition = FormStartPosition.CenterParent;
                game.ShowDialog();
            //});
            //playgame.IsBackground = true;
            //playgame.Start();
            this.Close();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Thread playgame = new Thread(() =>
            {
                Tetris_PlayerVsPCGame game = new Tetris_PlayerVsPCGame();
                game.StartPosition = FormStartPosition.CenterParent;
                game.ShowDialog();
            });
            playgame.IsBackground = true;
            playgame.Start();
            this.Close();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Thread playgame = new Thread(() =>
            {
                Tetris_Mulltiplayer game = new Tetris_Mulltiplayer();
                game.StartPosition = FormStartPosition.CenterParent;
                game.ShowDialog();
            });
            playgame.IsBackground = true;
            playgame.Start();
            this.Close();
        }
    }
}
