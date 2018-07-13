using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using ISET2018_CouClasses;
using ISET2018_CouGestion;


namespace ISET_2018_Decouverte
{
    public partial class EcranBD3 : Form
    {
        private DataTable dtPersonne;
        private BindingSource bsPersonnes;
        private string sChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Bac2\P.Alexandre\Personne\BD_Perso.mdf;Integrated Security=True;Connect Timeout=30";
        public EcranBD3()
        {
            InitializeComponent();
            RemplirDGV();
            if (dgvPersonne.Rows.Count > 0)
            {
                Activer(true);
                dgvPersonne.Rows[0].Selected = true;
            }
            else
                Activer(false);
        }
        private void Activer(bool lNavigation)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = lNavigation;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !lNavigation;
            dtpNai.Enabled = tbNom.Enabled = tbPre.Enabled = !lNavigation;
            dgvPersonne.Enabled = lNavigation;
            if (lNavigation)
                dgvPersonne.Focus();
            else
                tbPre.Focus();
        }
        private void RemplirDGV()
        {
            dtPersonne = new DataTable();
            dtPersonne.Columns.Add(new DataColumn("ID", System.Type.GetType("System.Int32")));
            dtPersonne.Columns.Add("Afficher");
            List<C_Personne> lTmp = new G_Personne(sChonn).Lire("Nom");
            foreach (C_Personne Tmp in lTmp)
                dtPersonne.Rows.Add(Tmp.ID, Tmp.PRE + " " + Tmp.NOM);
            bsPersonnes = new BindingSource();
            bsPersonnes.DataSource = dtPersonne;
            dgvPersonne.DataSource = bsPersonnes;
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbPre.Text = tbNom.Text = "";
            dtpNai.Value = DateTime.Today;

        }
        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text =dgvPersonne.SelectedRows[0].Cells["ID"].Value.ToString();
                C_Personne Tmp = new G_Personne(sChonn).Lire_ID(int.Parse(tbId.Text));
                tbPre.Text = Tmp.PRE;
                tbNom.Text = Tmp.NOM;
                dtpNai.Value = (Tmp.NAI == null ? DateTime.Today : (DateTime)Tmp.NAI);
            }
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvPersonne.SelectedRows.Count > 0)
            {
                int nID = (int)dgvPersonne.SelectedRows[0].Cells["ID"].Value;
                new G_Personne(sChonn).Supprimer(nID);
                // for testing
                bsPersonnes.RemoveCurrent();
            }
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (tbNom.Text.Length == 0)
                MessageBox.Show("Veuillez renseigner le nom");
            else
            {
                if (tbId.Text == "")
                //Mode ajout
                {
                    int nID = new G_Personne(sChonn).Ajouter(tbNom.Text, tbPre.Text, dtpNai.Value);
                    dtPersonne.Rows.Add(nID,tbPre.Text + " " + tbNom.Text);
                }
                else
                //Mode edition
                {
                    int nID = int.Parse(tbId.Text);
                    new G_Personne(sChonn).Modifier(nID,tbNom.Text,tbPre.Text,dtpNai.Value);
                    //for (int i = 0; i < dtPersonne.Rows.Count; i++)
                    //{
                    //    if ((int)dtPersonne.Rows[i]["ID"] == nID)
                    //    {
                    //        dtPersonne.Rows[i]["Afficher"] = tbPre.Text + " " + tbNom.Text;
                    //        break;
                    //    }
                    //}
                    //a tester
                    dgvPersonne.SelectedRows[0].Cells["Afficher"].Value = tbPre.Text + " " + tbNom.Text;
                    bsPersonnes.EndEdit();
                    Activer(true);
                }
            }
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        { Activer(true);}

        private void dgvPersonne_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
