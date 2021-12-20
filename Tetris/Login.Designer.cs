namespace Account
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnlogin = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.ForgotPss = new System.Windows.Forms.Label();
            this.SignUp = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.DOG = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbGuess = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(39, 137);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(39, 228);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUsername.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.Orange;
            this.txtUsername.Location = new System.Drawing.Point(167, 140);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(354, 25);
            this.txtUsername.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.Orange;
            this.txtPassword.Location = new System.Drawing.Point(167, 228);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(354, 25);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.Red;
            this.btnlogin.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlogin.ForeColor = System.Drawing.Color.Aqua;
            this.btnlogin.Location = new System.Drawing.Point(183, 282);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(109, 42);
            this.btnlogin.TabIndex = 3;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Red;
            this.btnexit.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnexit.ForeColor = System.Drawing.Color.Aqua;
            this.btnexit.Location = new System.Drawing.Point(395, 282);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(109, 42);
            this.btnexit.TabIndex = 4;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // ForgotPss
            // 
            this.ForgotPss.AutoSize = true;
            this.ForgotPss.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPss.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPss.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPss.ForeColor = System.Drawing.Color.Aqua;
            this.ForgotPss.Location = new System.Drawing.Point(391, 345);
            this.ForgotPss.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ForgotPss.Name = "ForgotPss";
            this.ForgotPss.Size = new System.Drawing.Size(129, 25);
            this.ForgotPss.TabIndex = 7;
            this.ForgotPss.Text = "ForgotPass?";
            this.ForgotPss.Click += new System.EventHandler(this.ForgotPss_Click);
            // 
            // SignUp
            // 
            this.SignUp.AutoSize = true;
            this.SignUp.BackColor = System.Drawing.Color.Transparent;
            this.SignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUp.ForeColor = System.Drawing.Color.Aqua;
            this.SignUp.Location = new System.Drawing.Point(145, 345);
            this.SignUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(182, 25);
            this.SignUp.TabIndex = 8;
            this.SignUp.Text = "Create account!!!";
            this.SignUp.Click += new System.EventHandler(this.SignUp_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Red;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Aqua;
            this.label3.Location = new System.Drawing.Point(248, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 54);
            this.label3.TabIndex = 10;
            this.label3.Text = "LOGIN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.Chim;
            this.pictureBox1.Location = new System.Drawing.Point(101, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // DOG
            // 
            this.DOG.BackColor = System.Drawing.Color.Transparent;
            this.DOG.Image = global::Tetris.Properties.Resources.Jake;
            this.DOG.Location = new System.Drawing.Point(467, 30);
            this.DOG.Margin = new System.Windows.Forms.Padding(4);
            this.DOG.Name = "DOG";
            this.DOG.Size = new System.Drawing.Size(83, 74);
            this.DOG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DOG.TabIndex = 9;
            this.DOG.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tetris.Properties.Resources.giphy;
            this.pictureBox2.Location = new System.Drawing.Point(4, 5);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(573, 374);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // lbGuess
            // 
            this.lbGuess.BackColor = System.Drawing.Color.Transparent;
            this.lbGuess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbGuess.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGuess.ForeColor = System.Drawing.Color.Aqua;
            this.lbGuess.Location = new System.Drawing.Point(13, 345);
            this.lbGuess.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbGuess.Name = "lbGuess";
            this.lbGuess.Size = new System.Drawing.Size(91, 25);
            this.lbGuess.TabIndex = 13;
            this.lbGuess.Text = "Guess";
            this.lbGuess.Click += new System.EventHandler(this.lbGuess_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.btnlogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.ClientSize = new System.Drawing.Size(580, 384);
            this.Controls.Add(this.lbGuess);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DOG);
            this.Controls.Add(this.SignUp);
            this.Controls.Add(this.ForgotPss);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DOG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label ForgotPss;
        private System.Windows.Forms.Label SignUp;
        private System.Windows.Forms.PictureBox DOG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbGuess;
    }
}

