using MENU;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Tetris;

namespace Tetris
{

    public partial class Name : Form
    {
        int Score;        
        public Name(int score)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            txtName.ForeColor = Color.PaleTurquoise;
            txtName.Text = "Please Enter Name";
            this.txtName.Leave += new System.EventHandler(this.textBox1_Leave);
            this.txtName.Enter += new System.EventHandler(this.textBox1_Enter);
            Score = score;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //MessageBox.Show("Thong bao", "Warning");
            if (txtName.Text == "")
            {
                txtName.Text = "Please Enter Name";
                txtName.ForeColor = Color.Gray;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtName.Text == "Please Enter Name")
            {
                txtName.Text = "";
                txtName.ForeColor = Color.Aqua;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            picEnter.Image = Tetris.Properties.Resources.SUBMITaf;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            picEnter.Image = Tetris.Properties.Resources.SUBMITnho;
        }

        void SaveLeaderBoard()
        {
            int LENGTH = Math.Min(txtName.Text.Length, 7);
            string name = txtName.Text.Substring(0, LENGTH);
            int index = 7;
            for (int i = 0; i < 7; i++)
            {
                if (Score > SourceGame.playerInfo[i].score)
                {
                    index = i;
                    break;
                }
            }
            if (index <= 6)
            {
                for (int i = 6; i > index; i--)
                {
                    SourceGame.playerInfo[i].score = SourceGame.playerInfo[i - 1].score;
                    SourceGame.playerInfo[i].name = SourceGame.playerInfo[i - 1].name;
                }
                SourceGame.playerInfo[index].score = Score;
                SourceGame.playerInfo[index].name = name;

                SourceGame.WriteLeaderBoard();
            }
        }

        private void picEnter_Click(object sender, EventArgs e)
        {
            SaveLeaderBoard();

            LeaderBoard board = new LeaderBoard();
            board.StartPosition = FormStartPosition.CenterParent;
            board.ShowDialog();

            this.Close();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == ' ')
                e.Handled = true;
        }
    }
}
