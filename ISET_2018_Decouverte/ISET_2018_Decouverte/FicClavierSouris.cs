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
    public partial class EcranClavierSouris : Form
    {
        int nGauche, nDroit;
        public EcranClavierSouris()
        {
            InitializeComponent();
            btnRAZ_Click(null, null);
        }

        private void btnRAZ_Click(object sender, EventArgs e)
        {
            lbClavier.Items.Clear();
            nGauche = nDroit = 0;
            tbGauche.Text = tbDroite.Text = "0";
            tbPosX.Text = tbPosY.Text = "0";
        }

        private void pSouris_MouseMove(object sender, MouseEventArgs e)
        {
            tbPosX.Text = e.X.ToString();
            tbPosY.Text = e.Y.ToString();
        }

        private void pSouris_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    nGauche++;
                    tbGauche.Text = nGauche.ToString();
                    break;
                case MouseButtons.Right:
                    nDroit++;
                    tbDroite.Text = nDroit.ToString();
                    break;
            }
        }

        private void EcranClavierSouris_KeyPress(object sender, KeyPressEventArgs e)
        {
            string s = "Touche pressee:" + e.KeyChar;
            lbClavier.Items.Insert(0, s);
        }

        private void EcranClavierSouris_KeyDown(object sender, KeyEventArgs e)
        {
            string s = "Touche enfoncee:" + e.KeyCode + " , value: " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void EcranClavierSouris_KeyUp(object sender, KeyEventArgs e)
        {
            string s = "Touche relachee:" + e.KeyCode + " , value : " + e.KeyValue;
            lbClavier.Items.Insert(0, s);
        }

        private void btnQuiter_Click(object sender, EventArgs e)
        { Close(); }
    }
}
