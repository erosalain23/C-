using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        List<string> icons = new List<string>()
        {
            "!","!","N","N",",",",","k","k",
            "b","b","v","v","w","w","z","z",
            "t","t","e","e","g","g","i","i",
            "l","l","m","m","p","p","r","r",
            "c","c","d","d","f","f","h","h",
            "o","o","q","q","s","s","~","~",
            "u","u","*","*","P","P","$","$",
            "%","%",".",".",";",";","]","]",
            "(","(","}","}","+","+","-","-"
        };
        Label firstClicked, secondClicked;
        private int pointsPlayerTwo = 0, pointsPlayerOne = 0;
        private Boolean playerOne = true;

        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }

        private void Label_Click(object sender, EventArgs e)
        {
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label;
            if (clickedLabel == null)
                return;
            if (clickedLabel.ForeColor == Color.Black||clickedLabel.ForeColor==Color.Red)
                return;
            if (playerOne)
            {
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                playerOne = !playerOne;
            }
            else
            {
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Red;
                    return;
                }
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Red;
                playerOne = !playerOne;
            }
            
            CheckForWinner();
            CheckTheWinner();

            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;
            secondClicked = null;
        }

        private void AssignIconsToSquares()
        {
            string[] proof = new string[72];
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;
                randomNumber = random.Next(0, icons.Count);
                //MessageBox.Show(randomNumber.ToString());
                label.Text = icons[randomNumber];
                proof[i] = icons[randomNumber];
                icons.RemoveAt(randomNumber);
            }
            //MessageBox.Show(string.Join(",",proof));
        }

        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void msNewGame_Click(object sender, EventArgs e)
        {
            AssignIconsToSquares();
        }

        private void CheckForWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            MessageBox.Show("You Matched all the icons! Congrats!");
            Close();
        }
        private void CheckTheWinner()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == Color.Black)
                    pointsPlayerOne += 1;
                if (label != null && label.ForeColor == Color.Red)
                    pointsPlayerTwo += 1;
                else
                    return;
            }
            if (pointsPlayerOne < pointsPlayerTwo)
                MessageBox.Show("Player Two wins");
            else
                MessageBox.Show("Player one wins");
        }
    }
}
