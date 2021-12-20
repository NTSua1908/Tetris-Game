using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MENU;
using Tetris;
namespace Tetris
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
            trackBar1.Value = Form1.wplayer.settings.volume;
            if (!SourceGame.isMusicMainMenuOn)
            {
                Sound.Image = Properties.Resources.sound_off;
            }
            else Sound.Image = Properties.Resources.sound_on;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Form1.wplayer.settings.volume = trackBar1.Value;
            setImage();
        }
        void setImage()
        {
            if (Form1.wplayer.settings.volume == 0)
            {
                Sound.Image = Properties.Resources.sound_off;
                SourceGame.isMusicMainMenuOn = false;
            }
            else
            {
                Sound.Image = Properties.Resources.sound_on;
                if (!SourceGame.isMusicMainMenuOn)
                    SourceGame.MainMenuMusic.PlayLooping();
                SourceGame.isMusicMainMenuOn = true;
                
            }
        }

        private void Sound_Click(object sender, EventArgs e)
        {
            if (SourceGame.isMusicMainMenuOn)
            {
                Sound.Image = Properties.Resources.sound_off;
                SourceGame.isMusicMainMenuOn = false;
                SourceGame.MainMenuMusic.Stop();
            }
            else
            {
                Sound.Image = Properties.Resources.sound_on;
                SourceGame.isMusicMainMenuOn = true;
                SourceGame.MainMenuMusic.PlayLooping();
            }
        }
    }
}