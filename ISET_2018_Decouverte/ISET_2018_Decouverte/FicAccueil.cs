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
    public partial class EcranAccueil : Form
    {
        
        private bool flag=false;
        public EcranAccueil()
        {
            InitializeComponent();
        }

        private void btnPoussez_Click(object sender, EventArgs e)
        { 
            flag = !flag;
            //PictureBox pb = new PictureBox();
            if (flag)
            {
                lblTitre.Text = "Alien Image";
                pbImageDepart.ImageLocation = "C:/Users/Alain/source/repos/ISET_2018_Decouverte/ISET_2018_Decouverte/alien.png";
                pbImageDepart.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImageDepart.Height = 100;
                pbImageDepart.Width = 100;
                //this.Controls.Add(pb);
            }
            else
            {
                lblTitre.Text = "Decouverte de C sharp";
                pbImageDepart.ImageLocation = "C:/Users/Alain/source/repos/ISET_2018_Decouverte/ISET_2018_Decouverte/alien2.png";
                pbImageDepart.SizeMode = PictureBoxSizeMode.StretchImage;
                pbImageDepart.Height = 100;
                pbImageDepart.Width = 100;
               // this.Controls.Add(pb);
            }
         
            
        }

        //private void EcranAccueil_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (MessageBox.Show("Souhaitez vous réellement quitter?", "votre souhait", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) e.Cancel = false;
        //    else
        //    {
        //        e.Cancel = true;
        //        f.ShowDialog();
        //        //e.Cancel = !e.Cancel;
        //        Close();
        //        //Show();
        //    }
        //    //else  Close();
        //    //
        //    //if (e.Cancel) f.Show();
        //}

        private void btnEntrez_Click(object sender, EventArgs e)
        {
            //this.Hide();         
            //f.ShowDialog();
            Close();
            
        }

    }
}
