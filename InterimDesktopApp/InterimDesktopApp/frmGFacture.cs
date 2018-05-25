using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class FrmGFacture : MetroFramework.Forms.MetroForm
    {
        public DataTable DtFacture { get; set; }
        public BindingSource BsFacture { get; set; }
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";

        public FrmGFacture()
        {
            InitializeComponent();
            RemplireComboBox();
            RemplireDgv();
            if (dgvFacture.Rows.Count <= 0) return;
            Activer(true);
            tbId.Enabled = false;
            dgvFacture.Rows[0].Selected = true;
        }
        private void Activer(bool b)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            dtpFacture.Enabled = cbEntre.Enabled = cbInte.Enabled = !b;
            dgvFacture.Enabled = b;
            if (b)
                dgvFacture.Focus();
            else
                dtpFacture.Focus();
        }

        private void RemplireDgv()
        {
            DtFacture = new DataTable();
            DtFacture.Columns.Add(new DataColumn("IdFact", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtFacture.Columns.Add("DateFact");
            DtFacture.Columns.Add("IdEntre");
            DtFacture.Columns.Add("IdInte");
            List<C_t_facture> factures = new G_t_facture(SChonn).Lire("Nom");
            foreach (C_t_facture facture in factures)
                DtFacture.Rows.Add(facture.date_fact,facture.id_entre,facture.id_inte);
            BsFacture = new BindingSource {DataSource = DtFacture};
            dgvFacture.DataSource = BsFacture;
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                var nId = new G_t_facture(SChonn).Ajouter(dtpFacture.Value, Convert.ToInt32(cbEntre.SelectedItem), Convert.ToInt32(cbInte.SelectedItem));
                DtFacture.Rows.Add(nId, DtFacture, cbEntre.SelectedItem, cbInte.SelectedItem);
            }
            else
            {
                var nId = int.Parse(tbId.Text);
                new G_t_facture(SChonn).Modifier(nId, dtpFacture.Value, Convert.ToInt32(cbEntre.SelectedItem), Convert.ToInt32(cbInte.SelectedItem));
                dgvFacture.SelectedRows[0].Cells["DateFact"].Value = DtFacture;
                dgvFacture.SelectedRows[0].Cells["IdEntre"].Value = cbEntre.Text;
                dgvFacture.SelectedRows[0].Cells["IdInte"].Value = cbInte.SelectedItem;
                BsFacture.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = "";
            dtpFacture.Value = DateTime.Today;
            cbEntre.SelectedItem = cbInte.SelectedItem = null;
        }
        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvFacture.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text = dgvFacture.SelectedRows[0].Cells["IdFact"].Value.ToString();
                var facture = new G_t_facture(SChonn).Lire_ID(int.Parse(tbId.Text));
                dtpFacture.Value = facture.date_fact;
                cbEntre.Text = facture.id_entre.ToString();
                cbInte.Text = facture.id_inte.ToString();
            }
            else
                MessageBox.Show(@"There is no row selected!");
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvFacture.SelectedRows.Count > 0)
            {
                var nId = (int) dgvFacture.SelectedRows[0].Cells["IdFact"].Value;
                new G_t_facture(SChonn).Supprimer(nId);
            }
            else
                MessageBox.Show(@"There is no row selected!");
            RefreshDgv();
        }
        private void RemplireComboBox()
        {
            List<C_t_entreprise> entreprises = new G_t_entreprise(SChonn).Lire("Nom");
            List<C_t_interimeur> interimeurs = new G_t_interimeur(SChonn).Lire("IdCateg");
            foreach (var entreprise in entreprises)
                cbEntre.Items.Add(entreprise.nom_entre);
            foreach (var interimeur in interimeurs)
                cbInte.Items.Add(interimeur.nom_inte);
        }
        private void btnAnnuler_Click(object sender, EventArgs e) => Activer(true);
        private void RefreshDgv() => RemplireDgv();
        private void ClearTb() => tbId.Text = "";
    }
}
