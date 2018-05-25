using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class FrmGEntreprise : MetroFramework.Forms.MetroForm
    {
        public DataTable DtEntreprise { get; set; }
        public BindingSource BsEntreprise { get; set; }
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";

        public FrmGEntreprise()
        {
            InitializeComponent();
            RemplireDgv();
            if (dgvEntreprise.Rows.Count > 0)
            {
                Activer(true);
                tbId.Enabled = false;
                dgvEntreprise.Rows[0].Selected = true;
            }
            else
                Activer(false);
        }
        private void Activer(bool b)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            tbId.Enabled = tbNom.Enabled = !b;
            dgvEntreprise.Enabled = b;
            if (b)
                dgvEntreprise.Focus();
            else
                tbNom.Focus();
        }
        private void RemplireDgv()
        {
            DtEntreprise = new DataTable();
            DtEntreprise.Columns.Add(new DataColumn("IdEntre", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtEntreprise.Columns.Add("NomEntre");
            List<C_t_entreprise> entreprises = new G_t_entreprise(SChonn).Lire("Nom");
            foreach (var entreprise in entreprises)
                DtEntreprise.Rows.Add(entreprise.id_entre, entreprise.nom_entre);
            BsEntreprise = new BindingSource {DataSource = DtEntreprise};
            dgvEntreprise.DataSource = BsEntreprise;
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            Activer(true);
            if (string.IsNullOrEmpty(tbId.Text))
            {
                if (string.IsNullOrEmpty(tbNom.Text))
                    MessageBox.Show(@"Please fill all require information");
                else
                {
                    var nId = new G_t_entreprise(SChonn).Ajouter(tbNom.Text);
                    DtEntreprise.Rows.Add(nId, tbNom);
                }
            }
            else
            {
                var nId = int.Parse(tbId.Text);
                new G_t_entreprise(SChonn).Modifier(nId, tbNom.Text);
                dgvEntreprise.SelectedRows[0].Cells["NomEntre"].Value = tbNom.Text;
                dgvEntreprise.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbNom.Text = "";
            tbId.Enabled = false;
        }
        private void btnEditer_Click(object sender, EventArgs e)
        {
            Activer(false);
            if (dgvEntreprise.SelectedRows.Count > 0)
            {
                tbId.Text = dgvEntreprise.SelectedRows[0].Cells["IdEntre"].Value.ToString();
                var entreprise = new G_t_entreprise(SChonn).Lire_ID(int.Parse(tbId.Text));
                tbNom.Text = entreprise.nom_entre;
            }
            else
                MessageBox.Show(@"There is no row selected!");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            Activer(false);
            if (dgvEntreprise.SelectedRows.Count > 0)
            {
                var nId = (int) dgvEntreprise.SelectedRows[0].Cells["IdEntre"].Value;
                new G_t_entreprise(SChonn).Supprimer(nId);
            }
            else
                MessageBox.Show(@"There is no row selected!");
            RefreshDgv();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Activer(true);
            ClearTb();
        }
        private void RefreshDgv() => RemplireDgv();
        private void ClearTb() => tbId.Text = tbNom.Text = "";
    }
}
