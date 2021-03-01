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
                    arrayOfNumbers[i, j].Location = new Point(i * 60, 130 + j * 60);
                    arrayOfNumbers[i, j].Size = new Size(60, 60);
                    arrayOfNumbers[i, j].MouseClick += new MouseEventHandler(S_MouseClick);
                    this.Controls.Add(arrayOfNumbers[i, j]);
                }
            StartGame();
        }

        void S_MouseClick(object sender, MouseEventArgs e)
        {
            for (int a = 0; a < 4; a++)
                for (int b = 0; b < 4; b++)
                    if (arrayOfNumbers[b, a] == sender)
                        try
                        {
                            if (arrayOfNumbers[b + 1, a].Text == "") Swap(ref arrayOfNumbers[b + 1, a], ref arrayOfNumbers[b, a]);
                            else if (arrayOfNumbers[b - 1, a].Text == "") Swap(ref arrayOfNumbers[b - 1, a], ref arrayOfNumbers[b, a]);
                            else if (arrayOfNumbers[b, a + 1].Text == "") Swap(ref arrayOfNumbers[b, a + 1], ref arrayOfNumbers[b, a]);
                            else if (arrayOfNumbers[b, a - 1].Text == "") Swap(ref arrayOfNumbers[b, a - 1], ref arrayOfNumbers[b, a]);
                        }
                        catch { }
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
        }

        private void Swap(ref Button a, ref Button b)
        {
            string temp = a.Text;
            a.Text = b.Text;
            b.Text = temp;
        }

    }
}
