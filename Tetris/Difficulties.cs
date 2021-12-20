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

namespace Tetris
{
    public partial class Difficulties : Form
    {
        public Difficulties()
        {
            InitializeComponent();
        }

        private void ptbEasy_MouseHover(object sender, EventArgs e)
        {
            ptbEasy.Image = Tetris.Properties.Resources.EASYaf;
            ptbCharmender.Visible = true;
        }

        private void ptbEasy_MouseLeave(object sender, EventArgs e)
        {
            ptbEasy.Image = Tetris.Properties.Resources.EASY;
            ptbCharmender.Visible = false;
        }

        private void ptbNormal_MouseHover(object sender, EventArgs e)
        {
            ptbNormal.Image = Tetris.Properties.Resources.NORMALaf;
            ptbCharmeleon.Visible = true;
        }

        private void ptbNormal_MouseLeave(object sender, EventArgs e)
        {
            ptbNormal.Image = Tetris.Properties.Resources.NORMAL;
            ptbCharmeleon.Visible = false;
        }

        private void ptbHard_MouseHover(object sender, EventArgs e)
        {
            ptbHard.Image = Tetris.Properties.Resources.HARDaf;
            ptbCharizard.Visible = true;
        }

        private void ptbHard_MouseLeave(object sender, EventArgs e)
        {
            ptbHard.Image = Tetris.Properties.Resources.HARD;
            ptbCharizard.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ptbEasy_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.EASY;
            StartGame();
            this.Close();
        }

        private void ptbNormal_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.MEDIUM;
            StartGame();
            this.Close();
        }

        private void ptbHard_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.HARD;
            StartGame();
            this.Close();
        }
        void StartGame()
        {

            Thread playgame = new Thread(() =>
            {
                Tetris_OnePlayerGame t = new Tetris_OnePlayerGame();
                t.StartPosition = FormStartPosition.CenterParent;
                t.ShowDialog();
            });
            playgame.IsBackground = true;
            playgame.Start();
        }

        private void ptbCasual_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.AUTO;
            StartGame();
            this.Close();
        }

        private void ptbCasual_MouseHover(object sender, EventArgs e)
        {
            ptbCasual.Image = Tetris.Properties.Resources.CASUALaf;
            ptbEvolution.Visible = true;
        }

        private void ptbCasual_MouseLeave(object sender, EventArgs e)
        {
            ptbCasual.Image = Tetris.Properties.Resources.CASUAL;
            ptbEvolution.Visible = false;
        }
    }
}
