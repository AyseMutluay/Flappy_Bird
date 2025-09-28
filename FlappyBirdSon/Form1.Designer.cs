namespace FlappyBirdSon
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flappyBird = new System.Windows.Forms.PictureBox();
            this.pipeBottom = new System.Windows.Forms.PictureBox();
            this.pipeTop = new System.Windows.Forms.PictureBox();
            this.scoreText = new System.Windows.Forms.Label();
            this.gameOverText = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.ground = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            this.SuspendLayout();
            // 
            // flappyBird
            // 
            this.flappyBird.Image = ((System.Drawing.Image)(resources.GetObject("flappyBird.Image")));
            this.flappyBird.Location = new System.Drawing.Point(159, 150);
            this.flappyBird.Name = "flappyBird";
            this.flappyBird.Size = new System.Drawing.Size(78, 57);
            this.flappyBird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flappyBird.TabIndex = 0;
            this.flappyBird.TabStop = false;
            // 
            // pipeBottom
            // 
            this.pipeBottom.Image = ((System.Drawing.Image)(resources.GetObject("pipeBottom.Image")));
            this.pipeBottom.Location = new System.Drawing.Point(455, 260);
            this.pipeBottom.Name = "pipeBottom";
            this.pipeBottom.Size = new System.Drawing.Size(100, 128);
            this.pipeBottom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeBottom.TabIndex = 1;
            this.pipeBottom.TabStop = false;
            // 
            // pipeTop
            // 
            this.pipeTop.Image = ((System.Drawing.Image)(resources.GetObject("pipeTop.Image")));
            this.pipeTop.Location = new System.Drawing.Point(599, 0);
            this.pipeTop.Name = "pipeTop";
            this.pipeTop.Size = new System.Drawing.Size(100, 136);
            this.pipeTop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeTop.TabIndex = 2;
            this.pipeTop.TabStop = false;
            // 
            // scoreText
            // 
            this.scoreText.AutoSize = true;
            this.scoreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreText.Location = new System.Drawing.Point(0, 0);
            this.scoreText.Name = "scoreText";
            this.scoreText.Size = new System.Drawing.Size(82, 25);
            this.scoreText.TabIndex = 5;
            this.scoreText.Text = "Skor: 0";
            // 
            // gameOverText
            // 
            this.gameOverText.AutoSize = true;
            this.gameOverText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameOverText.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameOverText.Location = new System.Drawing.Point(243, 159);
            this.gameOverText.Name = "gameOverText";
            this.gameOverText.Size = new System.Drawing.Size(98, 32);
            this.gameOverText.TabIndex = 6;
            this.gameOverText.Text = "label1";
            this.gameOverText.Visible = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 385);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(803, 65);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 7;
            this.ground.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.gameOverText);
            this.Controls.Add(this.scoreText);
            this.Controls.Add(this.pipeTop);
            this.Controls.Add(this.pipeBottom);
            this.Controls.Add(this.flappyBird);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gameKeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.flappyBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappyBird;
        private System.Windows.Forms.PictureBox pipeBottom;
        private System.Windows.Forms.PictureBox pipeTop;
        private System.Windows.Forms.Label scoreText;
        private System.Windows.Forms.Label gameOverText;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox ground;
    }
}

