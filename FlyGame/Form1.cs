using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyGame
{
    public partial class Form1 : Form
    {
        // Глобальные переменные
        int score = 0;
        int timer = 10;
        bool isRunning = false;

        public Form1()
        {
            InitializeComponent();

            this.Width = 500;
            this.Height = 500;
        }

        private void buttonFly_Click(object sender, EventArgs e)
        {
            if (isRunning == false)
            {
                timerGame.Enabled = true;
                isRunning = true;
            }
            

            #region Move Fly

            // RANDOM
            Random r = new Random();  // cоздание инструмента рандом

            int x = r.Next(0, 500 - buttonFly.Width - 20);
            int y = r.Next(0, 500 - buttonFly.Height - 20);

            buttonFly.Left = x;
            buttonFly.Top = y;

            #endregion

            score++;
            labelScore.Text = "Score: " + score.ToString();

            //score = score + 1;
            //score += 1;
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            timer--;  // уменьшаем время на 1
            labelTimer.Text = "Timer: " + timer.ToString();

            if (timer == 0)
            {
                timerGame.Enabled = false;   // останавливаем таймер
                buttonFly.Enabled = false;   // отключаем нажатие на кнопку

                // итоги игры
                if (score < 10)
                {
                    MessageBox.Show("Bad");
                }
                else if (score < 14)
                {
                    MessageBox.Show("Normal");
                }
                else
                {
                    MessageBox.Show("Cool!");
                }

            }
        }
    }
}
