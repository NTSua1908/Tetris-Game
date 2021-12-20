namespace Account
{
    partial class ForgotPass
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gmailtxb = new System.Windows.Forms.TextBox();
            this.codetxb = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.btnverify = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Aqua;
            this.label1.Location = new System.Drawing.Point(13, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registed Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Aqua;
            this.label2.Location = new System.Drawing.Point(92, 172);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // gmailtxb
            // 
            this.gmailtxb.BackColor = System.Drawing.SystemColors.ControlText;
            this.gmailtxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailtxb.ForeColor = System.Drawing.Color.OrangeRed;
            this.gmailtxb.Location = new System.Drawing.Point(150, 69);
            this.gmailtxb.Margin = new System.Windows.Forms.Padding(4);
            this.gmailtxb.Name = "gmailtxb";
            this.gmailtxb.Size = new System.Drawing.Size(297, 27);
            this.gmailtxb.TabIndex = 1;
            this.gmailtxb.Enter += new System.EventHandler(this.gmailtxb_Enter);
            this.gmailtxb.Leave += new System.EventHandler(this.gmailtxb_Leave);
            // 
            // codetxb
            // 
            this.codetxb.BackColor = System.Drawing.SystemColors.InfoText;
            this.codetxb.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codetxb.ForeColor = System.Drawing.Color.OrangeRed;
            this.codetxb.Location = new System.Drawing.Point(150, 170);
            this.codetxb.Margin = new System.Windows.Forms.Padding(4);
            this.codetxb.Name = "codetxb";
            this.codetxb.Size = new System.Drawing.Size(224, 27);
            this.codetxb.TabIndex = 2;
            this.codetxb.Enter += new System.EventHandler(this.codetxb_Enter);
            this.codetxb.Leave += new System.EventHandler(this.codetxb_Leave);
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.Red;
            this.btnsend.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsend.ForeColor = System.Drawing.Color.MintCream;
            this.btnsend.Location = new System.Drawing.Point(150, 109);
            this.btnsend.Margin = new System.Windows.Forms.Padding(4);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(100, 30);
            this.btnsend.TabIndex = 4;
            this.btnsend.Text = "SEND";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // btnverify
            // 
            this.btnverify.BackColor = System.Drawing.Color.Red;
            this.btnverify.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnverify.ForeColor = System.Drawing.Color.MintCream;
            this.btnverify.Location = new System.Drawing.Point(382, 170);
            this.btnverify.Margin = new System.Windows.Forms.Padding(4);
            this.btnverify.Name = "btnverify";
            this.btnverify.Size = new System.Drawing.Size(80, 30);
            this.btnverify.TabIndex = 5;
            this.btnverify.Text = "VERIFY\r\n";
            this.btnverify.UseVisualStyleBackColor = false;
            this.btnverify.Click += new System.EventHandler(this.btnverify_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.hiclipart_com__49_;
            this.pictureBox1.Location = new System.Drawing.Point(431, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Tetris.Properties.Resources.question;
            this.pictureBox2.Location = new System.Drawing.Point(1, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // ForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.Back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 290);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnverify);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.codetxb);
            this.Controls.Add(this.gmailtxb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ForgotPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgotPass";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gmailtxb;
        private System.Windows.Forms.TextBox codetxb;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Button btnverify;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}