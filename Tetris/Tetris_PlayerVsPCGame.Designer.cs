using System;

namespace Tetris
{
    partial class Tetris_PlayerVsPCGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tetris_PlayerVsPCGame));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbScorePC = new System.Windows.Forms.Label();
            this.lbScorePlayer = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ptbCD = new System.Windows.Forms.PictureBox();
            this.CD = new System.Windows.Forms.Timer(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // lbScorePC
            // 
            this.lbScorePC.AutoSize = true;
            this.lbScorePC.BackColor = System.Drawing.Color.Transparent;
            this.lbScorePC.Font = new System.Drawing.Font("DRAguSans-BlackItalic", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScorePC.ForeColor = System.Drawing.SystemColors.Control;
            this.lbScorePC.Location = new System.Drawing.Point(1063, 0);
            this.lbScorePC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScorePC.Name = "lbScorePC";
            this.lbScorePC.Size = new System.Drawing.Size(31, 35);
            this.lbScorePC.TabIndex = 0;
            this.lbScorePC.Text = "0";
            // 
            // lbScorePlayer
            // 
            this.lbScorePlayer.AutoSize = true;
            this.lbScorePlayer.BackColor = System.Drawing.Color.Transparent;
            this.lbScorePlayer.Font = new System.Drawing.Font("Dubai", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScorePlayer.ForeColor = System.Drawing.SystemColors.Control;
            this.lbScorePlayer.Location = new System.Drawing.Point(387, 0);
            this.lbScorePlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbScorePlayer.Name = "lbScorePlayer";
            this.lbScorePlayer.Size = new System.Drawing.Size(35, 48);
            this.lbScorePlayer.TabIndex = 1;
            this.lbScorePlayer.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Tetris.Properties.Resources.Pro_Gamer;
            this.pictureBox1.Location = new System.Drawing.Point(384, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(135, 149);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Tetris.Properties.Resources.BMO_avatar;
            this.pictureBox2.Location = new System.Drawing.Point(1059, 38);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(123, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // ptbCD
            // 
            this.ptbCD.BackColor = System.Drawing.Color.Transparent;
            this.ptbCD.Image = global::Tetris.Properties.Resources.countdown;
            this.ptbCD.Location = new System.Drawing.Point(384, 193);
            this.ptbCD.Name = "ptbCD";
            this.ptbCD.Size = new System.Drawing.Size(351, 354);
            this.ptbCD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCD.TabIndex = 4;
            this.ptbCD.TabStop = false;
            this.ptbCD.Visible = false;
            // 
            // CD
            // 
            this.CD.Tick += new System.EventHandler(this.CD_Tick);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Tetris.Properties.Resources.hiclipart_com__49_;
            this.pictureBox3.Location = new System.Drawing.Point(1243, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 34);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Tetris_PlayerVsPCGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tetris.Properties.Resources.BGAI;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1281, 760);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ptbCD);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbScorePlayer);
            this.Controls.Add(this.lbScorePC);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Tetris_PlayerVsPCGame";
            this.Text = "TetrisAI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Tetris_PlayerVsPCGame_FormClosed);
            this.Load += new System.EventHandler(this.Tetris_PlayerVsPCGame_Load);
            this.Shown += new System.EventHandler(this.Tetris_PlayerVsPCGame_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Tetris_PlayerVsPCGame_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Tetris_PlayerVsPCGame_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbScorePC;
        private System.Windows.Forms.Label lbScorePlayer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox ptbCD;
        private System.Windows.Forms.Timer CD;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

