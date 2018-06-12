using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;
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
        Document doc = new Document(PageSize.A4, 40, 40, 30, 25);
        PdfWriter pw;
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
            double salary = 0;
            pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\CAM12mois.pdf", FileMode.OpenOrCreate));
            doc.Open();//open for writing
            Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
            Paragraph logo_name = new Paragraph("Circle", small_font);
            Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
            Paragraph title = new Paragraph(@"Les chiffres d'affaire mensuel sur 12 mois", header_font);
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
            
            for (int i = 0; i < dgvFacture.RowCount - 1; i++)
            {
                int nId = (int)dgvFacture.Rows[i].Cells[0].Value;
                C_t_facture facture = Factures.Find(x => x.id_fact == nId);
                C_t_interimeur interimeur = Interimeurs.Find(x => x.id_inte == facture.id_inte);
                C_t_travail prestation = Prestations.Find(x => x.id_fact == facture.id_entre);
                double single_amount = prestation.prix_travail + (prestation.prix_travail * interimeur.bonus_sal / 100);
                salary += single_amount;
                PdfPTable table = new PdfPTable(2);// declaration d'un tablea a 2 col
                PdfPCell base_amount = new PdfPCell(new Phrase(single_amount.ToString()));
                PdfPCell details = new PdfPCell(new Phrase("Details", normal_font));//declare un cellule details
                PdfPCell Amount = new PdfPCell(new Phrase("Prix", normal_font));//declare une cellule  de la  date libre
                PdfPCell total = new PdfPCell(new Phrase("Total" + salary, normal_font));// declare un cellule nom interimeur
                PdfPCell total_salary = new PdfPCell(new Phrase(salary.ToString()));
                details.HorizontalAlignment = 1;//h alignment
                Amount.HorizontalAlignment = 1;//h alignment
                table.AddCell(details);//creating the table cell
                table.AddCell(Amount);//another cell
                table.AddCell(prestation.nom_travail);//putting the name in the cell
                table.AddCell(base_amount);//putting the calculated money in
                total.Colspan = 2; // merge 2 col
                total.BackgroundColor = BaseColor.ORANGE;//definir la coleur du nom de l interimeur
                total.HorizontalAlignment = 2;//horizontal alginment 0=lefte ; 1= center; 2=right
                table.AddCell(total);

                table.AddCell(total_salary);
                doc.Add(table);//pour lr table aussin
            }
           
            doc.Close();
        }
    }

}
