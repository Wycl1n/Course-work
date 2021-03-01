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
        private Button[,] arrayOfNumbers = new Button[4, 4];

        public Form1()
        {
            InitializeComponent();
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++) 
                {
                    arrayOfNumbers[i, j] = new Button();
                    arrayOfNumbers[i, j].Location = new Point(i * 60, 130+j * 60);
                    arrayOfNumbers[i, j].Size = new Size(60, 60);
                    arrayOfNumbers[i, j].MouseClick += new MouseEventHandler(S_MouseClick);
                    this.Controls.Add(arrayOfNumbers[i, j]);
                }
            StartGame();
        }

        void S_MouseClick(object sender, MouseEventArgs e)
        {
            int i = e.X / 60;
            int j = e.Y / 60;
        }

        private void StartGame()
        {
            byte temp = 0;
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++) 
                    arrayOfNumbers[j, i].Text = "" + temp++;
            arrayOfNumbers[0, 0].Text = "";

            Random rand = new Random();
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                {
                    string str = arrayOfNumbers[i, j].Text;
                    Button randomButton = arrayOfNumbers[rand.Next() % 4, rand.Next() % 4];
                    arrayOfNumbers[i, j].Text = randomButton.Text;
                    randomButton.Text = str;
                }

            // in future will be changed
            /*button1.Text = arrayOfNumbers[0, 0] != 0 ? arrayOfNumbers[0, 0].ToString() : " ";
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
            button16.Text = arrayOfNumbers[3, 3] != 0 ? arrayOfNumbers[3, 3].ToString() : " ";*/
        }

    }
}
