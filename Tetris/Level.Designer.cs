namespace Tetris
{
    partial class Level
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
            this.picAuto = new System.Windows.Forms.PictureBox();
            this.picEasy = new System.Windows.Forms.PictureBox();
            this.picMedium = new System.Windows.Forms.PictureBox();
            this.picHard = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEasy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHard)).BeginInit();
            this.SuspendLayout();
            // 
            // picAuto
            // 
            this.picAuto.Location = new System.Drawing.Point(44, 30);
            this.picAuto.Name = "picAuto";
            this.picAuto.Size = new System.Drawing.Size(199, 43);
            this.picAuto.TabIndex = 0;
            this.picAuto.TabStop = false;
            this.picAuto.Click += new System.EventHandler(this.picAuto_Click);
            // 
            // picEasy
            // 
            this.picEasy.Location = new System.Drawing.Point(44, 104);
            this.picEasy.Name = "picEasy";
            this.picEasy.Size = new System.Drawing.Size(199, 43);
            this.picEasy.TabIndex = 1;
            this.picEasy.TabStop = false;
            this.picEasy.Click += new System.EventHandler(this.picEasy_Click);
            // 
            // picMedium
            // 
            this.picMedium.Location = new System.Drawing.Point(44, 180);
            this.picMedium.Name = "picMedium";
            this.picMedium.Size = new System.Drawing.Size(199, 43);
            this.picMedium.TabIndex = 2;
            this.picMedium.TabStop = false;
            this.picMedium.Click += new System.EventHandler(this.picMedium_Click);
            // 
            // picHard
            // 
            this.picHard.Location = new System.Drawing.Point(44, 252);
            this.picHard.Name = "picHard";
            this.picHard.Size = new System.Drawing.Size(199, 43);
            this.picHard.TabIndex = 3;
            this.picHard.TabStop = false;
            this.picHard.Click += new System.EventHandler(this.picHard_Click);
            // 
            // Level
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 337);
            this.Controls.Add(this.picHard);
            this.Controls.Add(this.picMedium);
            this.Controls.Add(this.picEasy);
            this.Controls.Add(this.picAuto);
            this.Name = "Level";
            this.Text = "Level";
            ((System.ComponentModel.ISupportInitialize)(this.picAuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEasy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMedium)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picAuto;
        private System.Windows.Forms.PictureBox picEasy;
        private System.Windows.Forms.PictureBox picMedium;
        private System.Windows.Forms.PictureBox picHard;
    }
}