using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using InterimCouAccess;
using InterimCouClasses;
using InterimCouGestions;
using iTextSharp.text;
using iTextSharp.text.pdf;
namespace InterimDesktopApp
{
    public partial class FrmGPrestation : MetroFramework.Forms.MetroForm
    {
        public List<C_t_categorie> Categories { get; set; }
        public List<C_t_entreprise> Entreprises { get; set; }
        public List<C_t_facture> Factures { get; set; }
        public List<C_t_interimeur> Interimeurs { get; set; }
        public List<C_t_travail> Prestations { get; set; }
        public DataTable DtPrestation { get; set; }
        public BindingSource BsPrestation { get; set; }
        private  readonly NumberFormatInfo _info=new NumberFormatInfo();
        Font header_font = new Font(iTextSharp.text.Font.NORMAL, 16f, iTextSharp.text.Font.NORMAL, BaseColor.BLUE);
        Font date_font = new Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font normal_font = new Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font small_font = new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, BaseColor.RED);
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";
        public FrmGPrestation()
        {
            InitializeComponent();
            _info.CurrencySymbol = " (€) ";
            InitialiseListClasses();
            //foreach (var f in Factures)
            //    MessageBox.Show(f.id_fact.ToString());
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
            btnAjouter.Enabled = btnEditer.Enabled = btnSupprimer.Enabled = b;
            btnAnnuler.Enabled = btnConfirmer.Enabled = !b;
            tbNomPresta.Enabled = tbSalPresta.Enabled = dtpStart.Enabled = dtpEnd.Enabled = cbCategorie.Enabled = cbFacture.Enabled = !b;
            dgvPrestation.Enabled = b;
            if (b)
                dgvPrestation.Focus();
            else
                tbNomPresta.Focus();
        }
        private void RemplireDgv()
        {
            _info.CurrencySymbol = " € ";
            DtPrestation = new DataTable();
            DtPrestation.Columns.Add(new DataColumn("IdPresta", Type.GetType("System.Int32") ?? throw new InvalidOperationException()));
            DtPrestation.Columns.Add("NomTravail");
            DtPrestation.Columns.Add("DtDebut");
            DtPrestation.Columns.Add("DtFin");
            DtPrestation.Columns.Add("SalTravail");
            DtPrestation.Columns.Add("IdCateg");
            DtPrestation.Columns.Add("IdFact");
            foreach (var prestation in Prestations)
            {
                C_t_categorie categorie = Categories.Find(x => x.id_categ == prestation.id_categ);
                C_t_facture facture = Factures.Find(x => x.id_fact == prestation.id_fact);
                //MessageBox.Show(facture.id_fact.ToString() + "->" + prestation.Id_travail);
                DtPrestation.Rows.Add(prestation.Id_travail, prestation.nom_travail, string.Format("{0:dd/MM/yyyy}", prestation.date_debut), string.Format("{0:dd/MM/yyyy}", prestation.date_fin), string.Format(_info,"{0:C}", prestation.prix_travail), categorie.nom_categ, string.Format("{0:dd/MM/yyyy}",facture.date_fact));
            }
            BsPrestation = new BindingSource {DataSource = DtPrestation};
            dgvPrestation.DataSource = BsPrestation;
        }
        private void btnConfirmer_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text))
            {
                if (string.IsNullOrEmpty(tbNomPresta.Text) || string.IsNullOrEmpty(tbSalPresta.Text))
                    MessageBox.Show(@"Please fill all require information");
                else // ajouter dans la base de donnees
                {
                    //try
                    //{
                        //MessageBox.Show(cbCategorie.SelectedItem.ToString()+" - "+cbFacture.SelectedItem.ToString() );
                        //foreach (var f in Factures)
                        //    MessageBox.Show(f.id_fact.ToString()+" "+f.date_fact.ToString());
                        C_t_categorie categorie = Categories.Find(x => x.nom_categ == cbCategorie.SelectedItem.ToString());
                        C_t_facture facture = Factures.Find(x => x.date_fact.ToString("dd/MM/yyyy") == cbFacture.SelectedItem.ToString());
                        //MessageBox.Show(facture.id_fact.ToString() + " - " + categorie.id_categ.ToString());
                        //MessageBox.Show(facture.id_fact.ToString());
                        new G_t_travail(SChonn).Ajouter(tbNomPresta.Text, double.Parse(tbSalPresta.Text), dtpStart.Value,
                            dtpEnd.Value, categorie.id_categ, facture.id_fact);
                    //}
                    //catch (Exception ex){ MessageBox.Show(ex.Message);}
                    //finally { RemplireDgv(); }
                }
            }
           
            else // modification de la base de donnees
            {
                var nId = int.Parse(tbId.Text);
                //foreach (var f in Factures)
                //    MessageBox.Show(f.date_fact.ToString("dd/MM/yyyy") +"->"+ cbFacture.Text);
                C_t_categorie categorie = Categories.Find(x => x.nom_categ == cbCategorie.Text);
                C_t_facture facture = Factures.Find(x => x.date_fact.ToString("dd/MM/yyyy") == cbFacture.Text);
                MessageBox.Show(categorie.nom_categ + " " + facture.date_fact.ToString("dd/MM/yyyy"));
                new G_t_travail(SChonn).Modifier(nId, tbNomPresta.Text, Convert.ToDouble(tbSalPresta.Text), dtpStart.Value, dtpEnd.Value, categorie.id_categ, facture.id_fact);
                dgvPrestation.SelectedRows[0].Cells["NomTravail"].Value = tbNomPresta.Text;
                dgvPrestation.SelectedRows[0].Cells["DtDebut"].Value = dtpStart.Text;
                dgvPrestation.SelectedRows[0].Cells["DtFin"].Value = dtpEnd.Text;
                dgvPrestation.SelectedRows[0].Cells["SalTravail"].Value = tbSalPresta.Text;
                dgvPrestation.SelectedRows[0].Cells["IdCateg"].Value = cbCategorie.SelectedItem;
                dgvPrestation.SelectedRows[0].Cells["IdFact"].Value = cbFacture.Text;
                dgvPrestation.EndEdit();
                Activer(true);
            }
            RefreshDgv();
            ClearTb();
        }

        private void RemplireComboBox()
        {
            foreach (var categorie in Categories)
                cbCategorie.Items.Add(categorie.nom_categ);
            foreach (var facture in Factures)
                cbFacture.Items.Add(facture.date_fact.ToString("dd/MM/yyyy"));
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
                dtpEnd.Text = Convert.ToString(travail.date_fin, CultureInfo.CurrentCulture);
                C_t_categorie categorie = Categories.Find(x => x.id_categ == travail.id_categ);
                C_t_facture facture = Factures.Find(x => x.id_fact == travail.id_fact);
                cbCategorie.Text = categorie.nom_categ;
                cbFacture.Text = facture.date_fact.ToString("dd/MM/yyyy");
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
        private void InitialiseListClasses()
        {
            // this function is going to initialise all of my list classes every time i call it
            Categories = new G_t_categorie(SChonn).Lire("IdCateg");
            Entreprises = new G_t_entreprise(SChonn).Lire("IdEntre");
            Interimeurs = new G_t_interimeur(SChonn).Lire("IdInte");
            Factures = new G_t_facture(SChonn).Lire("IdFact");
            Prestations = new G_t_travail(SChonn).Lire("IdTravail");
        }

        private void btnNonEnFacture_Click(object sender, EventArgs e)
        {
            float total = 0f;
            float amount = 0f;
            if (dgvPrestation.Rows.Count > 0)
            {
                if (chbFacturee.Checked == true)
                {
                    Document doc = new Document(PageSize.LETTER, 40, 40, 30, 25);
                    PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\prestation facturee.pdf", FileMode.Create));
                    doc.Open();// opening the pdf to write in
                    Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
                    Paragraph logo_name = new Paragraph("Circle", small_font);
                    Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
                    Paragraph title = new Paragraph("Prestation factureé", header_font);
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
                    PdfPCell title_table = new PdfPCell(new Phrase("Prestation facturée", normal_font));
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
                    for (int i = 0; i < dgvPrestation.RowCount - 1; i++)
                    {
                        var nId = Convert.ToInt32(dgvPrestation.Rows[i].Cells[0].Value);
                        C_t_travail prestation = Prestations.Find(x => x.Id_travail == (int)nId);
                        if (prestation.date_fin > DateTime.Now)
                        {
                            C_t_categorie categorie = Categories.Find(x => x.id_categ == prestation.id_categ);
                            C_t_interimeur interimeur = Interimeurs.Find(x => x.specialisation == categorie.nom_categ);
                            //MessageBox.Show(categorie.nom_categ + "=>" + interimeur.nom_inte);
                            amount = (float)prestation.prix_travail + (float)((prestation.prix_travail * interimeur.bonus_sal) / 100);
                            total += amount;
                            PdfPCell cell_prestation = new PdfPCell(new Phrase(prestation.nom_travail, normal_font));
                            table_prestation.AddCell(cell_prestation);
                            table_prestation.AddCell(amount + "€");
                        }
                        else continue;
                    }
                    doc.Add(newLine);
                    table_prestation.AddCell(description_total);
                    table_prestation.AddCell(total.ToString() + "€");
                    doc.Add(table_prestation);
                    total = 0f;
                    doc.Close(); //closing the pdf
                }
                else
                {
                    Document doc = new Document(PageSize.LETTER, 40, 40, 30, 25);
                    PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\prestation non facturee.pdf", FileMode.Create));
                    doc.Open();// opening the pdf to write in
                    Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
                    Paragraph logo_name = new Paragraph("Circle", small_font);
                    Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
                    Paragraph title = new Paragraph("Prestation factureé", header_font);
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
                    PdfPCell title_table = new PdfPCell(new Phrase("Prestation non facturée", normal_font));
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
                    for (int i = 0; i < dgvPrestation.RowCount - 1; i++)
                    {
                        var nId = Convert.ToInt32(dgvPrestation.Rows[i].Cells[0].Value);
                        C_t_travail prestation = Prestations.Find(x => x.Id_travail == (int)nId);
                        if (prestation.date_fin.Date < DateTime.Now.Date)
                        {
                            C_t_categorie categorie = Categories.Find(x => x.id_categ == prestation.id_categ);
                            C_t_interimeur interimeur = Interimeurs.Find(x => x.specialisation == categorie.nom_categ);
                            //MessageBox.Show(categorie.nom_categ + "=>" + interimeur.nom_inte);
                            amount = (float)prestation.prix_travail + (float)((prestation.prix_travail * interimeur.bonus_sal) / 100);
                            total += amount;
                            PdfPCell cell_prestation = new PdfPCell(new Phrase(prestation.nom_travail, normal_font));
                            table_prestation.AddCell(cell_prestation);
                            table_prestation.AddCell(amount + "€");
                        }
                        else continue;
                    }
                    doc.Add(newLine);
                    table_prestation.AddCell(description_total);
                    table_prestation.AddCell(total.ToString() + "€");
                    doc.Add(table_prestation);
                    total = 0f;
                    doc.Close(); //closing the pdf
                }
            }
            else MessageBox.Show("Vous n'avez aucune prestation");
        }
    }
}
