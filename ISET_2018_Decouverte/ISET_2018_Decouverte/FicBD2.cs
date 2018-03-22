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
    public partial class FicBD2 : Form
    {
        public FicBD2()
        {
            InitializeComponent();
            clientBindingSource.PositionChanged += new EventHandler(BougerClient);
        }

        private void EcranBD2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dsPerso.Client' table. You can move, or remove it, as needed.
            this.clientTableAdapter.Fill(this.dsPerso.Client);
            //string s = Program.PA.chConnDB;
            Bouger();
            ActiverNavi(clientBindingSource.Count > 0);
        }
        private void BougerClient(object sender, EventArgs e)
        { Bouger(); }
        private void btnPrem_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = 0;
        }
        private void btnPrec_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position--;
        }
        private void btnSuiv_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position++;
        }
        private void btnDern_Click(object sender, EventArgs e)
        {
            clientBindingSource.Position = clientBindingSource.Count - 1;
        }
        private void ActiverNavi(bool lActi)
        {
            //btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = lActi;
            btnAjout.Enabled = btnModi.Enabled = btnSupp.Enabled = lActi;
            tbPre.Enabled = tbNom.Enabled = dtdNaissance.Enabled = !lActi;
            btnConf.Enabled = btnAnn.Enabled = !lActi;
        }
        private void Bouger()
        {
            btnPrem.Enabled = btnPrec.Enabled = btnSuiv.Enabled = btnDern.Enabled = true;
            if (clientBindingSource.Position == 0)
                btnPrem.Enabled = btnPrec.Enabled = false;
            if (clientBindingSource.Position == clientBindingSource.Count - 1)
                btnSuiv.Enabled = btnDern.Enabled = false;
            lblPos.Text = (1 + clientBindingSource.Position).ToString() + "/" + clientBindingSource.Count.ToString();
            //if (clientBindingSource.Count == 0)
            //    btnSupp.Enabled = btnModi.Enabled = false;
            //else
            //    btnSupp.Enabled = btnModi.Enabled = true;
            btnSupp.Enabled = btnModi.Enabled = (clientBindingSource.Count > 0);
        }
        private void btnAjout_Click(object sender, EventArgs e)
        {
            clientBindingSource.AddNew();
            ActiverNavi(false);
        }
        private void btnModi_Click(object sender, EventArgs e)
        {ActiverNavi(false);}
        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Souhetez vous supprimer cet enregistrement?", "confirmer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clientBindingSource.RemoveAt(clientBindingSource.Position);
                ValiderModif();
            }
        }
        private void btnAnn_Click(object sender, EventArgs e)
        {
            clientBindingSource.CancelEdit();
            ActiverNavi(true);
        }
        private void btnConf_Click(object sender, EventArgs e)
        {
            clientBindingSource.EndEdit();
            if (dsPerso.HasChanges()) ValiderModif();
            else MessageBox.Show("Aucune modification");
            ActiverNavi(true);
        }
        private void ValiderModif()
        {
            try
            {
                MessageBox.Show(clientTableAdapter.Update(dsPerso.Client).ToString() + "mise a jour effectuee");
            }
            catch { MessageBox.Show("Echec de la mise a jour"); }
        }
    }
}
