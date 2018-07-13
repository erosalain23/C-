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
using System.Media;

namespace Memory_Game
{
    public partial class frmGameEngine : Form
    {
        #region variables
        // creating a random instance
        Random random = new Random();
        //Variables that holds players names
        public string playerOneName { get; set; }
        public string playerTwoName { get; set; }
        //creating two labels that will hold a label if its clicked (first and second to be matched)
        public Label firstClicked { get; set; }
        public Label secondClicked { get; set; }
        //variables to store points
        public int pointsPlayerTwo { get; set; }
        public int pointsPlayerOne { get; set; }
        //boolean variable to check if its player one or player two
        public Boolean playerOne { get; set; }
        //variable to check if the game was over or not , NB the game is over if all those stuffs have been revealed 
        public Boolean GameOver { get; set; }
        //sounds declaration
        public SoundPlayer player { get; set; }
        #endregion
        #region constructor
        public frmGameEngine()
        {
            InitializeComponent();
            AssignIconsToSquares();// assigning icons to all labels
            pointsPlayerOne = pointsPlayerTwo = 0;
            playerOne = true;
            GameOver = false;
        }
        #endregion
        #region constructor 2
        public frmGameEngine( string[] DataRetr)
        {

            InitializeComponent();
                List<string> icons = ToStringList(DataRetr[0]);
                //foreach (string l in icons)
                //    Console.WriteLine(l);
                //Console.ReadLine();  
                List<string> BlackCards = DataRetr[1].Split(',').ToList();
                List<string> RedCards = DataRetr[2].Split(',').ToList();
                playerOne = bool.Parse(DataRetr[3]);
                pointsPlayerOne = int.Parse(DataRetr[4]);
                pointsPlayerTwo = int.Parse(DataRetr[5]);
                AssignIconsToSquares(icons, BlackCards, RedCards);//assigning icons to labels
            this.GameOver = false;
        }
        #endregion
        #region constructor 3
        public frmGameEngine(string _playerOneName,string _playerTwoName):this()
        {
            //InitializeComponent();
            this.playerOneName = _playerOneName;
            this.playerTwoName = _playerTwoName;
            //MessageBox.Show(playerOneName + " " + playerTwoName);
        }
        #endregion
        #region label click (play)
        private void Label_Click(object sender, EventArgs e)

        {
            player = new SoundPlayer(@"E:\C#\Memory Game2\Sounds\zapsplat_impacts_metal_tin_001_19645.wav");
            player.Play();
            //first check if you have already clicked twice to not chit by clicking the third time
            if (firstClicked != null && secondClicked != null)
            {
                player = new SoundPlayer(@"E:\C#\Memory Game2\Sounds\zapsplat_impacts_metal_thin_hit_vibrate_001_19643.wav");
                player.Play();
                return;
            }
                
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
                    secondClicked = clickedLabel; //storing in the clicked icon
                    secondClicked.ForeColor = Color.Black;
                    GameOver = IsGameOver();
                    if (GameOver)
                    {
                        player = new SoundPlayer(@"E:\C#\Memory Game2\Sounds\Ta Da-SoundBible.com-1884170640.wav");
                        player.Play();
                        //Console.WriteLine(GameOver.ToString());
                        //Console.ReadLine();
                        //the winer
                        CheckTheWinner();
                        return;
                    }
                }
                //check for one win and reset firstclicked and secondclicked
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    pointsPlayerOne += 1;
                }
                else
                {
                    timer1.Start();//starting the timer if they did not latch
                    playerOne = !playerOne;// shifting the players
                }
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
                    GameOver = IsGameOver();
                    if (GameOver)
                    {
                        player = new SoundPlayer(@"E:\C#\Memory Game2\Sounds\Ta Da-SoundBible.com-1884170640.wav");
                        player.Play();
                        //Console.WriteLine(GameOver.ToString());
                        //Console.ReadLine();
                        //the winer
                        CheckTheWinner();
                        return;
                    }
                }
                //check for one win and reset firstclicked and secondclicked
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    pointsPlayerTwo += 1;
                }
                else
                {
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

        #region fucntion to generate a list from a string
        // a function to generate a list of strings form a string
        private List<string> ToStringList(string line)
        {
            List<string> newList = new List<string>();
            foreach (char c in line)
                newList.Add(c.ToString());
            //foreach (string l in newList)
            //    Console.WriteLine(l);
            //Console.ReadLine();
            return newList;

        }
        #endregion
        #region function to initializing the squares 
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
        #region Overload function to initializing the squares 
        private void AssignIconsToSquares(List<string> iconsRetr,List<string>bCardsRetr,List<string>rCardsRetr)
        {
            //foreach (string ca in rCardsRetr)
            //    Console.WriteLine(ca);
            //Console.Read();
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];//casiting each control into a label
                else
                    continue;
                label.Text = iconsRetr[i+1];
                //Console.WriteLine(iconsRetr[i+1]);

            }

            try
            {
                foreach (string cardIndex in bCardsRetr)
                {
                    if (tableLayoutPanel1.Controls[int.Parse(cardIndex)] is Label)
                        label = (Label)tableLayoutPanel1.Controls[63 - (int.Parse(cardIndex))];//casiting each control into a label
                    else
                        continue;
                    label.ForeColor = Color.Black;
                }
                foreach (string cardIndex in rCardsRetr)
                {
                    if (tableLayoutPanel1.Controls[int.Parse(cardIndex)] is Label)
                        label = (Label)tableLayoutPanel1.Controls[63 - (int.Parse(cardIndex))];//casiting each control into a label
                    else
                        continue;
                    label.ForeColor = Color.Red;
                }
            }
            catch(Exception)
            {
                if (bCardsRetr[0] == " " && rCardsRetr[0] != " ")
                {
                    //MessageBox.Show("pass");
                    foreach (string cardIndex in rCardsRetr)
                    {
                        if (tableLayoutPanel1.Controls[int.Parse(cardIndex)] is Label)
                            label = (Label)tableLayoutPanel1.Controls[63 - (int.Parse(cardIndex))];//casiting each control into a label
                        else
                            continue;
                        label.ForeColor = Color.Red;
                    }
                }
                else if (rCardsRetr[0] == " " && bCardsRetr[0] != " ")
                {
                    foreach (string cardIndex in bCardsRetr)
                    {
                        if (tableLayoutPanel1.Controls[int.Parse(cardIndex)] is Label)
                            label = (Label)tableLayoutPanel1.Controls[63 - (int.Parse(cardIndex))];//casiting each control into a label
                        else
                            continue;
                        label.ForeColor = Color.Black;
                    }
                }
                else
                {
                    for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
                    {
                        if (tableLayoutPanel1.Controls[i] is Label)
                            label = (Label)tableLayoutPanel1.Controls[i];//casiting each control into a label
                        else
                            continue;
                        label.ForeColor = label.BackColor;

                    }
                }
            }
            

            //Console.Read();
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
            this.Close();
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
                MessageBox.Show(playerOneName + " Wins ","winner",MessageBoxButtons.OK);
            else
                MessageBox.Show(playerTwoName + " Wins ", "Winner",MessageBoxButtons.OK);
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
                this.Close();

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

        private void msRules_Click(object sender, EventArgs e)
        {
            frmAboutGame f = new frmAboutGame();
            f.ShowDialog();
        }

        private void msAbout_Click(object sender, EventArgs e)
        {
            frmAuthorInfo f = new frmAuthorInfo();
            f.ShowDialog();
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
        #region save game function
        private void SaveGame()
        {
            string path = @"E:\C#\Memory Game2\GameCache\savedGame.txt";
            Label label;
            string[] allIcons = new string[64];
            List<int> blackCards = new List<int>();
            List<int> redCards = new List<int>();

            //MessageBox.Show(firstClicked.Text +"-"+secondClicked.Text);
            if(secondClicked==null && firstClicked!=null)
                firstClicked.ForeColor = firstClicked.BackColor;// i dont want to save the first clicked icon only which means it must have matched with the second clicked otherwise  it will not be saved

            for (int i = 0; i < tableLayoutPanel1.Controls.Count ; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                    allIcons[i] = label.Text;
                   
                }
                else
                    continue;     
            }
            for (int i = tableLayoutPanel1.Controls.Count-1; i >= 0; i--)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                {
                    label = (Label)tableLayoutPanel1.Controls[i];
                    if (label.ForeColor == Color.Red)
                        redCards.Add(63-i);
                    if (label.ForeColor == Color.Black)
                        blackCards.Add(63-i);
                }
                else
                    continue;
            }
            //foreach (int i in redCards)
            //    Console.WriteLine(i);
            //Console.ReadLine();

            if (!File.Exists(path))
                return;
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write("Icons : ");
                    sw.WriteLine(string.Join("", allIcons));
                    sw.Write("Black cards : ");
                    sw.WriteLine(string.Join(",", blackCards.ToArray()));
                    sw.Write("Red cards : ");
                    sw.WriteLine(string.Join(",", redCards.ToArray()));
                    //sw.WriteLine("Paler :" + playerOne.ToString());
                    if (playerOne)
                    {
                        sw.Write("Player : ");
                        sw.WriteLine(playerOne.ToString());
                    }

                    else
                    {
                        sw.Write("Player : ");
                        sw.WriteLine((playerOne).ToString());
                    }

                    sw.Write("Player One Points : ");
                    sw.WriteLine(pointsPlayerOne.ToString());
                    sw.Write("Player Two Points : ");
                    sw.WriteLine(pointsPlayerTwo.ToString());
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Reading Error occured.");
            }
   

        }
        #endregion
        #region Quit game option 
        private void fmQuit_Click(object sender, EventArgs e)
        {
            if (!GameOver)
            {
                DialogResult dialog_result = MessageBox.Show("Do you want to save the Game?", "Saving Game", MessageBoxButtons.YesNo);
                if (dialog_result == DialogResult.Yes)
                    SaveGame();
            }
            this.Close();
        }
        #endregion
        private Label fingCorrespondingImage(string clickedIcon,Label SecondClickedIcon)
        {
            Label label;
            for (int i=0;i<tableLayoutPanel1.Controls.Count;i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else continue;
                if (label.Text == clickedIcon)
                {
                    secondClicked = label;
                    secondClicked.ForeColor = Color.Black;
                }
            }
            return secondClicked;
        }
    }
}
