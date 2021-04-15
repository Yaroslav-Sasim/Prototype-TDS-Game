using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginRegis
{
    public partial class FrnGame : Form
    {
        bool gameOver;
        string facing = "up";
        int playerHealth = 100;
        int resAmmo = 0;
        int ammo = 10;
        int monsterSpeed = 1;
        int score;
        Random randNum = new Random();

        List<PictureBox> monstersList = new List<PictureBox>();

        public FrnGame()
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(OKP);
            RestartGame();
        }

        private void OKP(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode.ToString())
            {
                case "Right":
                    Player.Location = new Point(Player.Location.X + 8, Player.Location.Y);
                    Player.Image = Properties.Resources.Hero;
                    facing = "right";
                    break;
                case "Left":
                    Player.Location = new Point(Player.Location.X - 8, Player.Location.Y);
                    Player.Image = Properties.Resources.HeroLeft;
                    facing = "left";
                    break;
                case "Up":
                    Player.Location = new Point(Player.Location.X, Player.Location.Y - 8);
                    Player.Image = Properties.Resources.HeroUp;
                    facing = "up";
                    break;
                case "Down":
                    Player.Location = new Point(Player.Location.X, Player.Location.Y + 8);
                    Player.Image = Properties.Resources.HeroDown;
                    facing = "down";
                    break;
                case "Space":
                    if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)//////////////////////////////

                    {
                        ammo--;
                        ShootBullet(facing);

                        if (ammo < 1)
                        {
                            DropAmmo();
                        }
                    }
                    ShootBullet(facing);
                    break;
                case "Enter":
                    RestartGame();
                    break;


            }
        }

        private void FrnGame_Load(object sender, EventArgs e)
        {

        }

        public void MainTimerEvent(object sender, EventArgs e)
        {


            if (playerHealth > 1)
            {
                healthTheBar.Value = playerHealth;
            }
            //else
            //{

            //    gameOver = true;
            //    if (gameOver == true)
            //    {
            //        Result fResult = new Result(score, resAmmo);
            //        fResult.Show();
            //        this.Close();
            //    }
            //    Player.Image = Properties.Resources.HeroDead;
            //    timer1.Stop();

            //}



            txtAmmo.Text = "Ammo:" + ammo;
            txtScore.Text = "Score:" + score;



            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && ((string)x.Tag == "ammo"))
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                        resAmmo += ammo;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 1920 || ((PictureBox)x).Top < 70 || ((PictureBox)x).Top > 1080)
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                    }
                }


                if (x is PictureBox && ((string)x.Tag == "monster"))
                {
                    if (((PictureBox)x).Bounds.IntersectsWith(Player.Bounds))
                    {
                        playerHealth -= 1;
                        numHP.Text = "%" + playerHealth;
                        if (playerHealth == 0)
                        {
                            numHP.Text = "%" + 0;
                        }

                    }

                    if (((PictureBox)x).Left > Player.Left)
                    {
                        ((PictureBox)x).Left -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterLeft;
                    }

                    if (((PictureBox)x).Left < Player.Left)
                    {
                        ((PictureBox)x).Left += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monster;
                    }

                    if (((PictureBox)x).Top > Player.Top)
                    {
                        ((PictureBox)x).Top -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterUp;
                    }

                    if (((PictureBox)x).Top < Player.Top)
                    {
                        ((PictureBox)x).Top += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterDown;
                    }
                }


                foreach (Control j in this.Controls)
                {

                    if ((j is PictureBox && (string)j.Tag == "bullet") && (x is PictureBox && (string)x.Tag == "monster"))
                    {

                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            monstersList.Remove(((PictureBox)x));
                            MakeMonsters();
                        }
                    }
                }


            }

        }

        public void GameOver()
        {
            if (healthTheBar.Value == 0)
            {
                gameOver = true;
            }
            else
            {
                gameOver = false;
            }

        }



        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = Player.Left + (Player.Width / 4);
            shootBullet.bulletTop = Player.Top + (Player.Height / 4);
            shootBullet.MakeBullet(this);
        }

        private void MakeMonsters()
        {

            PictureBox monster = new PictureBox();
            monster.Tag = "monster";
            monster.Image = Properties.Resources.monsterDown;
            monster.Left = randNum.Next(0, 1010);
            monster.Top = randNum.Next(70, 661);
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            monstersList.Add(monster);
            this.Controls.Add(monster);
            Player.BringToFront();

        }

        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(10, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            Player.BringToFront();
        }

        private void RestartGame()
        {

            Player.Image = Properties.Resources.HeroUp;

            foreach (PictureBox i in monstersList)
            {
                this.Controls.Remove(i);
            }

            monstersList.Clear();
            for (int i = 0; i < 3; i++)
            {
                MakeMonsters();
            }

            playerHealth = 100;
            score = 0;
            ammo = 10;
            timer1.Start();

        }

        public class Bullet
        {

            public string direction;
            public int bulletLeft;
            public int bulletTop;

            private int speed = 20;
            private PictureBox bullet = new PictureBox();
            private Timer bulletTimer = new Timer();


            public void MakeBullet(FrnGame form)
            {
                bullet.BackColor = Color.Black;
                bullet.Size = new Size(10, 5);
                bullet.Tag = "bullet";
                bullet.Left = bulletLeft;
                bullet.Top = bulletTop;
                bullet.BringToFront();

                form.Controls.Add(bullet);

                bulletTimer.Interval = speed;
                bulletTimer.Tick += new EventHandler(BulletTimerEvent);
                bulletTimer.Start();


            }

            private void BulletTimerEvent(object sender, EventArgs e)
            {
                if (direction == "left")
                {
                    bullet.Left -= speed;
                }

                if (direction == "right")
                {
                    bullet.Left += speed;
                }

                if (direction == "up")
                {
                    bullet.Top -= speed;
                }

                if (direction == "down")
                {
                    bullet.Top += speed;
                }


                if (bullet.Left < 10 || bullet.Left > 1920 || bullet.Top < 10 || bullet.Top > 1080)
                {
                    bulletTimer.Stop();
                    bulletTimer.Dispose();
                    bullet.Dispose();
                    bulletTimer = null;
                    bullet = null;
                }

            }
        }
    }
}
