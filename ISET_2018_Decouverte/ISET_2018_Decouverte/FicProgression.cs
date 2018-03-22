using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Decouverte
{
    public partial class EcranProgression : Form
    {
        public EcranProgression()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {  Close(); }

        private void btnExecuter_Click(object sender, EventArgs e)
        {
            int i, j, pas;
            Cursor curseur = this.Cursor;//it means the cursor of the current form
            Random delai = new Random();//this returns a random value
            Cursor = Cursors.WaitCursor;// the cursor wait tells makes the cursos wait for the progressions to finish 
            btnExecuter.Enabled = btnQuitter.Enabled = false;// disabling btns
            pbPrincipal.Value = 0;//initialy the progress is zero
            for (i = 1; i <= 8; i++)
            {
                pbSecondaire.Value = 0;
                //pas = 5 + 9 * delai.Next(20);
                pas = 5 + 9 * delai.Next(20);//pour quoi 5*9??????????????
                for (j = 1; j <= 20; j++)
                {
                    pbSecondaire.Value = j * 5;//it will attend 20*5 which is equal to 100 and then it will update the pbPrincipal
                    System.Threading.Thread.Sleep(pas);// this waits for a random period to load the next progress
                }
                pbPrincipal.Value = i * 100 / 8;// this is divided into 7 progressions because 8*100/8=100 and it will be full
            }
            btnExecuter.Enabled = btnQuitter.Enabled = true;
            Cursor = curseur;//the cursor is put on again
        }
    }
}
