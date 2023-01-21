using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedGame
{
    public partial class Form1 : Form
    {
        // global variables
        Random r = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            //r.Next(0, 10);

            // подключить двойной буфер 

            pictureBoxCar1.Left = pictureBoxCar1.Left + r.Next(0, 10);
            pictureBoxCar2.Left = pictureBoxCar2.Left + r.Next(0, 10);
            pictureBoxCar3.Left = pictureBoxCar3.Left + r.Next(0, 10);
            pictureBoxCar4.Left = pictureBoxCar4.Left + r.Next(0, 10);

            /*if (pictureBoxCar1.Right >= buttonFinish.Right ||
                pictureBoxCar2.Right >= buttonFinish.Right ||
                pictureBoxCar3.Right >= buttonFinish.Right ||
                pictureBoxCar4.Right >= buttonFinish.Right)
            {
                timerGame.Enabled = false;
            } */


            if (pictureBoxCar1.Right >= buttonFinish.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Red car has won!");
            }
            else if (pictureBoxCar2.Right >= buttonFinish.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Pink car has won!");
            }
            else if (pictureBoxCar3.Right >= buttonFinish.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Green car has won!");
            }
            else if (pictureBoxCar4.Right >= buttonFinish.Right)
            {
                timerGame.Enabled = false;
                MessageBox.Show("Yellow car has won!");
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerGame.Enabled = true;
        }
    }
}
