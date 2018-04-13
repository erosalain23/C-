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
    public partial class fmEngine : Form
    {
        Random random = new Random();
       
        private bool player1 = false;
        private bool gameEnd = false;

        #region constructor
        public fmEngine()
        {
            InitializeComponent();
            AssignNumbersToSquares();
        }
        #endregion
        #region application close
        private void msClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
        private void msInfo_Click(object sender, EventArgs e)
        {
            fmInfo f = new fmInfo();
            f.ShowDialog();
        }

        private void AssignNumbersToSquares()
        {
                int[,] emptySudoku = new int[9, 9]
            {
                    {1,1,1,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0},
                    {0,0,0,1,0,0,0,0,0},
                    {0,0,0,0,0,0,0,8,0},
                    {0,0,0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0},
                    {0,0,0,0,0,0,0,0,0}
            };
            Label label;
            foreach (Label l in tableLayoutPanel1.Controls)
            {
                if (l is Label)
                    l.Text = "1";
                else
                    continue;
            }
            //for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            //{
            //    for (int j = 0; j < tableLayoutPanel1.Controls.Count; j++)
            //    {
            //        if (tableLayoutPanel1.Controls[i] is Label)
            //            label = (Label)tableLayoutPanel1.Controls[i];
            //        else
            //            continue;
            //        label.Text = "1";
            //    }

            //}
        }

        //private void pictureBox1_Click(object sender, EventArgs e)
        //{
          
        //}

        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
            
        //}

        //private void button1_Paint(object sender, PaintEventArgs e)
        //{
        //    Bitmap bm = new Bitmap(400, 400);
        //    Graphics g = Graphics.FromImage(bm);
        //    g.DrawRectangle(new Pen(Color.Black, 10), ClientSize.Width / 2, ClientSize.Height / 2, 100, 100);
        //    pictureBox1.Image = bm;
        //}
    }
}
