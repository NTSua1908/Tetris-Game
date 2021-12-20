using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class Level : Form
    {
        public Level()
        {
            InitializeComponent();
        }

        private void picAuto_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.AUTO;
        }

        private void picEasy_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.EASY;
        }

        private void picMedium_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.MEDIUM;
        }

        private void picHard_Click(object sender, EventArgs e)
        {
            SourceGame.SelectedLevel = LevelGame.HARD;
        }
    }
}
