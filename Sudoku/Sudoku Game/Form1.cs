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
    public partial class fmWelcome : Form
    {
        public fmWelcome()
        {
            InitializeComponent();
            MaximizeBox = false;
            MinimizeBox = false;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            fmEngine f = new fmEngine();
            f.ShowDialog();

        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            fmInfo f1 = new fmInfo();
            f1.ShowDialog();
        }
    }
}
