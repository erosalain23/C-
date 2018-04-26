using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Memory_Game
{
    public partial class frmGameEngine : Form
    {
        #region variables
        // creating a random instance
        Random random = new Random();
        // creating a list of icons, those icons are respresented by characters in the webddings font
        List<string> icons = new List<string>()
            {
                "A","A","B","B","C","C","D","D",
                "E","E","F","F","G","G","H","H",
                "I","I","J","J","K","K","L","L",
                "M","M","N","N","O","O","P","P",
                "Q","Q","R","R","S","S","T","T",
                "U","U","V","V","W","W","X","X",
                "Y","Y","Z","Z","t","t","b","b",
                "c","c","d","d","e","e","m","m"
            };
        //creating two labels that will hold a label if its clicked (first and second to be matched)
        Label firstClicked, secondClicked;
        //variables to store points
        private int pointsPlayerTwo = 0, pointsPlayerOne = 0;
        //boolean variable to check if its player one or player two
        private Boolean playerOne = true;
        //variable to check if the game was over or not , NB the game is over if all those stuffs have been revealed 
        private Boolean GameOver = false;

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
            GameOver = IsGameOver();
            if (GameOver)
            {
                //the winer
                CheckTheWinner();
            }
            else
            {
                //getting the clicked label using th sender
                Label clickedLabel = sender as Label;
                //checking is the clicked label is not null for security reasons
                if (clickedLabel == null)
                    return;
                //checking if the icon was colored (clicked)
                if (clickedLabel.ForeColor == Color.Black || clickedLabel.ForeColor == Color.Red)
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
                    else
                    {
                        secondClicked = clickedLabel;//storing in the clicked icon
                        secondClicked.ForeColor = Color.Black;
                    }
                    //check for one win and reset firstclicked and secondclicked
                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        pointsPlayerOne += 1;
                    }
                    else
                        timer1.Start();//starting the timer if they did not latch
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
                    else
                    {
                        secondClicked = clickedLabel;//storing in the clicked icon
                        secondClicked.ForeColor = Color.Red;
                    }
                    //check for one win and reset firstclicked and secondclicked
                    if (firstClicked.Text == secondClicked.Text)
                    {
                        firstClicked = null;
                        secondClicked = null;
                        pointsPlayerOne += 1;
                    }
                    else
                        timer1.Start();//starting the timer if they did not latch
                    playerOne = !playerOne;
                }
                
                
            }
          
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
        #region functioin to initializing the squares 
        private void AssignIconsToSquares()
        {
            List<string> icons = new List<string>()
            {
                "A","A","B","B","C","C","D","D",
                "E","E","F","F","G","G","H","H",
                "I","I","J","J","K","K","L","L",
                "M","M","N","N","O","O","P","P",
                "Q","Q","R","R","S","S","T","T",
                "U","U","V","V","W","W","X","X",
                "Y","Y","Z","Z","t","t","b","b",
                "c","c","d","d","e","e","m","m"
            };
            //string[] proof = new string[64];
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
                //label.Text = "0";
                //proof[i] = icons[randomNumber];
                icons.RemoveAt(randomNumber);// removing selected icons to not be selected twice
            }
            //MessageBox.Show(string.Join(",",proof));
        }
        #endregion
        #region exit from menu bar
        private void msExit_Click(object sender, EventArgs e)
        {
            if (!GameOver)
            {
                DialogResult dialog_result = MessageBox.Show("Do you want to save the Game?", "Saving Game", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.Yes)
                    SaveGame();
            }
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
        private Boolean IsGameOver()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                //checking if it is not clicked yet
                if (label != null && label.ForeColor == label.BackColor)
                    return false ;//nothing happens
            }
            return true;// when every label was clicked and each of them is colored black or red
        }
        #endregion
        #region check for winner
        private void CheckTheWinner()
        {

            if (pointsPlayerOne < pointsPlayerTwo)
                MessageBox.Show("Player Two wins","winner",MessageBoxButtons.OK);
            else
                MessageBox.Show("Player one wins", "Winner",MessageBoxButtons.OK);
            DialogResult dialogResults = MessageBox.Show("Do you want to play a new game?", "Game over", MessageBoxButtons.YesNo);
            if (dialogResults == DialogResult.Yes)
            {
                pointsPlayerOne = pointsPlayerTwo = 0;
                playerOne = true;
                EmptySquares();
                AssignIconsToSquares();
                HideIcons();
            }
            else
                Application.Exit();

        }
        #endregion
        #region Empty squares
        private void EmptySquares()
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count-1; i++)
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
            for (int i = 0; i < tableLayoutPanel1.Controls.Count-1; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                label.ForeColor = label.BackColor;
            }
        }
        #endregion
        #region save game function
        private void SaveGame()
        {
            string path = @"E:\C#\Memory Game\Game cache\savedGame.txt";
            Label label;
            string[] allIcons = new string[64];

            for (int i = 0; i < tableLayoutPanel1.Controls.Count - 1; i++)
            {
                //converting each control to a label
                label = tableLayoutPanel1.Controls[i] as Label;
                allIcons[i] = label.Text;
            }
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Join(",", allIcons));
                    //sw.WriteLine("Paler :" + playerOne.ToString());
                    if (playerOne)
                        sw.WriteLine(playerOne.ToString());
                    else
                        sw.WriteLine((playerOne).ToString());
                    sw.WriteLine(pointsPlayerOne.ToString());
                    sw.WriteLine(pointsPlayerTwo.ToString());
                }
            }
            else
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Join(",", allIcons));
                    //sw.WriteLine("Paler :" + playerOne.ToString());
                    if (playerOne)
                        sw.WriteLine(playerOne.ToString());
                    else
                        sw.WriteLine(playerOne.ToString());
                    sw.WriteLine(pointsPlayerOne.ToString());
                    sw.WriteLine(pointsPlayerTwo.ToString());
                }
            }
         

        }
        #endregion
        #region Resume game function
        private void ResumeGame()
        {
            string path = @"E:\C#\Memory Game\Game cache\savedGame.txt";
            StreamReader sr = new StreamReader(path);
            long count = CountTextFileLines(path);
            string[] lines = new string[5];
            for (long i = count - 5; i < count; i++)
            {
                String line = sr.ReadLine();
                lines = line.Split(':');
            }
            foreach (string line in lines)
                Console.WriteLine(line);
            Console.ReadLine();
        }
        #endregion
        private long CountTextFileLines(string file)
        {
            long count = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                string line;
                while ((line=sr.ReadLine())!= null)
                {
                    count++;
                }
            }
            return count;
        }

    }
}
