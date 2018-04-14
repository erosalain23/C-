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
    public partial class frmGameEngine : Form
    {
        #region variables
        // creating a random instance
        Random random = new Random();
        // creating a list of icons, those icons are respresented by characters in the webddings font
        //List<string> icons = new List<string>()
        //{
        //    "!","!","N","N",",",",","k","k",
        //    "b","b","v","v","w","w","z","z",
        //    "t","t","e","e","g","g","i","i",
        //    "l","l","m","m","p","p","r","r",
        //    "c","c","d","d","f","f","h","h",
        //    "o","o","q","q","s","s","~","~",
        //    "u","u","*","*","P","P","$","$",
        //    "%","%",".",".",";",";","]","]",
        //    "(","(","}","}","+","+","-","-"
        //};
        //creating two labels that will hold a label if its clicked (first and second to be matched)
        Label firstClicked, secondClicked;
        //variables to store points
        private int pointsPlayerTwo = 0, pointsPlayerOne = 0;
        //boolean variable to check if its player one or player two
        private Boolean playerOne = true;
        #endregion
        #region constructor
        // the constructor
        public frmGameEngine()
        {
            InitializeComponent();
            // assigning icons to all labels
            AssignIconsToSquares();
        }
        #endregion
        #region label click (play)
        private void Label_Click(object sender, EventArgs e)
        {
            //first check if you have already clicked twice to not chit by clicking the third time
            if (firstClicked != null && secondClicked != null)
                return;
            //getting the clicked label using th sender
            Label clickedLabel = sender as Label;
            //checking is the clicked label is not null for security reasons
            if (clickedLabel == null)
                return;
            //checking if the icon was colored (clicked)
            if (clickedLabel.ForeColor == Color.Black||clickedLabel.ForeColor==Color.Red)
                return;
            //checking if its the player one playing
            if (playerOne)
            {
                //if the firstclicked is still null
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;//storing in the clicked icon
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;//storing in the clicked icon
                secondClicked.ForeColor = Color.Black;
                playerOne = !playerOne;// shifting the players
            }
            //when its not the player one
            else
            {
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;//storing in the clicked icon
                    firstClicked.ForeColor = Color.Red;
                    return;
                }
                secondClicked = clickedLabel;//storing in the clicked icon
                secondClicked.ForeColor = Color.Red;
                playerOne = !playerOne;
            }
            // after each play we check for:
            //were all icons found
            AllFound();
            //the winer
            CheckTheWinner();
            //check for one win and reset firstclicked and secondclicked
            if (firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
                timer1.Start();//starting the timer if they did not latch
        }
        #endregion
        #region timer
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();//stoppping the timer
            //make icons invisible
            firstClicked.ForeColor = firstClicked.BackColor;
            secondClicked.ForeColor = secondClicked.BackColor;
            //clean the firstclicked and secondclicked temp labels
            firstClicked = null;
            secondClicked = null;
        }
        #endregion
        #region initializing the squares function
        private void AssignIconsToSquares()
        {
            List<string> icons = new List<string>()
            {
                "!","!","N","N",",",",","k","k",
                "b","b","v","v","w","w","z","z",
                "t","t","e","e","g","g","i","i",
                "l","l","m","m","p","p","r","r",
                "c","c","d","d","f","f","h","h",
                "o","o","q","q","s","s","~","~",
                "u","u","*","*","P","P","$","$",
                "%","%",".",".",";",";","n","n",
                "7","7","L","L","+","+","-","-"
            };
            //string[] proof = new string[72];
            Label label;
            int randomNumber;

            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];//casiting each control into a label
                else
                    continue;
                randomNumber = random.Next(0, icons.Count);// choosing a random icon
                //MessageBox.Show(randomNumber.ToString());
                label.Text = icons[randomNumber];
                //proof[i] = icons[randomNumber];
                icons.RemoveAt(randomNumber);// removing selected icons to not be selected twice
            }
            //MessageBox.Show(string.Join(",",proof));
        }
        #endregion
        #region exit from menu bar
        private void msExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region new game form menu bar
        private void msNewGame_Click(object sender, EventArgs e)
        {

            pointsPlayerOne = pointsPlayerTwo = 0;
            playerOne = true;
            EmptySquares();
            AssignIconsToSquares();
            HideIcons();
        }
        #endregion
        #region check match function
        //checking if all icons were found
        private void AllFound()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                //checking if it is not clicked yet
                if (label != null && label.ForeColor == label.BackColor)
                    return;//nothing happens
            }

            MessageBox.Show("You have Matched all the icons! Congrats!");
            Close();
        }
        #endregion
        #region check for winner
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
        #endregion
        #region Empty squares
        private void EmptySquares()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                label.Text = string.Empty;
                firstClicked = secondClicked = null;
            }
        }
        #endregion
        #region HideIcons
        private void HideIcons()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                label.ForeColor = label.BackColor;
            }
        }
        #endregion
    }
}
