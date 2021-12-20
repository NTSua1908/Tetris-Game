namespace MENU
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.ptbNoContinue = new System.Windows.Forms.PictureBox();
            this.Continue = new System.Windows.Forms.PictureBox();
            this.Option = new System.Windows.Forms.PictureBox();
            this.SFX = new AxWMPLib.AxWindowsMediaPlayer();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoContinue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Option)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.lbName);
            this.panel1.Controls.Add(this.ptbNoContinue);
            this.panel1.Controls.Add(this.Continue);
            this.panel1.Controls.Add(this.Option);
            this.panel1.Controls.Add(this.SFX);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 935);
            this.panel1.TabIndex = 0;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.BackColor = System.Drawing.Color.Transparent;
            this.lbName.Location = new System.Drawing.Point(580, 17);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 17);
            this.lbName.TabIndex = 17;
            this.lbName.Text = "label";
            // 
            // ptbNoContinue
            // 
            this.ptbNoContinue.BackColor = System.Drawing.Color.Transparent;
            this.ptbNoContinue.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.ptbNoContinue.Image = global::Tetris.Properties.Resources.COUNTINUE;
            this.ptbNoContinue.Location = new System.Drawing.Point(3, 241);
            this.ptbNoContinue.Name = "ptbNoContinue";
            this.ptbNoContinue.Size = new System.Drawing.Size(336, 64);
            this.ptbNoContinue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNoContinue.TabIndex = 16;
            this.ptbNoContinue.TabStop = false;
            this.ptbNoContinue.Click += new System.EventHandler(this.ptbNoContinue_Click);
            // 
            // Continue
            // 
            this.Continue.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.Continue.Image = global::Tetris.Properties.Resources.COUNTINUEnm;
            this.Continue.Location = new System.Drawing.Point(4, 240);
            this.Continue.Name = "Continue";
            this.Continue.Size = new System.Drawing.Size(339, 65);
            this.Continue.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Continue.TabIndex = 15;
            this.Continue.TabStop = false;
            this.Continue.Visible = false;
            this.Continue.Click += new System.EventHandler(this.Continue_Click);
            this.Continue.MouseLeave += new System.EventHandler(this.Continue_MouseLeave);
            this.Continue.MouseHover += new System.EventHandler(this.Continue_MouseHover);
            // 
            // Option
            // 
            this.Option.BackColor = System.Drawing.Color.Transparent;
            this.Option.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.Option.Image = global::Tetris.Properties.Resources.OPTION;
            this.Option.Location = new System.Drawing.Point(-1, 386);
            this.Option.Name = "Option";
            this.Option.Size = new System.Drawing.Size(306, 58);
            this.Option.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Option.TabIndex = 14;
            this.Option.TabStop = false;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            this.Option.MouseLeave += new System.EventHandler(this.Option_MouseLeave);
            this.Option.MouseHover += new System.EventHandler(this.Option_MouseHover);
            // 
            // SFX
            // 
            this.SFX.Enabled = true;
            this.SFX.Location = new System.Drawing.Point(5, 518);
            this.SFX.Name = "SFX";
            this.SFX.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("SFX.OcxState")));
            this.SFX.Size = new System.Drawing.Size(75, 23);
            this.SFX.TabIndex = 11;
            this.SFX.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Black;
            this.pictureBox8.Image = global::Tetris.Properties.Resources.hiclipart_com__48_;
            this.pictureBox8.Location = new System.Drawing.Point(655, 501);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(49, 39);
            this.pictureBox8.TabIndex = 8;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox7.Image = global::Tetris.Properties.Resources.Off;
            this.pictureBox7.Location = new System.Drawing.Point(657, 501);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(47, 38);
            this.pictureBox7.TabIndex = 7;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox9.Image = global::Tetris.Properties.Resources.Y3il;
            this.pictureBox9.Location = new System.Drawing.Point(79, 0);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(73, 62);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 10;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox6.Image = global::Tetris.Properties.Resources.Menu_gif;
            this.pictureBox6.Location = new System.Drawing.Point(346, 164);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(359, 389);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox5.Image = global::Tetris.Properties.Resources.Exit1;
            this.pictureBox5.Location = new System.Drawing.Point(3, 451);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(305, 59);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            this.pictureBox5.MouseLeave += new System.EventHandler(this.pictureBox5_MouseLeave);
            this.pictureBox5.MouseHover += new System.EventHandler(this.pictureBox5_MouseHover);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox4.Image = global::Tetris.Properties.Resources.Play1;
            this.pictureBox4.Location = new System.Drawing.Point(4, 180);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(305, 53);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            this.pictureBox4.MouseLeave += new System.EventHandler(this.pictureBox4_MouseLeave);
            this.pictureBox4.MouseHover += new System.EventHandler(this.pictureBox4_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox3.Image = global::Tetris.Properties.Resources.Leaderboard1;
            this.pictureBox3.Location = new System.Drawing.Point(0, 312);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(343, 67);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            this.pictureBox3.MouseLeave += new System.EventHandler(this.pictureBox3_MouseLeave);
            this.pictureBox3.MouseHover += new System.EventHandler(this.pictureBox3_MouseHover);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox2.Image = global::Tetris.Properties.Resources.Tettris;
            this.pictureBox2.Location = new System.Drawing.Point(4, 61);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(451, 97);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tetris.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 763);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(4, 412);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(75, 23);
            this.axWindowsMediaPlayer1.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.ClientSize = new System.Drawing.Size(717, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tetris";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNoContinue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Continue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Option)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private AxWMPLib.AxWindowsMediaPlayer SFX;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox Option;
        private System.Windows.Forms.PictureBox Continue;
        private System.Windows.Forms.PictureBox ptbNoContinue;
        private System.Windows.Forms.Label lbName;
    }
}

