using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlappyBirdSon
{
    public partial class Form1 : Form
    {
        // Değişkenler
        int pipeSpeed = 8;        // Boruların hızı
        int gravity = 9;         // Kuşun düşme hızı (yerçekimi)
        int score = 0;            // Skor
        bool gameOver = false;    // Oyun durumu
        public Form1()
        {
            InitializeComponent();
            GameStart(); // Oyun başlangıcı
        }
        private void gameTimerEvent(object sender, EventArgs e)
        {
            flappyBird.Top += gravity; // Kuşu yerçekimi ile aşağıya çek

            // Boruları sola hareket ettir
            pipeBottom.Left -= pipeSpeed;
            pipeTop.Left -= pipeSpeed;

            // Skoru güncelle
            scoreText.Text = "Score: " + score;

            if (pipeBottom.Left < -150)
            {
                pipeBottom.Left = 800;
                score++;
            }
            if (pipeTop.Left < -180)
            {
                pipeTop.Left = 950;
                score++;
            }
            if (score > 5)
            {
                pipeSpeed = 12;
            }

            // Çarpışma Tespiti
            if (flappyBird.Bounds.IntersectsWith(pipeBottom.Bounds) ||
                flappyBird.Bounds.IntersectsWith(pipeTop.Bounds) ||
                flappyBird.Bounds.IntersectsWith(ground.Bounds) || // Yer ile çarpışma (eğer yer resmi varsa)
                flappyBird.Top < -25 // Kuşun ekranın çok üstüne çıkmasını engelle
                )
            {
                EndGame();
            }
        }

        private void gameKeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -9; // Zıplama gücü (eksi değer yukarı gitmesini sağlar)
            }
        }

        private void gameKeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 9; // Yerçekimi eski haline döner
            }
            if (e.KeyCode == Keys.R && gameOver == true)
            {
                GameStart(); // Oyunu yeniden başlat
            }
        }
        // Oyunu başlatma veya yeniden başlatma
        private void GameStart()
        {
            score = 0;
            gravity = 15;
            pipeSpeed = 8;
            gameOver = false;
            scoreText.Text = "Score: " + score;
            gameOverText.Visible = false;

            flappyBird.Location = new Point(78, 57); // Başlangıç konumu

            // Boruları başlangıç konumlarına taşı
            pipeBottom.Location = new Point(465, 222);
            pipeTop.Location = new Point(510, -30);

            gameTimer.Start(); // Zamanlayıcıyı başlat
        }
        private void EndGame()
        {
            gameTimer.Stop(); // Zamanlayıcıyı durdur
            gameOver = true;
            gameOverText.Text = "Game Over!!! Score: " + score + Environment.NewLine + "Press R to Restart";
            gameOverText.Visible = true;
        }
    }
    }
