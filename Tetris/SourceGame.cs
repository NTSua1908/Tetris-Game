using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace Tetris
{
    static public class SourceGame
    {
        public struct PlayerInfo
        {
            public string name;
            public int score;
        };

        static public LevelGame SelectedLevel = LevelGame.AUTO;

        static public PlayerInfo[] playerInfo = new PlayerInfo[7];

        static public SoundPlayer MainMenuMusic = new SoundPlayer();
        static public SoundPlayer OnePlayerMusic = new SoundPlayer();
        static public SoundPlayer MultiPlayerMusic = new SoundPlayer();
        static public SoundPlayer AlMusic = new SoundPlayer();

        static public bool isMusicMainMenuOn = true;
        static public bool isLogin = false;
        static public bool isSavedGame = false;
        static public int UserID;
        static public string UserName;

        static public PrivateFontCollection FontGame;

        static public void WriteLeaderBoard()
        {
            try
            {
                using (System.IO.StreamWriter file =
                new System.IO.StreamWriter(Application.StartupPath + "\\LeaderBoard.save"))
                {
                    for (int i = 0; i < 7; i++)
                    {
                        file.WriteLine(playerInfo[i].name + " " + playerInfo[i].score);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Save Error!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static public bool LoadLeaderBoard()
        {

            try
            {
                int i = 0;
                foreach (string line in File.ReadLines(Application.StartupPath + "\\LeaderBoard.save"))
                {
                    int index = line.IndexOf(' ');
                    if (index == 0)
                        continue;
                    playerInfo[i].name = line.Substring(0, index);
                    playerInfo[i].score = Convert.ToInt32(line.Substring(index + 1, line.Length - index - 1));
                    i++;
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool LoadFont()
        {
            try
            {
                FontGame = new PrivateFontCollection();
                FontGame.AddFontFile(Application.StartupPath + "\\Font\\DRAguSans-BlackItalic.ttf");
                return true;
            }
            catch { return false; }
        }
        static public bool LoadSound()
        {
            try
            {
                MainMenuMusic.SoundLocation = Application.StartupPath + "\\music\\MainMenu.wav";
                OnePlayerMusic.SoundLocation = Application.StartupPath + "\\music\\TetrisOnePlayer.wav";
                MultiPlayerMusic.SoundLocation = Application.StartupPath + "\\music\\TetrisMulti.wav";
                AlMusic.SoundLocation = Application.StartupPath + "\\music\\TetrisAI.wav";
                
                MainMenuMusic.Play();
                MainMenuMusic.Stop();
                OnePlayerMusic.Play();
                OnePlayerMusic.Stop();
                MultiPlayerMusic.Play();
                MultiPlayerMusic.Stop();
                AlMusic.Play();
                AlMusic.Stop();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static bool CheckSource()
        {
            return (LoadLeaderBoard() && LoadSound() && LoadFont());
        }
    }

    public enum LevelGame
    {
        AUTO,
        EASY,
        MEDIUM,
        HARD
    }
}
