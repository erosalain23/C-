using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorFinal
{
    public partial class Form1 : Form
    {
        double total1 = 0;
        double total2 = 0;

        public Form1()
        {
            InitializeComponent();
        }
        /*Creating Num button display functions*/
        private void btnOne_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnOne.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnTwo.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnThree.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnFour.Text;
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnSix.Text;
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnSeven.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnEight.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnNine.Text;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Text = DisplayAnswer.Text + btnZero.Text;
        }
        /*END of number display functions*/

        /*Clearing function*/
        private void btnClear_Click(object sender, EventArgs e)
        {
            DisplayAnswer.Clear();
        }

        /* Adding function*/
        private void btnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(DisplayAnswer.Text);
            DisplayAnswer.Clear();
        }

        /*Creating the equal function*/
        private void btnEqual_Click(object sender, EventArgs e)
        {
            total2 = total1 + double.Parse(DisplayAnswer.Text);
            DisplayAnswer.Text = total2.ToString();
            total1 = 0;
        }
    }
}
