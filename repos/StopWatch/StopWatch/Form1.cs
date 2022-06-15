using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();
        private Random random = new Random();
        private int currentScore = 0;
        private int highScore = 0;
        private int TimeRemaigning = 0;
        private int lives = 3;
        private bool isHit = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Start_Click(object sender, EventArgs e)
        {
            BTN_Start.Visible = false;
            lives = 3;
            LBL_Lives.Text = lives.ToString();
            currentScore = 0;
            LBL_CurrentScore.Text = currentScore.ToString();
            TimeRemaigning = 60;
            LBL_Timer.Text = TimeRemaigning.ToString();
            timer1.Enabled = true;
            watch.Start();
        }


        private void GameEnd()
        {
            watch.Stop();
            timer1.Enabled = false;
            if (currentScore > highScore)
            {
                highScore = currentScore;
                LBL_HighScore.Text = highScore.ToString();
            }
            currentScore = 0;
            BTN_Start.Visible = true;

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isHit == false)
            {
                lives--;
                LBL_Lives.Text = lives.ToString();
            }
            if (lives <= 0)
            {
                GameEnd();
                return;
            }
            TimeRemaigning -= 1;
            if (TimeRemaigning <= 0)
            {
                GameEnd();
                return;
            }
            LBL_Timer.Text = TimeRemaigning.ToString();
            move();
        }

        private void Hit(object sender, EventArgs e)
        {
            currentScore ++;
            HitBox.Image = Properties.Resources.Valkyrie_Offline;
            LBL_CurrentScore.Text = currentScore.ToString();
            isHit = true;
        }

        private void move()
        {
            isHit = false;
            HitBox.Enabled = true;
            HitBox.Image = Properties.Resources.Valkyrie;
            HitBox.BackColor = System.Drawing.Color.Transparent;

            int location = random.Next(1, 7);

            switch (location)
            {
                case 1:
                    HitBox.Left = 436;
                    HitBox.Top = 202;
                    break;
                case 2:
                    HitBox.Left = 255;
                    HitBox.Top = 328;
                    break;
                case 3:
                    HitBox.Left = 267;
                    HitBox.Top = 167;
                    break;
                case 4:
                    HitBox.Left = 50;
                    HitBox.Top = 151;
                    break;
                case 5:
                    HitBox.Left = 35;
                    HitBox.Top = 298;
                    break;
                case 6:
                    HitBox.Left = 460;
                    HitBox.Top = 147;
                    break;
                case 7:
                    HitBox.Left = 477;
                    HitBox.Top = 360;
                    break;
                default:
                    break;
            }
        }

    }
}
