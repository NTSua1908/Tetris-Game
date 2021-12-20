using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;
using Tetris;
using MENU;

namespace Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Do you want to exit the program?","Nofitication",MessageBoxButtons.OKCancel)!=DialogResult.OK)
            {
                e.Cancel = true;
            }    
        }
        static string Encrypt(string value)
        {
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                UTF8Encoding utf8 = new UTF8Encoding();
                byte[] data = md5.ComputeHash(utf8.GetBytes(value));
                return Convert.ToBase64String(data);
            }
        }
        string connectionString = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
        private void btnlogin_Click(object sender, EventArgs e)
        {   
            SqlConnection sqlc = new SqlConnection(connectionString);
            string query = "Select * from tbIUser Where UserName ='" + txtUsername.Text.Trim() + "' and Password = '" + Encrypt(txtPassword.Text.Trim())+"'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);

            SourceGame.UserName = txtUsername.Text.Trim();
            if (dttb.Rows.Count==1)
            {
                SourceGame.isLogin = true;
                SourceGame.UserID = (from DataRow dr in dttb.Rows
                                     where (string)dr["UserName"] == SourceGame.UserName
                                     select (int)dr["UserID"]).FirstOrDefault();
                Form1 form = new Form1();
                //this.Hide();
                form.ShowDialog();
                //this.Show();
            }
            else
            {
                MessageBox.Show("Wrong username or password!!!!");
            }
        }
        private void SignUp_Click(object sender, EventArgs e)
        {
            Signup sign = new Signup();
            this.Hide();
            sign.ShowDialog();
            this.Show();
        }

        private void ForgotPss_Click(object sender, EventArgs e)
        {
            ForgotPass forgotp = new ForgotPass();
            this.Hide();
            forgotp.ShowDialog();
            this.Show();
        }

        private void lbGuess_Click(object sender, EventArgs e)
        {
            SourceGame.isLogin = false;
            Form1 form = new Form1();
            form.ShowDialog();
        }
    }
}
