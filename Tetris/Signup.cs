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
using System.Net;
using System.Net.Mail;
namespace Account
{
    public partial class Signup : Form
    {
        string randomcode;
        public static string to;
        System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^([a-zA-Z0-9_\-])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$");
        string connectionString = @"Data Source=tetris.database.windows.net;Initial Catalog=UserRegistrationDB;User ID=Sua;Password=Aa123456";
        public Signup()
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
        private void SignUpbtn_Click(object sender, EventArgs e)
        {
            SqlConnection sqlCon = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand("select * from tbIUser where Gmail=@Gmail", sqlCon);
            sqlCon.Open();
            cmd.Parameters.AddWithValue("Gmail", txbGmail.Text);
            cmd.Parameters.AddWithValue("UserName", txbUserName.Text);
            SqlDataReader sdr = cmd.ExecuteReader();
            SqlConnection sqlCon1 = new SqlConnection(connectionString);
            SqlCommand cmd1 = new SqlCommand("select * from tbIUser where UserName=@UserName", sqlCon1);
            sqlCon1.Open();
            cmd1.Parameters.AddWithValue("UserName", txbUserName.Text);
            SqlDataReader sdr1 = cmd1.ExecuteReader();
            if (sdr.HasRows)
            {
                MessageBox.Show("Your Gmail is already in use");
            }
            else if (sdr1.HasRows)
            {
                MessageBox.Show("Your username is already in use");
            }
            else if (txbUserName.Text == "" || txbGmail.Text == "")
            {
                MessageBox.Show("Please enter FULL INFORMATION!!!");
            }
            else if  (txbUserName.Text == "" || txbPass.Text == "")
                MessageBox.Show("Please Enter UserName and Password!!!");
            else if (txbConfirm.Text != txbPass.Text)
                MessageBox.Show("Password not match!!!");  
            else if(randomcode != txbCode.Text.ToString() || txbGmail.Text.ToString()!=email)
            {
                MessageBox.Show("Code Box is wrong or empty!!!");
            }    
            else 
            {
                using (sqlCon = new SqlConnection(connectionString))
                {
                    label11.Text = "Checked";
                    label11.ForeColor = Color.Green;
                    label12.Text = "Checked";
                    label12.ForeColor = Color.Green;
                    SignUpbtn.Enabled = true;
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("UserAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@Họ", txbHo.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Tên", txbTen.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@SĐT", txbSDT.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Gmail", txbGmail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", txbUserName.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", Encrypt(txbPass.Text.Trim()));
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("SignUp success!!!");
                    Clear();
                    this.Close();
                }
            }
        }
        void Clear()
        {
            txbHo.Text = txbTen.Text = txbSDT.Text = txbGmail.Text = txbUserName.Text = txbPass.Text = txbConfirm.Text = "";
        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txbGmail_Validating(object sender, CancelEventArgs e)
        {
            if(txbGmail.Text.Length>0)
            {
                if(!rEMail.IsMatch(txbGmail.Text))
                {
                    MessageBox.Show("Invalidate Email","Error");
                    txbGmail.SelectAll();
                    SignUpbtn.Enabled = false;
                    //e.Cancel = true;
                }
                else
                {
                    SignUpbtn.Enabled = true;
                }
            }    
        }
        string email;
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (txbGmail.Text.Length>0)
            {
                if (rEMail.IsMatch(txbGmail.Text))
                {
                    email = txbGmail.Text.ToString();
                    string from, pass, messageBody;
                    Random random = new Random();
                    randomcode = (random.Next(100000, 999999)).ToString();
                    MailMessage message = new MailMessage();
                    to = (txbGmail.Text).ToString();
                    from = "PTS.UIT.Group@gmail.com";
                    pass = "PTS@uitGroup";
                    messageBody = "Verification code exists for your email :" + randomcode;
                    message.To.Add(to);
                    message.From = new MailAddress(from);
                    message.Body = messageBody;
                    message.Subject = "Confirm Email Code";
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
            }
        }
        private void txbGmail_TextChanged(object sender, EventArgs e)
        {
                txbCode.Text = "";
        }
    }
}

