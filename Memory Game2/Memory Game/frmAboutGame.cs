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
    public partial class frmAboutGame : Form
    {
        public frmAboutGame()
        {
            InitializeComponent();
        }

        private void btnOkToPlay_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
