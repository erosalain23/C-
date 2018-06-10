using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public List<C_t_categorie> Categories { get; set; }
        public DataTable DtInterimeur { get; set; }
        public DataTable DtEntreprise { get; set; }
        public DataTable DtPrestation { get; set; }
        public DataTable DtFacture { get; set; }
        public BindingSource BsInterimeur { get; set; }
        public BindingSource BsEntreprise { get; set; }
        public BindingSource BsPrestation { get; set; }
        public BindingSource BsFacture { get; set; }
        private readonly NumberFormatInfo _info = new NumberFormatInfo();
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";


        public MainForm()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey600, MaterialSkin.Primary.Amber700, MaterialSkin.Primary.Amber500, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);
            Categories = new G_t_categorie(SChonn).Lire("IdCateg");
            RemplirDgvInterimeur();
            RemplirDgvEntreprise();
            RemplirDgvPrestation();
            RemplirDgvFacture();
            SelectFirstRow(dgvInterimeur, dgvEntreprise, dgvPrestation, dgvFacture);
        }
        private void RemplirDgvInterimeur()
        {
            DtInterimeur = new DataTable();
            DtInterimeur.Columns.Add(new DataColumn("IdInte", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtInterimeur.Columns.Add("NomInte");
            DtInterimeur.Columns.Add("PrenomInte");
            List<C_t_interimeur> interimeurs = new G_t_interimeur(SChonn).Lire("Nom");
            
            foreach (var interimeur in interimeurs)
                DtInterimeur.Rows.Add(interimeur.id_inte, interimeur.nom_inte, interimeur.prenom_inte);
            BsInterimeur = new BindingSource {DataSource = DtInterimeur};
            dgvInterimeur.DataSource = BsInterimeur;
        }
        private void RemplirDgvEntreprise()
        {
            DtEntreprise = new DataTable();
            DtEntreprise.Columns.Add(new DataColumn("IdEntre", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtEntreprise.Columns.Add("NomEntre");
            List<C_t_entreprise> entreprises = new G_t_entreprise(SChonn).Lire("Nom");
            foreach (var entreprise in entreprises)
                DtEntreprise.Rows.Add(entreprise.id_entre, entreprise.nom_entre);
            BsEntreprise = new BindingSource { DataSource = DtEntreprise };
            dgvEntreprise.DataSource = BsEntreprise;
        }
        private void RemplirDgvPrestation()
        {
            _info.CurrencySymbol = " (%) ";
            DtPrestation = new DataTable();
            DtPrestation.Columns.Add(new DataColumn("IdPresta", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtPrestation.Columns.Add("NomPresta");
            DtPrestation.Columns.Add("NomCateg");
            List<C_t_travail> prestations = new G_t_travail(SChonn).Lire("Nom");
            foreach (var prestation in prestations)
            {
                C_t_categorie categorie = Categories.Find(x => x.id_categ == prestation.id_categ);
                DtPrestation.Rows.Add(prestation.Id_travail, prestation.nom_travail, categorie.nom_categ);
            }
            BsPrestation = new BindingSource {DataSource = DtPrestation};
            dgvPrestation.DataSource = BsPrestation;
        }
        private void RemplirDgvFacture()
        {
            DtFacture = new DataTable();
            DtFacture.Columns.Add(new DataColumn("IdFact", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtFacture.Columns.Add("DateFact");
            List<C_t_facture> factures = new G_t_facture(SChonn).Lire("DateFact");
            foreach (var facture in factures)
                DtFacture.Rows.Add(facture.id_fact,facture.date_fact.ToString("dd/MM/yyyy"));
            BsFacture = new BindingSource {DataSource = DtFacture};
            dgvFacture.DataSource = BsFacture;
        }
        private static void SelectFirstRow( DataGridView dgvInterimeur,DataGridView dgvClient,DataGridView dgvPrestation, DataGridView dgvFacture)
        {

            if (dgvInterimeur.Rows.Count > 0)
                dgvInterimeur.Rows[0].Selected = true;
            else if (dgvClient.Rows.Count > 0)
                dgvClient.Rows[0].Selected = true;
            else if (dgvPrestation.Rows.Count > 0)
                dgvPrestation.Rows[0].Selected = true;
            else if (dgvFacture.Rows.Count > 0)
                dgvFacture.Rows[0].Selected = true;
        }

        private void btnGInte_Click(object sender, EventArgs e)
        {
            using (var frm = new btnEmpDuTemps())
            {
                frm.ShowDialog();
            }
        }
        private void btnGeEntre_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmGEntreprise())
            {
                frm.ShowDialog();
            }
        }

        private void btnGePresta_Click(object sender, EventArgs e)
        {
            using (var frm = new FrmGPrestation())
            {
                frm.ShowDialog();
            }
        }

        private void btnGeFact_Click(object sender, EventArgs e)
        {
            using (FrmGFacture frm = new FrmGFacture())
            {
                frm.ShowDialog();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            RemplirDgvEntreprise();
            RemplirDgvFacture();
            RemplirDgvInterimeur();
            RemplirDgvPrestation();
        }
    }
}
