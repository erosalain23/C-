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
    public partial class EcranPrincipal : Form
    {
        public EcranPrincipal()
        {
            InitializeComponent();
        }

        private void mQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void mNonDefini_Click(object sender, EventArgs e)
        {MessageBox.Show("Fonctionalité non implementée");}

        private void mAide_Click(object sender, EventArgs e)
        {
            FicAide f = new FicAide();
            f.Show();
        }

        private void mfProgression_Click(object sender, EventArgs e)
        {
            EcranProgression f = new EcranProgression();
            f.ShowDialog();
        }

        private void mfListe_Click(object sender, EventArgs e)
        {
            EcranList f = new EcranList();
            f.ShowDialog();
        }

        private void mfEditeur_Click(object sender, EventArgs e)
        {
            EcranEditeur f = new EcranEditeur();
            f.ShowDialog();
        }

        private void horlogeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranHorloge f = new EcranHorloge();
            f.ShowDialog();
        }

        private void spirographeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EcranSpirographe f = new EcranSpirographe();
            f.ShowDialog();
        }
        private void mfCarnaval_Click(object sender, EventArgs e)
        {
            EcranCarnaval f = new EcranCarnaval();
            f.ShowDialog();
        }

        private void mfClavierSouris_Click(object sender, EventArgs e)
        {
            EcranClavierSouris f = new EcranClavierSouris();
            f.ShowDialog();
        }

        private void dessinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //EcranDessin f = new EcranDessin();
            //f.ShowDialog();
        }

        private void mfExplorateur_Click(object sender, EventArgs e)
        {
            EcranExplorateur f = new EcranExplorateur();
            f.ShowDialog();
        }

        private void mfBD1_Click(object sender, EventArgs e)
        {
            FicBD1 f = new FicBD1();
            f.ShowDialog();
        }

        private void mfBD2_Click(object sender, EventArgs e)
        {
            FicBD2 f = new FicBD2();
            f.ShowDialog();
        }

        private void mfBD3_Click(object sender, EventArgs e)
        {
            EcranBD3 f = new EcranBD3();
            f.ShowDialog();
        }

        private void mfDiner_Click(object sender, EventArgs e)
        {
            EcranDinerPhilosophes f = new EcranDinerPhilosophes();
            f.ShowDialog();
        }
    }
}

