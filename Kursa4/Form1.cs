using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursa4
{
    public partial class Form1 : Form
    {
        private byte[,] arrayOfNumbers = new byte[4, 4];

        public Form1()
        {
            InitializeComponent();
            StartGame();
        }

        private void StartGame()
        {
            byte temp = 0;
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++) 
                    arrayOfNumbers[i, j] = temp++;

            Random rand = new Random();
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                    Swap(ref arrayOfNumbers[i, j], ref arrayOfNumbers[rand.Next() % 4, rand.Next() % 4]);

            // in future will be changed
            button1.Text = arrayOfNumbers[0, 0] != 0 ? arrayOfNumbers[0, 0].ToString() : " ";
            button2.Text = arrayOfNumbers[0, 1] != 0 ? arrayOfNumbers[0, 1].ToString() : " ";
            button3.Text = arrayOfNumbers[0, 2] != 0 ? arrayOfNumbers[0, 2].ToString() : " ";
            button4.Text = arrayOfNumbers[0, 3] != 0 ? arrayOfNumbers[0, 3].ToString() : " ";
            button5.Text = arrayOfNumbers[1, 0] != 0 ? arrayOfNumbers[1, 0].ToString() : " ";
            button6.Text = arrayOfNumbers[1, 1] != 0 ? arrayOfNumbers[1, 1].ToString() : " ";
            button7.Text = arrayOfNumbers[1, 2] != 0 ? arrayOfNumbers[1, 2].ToString() : " ";
            button8.Text = arrayOfNumbers[1, 3] != 0 ? arrayOfNumbers[1, 3].ToString() : " ";
            button9.Text = arrayOfNumbers[2, 0] != 0 ? arrayOfNumbers[2, 0].ToString() : " ";
            button10.Text = arrayOfNumbers[2, 1] != 0 ? arrayOfNumbers[2, 1].ToString() : " ";
            button11.Text = arrayOfNumbers[2, 2] != 0 ? arrayOfNumbers[2, 2].ToString() : " ";
            button12.Text = arrayOfNumbers[2, 3] != 0 ? arrayOfNumbers[2, 3].ToString() : " ";
            button13.Text = arrayOfNumbers[3, 0] != 0 ? arrayOfNumbers[3, 0].ToString() : " ";
            button14.Text = arrayOfNumbers[3, 1] != 0 ? arrayOfNumbers[3, 1].ToString() : " ";
            button15.Text = arrayOfNumbers[3, 2] != 0 ? arrayOfNumbers[3, 2].ToString() : " ";
            button16.Text = arrayOfNumbers[3, 3] != 0 ? arrayOfNumbers[3, 3].ToString() : " ";
        }

        private void Swap(ref byte a, ref byte b)
        {
            byte t = a;
            a = b;
            b = t;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }
    }
}
