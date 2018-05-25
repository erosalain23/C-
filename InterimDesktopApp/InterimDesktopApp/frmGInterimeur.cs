using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class FrmGInterimeur : MetroFramework.Forms.MetroForm
    {
        public DataTable DtInterimeur { get; set; }
        public BindingSource BsInterimeur  { get; set; }
        private readonly NumberFormatInfo _info = new NumberFormatInfo();
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";

        public FrmGInterimeur()
        {
            InitializeComponent();
            RemplireComboBox();
            RemplireDgv();
            if (dgvInterimeur.Rows.Count > 0)
            {
                Activer(true);
                tbId.Enabled = false;
                dgvInterimeur.Rows[0].Selected = true;
            }
            else
                Activer(false);
        }
        private void Activer(bool b)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            tbId.Enabled = tbNom.Enabled = tbPrenom.Enabled = cbMetier.Enabled = tbBonus.Enabled = !b;
            dgvInterimeur.Enabled = b;
            if (b)
                dgvInterimeur.Focus();
            else
                tbNom.Focus();
        }
        private void RemplireDgv()
        {
            _info.CurrencySymbol = " (%) ";
            DtInterimeur = new DataTable();
            DtInterimeur.Columns.Add(new DataColumn("IdInte",Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtInterimeur.Columns.Add("NomInte");
            DtInterimeur.Columns.Add("PrenomInte");
            DtInterimeur.Columns.Add("IdSpec");
            DtInterimeur.Columns.Add("BonusSal");
            List<C_t_interimeur> interimeurs = new G_t_interimeur(SChonn).Lire("Nom");
            foreach (C_t_interimeur interimeur in interimeurs)
                DtInterimeur.Rows.Add(interimeur.id_inte, interimeur.nom_inte, interimeur.prenom_inte,interimeur.specialisation,string.Format(_info,"{0:C}", interimeur.bonus_sal) );
            BsInterimeur = new BindingSource {DataSource = DtInterimeur};
            dgvInterimeur.DataSource = BsInterimeur;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                if (string.IsNullOrEmpty(tbNom.Text) || string.IsNullOrEmpty(tbPrenom.Text) ||
                    string.IsNullOrEmpty(tbBonus.Text))
                    MessageBox.Show(@"Please fill all require information");
                else
                {
                    var nId = new G_t_interimeur(SChonn).Ajouter(tbNom.Text, tbPrenom.Text,
                        Convert.ToString(cbMetier.SelectedValue), Convert.ToDouble(tbBonus.Text));
                    DtInterimeur.Rows.Add(nId, tbNom, tbPrenom, cbMetier.SelectedItem, tbBonus);
                }
            }
            else
            {
                var nId = int.Parse(tbId.Text);
                new G_t_interimeur(SChonn).Modifier(nId, tbNom.Text, tbPrenom.Text,Convert.ToString(cbMetier.SelectedItem), Convert.ToDouble(tbBonus.Text));
                dgvInterimeur.SelectedRows[0].Cells["NomInte"].Value = tbNom.Text;
                dgvInterimeur.SelectedRows[0].Cells["PrenomInte"].Value = tbPrenom.Text;
                dgvInterimeur.SelectedRows[0].Cells["IdSpec"].Value = cbMetier.SelectedItem;
                dgvInterimeur.SelectedRows[0].Cells["BonusSal"].Value = tbBonus.Text;
                BsInterimeur.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }


        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbNom.Text = tbBonus.Text = "";
            tbId.Enabled = false;
        }
        private void btnEditer_Click(object sender, EventArgs e)
        {
            if (dgvInterimeur.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text = dgvInterimeur.SelectedRows[0].Cells["IdInte"].Value.ToString();
                var interimeur = new G_t_interimeur(SChonn).Lire_ID(int.Parse(tbId.Text));
                tbNom.Text = interimeur.nom_inte;
                tbPrenom.Text = interimeur.prenom_inte;
                tbBonus.Text = Convert.ToString(interimeur.bonus_sal, CultureInfo.CurrentCulture);
                cbMetier.Text = interimeur.specialisation;
            }
            else
                MessageBox.Show(@"There is no row selected!");
        }
        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvInterimeur.SelectedRows.Count > 0)
            {
                var nId = (int) dgvInterimeur.SelectedRows[0].Cells["IdInte"].Value;
                new G_t_interimeur(SChonn).Supprimer(nId);
            }
            else
                MessageBox.Show(@"There is no row selected!");
            RefreshDgv();
        }
        private void RemplireComboBox()
        {
            List<C_t_categorie> categories = new G_t_categorie(SChonn).Lire("IdCateg");
            foreach (C_t_categorie categorie in categories)
                cbMetier.Items.Add(categorie.nom_categ);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearTb();
            cbMetier.SelectedItem = null;
            Activer(true);
        }
        private void RefreshDgv() => RemplireDgv();
        private void ClearTb() => tbId.Text = tbNom.Text = tbPrenom.Text = tbBonus.Text = "";
    }
}
