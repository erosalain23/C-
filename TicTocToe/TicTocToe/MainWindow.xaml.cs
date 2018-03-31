
using System;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;

namespace TicTocToe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        #region Private members

        #endregion
        private MarkType[] mResults;
        private bool mPlayer1Turn;
        private bool mGameEnded;
        #region Constructor
        // default constructor
        public MainWindow()
        {
            InitializeComponent();
            NewGame();
        }

        #endregion

        private void NewGame()
        {
            mResults = new MarkType[9];
            for (var i = 0; i < mResults.Length; i++)
                mResults[i] = MarkType.Free;
            mPlayer1Turn = true;

            Container.Children.Cast<Button>().ToList().ForEach(button => 
            {
                button.Content = string.Empty;
                button.Background = Brushes.White;
                button.Foreground = Brushes.Blue;
            });

            mGameEnded = false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (mGameEnded)
            {
                NewGame();
                return;
            }
            var button = (Button)sender;

            var column = Grid.GetColumn(button);
            var row = Grid.GetRow(button);
            var index = column + (row * 3);
            if(mResults[index] != MarkType.Free)
                return;
            mResults[index] = mPlayer1Turn ? MarkType.Cross : MarkType.Nought;
            button.Content = mPlayer1Turn ? "X" : "0";
           
            if (!mPlayer1Turn)
                button.Foreground = Brushes.Red;

            mPlayer1Turn ^= true; // toggle the  player's bool to treu or false if it was true

            checkForWinner();
        }

        private void checkForWinner()
        {
            #region Horizantol wins
            //check for horizontal wins
            //Row 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[1] & mResults[2]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_0.Background = Button1_0.Background = Button2_0.Background = Brushes.Green;
            }
            //Row 1
            if (mResults[3] != MarkType.Free && (mResults[3] & mResults[4] & mResults[5]) == mResults[3])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_1.Background = Button1_1.Background = Button2_1.Background = Brushes.Green;
            }
            //Row 2
            if (mResults[6] != MarkType.Free && (mResults[6] & mResults[7] & mResults[8]) == mResults[6])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_2.Background = Button1_2.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region vertical wins
            //check for Vertical wins
            //Column 0
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[3] & mResults[6]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_0.Background = Button0_1.Background = Button0_2.Background = Brushes.Green;
            }
            //Column 1
            if (mResults[1] != MarkType.Free && (mResults[1] & mResults[4] & mResults[7]) == mResults[1])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button1_0.Background = Button1_1.Background = Button1_2.Background = Brushes.Green;
            }
            //Column 2
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[5] & mResults[8]) == mResults[2])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button2_0.Background = Button2_1.Background = Button2_2.Background = Brushes.Green;
            }
            #endregion
            #region Diagonal wins
            //check for Vertical wins
            //Top left bottom right
            if (mResults[0] != MarkType.Free && (mResults[0] & mResults[4] & mResults[8]) == mResults[0])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_0.Background = Button1_1.Background = Button2_2.Background = Brushes.Green;
            }
            //Top left bottom right
            if (mResults[2] != MarkType.Free && (mResults[2] & mResults[4] & mResults[6]) == mResults[2])
            {
                // Game ends
                mGameEnded = true;
                // highlight winning cells 
                Button0_2.Background = Button1_1.Background = Button2_0.Background = Brushes.Green;
            }
            #endregion

            // check for no winner
            if (!mResults.Any(f => f == MarkType.Free))
            {
                //Game endded
                mGameEnded = true;
                Container.Children.Cast<Button>().ToList().ForEach(button =>
                {
                    button.Background = Brushes.Orange;
                });
            }
        }

    }
}
