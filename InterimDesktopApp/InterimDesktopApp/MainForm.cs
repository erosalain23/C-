using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using InterimCouClasse;
using InterimCouGestion;

namespace InterimDesktopApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        //variable declaration
        public List<C_t_categorie> Travails { get; set; }
        public List<C_t_interimeur> Interimaires { get; set; }
        public List<C_t_entreprise> Entreprises { get; set; }
        public List<C_t_travail> Prestations { get; set; }
        public List<C_t_facture> Factures { get; set; }
        public DataTable DtInterimeur { get; set; }
        public DataTable DtEntreprise { get; set; }
        public DataTable DtTravails { get; set; }
        public DataTable DtFacture { get; set; }
        public DataTable DtPrestations { get; set; }
        public BindingSource BsInterimeur { get; set; }
        public BindingSource BsEntreprise { get; set; }
        public BindingSource BsTravail { get; set; }
        public BindingSource BsFacture { get; set; }
        public BindingSource BsPrestations { get; set; }
        private readonly NumberFormatInfo _info = new NumberFormatInfo();//money currency declaration
        //Connection string declaration
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";
        //constructor
        public MainForm()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;//Material theme initialization
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey600, MaterialSkin.Primary.Amber700, MaterialSkin.Primary.Amber500, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);// changing the color theme to bleu and amber
            Travails = new G_t_categorie(SChonn).Lire("IdTravail");//initialization of category list
            Interimaires = new G_t_interimeur(SChonn).Lire("IdInte");//initialization of Interimaire list
            Entreprises = new G_t_entreprise(SChonn).Lire("IdEntre");//initialization of Entreprise list
            Prestations = new G_t_travail(SChonn).Lire("IdPresta");//initialization of Prestation list
            Factures = new G_t_facture(SChonn).Lire("IdFact");//initialization of Facture list

            RemplirDgvInterimeur();
            RemplirDgvEntreprise();
            RemplirDgvTravail();
            RemplirDgvFacture();
            RemplirDgvPrestations();
            SelectFirstRow(dgvInterimeur, dgvEntreprise, dgvTravails, dgvFacture,dgvTravails);
        }
        private void RemplirDgvInterimeur()
        {
            DtInterimeur = new DataTable();
            DtInterimeur.Columns.Add(new DataColumn("IdInte", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtInterimeur.Columns.Add("NomInte");
            DtInterimeur.Columns.Add("PrenomInte");
            foreach (var interimeur in Interimaires)
                DtInterimeur.Rows.Add(interimeur.id_inte, interimeur.nom_inte, interimeur.prenom_inte);
            BsInterimeur = new BindingSource {DataSource = DtInterimeur};
            dgvInterimeur.DataSource = BsInterimeur;
        }
        private void RemplirDgvEntreprise()
        {
            DtEntreprise = new DataTable();
            DtEntreprise.Columns.Add(new DataColumn("IdEntre", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtEntreprise.Columns.Add("NomEntre");
            foreach (var entreprise in Entreprises)
                DtEntreprise.Rows.Add(entreprise.id_entre, entreprise.nom_entre);
            BsEntreprise = new BindingSource { DataSource = DtEntreprise };
            dgvEntreprise.DataSource = BsEntreprise;
        }
        private void RemplirDgvTravail()
        {
            DtTravails = new DataTable();
            DtTravails.Columns.Add(new DataColumn("IdCat", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtTravails.Columns.Add("NomTravail");
            foreach (var travail in Travails)
            {
                DtTravails.Rows.Add(travail.id_categ,travail.nom_categ);
            }
            BsTravail = new BindingSource {DataSource = DtTravails };
            dgvTravails.DataSource = BsTravail;
        }
        private void RemplirDgvFacture()
        {
            DtFacture = new DataTable();
            DtFacture.Columns.Add(new DataColumn("IdFact", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtFacture.Columns.Add("DateFact");
            foreach (var facture in Factures)
                DtFacture.Rows.Add(facture.id_fact,facture.date_fact.ToString("dd/MM/yyyy"));
            BsFacture = new BindingSource {DataSource = DtFacture};
            dgvFacture.DataSource = BsFacture;
        }
        private void RemplirDgvPrestations()
        {
            DtPrestations = new DataTable();
            DtPrestations.Columns.Add(new DataColumn("IdPresta",Type.GetType("System.Int32")?? throw new InvalidOperationException()));
            DtPrestations.Columns.Add("Interimaire");
            DtPrestations.Columns.Add("Entreprise");
            DtPrestations.Columns.Add("Travail");
            DtPrestations.Columns.Add("DateDebut");
            DtPrestations.Columns.Add("DateFin");
            DtPrestations.Columns.Add("JourRestant");
            DtPrestations.Columns.Add("Facture");
            DtPrestations.Columns.Add("Status");
            foreach(var prestation in Prestations)
            {
                
                C_t_facture facture = Factures.Find(x => x.id_fact == prestation.id_fact);
                C_t_categorie travail = Travails.Find(x => x.id_categ == prestation.id_categ);
                C_t_interimeur interimaire = Interimaires.Find(x => x.id_inte == facture.id_inte);
                C_t_entreprise entreprise = Entreprises.Find(x => x.id_entre == facture.id_entre);
                MessageBox.Show(entreprise.nom_entre);
                DtPrestations.Rows.Add(prestation.Id_travail,interimaire.nom_inte, entreprise.nom_entre, travail.nom_categ, prestation.date_debut.ToString("dd-MM-yyyy"), prestation.date_fin.ToString("dd-MM-yyyy"), (DateTime.Today - prestation.date_fin).TotalDays, facture.date_fact, (prestation.date_fin < DateTime.Today) ? "En Cours" : "Terminer");
            }
            BsPrestations = new BindingSource { DataSource = DtPrestations };
            dgvPrestations.DataSource = BsPrestations;
        }
        private static void SelectFirstRow( DataGridView dgvInterimeur,DataGridView dgvClient,DataGridView dgvTravails, DataGridView dgvFacture,DataGridView dgvPrestations)
        {

            if (dgvInterimeur.Rows.Count > 0)
                dgvInterimeur.Rows[0].Selected = true;
            else if (dgvClient.Rows.Count > 0)
                dgvClient.Rows[0].Selected = true;
            else if (dgvTravails.Rows.Count > 0)
                dgvTravails.Rows[0].Selected = true;
            else if (dgvFacture.Rows.Count > 0)
                dgvFacture.Rows[0].Selected = true;
            else if (dgvPrestations.RowCount > 0)
                dgvPrestations.Rows[0].Selected = true;
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
            RemplirDgvTravail();
            RemplirDgvPrestations();
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string nomPresta= tbNomPresta.Text;
            if (string.IsNullOrEmpty(tbPrix.Text))
            {
                MessageBox.Show("Please Enter the Salary per day");
                return;
            }
            else if (string.IsNullOrEmpty(nomPresta)) nomPresta = " "; //making nom de prestation a blank text 
            else
            {
                new G_t_travail(SChonn).Ajouter(nomPresta, double.Parse(tbPrix.Text), dtpDebut.Value, dtpFin.Value, (int)dgvTravails.SelectedRows[0].Cells["IdPresta"].Value, (int)dgvFacture.SelectedRows[0].Cells["IdFact"].Value);
                MessageBox.Show("Registation successful");
            }

        }
    }
}
