namespace FighterJet_Getaway
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            gameTimer = new System.Windows.Forms.Timer(components);
            enemy1 = new PictureBox();
            Bullet = new PictureBox();
            enemy2 = new PictureBox();
            enemy3 = new PictureBox();
            player = new PictureBox();
            txtScore = new Label();
            helth1 = new PictureBox();
            helth2 = new PictureBox();
            helth3 = new PictureBox();
            helthplus = new PictureBox();
            score2 = new Label();
            scorsc = new System.Windows.Forms.Timer(components);
            bishtarin = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            soboshab = new PictureBox();
            star1 = new PictureBox();
            star2 = new PictureBox();
            star3 = new PictureBox();
            star4 = new PictureBox();
            EmfejaR = new System.Windows.Forms.Timer(components);
            explosionTimer = new System.Windows.Forms.Timer(components);
            Enfejar = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)enemy1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helth1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helth2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helth3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)helthplus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)soboshab).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Enfejar).BeginInit();
            SuspendLayout();
            // 
            // gameTimer
            // 
            gameTimer.Interval = 20;
            gameTimer.Tick += mainTimerGameEvent;
            // 
            // enemy1
            // 
            enemy1.BackColor = Color.Transparent;
            enemy1.Image = Properties.Resources.enemy;
            enemy1.Location = new Point(42, 18);
            enemy1.Name = "enemy1";
            enemy1.Size = new Size(100, 85);
            enemy1.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy1.TabIndex = 0;
            enemy1.TabStop = false;
            // 
            // Bullet
            // 
            Bullet.BackColor = Color.Transparent;
            Bullet.Location = new Point(397, 470);
            Bullet.Name = "Bullet";
            Bullet.Size = new Size(7, 27);
            Bullet.SizeMode = PictureBoxSizeMode.AutoSize;
            Bullet.TabIndex = 1;
            Bullet.TabStop = false;
            // 
            // enemy2
            // 
            enemy2.BackColor = Color.Transparent;
            enemy2.Image = Properties.Resources.enemy;
            enemy2.Location = new Point(346, 17);
            enemy2.Name = "enemy2";
            enemy2.Size = new Size(100, 85);
            enemy2.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy2.TabIndex = 1;
            enemy2.TabStop = false;
            // 
            // enemy3
            // 
            enemy3.BackColor = Color.Transparent;
            enemy3.Image = Properties.Resources.enemy;
            enemy3.Location = new Point(638, 18);
            enemy3.Name = "enemy3";
            enemy3.Size = new Size(100, 85);
            enemy3.SizeMode = PictureBoxSizeMode.AutoSize;
            enemy3.TabIndex = 2;
            enemy3.TabStop = false;
            // 
            // player
            // 
            player.BackColor = Color.Transparent;
            player.Location = new Point(346, 503);
            player.Name = "player";
            player.Size = new Size(110, 98);
            player.SizeMode = PictureBoxSizeMode.AutoSize;
            player.TabIndex = 3;
            player.TabStop = false;
            // 
            // txtScore
            // 
            txtScore.BackColor = Color.Transparent;
            txtScore.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtScore.Location = new Point(0, 177);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(800, 200);
            txtScore.TabIndex = 4;
            txtScore.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // helth1
            // 
            helth1.BackColor = Color.Transparent;
            helth1.Image = Properties.Resources.helth3;
            helth1.Location = new Point(16, 580);
            helth1.Name = "helth1";
            helth1.Size = new Size(38, 38);
            helth1.SizeMode = PictureBoxSizeMode.AutoSize;
            helth1.TabIndex = 5;
            helth1.TabStop = false;
            // 
            // helth2
            // 
            helth2.BackColor = Color.Transparent;
            helth2.Image = Properties.Resources.helth3;
            helth2.Location = new Point(60, 580);
            helth2.Name = "helth2";
            helth2.Size = new Size(38, 38);
            helth2.SizeMode = PictureBoxSizeMode.AutoSize;
            helth2.TabIndex = 6;
            helth2.TabStop = false;
            // 
            // helth3
            // 
            helth3.BackColor = Color.Transparent;
            helth3.Image = Properties.Resources.helth3;
            helth3.Location = new Point(104, 580);
            helth3.Name = "helth3";
            helth3.Size = new Size(38, 38);
            helth3.SizeMode = PictureBoxSizeMode.AutoSize;
            helth3.TabIndex = 7;
            helth3.TabStop = false;
            // 
            // helthplus
            // 
            helthplus.BackColor = Color.Transparent;
            helthplus.Image = Properties.Resources._11zon_resized__4_2;
            helthplus.Location = new Point(378, 150);
            helthplus.Name = "helthplus";
            helthplus.Size = new Size(38, 38);
            helthplus.SizeMode = PictureBoxSizeMode.AutoSize;
            helthplus.TabIndex = 8;
            helthplus.TabStop = false;
            // 
            // score2
            // 
            score2.AutoSize = true;
            score2.BackColor = Color.Transparent;
            score2.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            score2.ImageAlign = ContentAlignment.MiddleLeft;
            score2.Location = new Point(12, 9);
            score2.Name = "score2";
            score2.Size = new Size(38, 45);
            score2.TabIndex = 9;
            score2.Text = "0";
            // 
            // scorsc
            // 
            scorsc.Enabled = true;
            scorsc.Interval = 3000;
            scorsc.Tick += scorsc_Tick;
            // 
            // bishtarin
            // 
            bishtarin.AutoSize = true;
            bishtarin.BackColor = Color.Transparent;
            bishtarin.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bishtarin.ImageAlign = ContentAlignment.MiddleLeft;
            bishtarin.Location = new Point(12, 54);
            bishtarin.Name = "bishtarin";
            bishtarin.Size = new Size(38, 45);
            bishtarin.TabIndex = 10;
            bishtarin.Text = "0";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_jet_100;
            pictureBox1.Location = new Point(295, 279);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            pictureBox1.Click += skin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.player;
            pictureBox2.Location = new Point(401, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(110, 98);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.bullet;
            pictureBox3.Location = new Point(453, 237);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(7, 27);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            pictureBox3.Click += skinbullet2_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._11zon_resized__6_;
            pictureBox4.Location = new Point(332, 237);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(25, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            pictureBox4.Click += skinbullet1_Click;
            // 
            // soboshab
            // 
            soboshab.Image = Properties.Resources.icons8_smiling_sun_100;
            soboshab.Location = new Point(688, 9);
            soboshab.Name = "soboshab";
            soboshab.Size = new Size(100, 100);
            soboshab.SizeMode = PictureBoxSizeMode.AutoSize;
            soboshab.TabIndex = 15;
            soboshab.TabStop = false;
            // 
            // star1
            // 
            star1.Image = Properties.Resources.icons8_star_48;
            star1.Location = new Point(740, 128);
            star1.Name = "star1";
            star1.Size = new Size(48, 48);
            star1.SizeMode = PictureBoxSizeMode.AutoSize;
            star1.TabIndex = 16;
            star1.TabStop = false;
            // 
            // star2
            // 
            star2.Image = Properties.Resources.icons8_star_48;
            star2.Location = new Point(740, 237);
            star2.Name = "star2";
            star2.Size = new Size(48, 48);
            star2.SizeMode = PictureBoxSizeMode.AutoSize;
            star2.TabIndex = 17;
            star2.TabStop = false;
            // 
            // star3
            // 
            star3.Image = Properties.Resources.icons8_star_48;
            star3.Location = new Point(12, 128);
            star3.Name = "star3";
            star3.Size = new Size(48, 48);
            star3.SizeMode = PictureBoxSizeMode.AutoSize;
            star3.TabIndex = 18;
            star3.TabStop = false;
            // 
            // star4
            // 
            star4.Image = Properties.Resources.icons8_star_48;
            star4.Location = new Point(12, 237);
            star4.Name = "star4";
            star4.Size = new Size(48, 48);
            star4.SizeMode = PictureBoxSizeMode.AutoSize;
            star4.TabIndex = 19;
            star4.TabStop = false;
            // 
            // EmfejaR
            // 
            EmfejaR.Enabled = true;
            EmfejaR.Interval = 1000;
            EmfejaR.Tick += EmfejaR_Tick;
            // 
            // Enfejar
            // 
            Enfejar.BackColor = Color.Transparent;
            Enfejar.Image = Properties.Resources.enfejar;
            Enfejar.Location = new Point(158, 279);
            Enfejar.Name = "Enfejar";
            Enfejar.Size = new Size(120, 120);
            Enfejar.SizeMode = PictureBoxSizeMode.AutoSize;
            Enfejar.TabIndex = 20;
            Enfejar.TabStop = false;
            Enfejar.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Orange;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 630);
            Controls.Add(Enfejar);
            Controls.Add(star2);
            Controls.Add(soboshab);
            Controls.Add(star4);
            Controls.Add(star3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bishtarin);
            Controls.Add(score2);
            Controls.Add(helthplus);
            Controls.Add(helth3);
            Controls.Add(helth2);
            Controls.Add(helth1);
            Controls.Add(player);
            Controls.Add(enemy3);
            Controls.Add(enemy2);
            Controls.Add(Bullet);
            Controls.Add(enemy1);
            Controls.Add(txtScore);
            Controls.Add(star1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "FighterJet Getaway";
            Load += Form1_Load;
            KeyDown += keyisdown;
            KeyUp += keyisup;
            ((System.ComponentModel.ISupportInitialize)enemy1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Bullet).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy2).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemy3).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)helth1).EndInit();
            ((System.ComponentModel.ISupportInitialize)helth2).EndInit();
            ((System.ComponentModel.ISupportInitialize)helth3).EndInit();
            ((System.ComponentModel.ISupportInitialize)helthplus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)soboshab).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)Enfejar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox enemy1;
        private PictureBox Bullet;
        private PictureBox enemy2;
        private PictureBox enemy3;
        private PictureBox player;
        private Label txtScore;
        private System.Windows.Forms.Timer gameTimer;
        private PictureBox helth1;
        private PictureBox helth2;
        private PictureBox helth3;
        private PictureBox helthplus;
        private Label score2;
        private System.Windows.Forms.Timer scorsc;
        private Label bishtarin;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox soboshab;
        private PictureBox star1;
        private PictureBox star2;
        private PictureBox star3;
        private PictureBox star4;
        private System.Windows.Forms.Timer EmfejaR;
        private System.Windows.Forms.Timer explosionTimer;
        private PictureBox Enfejar;
    }
}
