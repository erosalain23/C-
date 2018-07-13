using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using InterimCouClasse;
using InterimCouGestion;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace InterimDesktopApp
{
    public partial class FrmGFacture : MetroFramework.Forms.MetroForm
    {
        public List<C_t_categorie> Categories { get; set; }
        public List<C_t_entreprise> Entreprises { get; set; }
        public List<C_t_facture> Factures { get; set; }
        public List<C_t_interimeur> Interimeurs { get; set; }
        public List<C_t_travail> Prestations { get; set; }
        public DataTable DtFacture { get; set; }
        public BindingSource BsFacture { get; set; }
        Font header_font = new Font(iTextSharp.text.Font.NORMAL, 16f, iTextSharp.text.Font.NORMAL, BaseColor.BLUE);
        Font date_font = new Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font normal_font = new Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font small_font = new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, BaseColor.RED);
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";

        public FrmGFacture()
        {
            InitializeComponent();
            InitialiseListClasses();
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
            {
                C_t_entreprise entreprise = Entreprises.Find(x => x.id_entre == facture.id_entre);
                C_t_interimeur interimeur = Interimeurs.Find(x => x.id_inte == facture.id_inte);
                DtFacture.Rows.Add(facture.id_fact, facture.date_fact.ToString("dd/MM/yyyy"), entreprise.nom_entre, interimeur.nom_inte);
            }
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
                C_t_interimeur interimeur = Interimeurs.Find(x => x.nom_inte == cbInte2.Text);
                C_t_entreprise entreprise = Entreprises.Find(x => x.nom_entre == cbEntre2.Text);
                new G_t_facture(SChonn).Modifier(nId,dtpFacture.Value,interimeur.id_inte,entreprise.id_entre);
                dgvFacture.SelectedRows[0].Cells["DateFact"].Value = DtFacture;
                dgvFacture.SelectedRows[0].Cells["IdEntre"].Value = cbEntre.Text;
                dgvFacture.SelectedRows[0].Cells["IdInte"].Value = cbInte.Text;
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
                C_t_entreprise entreprise = Entreprises.Find(x => x.id_entre == facture.id_entre);
                C_t_interimeur interimeur = Interimeurs.Find(x => x.id_inte == facture.id_inte);
                dtpFacture.Value = facture.date_fact;
                cbEntre2.Text = entreprise.nom_entre.ToString();
                cbInte2.Text = interimeur.nom_inte.ToString();
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
                cbEntre2.Items.Add(entreprise.nom_entre);
            foreach (var interimeur in interimeurs)
                cbInte2.Items.Add(interimeur.nom_inte);
        }
        private void btnAnnuler_Click(object sender, EventArgs e) => Activer(true);
        private void RefreshDgv() => RemplireDgv();
        private void ClearTb() => tbId.Text = "";
        private void InitialiseListClasses()
        {
            // this function is going to initialise all of my list classes every time i call it
            Categories = new G_t_categorie(SChonn).Lire("IdCateg");
            Entreprises = new G_t_entreprise(SChonn).Lire("IdEntre");
            Interimeurs = new G_t_interimeur(SChonn).Lire("IdInte");
            Factures = new G_t_facture(SChonn).Lire("IdFact");
            Prestations = new G_t_travail(SChonn).Lire("IdTravail");
        }

        private void btnCA_Click(object sender, EventArgs e)
        {
            float total = 0f;
            float amount = 0f;
            if (dgvFacture.Rows.Count > 0)
            {
                Document doc = new Document(PageSize.LETTER, 40, 40, 30, 25);
                PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\CAM12mois.pdf", FileMode.Create));
                doc.Open();// opening the pdf to write in
                Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
                Paragraph logo_name = new Paragraph("Circle", small_font);
                Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
                Paragraph title = new Paragraph("Chiffres d'affaire mensuel", header_font);
                Paragraph newLine = new Paragraph("\n");
                logo.ScalePercent(10.0f);
                logo.Alignment = 0;// 0 = left; 1=center ; 2=right
                logo.Alignment = 0;
                date.Alignment = 2;
                title.Alignment = 1;
                doc.Add(logo);
                doc.Add(logo_name);
                doc.Add(date);
                doc.Add(title);
                doc.Add(newLine);
                PdfPTable table_prestation = new PdfPTable(2);
                PdfPCell title_table = new PdfPCell(new Phrase("Chiffres d'affaires", normal_font));
                title_table.Colspan = 2;
                title_table.BackgroundColor = BaseColor.ORANGE;
                title_table.HorizontalAlignment = 1;
                PdfPCell col_prestation = new PdfPCell(new Phrase("Nom Prestation", normal_font));
                PdfPCell col_Amount = new PdfPCell(new Phrase("Prix", normal_font));
                PdfPCell description_total = new PdfPCell(new Phrase("Total"));
                col_prestation.HorizontalAlignment = 1;
                col_Amount.HorizontalAlignment = 1;
                table_prestation.AddCell(title_table);
                table_prestation.AddCell(col_prestation);
                table_prestation.AddCell(col_Amount);
                for (int i = 0; i < dgvFacture.RowCount - 1; i++)
                {
                    var nId = Convert.ToInt32(dgvFacture.Rows[i].Cells[0].Value);
                    C_t_facture facture = Factures.Find(x => x.id_fact == (int)nId);
                    C_t_travail prestation = Prestations.Find(x => x.id_fact == facture.id_fact);
                    C_t_categorie categorie = Categories.Find(x => x.id_categ == prestation.id_categ);
                    C_t_interimeur interimeur = Interimeurs.Find(x => x.specialisation == categorie.nom_categ);
                    MessageBox.Show(categorie.nom_categ + "=>" + interimeur.nom_inte);
                    amount = (float)prestation.prix_travail + (float)((prestation.prix_travail * interimeur.bonus_sal) / 100);
                    total += amount;
                    PdfPCell cell_prestation = new PdfPCell(new Phrase(prestation.nom_travail, normal_font));
                    table_prestation.AddCell(cell_prestation);
                    table_prestation.AddCell(amount + "€");
                }
                doc.Add(newLine);
                table_prestation.AddCell(description_total);
                table_prestation.AddCell(total.ToString() + "€");
                doc.Add(table_prestation);
                total = 0f;
                doc.Close(); //closing the pdf  
            }
            else MessageBox.Show("Vous n'avez pas de facture dans votre base de données");
        }
    }

}
