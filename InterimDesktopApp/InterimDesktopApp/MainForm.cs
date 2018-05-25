using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InterimCouAccess;
using InterimCouClasses;
using InterimCouGestions;

namespace InterimDesktopApp
{
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        public DataTable dtInterimeur { get; set; }
        public DataTable dtEntreprise { get; set; }
        public DataTable dtPrestation { get; set; }
        public DataTable dtFacture { get; set; }
        public BindingSource bsInterimeur { get; set; }
        public BindingSource bsEntreprise { get; set; }
        public BindingSource bsPrestation { get; set; }
        public BindingSource bsFacture { get; set; }
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";


        public MainForm()
        {
            InitializeComponent();
            MaterialSkin.MaterialSkinManager skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.BlueGrey600, MaterialSkin.Primary.Amber700, MaterialSkin.Primary.Amber500, MaterialSkin.Accent.Green400, MaterialSkin.TextShade.WHITE);
            RemplirDGVInterimeur();
            RemplirDGVEntreprise();
            RemplirDGVPrestation();
            RemplirDGVFacture();
            SelectFirstRow(dgvInterimeur, dgvEntreprise, dgvPrestation, dgvFacture);
        }
        private void RemplirDGVInterimeur()
        {
            dtInterimeur = new DataTable();
            dtInterimeur.Columns.Add(new DataColumn("IdInte", Type.GetType("System.Int32")));
            dtInterimeur.Columns.Add("NomInte");
            dtInterimeur.Columns.Add("PrenomInte");
            List<C_t_interimeur> Interimeurs = new G_t_interimeur(SChonn).Lire("Nom");
            foreach (C_t_interimeur Interimeur in Interimeurs)
                dtInterimeur.Rows.Add(Interimeur.id_inte, Interimeur.nom_inte, Interimeur.prenom_inte);
            bsInterimeur = new BindingSource();
            bsInterimeur.DataSource = dtInterimeur;
            dgvInterimeur.DataSource = bsInterimeur;
        }
        private void RemplirDGVEntreprise()
        {
            dtEntreprise = new DataTable();
            dtEntreprise.Columns.Add(new DataColumn("IdClient", Type.GetType("System.Int32")));
            dtEntreprise.Columns.Add("NomClient");
            dtEntreprise.Columns.Add("CategorieClient");
            List<C_t_entreprise> Entreprises = new G_t_entreprise(SChonn).Lire("Nom");
            foreach (C_t_entreprise Entreprise in Entreprises)
                dtInterimeur.Rows.Add(Entreprise.id_entre, Entreprise.nom_entre);
            bsEntreprise = new BindingSource();
            bsEntreprise.DataSource = dtEntreprise;
            dgvEntreprise.DataSource = bsEntreprise;
        }
        private void RemplirDGVPrestation()
        {
            dtPrestation = new DataTable();
            dtPrestation.Columns.Add(new DataColumn("IdPresta", Type.GetType("System.Int32")));
            dtPrestation.Columns.Add("NomPresta");
            dtPrestation.Columns.Add("CategoriePresta");
            List<C_t_travail> Prestations = new G_t_travail(SChonn).Lire("Nom");
            foreach (C_t_travail Prestation in Prestations)
                dtPrestation.Rows.Add(Prestation.nom_travail,Prestation.id_categ,string.Format("c",Prestation.prix_travail));
            bsPrestation = new BindingSource();
            bsPrestation.DataSource = dtPrestation;
            dgvPrestation.DataSource = bsPrestation;
        }
        private void RemplirDGVFacture()
        {
            dtFacture = new DataTable();
            dtFacture.Columns.Add(new DataColumn("IdFact", Type.GetType("System.Int32")));
            dtFacture.Columns.Add("DateFact");
            List<C_t_facture> Factures = new G_t_facture(SChonn).Lire("DateFact");
            foreach (C_t_facture Facture in Factures)
                dtFacture.Rows.Add(Facture.date_fact);
            bsFacture = new BindingSource();
            bsFacture.DataSource = dtFacture;
            dgvFacture.DataSource = bsFacture;
        }
        private void SelectFirstRow( DataGridView dgvInterimeur,DataGridView dgvClient,DataGridView dgvPrestation, DataGridView dgvFacture)
        {

            if (dgvInterimeur.Rows.Count > 0)
                dgvInterimeur.Rows[0].Selected = true;
            else if (dgvClient.Rows.Count > 0)
                dgvClient.Rows[0].Selected = true;
            else if (dgvPrestation.Rows.Count > 0)
                dgvPrestation.Rows[0].Selected = true;
            else if (dgvFacture.Rows.Count > 0)
                dgvFacture.Rows[0].Selected = true;
            else return;
        }

        private void btnGInte_Click(object sender, EventArgs e)
        {
            using (FrmGInterimeur frm = new FrmGInterimeur())
            {
                frm.ShowDialog();
            }
        }

        private void btnGeEntre_Click(object sender, EventArgs e)
        {
            using (FrmGEntreprise frm = new FrmGEntreprise())
            {
                frm.ShowDialog();
            }
        }

        private void btnGePresta_Click(object sender, EventArgs e)
        {
            using (FrmGPrestation frm = new FrmGPrestation())
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
    }
}
