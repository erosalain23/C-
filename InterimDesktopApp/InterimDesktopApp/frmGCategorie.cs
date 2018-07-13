
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using InterimCouClasse;
using InterimCouGestion;

namespace InterimDesktopApp
{
    public partial class FrmGCategorie : MetroFramework.Forms.MetroForm
    {
        public DataTable DtCategorie { get; set; }
        public BindingSource BsCategorie { get; set; }
        private readonly NumberFormatInfo _info =new NumberFormatInfo();

        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FrmGCategorie()
        {
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey600, MaterialSkin.Primary.Teal100, MaterialSkin.Primary.Teal300, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);
            InitializeComponent();
            _info.CurrencySymbol = " (€) ";
            RemplirDgv();
            if (dgvCategorie.Rows.Count > 0)
            {
                Activer(true);
                tbId.Enabled = false;
                dgvCategorie.Rows[0].Selected = true;
            }
            else
                MessageBox.Show(@"Enter new records because the table is apparently empty or there is an error");
        }
        private void Activer(bool b)
        {
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = tbId.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            tbId.Enabled = tbCateg.Enabled = tbSal.Enabled = !b;
            if (b)
                dgvCategorie.Focus();
        }
        private void RemplirDgv()
        {
            DtCategorie=new DataTable();
            DtCategorie.Columns.Add(new DataColumn("id_cat", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtCategorie.Columns.Add("nom_cat");
            DtCategorie.Columns.Add("sal_cat");
            List<C_t_categorie> categories = new G_t_categorie(SChonn).Lire("Nom");
            foreach (var categorie in categories)
                DtCategorie.Rows.Add(categorie.id_categ, categorie.nom_categ,
                    string.Format(_info, "{0:C}", categorie.sal_categ));
            BsCategorie = new BindingSource {DataSource = DtCategorie};
            dgvCategorie.DataSource = BsCategorie;
        }
        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            _info.CurrencySymbol = " € ";
            if (string.IsNullOrEmpty(tbId.Text))
            {
                if (string.IsNullOrEmpty(tbCateg.Text) || string.IsNullOrEmpty(tbSal.Text))
                    MessageBox.Show(@"Please fill all require information");
                else
                    new G_t_categorie(SChonn).Ajouter(tbCateg.Text, double.Parse(tbSal.Text));
                //MessageBox.Show(nId.ToString());
            }
            else
            {
                var nId = int.Parse(tbId.Text);
                new G_t_categorie(SChonn).Modifier(nId, tbCateg.Text, double.Parse(tbSal.Text));
                dgvCategorie.SelectedRows[0].Cells["nom_cat"].Value = tbCateg.Text;
                dgvCategorie.SelectedRows[0].Cells["sal_cat"].Value = string.Format(_info,"{0:C}", tbSal.Text) ;
                BsCategorie.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            Activer(false);
            tbId.Text = tbCateg.Text = tbSal.Text = "";
            tbId.Enabled = false;
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            
            if (dgvCategorie.SelectedRows.Count > 0)
            {
                Activer(false);
                tbId.Text = dgvCategorie.SelectedRows[0].Cells["id_cat"].Value.ToString();
                var categorie = new G_t_categorie(SChonn).Lire_ID(int.Parse(tbId.Text));
                tbCateg.Text = categorie.nom_categ;
                tbSal.Text = categorie.sal_categ.ToString(CultureInfo.CurrentCulture);
            }
            else
                MessageBox.Show(@"There is no row selected!");
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dgvCategorie.SelectedRows.Count > 0)
            {
                var nId = (int) dgvCategorie.SelectedRows[0].Cells["id_cat"].Value;
                new G_t_categorie(SChonn).Supprimer(nId);
            }
            else
                MessageBox.Show(@"There is no row selected!");
            RefreshDgv();
        }
        private void btnAnnuler_Click(object sender, EventArgs e) => Activer(true);
        private void RefreshDgv() => RemplirDgv();
        private void ClearTb() => tbId.Text = tbCateg.Text = tbSal.Text = "";
    }
}
