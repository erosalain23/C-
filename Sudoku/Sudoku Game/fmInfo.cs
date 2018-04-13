using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sudoku_Game
{
    public partial class fmInfo : Form
    {
        #region help string
        //Text saying how to play the game
        private string userInfo = @"    The classic Sudoku game involves a grid of 81 squares. 
                                    The grid is divided into nine blocks, each containing nine squares.
                                    The rules of the game are simple: 
                                    each of the nine blocks has to contain all the numbers 1-9 within its squares. 
                                    Each number can only appear once in a row, column or box.
                                    The difficulty lies in that each vertical nine-square column, 
                                    or horizontal nine-square line across, within the larger square, 
                                    must also contain the numbers 1-9, without repetition or omission.
                                    Every puzzle has just one correct solution.
                                    ";
        #endregion
        #region constructor
        public fmInfo()
        {
            InitializeComponent();
            lblInfo.Text = userInfo;
        }
        #endregion
    }
}
