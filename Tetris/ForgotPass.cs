using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Data.SqlClient;
namespace Account
{
    public partial class ForgotPass : Form
    {
        string randomcode;
        public static string to;
        public ForgotPass()
        {
            InitializeComponent();
        }

        private void gmailtxb_Leave(object sender, EventArgs e)
        {
            if (gmailtxb.Text == "")
            {
                gmailtxb.Text = "Please Enter Your Email";
                gmailtxb.ForeColor = Color.Gray;
            }
        }

        private void gmailtxb_Enter(object sender, EventArgs e)
        {
            if (gmailtxb.Text == "Please Enter Your Email")
            {
                gmailtxb.Text = "";
                gmailtxb.ForeColor = Color.Aqua;
            }
        }

        private void codetxb_Leave(object sender, EventArgs e)
        {
            if (codetxb.Text == "")
            {
                codetxb.Text = "Please Enter Your Verify code";
                codetxb.ForeColor = Color.Gray;
            }
        }

        private void codetxb_Enter(object sender, EventArgs e)
        {
            if (codetxb.Text == "Please Enter Your Verify code")
            {
                codetxb.Text = "";
                codetxb.ForeColor = Color.Aqua;
            }
        }
        string connectionString = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
        private void btnsend_Click(object sender, EventArgs e)
        {
            SqlConnection sqlc = new SqlConnection(connectionString);
            string query = "Select * from tbIUser Where Gmail ='" + gmailtxb.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlc);
            DataTable dttb = new DataTable();
            sda.Fill(dttb);
            if (dttb.Rows.Count == 1)
            {
                string from, pass, messageBody;
                Random random = new Random();
                randomcode = (random.Next(100000,999999)).ToString();
                MailMessage message = new MailMessage();
                to = (gmailtxb.Text).ToString();
                from = "PTS.UIT.Group@gmail.com";
                pass = "PTS@uitGroup";
                messageBody = "Your reset account code:" + randomcode;
                message.To.Add(to);
                message.From = new MailAddress(from);
                message.Body = messageBody;
                message.Subject = "Password reseting code";
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Credentials = new NetworkCredential(from, pass);
                try
                {
                    smtp.Send(message);
                    MessageBox.Show("Code send success!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Wrong Gmail.Try Again!!!!");
            }
        }

        private void btnverify_Click(object sender, EventArgs e)
        {
            if(randomcode==(codetxb.Text).ToString())
            {
                to = gmailtxb.Text;
                ChangePass change = new ChangePass();
                this.Close();
                change.ShowDialog();
                this.Show();
            }   
            else
            {
                MessageBox.Show("Wrong reset Code!!!!");
            }    
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
