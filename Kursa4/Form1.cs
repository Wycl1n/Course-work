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
        private Button restartButton = new Button();
        private Label label = new Label();
        private bool isGameEnded;

        public Form1()
        {
            InitializeComponent();
            label.Location = new Point(30, 30);
            label.Size = new Size(200, 50);
            label.Font = new Font("Arial", 20);
            this.Controls.Add(label);
            restartButton.Location = new Point(27, 80);
            restartButton.Size = new Size(190, 50);
            restartButton.Text = "Restart";
            restartButton.MouseClick += new MouseEventHandler(StartGame);
            this.Controls.Add(restartButton);

            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++) 
                {
                    arrayOfNumbers[i, j] = new Button();
                    arrayOfNumbers[i, j].Location = new Point(i * 60, 135 + j * 60);
                    arrayOfNumbers[i, j].Size = new Size(60, 60);
                    arrayOfNumbers[i, j].MouseClick += new MouseEventHandler(S_MouseClick);
                    this.Controls.Add(arrayOfNumbers[i, j]);
                }

            StartGame();
        }

        void S_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isGameEnded)
            {
                for (int a = 0; a < 4; a++)
                    for (int b = 0; b < 4; b++)
                        if (arrayOfNumbers[b, a] == sender)
                        {
                            try
                            {
                                if (arrayOfNumbers[b + 1, a].Text == "")
                                    Swap(ref arrayOfNumbers[b + 1, a], ref arrayOfNumbers[b, a]);
                            }
                            catch { }
                            try
                            {
                                if (arrayOfNumbers[b - 1, a].Text == "")
                                    Swap(ref arrayOfNumbers[b - 1, a], ref arrayOfNumbers[b, a]);
                            }
                            catch { }
                            try
                            {
                                if (arrayOfNumbers[b, a + 1].Text == "")
                                    Swap(ref arrayOfNumbers[b, a + 1], ref arrayOfNumbers[b, a]);
                            }
                            catch { }
                            try
                            {
                                if (arrayOfNumbers[b, a - 1].Text == "")
                                    Swap(ref arrayOfNumbers[b, a - 1], ref arrayOfNumbers[b, a]);
                            }
                            catch { }
                        }

                if (arrayOfNumbers[0, 0].Text == "1" &&
                    arrayOfNumbers[1, 0].Text == "2" &&
                    arrayOfNumbers[2, 0].Text == "3" &&
                    arrayOfNumbers[3, 0].Text == "4" &&
                    arrayOfNumbers[0, 1].Text == "5" &&
                    arrayOfNumbers[1, 1].Text == "6" &&
                    arrayOfNumbers[2, 1].Text == "7" &&
                    arrayOfNumbers[3, 1].Text == "8" &&
                    arrayOfNumbers[0, 2].Text == "9" &&
                    arrayOfNumbers[1, 2].Text == "10" &&
                    arrayOfNumbers[2, 2].Text == "11" &&
                    arrayOfNumbers[3, 2].Text == "12" &&
                    arrayOfNumbers[0, 3].Text == "13" &&
                    arrayOfNumbers[1, 3].Text == "14" &&
                    arrayOfNumbers[2, 3].Text == "15" &&
                    arrayOfNumbers[3, 3].Text == "")
                {
                    label.Text = "Success";
                    isGameEnded = true;
                }
            }
        }

        void StartGame(object sender, MouseEventArgs e)
        {
            StartGame();
        }
        private void StartGame()
        {
            isGameEnded = false;
            label.Text = "Game is going";
            byte temp = 0;
            for (byte i = 0; i < 4; i++)
                for (byte j = 0; j < 4; j++)
                    arrayOfNumbers[j, i].Text = "" + ++temp;
            arrayOfNumbers[3, 3].Text = "";

            Random rand = new Random();
            do
            {
                for (byte i = 0; i < 4; i++)
                    for (byte j = 0; j < 4; j++)
                    {
                        Button randomButton = arrayOfNumbers[rand.Next() % 4, rand.Next() % 4];
                        string str = arrayOfNumbers[i, j].Text;
                        arrayOfNumbers[i, j].Text = randomButton.Text;
                        randomButton.Text = str;
                    }
            }
            while (!isSolvable());
            temp = 0;
        }

        public bool isSolvable()
        {
            int count = 0;

            int[] arr = new int[16];
            int i_arr = 0;
            for(int i=0;i<4;i++)
                for(int j=0;j<4;j++)
                    arr[i_arr++] = arrayOfNumbers[j, i].Text == "" 
                                   ? 0
                                   : Convert.ToInt32(arrayOfNumbers[j, i].Text);

            for (int i = 0; i < 16; i++)
                for (int j = 0; j < i; j++) 
                    if (arr[i] < arr[j]) 
                        count++;

            for (int i = 0; i < 16; i++)
                if (arr[i] == 0)
                    count += 1 + i / 4;

            return count%2!=0;
        }
        private void Swap(ref Button a, ref Button b)
        {
            string temp = a.Text;
            a.Text = b.Text;
            b.Text = temp;
        }

    }
}
