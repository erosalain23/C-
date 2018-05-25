using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class FrmGPrestation : MetroFramework.Forms.MetroForm
    {
        public DataTable DtPrestation { get; set; }
        public BindingSource BsPrestation { get; set; }
        private  readonly NumberFormatInfo _info=new NumberFormatInfo();

        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FrmGPrestation()
        {
            InitializeComponent();
            RemplireComboBox();
            RemplireDgv();
            if (dgvPrestation.Rows.Count > 0)
            {
                Activer(true);
                tbId.Enabled = false;
                dgvPrestation.Rows[0].Selected = true;
            }
            else
                Activer(false);
            ClearTb();
        }
        private void Activer(bool b)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = tbId.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            tbId.Enabled = tbNomPresta.Enabled = tbSalPresta.Enabled =
                dtpStart.Enabled = dtpEnd.Enabled = cbCategorie.Enabled = cbFacture.Enabled = !b;
            dgvPrestation.Enabled = b;
            if (b)
                dgvPrestation.Focus();
            else
                tbNomPresta.Focus();
        }
        private void RemplireDgv()
        {
            _info.CurrencySymbol = " (%) ";
            DtPrestation = new DataTable();
            DtPrestation.Columns.Add(new DataColumn("IdPresta", System.Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtPrestation.Columns.Add("NomTravail");
            DtPrestation.Columns.Add("DtDebut");
            DtPrestation.Columns.Add("DtFin");
            DtPrestation.Columns.Add("SalTravail");
            DtPrestation.Columns.Add("IdCateg");
            DtPrestation.Columns.Add("IdFact");
            List<C_t_travail> travails = new G_t_travail(SChonn).Lire("Nom");
            foreach (var travail in travails)
                DtPrestation.Rows.Add(travail.Id_travail, travail.nom_travail, travail.date_debut, travail.date_fin, travail.prix_travail, travail.id_categ, travail.id_fact);
            BsPrestation = new BindingSource {DataSource = DtPrestation};
            dgvPrestation.DataSource = BsPrestation;
        }
        private void btnConfirmer_Click_1(object sender, EventArgs e)
        {
            _info.CurrencySymbol = " (%) ";
            if (string.IsNullOrEmpty(tbId.Text))
            {
                if (string.IsNullOrEmpty(tbNomPresta.Text) || string.IsNullOrEmpty(tbSalPresta.Text))
                    MessageBox.Show(@"Please fill all require information");
                else
                {
                    new G_t_travail(SChonn).Ajouter(tbNomPresta.Text, double.Parse(tbSalPresta.Text), dtpStart.Value,
                        dtpEnd.Value,Convert.ToInt32(cbCategorie.SelectedItem),Convert.ToInt32(cbFacture.SelectedItem));
                }
            }
           
            else
            {
                var nId = int.Parse(tbId.Text);
                new G_t_travail(SChonn).Modifier(nId, tbNomPresta.Text, Convert.ToDouble(tbSalPresta.Text), dtpStart.Value, dtpEnd.Value, Convert.ToInt32(cbCategorie.SelectedItem), Convert.ToInt32(cbFacture.SelectedItem));
                dgvPrestation.SelectedRows[0].Cells["NomPresta"].Value = tbNomPresta.Text;
                dgvPrestation.SelectedRows[0].Cells["DtStart"].Value = dtpStart.Text;
                dgvPrestation.SelectedRows[0].Cells["DtEnd"].Value = dtpEnd.Text;
                dgvPrestation.SelectedRows[0].Cells["SalTravail"].Value = tbSalPresta.Text;
                dgvPrestation.SelectedRows[0].Cells["Idcateg"].Value = cbCategorie.SelectedItem;
                dgvPrestation.SelectedRows[0].Cells["IdFact"].Value = cbFacture.Text;
                dgvPrestation.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }

        private void RemplireComboBox()
        {
            List<C_t_categorie> categories = new G_t_categorie(SChonn).Lire("IdCateg");
            foreach (var categorie in categories)
                cbCategorie.Items.Add(categorie.nom_categ);
            List<C_t_facture> factures = new G_t_facture(SChonn).Lire("IdFact");
            foreach (var facture in factures)
                cbCategorie.Items.Add(facture.id_fact);
        }

        private void llbCateg_Click(object sender, EventArgs e)
        {
            var frm = new FrmGCategorie();
            frm.ShowDialog();
        }

        private void btnAjouter_Click_1(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbNomPresta.Text = tbSalPresta.Text = "";
            cbCategorie.SelectedItem = cbFacture.SelectedItem = -1;
        }

        private void btnEditer_Click_1(object sender, EventArgs e)
        {
            if (dgvPrestation.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text = dgvPrestation.SelectedRows[0].Cells["IdPresta"].Value.ToString();
                var travail = new G_t_travail(SChonn).Lire_ID(int.Parse(tbId.Text));
                tbNomPresta.Text = travail.nom_travail;
                tbSalPresta.Text = Convert.ToString(travail.prix_travail, CultureInfo.InvariantCulture);
                dtpStart.Text = Convert.ToString(travail.date_debut, CultureInfo.CurrentCulture);
                cbCategorie.Text = Convert.ToString(travail.date_fin, CultureInfo.CurrentCulture);
                cbFacture.Text = Convert.ToString(travail.id_fact);
            }
            else
                MessageBox.Show(@"There is no row selected!");
        }

        private void btnSupprimer_Click_1(object sender, EventArgs e)
        {
            if (dgvPrestation.SelectedRows.Count > 0)
            {
                var nId = (int) dgvPrestation.SelectedRows[0].Cells["IdPresta"].Value;
                new G_t_travail(SChonn).Supprimer(nId);
            }
            else
                MessageBox.Show(@"There is no row selected!");
            RefreshDgv();
        }
        private void RefreshDgv() => RemplireDgv();
        private void btnAnnuler_Click_1(object sender, EventArgs e) => Activer(true);
        private void ClearTb()
        {
            tbId.Text = tbNomPresta.Text = tbSalPresta.Text = "";
            //cbCategorie.SelectedIndex = cbFacture.SelectedIndex = 0;
        }
    }
}
