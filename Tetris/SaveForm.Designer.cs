
namespace Tetris
{
    partial class SaveForm
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
            this.ptbYes = new System.Windows.Forms.PictureBox();
            this.ptbNo = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbYes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbYes
            // 
            this.ptbYes.BackColor = System.Drawing.Color.Transparent;
            this.ptbYes.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.ptbYes.Image = global::Tetris.Properties.Resources.yes;
            this.ptbYes.Location = new System.Drawing.Point(399, 256);
            this.ptbYes.Name = "ptbYes";
            this.ptbYes.Size = new System.Drawing.Size(126, 47);
            this.ptbYes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbYes.TabIndex = 3;
            this.ptbYes.TabStop = false;
            this.ptbYes.Click += new System.EventHandler(this.ptbYes_Click);
            this.ptbYes.MouseLeave += new System.EventHandler(this.ptbYes_MouseLeave);
            this.ptbYes.MouseHover += new System.EventHandler(this.ptbYes_MouseHover);
            // 
            // ptbNo
            // 
            this.ptbNo.BackColor = System.Drawing.Color.Transparent;
            this.ptbNo.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.ptbNo.Image = global::Tetris.Properties.Resources.no;
            this.ptbNo.Location = new System.Drawing.Point(590, 256);
            this.ptbNo.Name = "ptbNo";
            this.ptbNo.Size = new System.Drawing.Size(109, 47);
            this.ptbNo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbNo.TabIndex = 4;
            this.ptbNo.TabStop = false;
            this.ptbNo.Click += new System.EventHandler(this.ptbNo_Click);
            this.ptbNo.MouseLeave += new System.EventHandler(this.ptbNo_MouseLeave);
            this.ptbNo.MouseHover += new System.EventHandler(this.ptbNo_MouseHover);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox3.Image = global::Tetris.Properties.Resources.SaveGame;
            this.pictureBox3.Location = new System.Drawing.Point(62, 94);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(701, 43);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::Tetris.Properties.Resources.giphy;
            this.pictureBox2.Image = global::Tetris.Properties.Resources.Byegif;
            this.pictureBox2.Location = new System.Drawing.Point(20, 164);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(337, 259);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tetris.Properties.Resources.giphy;
            this.pictureBox1.Location = new System.Drawing.Point(20, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(763, 401);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox4.Image = global::Tetris.Properties.Resources._127234887_829127167885529_2086583191965389105_n;
            this.pictureBox4.Location = new System.Drawing.Point(0, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(803, 443);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 5;
            this.pictureBox4.TabStop = false;
            // 
            // SaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(806, 446);
            this.Controls.Add(this.ptbYes);
            this.Controls.Add(this.ptbNo);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SaveForm";
            this.Text = "SAVE GAME";
            this.TransparencyKey = System.Drawing.Color.Yellow;
            ((System.ComponentModel.ISupportInitialize)(this.ptbYes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbNo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox ptbYes;
        private System.Windows.Forms.PictureBox ptbNo;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}