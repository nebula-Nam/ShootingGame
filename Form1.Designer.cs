namespace ShootingGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private PictureBox player;
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(-3, -48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(392, 841);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 761);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);

             this.player = new System.Windows.Forms.PictureBox(); // 이교현 플레이어 움직임
 ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
 this.SuspendLayout();
 // 
 // player
 // 
 this.player.BackColor = System.Drawing.Color.Transparent; // 투명 배경 설정
 this.player.Image = Properties.Resources.플레이어; // 투명 배경의 이미지 사용
 this.player.Location = new System.Drawing.Point(150, 150); // 초기 위치 설정
 this.player.Name = "player";
 this.player.Size = new System.Drawing.Size(50, 50); // 플레이어 크기 설정
 this.player.SizeMode = PictureBoxSizeMode.AutoSize;
 this.player.TabIndex = 0;
 this.player.TabStop = false;
 // 
 // Form1
 // 
 this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
 this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
 this.ClientSize = new System.Drawing.Size(400, 400);
 this.Controls.Add(this.player);
 this.Name = "Form1";
 this.Text = "Shooting Game";
 this.Load += new System.EventHandler(this.Form1_Load);
 this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
 ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
 this.ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
    }
}
