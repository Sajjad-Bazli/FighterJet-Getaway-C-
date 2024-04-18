using FighterJet_Getaway.Properties;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

using System;
using System.IO;
using System.Windows.Forms;

namespace FighterJet_Getaway
{
    public partial class Form1 : Form
    {
        bool goLeft, goRight, shooting, isGameOver, rooh = false, skin = false, skin2 = false;
        int score, score3 = 0, bishtarinScore = 0;
        int playerSpeed = 12, enemySpeed, bulletspeed;
        int enemySpeedIncrement = 2;
        int scoreThreshold = 5;
        Random rnd = new Random();

        public Form1()
        {
            List<PictureBox> bullets = new List<PictureBox>();
            InitializeComponent();
            LoadBishtarinScore();
            resetGame();
        }

        private void LoadBishtarinScore()
        {
            if (File.Exists("bishtarinScore.txt"))
            {
                string scoreText = File.ReadAllText("bishtarinScore.txt");
                int.TryParse(scoreText, out bishtarinScore);
                bishtarin.Text = bishtarinScore.ToString();
            }
        }
        private void SaveBishtarinScore()
        {
            File.WriteAllText("bishtarinScore.txt", bishtarinScore.ToString());
        }

        private void mainTimerGameEvent(object sender, EventArgs e)
        {

            if (score3 >= 5)
            {
                this.BackColor = Color.DimGray;
                soboshab.Image = Properties.Resources.moon;
            }
            if (score3 >= 10)
            {
                this.BackColor = Color.Orange;
                soboshab.Image = Properties.Resources.sun;
                score3 = 0;
            }

            score2.Text = score.ToString();

            enemy1.Top += enemySpeed;
            enemy2.Top += enemySpeed;
            enemy3.Top += enemySpeed;
            helthplus.Top += enemySpeed;
            star1.Top += enemySpeed;
            star2.Top += enemySpeed;
            star3.Top += enemySpeed;
            star4.Top += enemySpeed;


            if (enemy1.Top > 666)
            {
                enemy1.Top = -700;
                enemy1.Left = rnd.Next(20, 600);
                //enemy2.Top = -450;
                //enemy2.Left = rnd.Next(20, 600);
                //enemy3.Top = -800;
                //enemy3.Left = rnd.Next(20, 600);
            }
            else if (enemy2.Top > 666)
            {
                enemy2.Top = -450;
                enemy2.Left = rnd.Next(20, 600);
            }
            else if (enemy3.Top > 666)
            {
                enemy3.Top = -800;
                enemy3.Left = rnd.Next(20, 600);
            }
            if (star1.Top > 666)
            {
                star1.Top = -800;
                star1.Left = (740);

            }
            else if (star2.Top > 666)
            {
                star2.Top = -800;
                star2.Left = (740);
            }
            else if (star3.Top > 666)
            {
                star3.Top = -800;
                star3.Left = (12);
            }
            else if (star4.Top > 666)
            {
                star4.Top = -800;
                star4.Left = (12);
            }

            if (helthplus.Top > 666)
            {
                helthplus.Top = -450;
                helthplus.Left = rnd.Next(20, 600);
            }

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Right < 793)
            {
                player.Left += playerSpeed;
            }

            if (shooting == true)
            {
                bulletspeed = 20;
                Bullet.Top -= bulletspeed;
            }
            else
            {
                Bullet.Left = -300;
                bulletspeed = 0;
            }

            if (Bullet.Top < -30)
            {
                shooting = false;
            }
            if (Bullet.Bounds.IntersectsWith(enemy1.Bounds))
            {

                score += 1;
                score3 += 1;
                enemy1.Top = -450;
                enemy1.Left = rnd.Next(20, 600);
                shooting = false;
            }
            else if (Bullet.Bounds.IntersectsWith(enemy2.Bounds))
            {
                score += 1;
                score3 += 1;
                enemy2.Top = -450;
                enemy2.Left = rnd.Next(20, 600);
                shooting = false;
            }
            else if (Bullet.Bounds.IntersectsWith(enemy3.Bounds))
            {
                score += 1;
                score3 += 1;
                enemy3.Top = -450;
                enemy3.Left = rnd.Next(20, 600);
                shooting = false;
            }
            if (score3 >= scoreThreshold)
            {
                enemySpeed += enemySpeedIncrement;
                scoreThreshold += 5;

            }
            if (!rooh)
            {

                if (player.Bounds.IntersectsWith(enemy1.Bounds))
                {
                    if (helth3.Visible)
                    {
                        helth3.Visible = false;
                        helth2.Image = Properties.Resources.helth2;
                        helth1.Image = Properties.Resources.helth2;
                    }
                    else if (helth2.Visible)
                    {
                        helth2.Visible = false;
                        helth1.Image = Properties.Resources.helth1;
                    }
                    else if (helth1.Visible)
                    {
                        helth1.Visible = false;
                        gameOver();
                    }
                    enemy1.Top = -450;
                    enemy1.Left = rnd.Next(20, 600);
                }
                else if (player.Bounds.IntersectsWith(enemy2.Bounds))
                {
                    if (helth3.Visible)
                    {
                        helth3.Visible = false;
                        helth2.Image = Properties.Resources.helth2;
                        helth1.Image = Properties.Resources.helth2;
                    }
                    else if (helth2.Visible)
                    {
                        helth2.Visible = false;
                        helth1.Image = Properties.Resources.helth1;
                    }
                    else if (helth1.Visible)
                    {
                        helth1.Visible = false;
                        gameOver();
                    }
                    enemy2.Top = -450;
                    enemy2.Left = rnd.Next(20, 600);
                }
                else if (player.Bounds.IntersectsWith(enemy3.Bounds))
                {
                    if (helth3.Visible)
                    {
                        helth3.Visible = false;
                        helth2.Image = Properties.Resources.helth2;
                        helth1.Image = Properties.Resources.helth2;
                    }
                    else if (helth2.Visible)
                    {
                        helth2.Visible = false;
                        helth1.Image = Properties.Resources.helth1;
                    }
                    else if (helth1.Visible)
                    {
                        helth1.Visible = false;
                        gameOver();
                    }

                    enemy3.Top = -450;
                    enemy3.Left = rnd.Next(20, 600);
                }
            }
            if (player.Bounds.IntersectsWith(helthplus.Bounds))
            {
                if (!helth2.Visible)
                {
                    helth2.Visible = true;
                    helth1.Image = Properties.Resources.helth2;
                    helth2.Image = Properties.Resources.helth2;
                }
                else if (!helth3.Visible)
                {
                    helth3.Visible = true;
                    helth1.Image = Properties.Resources.helth3;
                    helth2.Image = Properties.Resources.helth3;
                    helth3.Image = Properties.Resources.helth3;
                }

                helthplus.Top = -450;
                helthplus.Left = rnd.Next(20, 600);
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }

            if (e.KeyCode == Keys.Z)
            {
                rooh = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Space)
            {
                shooting = true;

                Bullet.Top = player.Top - 30;
                Bullet.Left = player.Left + (player.Width / 2);
            }
            else if (e.KeyCode == Keys.Enter && isGameOver == true)
            {
                if (txtScore.Text == Environment.NewLine + "Game Over" + Environment.NewLine + "Press Enter to try again.")
                {
                    helth1.Image = Properties.Resources.helth3;
                    helth2.Image = Properties.Resources.helth3;
                    helth3.Image = Properties.Resources.helth3;
                    helth1.Visible = true;
                    helth2.Visible = true;
                    helth3.Visible = true;
                    resetGame();
                }
            }

            else if (e.KeyCode == Keys.Z)
            {
                rooh = false;
            }
        }
        private void resetGame()
        {

            gameTimer.Start();
            scoreThreshold = 5;
            enemySpeed = 6;
            bulletspeed = 0;
            scoreThreshold = 5;

            enemy1.Left = rnd.Next(20, 600);
            enemy2.Left = rnd.Next(20, 600);
            enemy3.Left = rnd.Next(20, 600);
            helthplus.Left = rnd.Next(20, 600);

            enemy1.Top = rnd.Next(0, 200) * -1;
            enemy2.Top = rnd.Next(0, 500) * -1;
            enemy3.Top = rnd.Next(0, 900) * -1;
            helthplus.Top = rnd.Next(0, 900) * -1;

            score3 = 0;
            score = 0;
            Bullet.Left = -300;
            shooting = false;
            txtScore.Text = score == 0 ? "" : score.ToString();


        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            txtScore.Text += Environment.NewLine + "Game Over" + Environment.NewLine + "Press Enter to try again.";

            if (score > bishtarinScore)
            {
                bishtarinScore = score;
            }
            bishtarin.Text = bishtarinScore.ToString();
            SaveBishtarinScore();
        }
        private void scorsc_Tick(object sender, EventArgs e)
        {
            score3 += 1;
            score += 1;
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.player;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            skin = true;
            if (skin == true && skin2 == true)
            {
                gameTimer.Start();
            }
        }

        private void skin_Click(object sender, EventArgs e)
        {
            player.Image = Properties.Resources.player2;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            skin = true;
            if (skin == true && skin2 == true)
            {
                gameTimer.Start();
            }
        }

        private void skinbullet1_Click(object sender, EventArgs e)
        {
            Bullet.Image = Properties.Resources.bullet2;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            skin2 = true;
            if (skin == true && skin2 == true)
            {
                gameTimer.Start();
            }
        }

        private void skinbullet2_Click(object sender, EventArgs e)
        {
            Bullet.Image = Properties.Resources.bullet;
            pictureBox4.Visible = false;
            pictureBox3.Visible = false;
            skin2 = true;
            if (skin == true && skin2 == true)
            {
                gameTimer.Start();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gameTimer.Stop();
            MaximizeBox = false;
            MinimizeBox = false;
        }
    }
}