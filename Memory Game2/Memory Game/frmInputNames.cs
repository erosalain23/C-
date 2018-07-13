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
    
    public partial class frmInputNames : Form
    {
        public string player1Name { get; set; }
        public string player2Name { get; set; }
        public frmInputNames()
        {
            InitializeComponent();
        }
        private void btnGo_Click(object sender, EventArgs e)
        {
            this.Hide();
            player1Name = lblPlyr1Nm.Text;
            player2Name = lblPlyr2Nm.Text;
            if (player1Name != "" && player2Name != "")
            {
                frmGameEngine f = new frmGameEngine(player1Name,player2Name);
                f.ShowDialog();
                this.Close();
            }
            else MessageBox.Show("Enter all players names"); 
        }
       
    }
}
