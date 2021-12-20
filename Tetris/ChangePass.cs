using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
namespace Account
{
    public partial class ChangePass : Form
    {
        string gmail = ForgotPass.to;
        public ChangePass()
        {
            InitializeComponent();
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
        private void btnReset_Click(object sender, EventArgs e)
        {
            if(NewPasstxb.Text==confirmtxb.Text && NewPasstxb.Text!="")
            {
                SqlConnection sqlc = new SqlConnection(connectionString);
                SqlCommand sqlCmd = new SqlCommand("UPDATE [dbo].[tbIUser] SET [Password] ='" +Encrypt(NewPasstxb.Text) + "' WHERE Gmail='"+gmail+"' ",sqlc);
                sqlc.Open();
                sqlCmd.ExecuteNonQuery();
                sqlc.Close();
                MessageBox.Show("Reset password success!!!");
                this.Close();
            }    
            else
            {
                MessageBox.Show("Password does not match!!!");
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
