using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_TOE
{
    public partial class Form1 : Form
    {
        bool turn = true; // when true = x turn else y turn
        int turnCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string aboutText = "A Tic Toc Toe game By Alain Eros Prestige , built for learning puporse \r\n this was built on 31/3/2018 \r\n #Fi #CodeEverything ";
            Message_Box mb = new Message_Box(aboutText);
            mb.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (turn)
                b.Text = "X";
            else
                b.Text = "O";
            turn = !turn;
            turnCount++;
            b.Enabled = false;
            checkForWinner();
        }
        private void checkForWinner()
        {
            bool thereIsAwinner = false;

            //the Horizontal wins
            if ((A1.Text == A2.Text) && (A2.Text == A3.Text) && (!A1.Enabled))
                thereIsAwinner = true;
            else if ((B1.Text == B2.Text) && (B2.Text == B3.Text) && (!B1.Enabled))
                thereIsAwinner = true;
            else if ((C1.Text == C2.Text) && (C2.Text == C3.Text) && (!C1.Enabled))
                thereIsAwinner = true;
            // the vertical wins
            else if ((A1.Text == B1.Text) && (B1.Text == C1.Text) && (!A1.Enabled))
                thereIsAwinner = true;
            else if ((A2.Text == B2.Text) && (B2.Text == C2.Text) && (!A2.Enabled))
                thereIsAwinner = true;
            else if ((A3.Text == B3.Text) && (B3.Text == C3.Text) && (!A3.Enabled))
                thereIsAwinner = true;
            // the Diagonal wins

            else if ((A3.Text == B2.Text) && (B2.Text == C1.Text) && (!A3.Enabled))
                thereIsAwinner = true;
            else if ((A1.Text == B2.Text) && (B2.Text == C3.Text) && (!A1.Enabled))
                thereIsAwinner = true;

            //End of  win checks

            if (thereIsAwinner)
            {
                disableButtons();
                turnCount = 0;
                string winner = "";
                if (turn)
                    winner = "O";
                else
                    winner = "X";

                MessageBox.Show(winner + " Wins" + " " + "Yay !");
            }
            else
            {
                if (turnCount == 9)
                    MessageBox.Show("Draw!", "Bummer!");
            }
        }

        private void disableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Enabled = false;
                }
            }
            catch{ }
            
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            turn = true;
            turnCount = 0;
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = (Button)c;
                    b.Text = string.Empty;
                    b.Enabled = true;
                }
            }
            catch { }
           
        }
    }
}
