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
    public partial class EcranEditeur : Form
    {
        private bool lModifie = false;
        private string NomFichier = "";
        public EcranEditeur()
        {
            InitializeComponent();
        }
        private void EnregistrerFichier()
        {
            if (NomFichier == "")
                if (dlgSauverFichier.ShowDialog() == DialogResult.OK)
                    NomFichier = dlgSauverFichier.FileName;
            if (NomFichier != "")
            {
                rtbTexte.SaveFile(NomFichier);
                lModifie = false;
            }
        }
        private void VerifierSauver()
        {
            if (lModifie)
                if (MessageBox.Show("Enregistre la modification ?", "Texte modifié", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    EnregistrerFichier();
        }
    
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            rtbTexte.Clear();
            NomFichier = "";
            lModifie = false;
            rtbTexte.Focus();
        }

        private void btnOuvrir_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            if (dlgOuvrirFichier.ShowDialog() == DialogResult.OK)
            {
                NomFichier = dlgOuvrirFichier.FileName;
                rtbTexte.LoadFile(NomFichier);
            }
            lModifie = false;
        }

        private void mefSauver_Click(object sender, EventArgs e)
        {
            VerifierSauver();
        }

        private void mefQuitter_Click(object sender, EventArgs e)
        {
            VerifierSauver();
            Close();
        }

        private void rtbTexte_TextChanged(object sender, EventArgs e)
        {
            lModifie = true;
        }

        private void mefjGauche_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Left;
        }

        private void mefjDroite_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void mefjCentre_Click(object sender, EventArgs e)
        {
            rtbTexte.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void mefPolice_Click(object sender, EventArgs e)
        {
            if (dlgPolice.ShowDialog() == DialogResult.OK)
                rtbTexte.SelectionFont = new Font(dlgPolice.Font, dlgPolice.Font.Style);
        }

        private void meeCouper_Click(object sender, EventArgs e)
        {
            rtbTexte.Cut();
        }

        private void meeCopier_Click(object sender, EventArgs e)
        {
            rtbTexte.Copy();
        }

        private void meeColler_Click(object sender, EventArgs e)
        {
            rtbTexte.Paste();
        }

        private void mefcGras_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            if (rtbTexte.SelectionFont.Bold)
                NouvellePolice = FontStyle.Regular;
            else
                NouvellePolice = FontStyle.Bold;
            rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void mefcItalique_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbTexte.SelectionFont.Italic)
                NouvellePolice = FontStyle.Regular;
            //else
                NouvellePolice = FontStyle.Italic ^ PoliceActuelle.Style;
            rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void mefcSouligne_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbTexte.SelectionFont.Underline)
                NouvellePolice = FontStyle.Regular^PoliceActuelle.Style;
            //else
                NouvellePolice = FontStyle.Underline;
            rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }

        private void mefcBarre_Click(object sender, EventArgs e)
        {
            System.Drawing.Font PoliceActuelle = rtbTexte.SelectionFont;
            System.Drawing.FontStyle NouvellePolice;
            //if (rtbTexte.SelectionFont.Strikeout)
                NouvellePolice = FontStyle.Regular^PoliceActuelle.Style;
            //else
                NouvellePolice = FontStyle.Strikeout;
            rtbTexte.SelectionFont = new Font(PoliceActuelle.FontFamily, PoliceActuelle.Size, NouvellePolice);
        }
    }
}
/* Filter de dlgOuvrirFichier et dlgSauverFichier
 Nos fichiers(*.mesdocs)|*.mesdocs|Tous fichiers(*.*)|*.*  
*/
