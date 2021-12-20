using System;

namespace Tetris
{
    partial class Tetris_Mulltiplayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris_Mulltiplayer));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.txtMess = new System.Windows.Forms.TextBox();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.lstMess = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbPlayReady = new System.Windows.Forms.Label();
            this.lbConnect = new System.Windows.Forms.Label();
            this.lbDisconnect = new System.Windows.Forms.Label();
            this.lbSend = new System.Windows.Forms.Label();
            this.lbScore1 = new System.Windows.Forms.Label();
            this.lbScore2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GetIP = new System.Windows.Forms.PictureBox();
            this.ptbFrame = new System.Windows.Forms.PictureBox();
            this.ptbEmiya = new System.Windows.Forms.PictureBox();
            this.ptbGil = new System.Windows.Forms.PictureBox();
            this.ptbRandom = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GetIP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmiya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRandom)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // txtMess
            // 
            this.txtMess.BackColor = System.Drawing.Color.IndianRed;
            this.txtMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMess.ForeColor = System.Drawing.Color.Aqua;
            this.txtMess.Location = new System.Drawing.Point(16, 664);
            this.txtMess.Margin = new System.Windows.Forms.Padding(4);
            this.txtMess.Name = "txtMess";
            this.txtMess.Size = new System.Drawing.Size(1196, 30);
            this.txtMess.TabIndex = 0;
            this.txtMess.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMess_KeyDown);
            this.txtMess.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMess_KeyUp);
            // 
            // txtIP
            // 
            this.txtIP.BackColor = System.Drawing.Color.Turquoise;
            this.txtIP.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIP.ForeColor = System.Drawing.Color.SeaGreen;
            this.txtIP.Location = new System.Drawing.Point(1100, 331);
            this.txtIP.Margin = new System.Windows.Forms.Padding(4);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(117, 30);
            this.txtIP.TabIndex = 3;
            this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
            // 
            // txtPort
            // 
            this.txtPort.BackColor = System.Drawing.Color.LightGreen;
            this.txtPort.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPort.ForeColor = System.Drawing.Color.DarkCyan;
            this.txtPort.Location = new System.Drawing.Point(1101, 289);
            this.txtPort.Margin = new System.Windows.Forms.Padding(4);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(116, 32);
            this.txtPort.TabIndex = 4;
            this.txtPort.Text = "9999";
            this.txtPort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPort_KeyPress);
            // 
            // lstMess
            // 
            this.lstMess.BackColor = System.Drawing.Color.DarkRed;
            this.lstMess.BackgroundImageTiled = true;
            this.lstMess.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstMess.Enabled = false;
            this.lstMess.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMess.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.lstMess.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstMess.HideSelection = false;
            this.lstMess.Location = new System.Drawing.Point(16, 697);
            this.lstMess.Margin = new System.Windows.Forms.Padding(4);
            this.lstMess.MultiSelect = false;
            this.lstMess.Name = "lstMess";
            this.lstMess.Scrollable = false;
            this.lstMess.Size = new System.Drawing.Size(1251, 107);
            this.lstMess.TabIndex = 5;
            this.lstMess.UseCompatibleStateImageBehavior = false;
            this.lstMess.View = System.Windows.Forms.View.List;
            this.lstMess.Click += new System.EventHandler(this.lstMess_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MESSAGE";
            this.columnHeader1.Width = 917;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.DimGray;
            this.lbStatus.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.Color.Snow;
            this.lbStatus.Location = new System.Drawing.Point(1108, 427);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 18);
            this.lbStatus.TabIndex = 7;
            // 
            // lbPlayReady
            // 
            this.lbPlayReady.BackColor = System.Drawing.Color.Beige;
            this.lbPlayReady.Enabled = false;
            this.lbPlayReady.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlayReady.ForeColor = System.Drawing.Color.Black;
            this.lbPlayReady.Location = new System.Drawing.Point(1152, 460);
            this.lbPlayReady.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPlayReady.Name = "lbPlayReady";
            this.lbPlayReady.Size = new System.Drawing.Size(85, 33);
            this.lbPlayReady.TabIndex = 11;
            this.lbPlayReady.Text = "Ready";
            this.lbPlayReady.Click += new System.EventHandler(this.lbPlayReady_Click);
            // 
            // lbConnect
            // 
            this.lbConnect.AutoSize = true;
            this.lbConnect.BackColor = System.Drawing.Color.Beige;
            this.lbConnect.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConnect.ForeColor = System.Drawing.Color.Black;
            this.lbConnect.Location = new System.Drawing.Point(1047, 460);
            this.lbConnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConnect.Name = "lbConnect";
            this.lbConnect.Size = new System.Drawing.Size(97, 29);
            this.lbConnect.TabIndex = 12;
            this.lbConnect.Text = "Connect";
            this.lbConnect.Click += new System.EventHandler(this.lbConnect_Click);
            // 
            // lbDisconnect
            // 
            this.lbDisconnect.AutoSize = true;
            this.lbDisconnect.BackColor = System.Drawing.Color.Beige;
            this.lbDisconnect.Enabled = false;
            this.lbDisconnect.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDisconnect.ForeColor = System.Drawing.Color.Black;
            this.lbDisconnect.Location = new System.Drawing.Point(1047, 506);
            this.lbDisconnect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDisconnect.Name = "lbDisconnect";
            this.lbDisconnect.Size = new System.Drawing.Size(127, 29);
            this.lbDisconnect.TabIndex = 13;
            this.lbDisconnect.Text = "Disconnect";
            this.lbDisconnect.Click += new System.EventHandler(this.lbDisconnect_Click);
            // 
            // lbSend
            // 
            this.lbSend.AutoSize = true;
            this.lbSend.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbSend.Enabled = false;
            this.lbSend.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSend.Location = new System.Drawing.Point(1220, 670);
            this.lbSend.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSend.Name = "lbSend";
            this.lbSend.Size = new System.Drawing.Size(47, 23);
            this.lbSend.TabIndex = 14;
            this.lbSend.Text = "Send";
            this.lbSend.Click += new System.EventHandler(this.lbSend_Click);
            // 
            // lbScore1
            // 
            this.lbScore1.AutoSize = true;
            this.lbScore1.BackColor = System.Drawing.Color.Transparent;
            this.lbScore1.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore1.ForeColor = System.Drawing.Color.White;
            this.lbScore1.Location = new System.Drawing.Point(323, 9);
            this.lbScore1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore1.Name = "lbScore1";
            this.lbScore1.Size = new System.Drawing.Size(29, 31);
            this.lbScore1.TabIndex = 16;
            this.lbScore1.Text = "0";
            // 
            // lbScore2
            // 
            this.lbScore2.AutoSize = true;
            this.lbScore2.BackColor = System.Drawing.Color.Transparent;
            this.lbScore2.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScore2.ForeColor = System.Drawing.Color.White;
            this.lbScore2.Location = new System.Drawing.Point(852, 9);
            this.lbScore2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScore2.Name = "lbScore2";
            this.lbScore2.Size = new System.Drawing.Size(29, 31);
            this.lbScore2.TabIndex = 17;
            this.lbScore2.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(1045, 293);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "PORT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Turquoise;
            this.label2.Location = new System.Drawing.Point(1064, 334);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 24);
            this.label2.TabIndex = 20;
            this.label2.Text = "IP";
            // 
            // GetIP
            // 
            this.GetIP.BackColor = System.Drawing.Color.Transparent;
            this.GetIP.Image = global::Tetris.Properties.Resources.hiclipart_com__49_1;
            this.GetIP.Location = new System.Drawing.Point(1224, 334);
            this.GetIP.Name = "GetIP";
            this.GetIP.Size = new System.Drawing.Size(23, 24);
            this.GetIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.GetIP.TabIndex = 18;
            this.GetIP.TabStop = false;
            this.GetIP.Click += new System.EventHandler(this.GetIP_Click);
            // 
            // ptbFrame
            // 
            this.ptbFrame.BackColor = System.Drawing.Color.Transparent;
            this.ptbFrame.Image = global::Tetris.Properties.Resources.pngkin_com_frame_png_73320;
            this.ptbFrame.Location = new System.Drawing.Point(1005, 203);
            this.ptbFrame.Name = "ptbFrame";
            this.ptbFrame.Size = new System.Drawing.Size(276, 380);
            this.ptbFrame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbFrame.TabIndex = 21;
            this.ptbFrame.TabStop = false;
            // 
            // ptbEmiya
            // 
            this.ptbEmiya.BackColor = System.Drawing.Color.Transparent;
            this.ptbEmiya.Image = global::Tetris.Properties.Resources.Samurai;
            this.ptbEmiya.Location = new System.Drawing.Point(329, 288);
            this.ptbEmiya.Name = "ptbEmiya";
            this.ptbEmiya.Size = new System.Drawing.Size(181, 330);
            this.ptbEmiya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbEmiya.TabIndex = 22;
            this.ptbEmiya.TabStop = false;
            this.ptbEmiya.Visible = false;
            // 
            // ptbGil
            // 
            this.ptbGil.BackColor = System.Drawing.Color.Transparent;
            this.ptbGil.Image = global::Tetris.Properties.Resources.Enamies;
            this.ptbGil.Location = new System.Drawing.Point(858, 293);
            this.ptbGil.Name = "ptbGil";
            this.ptbGil.Size = new System.Drawing.Size(155, 325);
            this.ptbGil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbGil.TabIndex = 23;
            this.ptbGil.TabStop = false;
            this.ptbGil.Visible = false;
            // 
            // ptbRandom
            // 
            this.ptbRandom.BackColor = System.Drawing.Color.Transparent;
            this.ptbRandom.Image = global::Tetris.Properties.Resources.random;
            this.ptbRandom.Location = new System.Drawing.Point(1220, 293);
            this.ptbRandom.Name = "ptbRandom";
            this.ptbRandom.Size = new System.Drawing.Size(27, 25);
            this.ptbRandom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbRandom.TabIndex = 24;
            this.ptbRandom.TabStop = false;
            this.ptbRandom.Click += new System.EventHandler(this.ptbRandom_Click);
            // 
            // Tetris_Mulltiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.Background_Multi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1280, 812);
            this.Controls.Add(this.ptbRandom);
            this.Controls.Add(this.ptbGil);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.lbDisconnect);
            this.Controls.Add(this.lbConnect);
            this.Controls.Add(this.lbPlayReady);
            this.Controls.Add(this.GetIP);
            this.Controls.Add(this.txtIP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbFrame);
            this.Controls.Add(this.ptbEmiya);
            this.Controls.Add(this.lbScore2);
            this.Controls.Add(this.lbScore1);
            this.Controls.Add(this.lbSend);
            this.Controls.Add(this.lstMess);
            this.Controls.Add(this.txtMess);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Tetris_Mulltiplayer";
            this.Text = "Tetris Multiplayer";
            this.TransparencyKey = System.Drawing.Color.Magenta;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tetris_Mulltiplayer_FormClosed);
            this.Load += new System.EventHandler(this.Tetris_Mulltiplayer_Load);
            this.Shown += new System.EventHandler(this.Tetris_Mulltiplayer_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.GetIP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFrame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbEmiya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbGil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRandom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtMess;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ListView lstMess;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        internal System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label lbPlayReady;
        private System.Windows.Forms.Label lbConnect;
        private System.Windows.Forms.Label lbDisconnect;
        private System.Windows.Forms.Label lbSend;
        private System.Windows.Forms.Label lbScore1;
        private System.Windows.Forms.Label lbScore2;
        private System.Windows.Forms.PictureBox GetIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ptbFrame;
        private System.Windows.Forms.PictureBox ptbEmiya;
        private System.Windows.Forms.PictureBox ptbGil;
        private System.Windows.Forms.PictureBox ptbRandom;
    }
}

