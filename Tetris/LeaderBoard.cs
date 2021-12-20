using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tetris;

namespace MENU
{
    public partial class LeaderBoard : Form
    {
        public LeaderBoard()
        {
            InitializeComponent();

            if (!SourceGame.isLogin)
                ShowLeaderBoard();
            else GetPointFromDatabase();
        }

        void Check(Label lbname, Label lbscore, SourceGame.PlayerInfo info)
        {
            if (!string.IsNullOrEmpty(info.name))
            {
                lbname.Text = info.name;
                lbscore.Text = info.score.ToString();
            }
            else
            {
                lbname.Text = "--";
                lbscore.Text = "--";
            }
        }

        void ShowLeaderBoard()
        {
            Check(lbname1, lbscore1, SourceGame.playerInfo[0]);
            Check(lbname2, lbscore2, SourceGame.playerInfo[1]);
            Check(lbname3, lbscore3, SourceGame.playerInfo[2]);
            Check(lbname4, lbscore4, SourceGame.playerInfo[3]);
            Check(lbname5, lbscore5, SourceGame.playerInfo[4]);
            Check(lbname6, lbscore6, SourceGame.playerInfo[5]);
            Check(lbname7, lbscore7, SourceGame.playerInfo[6]);
        }

        private void pictureBox2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void GetPointFromDatabase()
        {
            //string ConnectStr = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
            //SqlConnection connection = new SqlConnection(ConnectStr);
            //connection.Open();

            //string query = "select * from Point";
            //SqlCommand command = new SqlCommand(query, connection);

            //DataTable data = new DataTable();
            //SqlDataAdapter adapter = new SqlDataAdapter(command);

            //adapter.Fill(data);

            //table.DataSource = data;

            string ConnectStr = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
            SqlConnection connection = new SqlConnection(ConnectStr);
            connection.Open();

            string query = "select top 7 * from Point p inner join tbIUser u on u.UserID = p.UserID order by Point desc";
            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            table.DataSource = data; //table la DatgridView, them no vao ben design roi sent to back an no di

            SetValue(lbname1, lbscore1, 0);
            SetValue(lbname2, lbscore2, 1);
            SetValue(lbname3, lbscore3, 2);
            SetValue(lbname4, lbscore4, 3);
            SetValue(lbname5, lbscore5, 4);
            SetValue(lbname6, lbscore6, 5);
            SetValue(lbname7, lbscore7, 6);
        }

        void SetValue(Label lbname, Label lbscore, int i)
        {
            if (i >= table.Rows.Count - 1)
            {
                lbname.Text = "--";
                lbscore.Text = "--";
                return;
            }

            lbname.Text = table.Rows[i].Cells[7].Value.ToString();
            lbscore.Text = table.Rows[i].Cells[1].Value.ToString();
        }
    }
}
