using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Windows.Forms;
using InterimCouClasses;
using InterimCouGestions;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace InterimDesktopApp
{
    public partial class btnEmpDuTemps : MetroFramework.Forms.MetroForm
    {
        public List<C_t_categorie> Categories { get; set; }
        public List<C_t_entreprise> Entreprises { get; set; }
        public List<C_t_facture> Factures { get; set; }
        public List<C_t_interimeur> Interimeurs { get; set; }
        public List<C_t_travail> Prestations { get; set; }
        public DataTable DtInterimeur { get; set; }
        public BindingSource BsInterimeur  { get; set; }
        private readonly NumberFormatInfo _info = new NumberFormatInfo();
       
        Font header_font = new Font(iTextSharp.text.Font.NORMAL, 16f, iTextSharp.text.Font.NORMAL, BaseColor.BLUE);
        Font date_font = new Font(iTextSharp.text.Font.NORMAL, 9f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font normal_font = new Font(iTextSharp.text.Font.NORMAL, 12f, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        Font small_font = new Font(iTextSharp.text.Font.NORMAL, 8f, iTextSharp.text.Font.NORMAL, BaseColor.RED);
        private const string SChonn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\C#\NewInterimDB\NewInterimDB.mdf;Integrated Security=True;Connect Timeout=30";

        public btnEmpDuTemps()
        {
            InitializeComponent();
            InitialiseListClasses();
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
            tbNom.Enabled = tbPrenom.Enabled = cbMetier.Enabled = tbBonus.Enabled = cbEntreprise.Enabled = !b;
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
                DtInterimeur.Rows.Add(interimeur.id_inte, interimeur.nom_inte, interimeur.prenom_inte,interimeur.specialisation,string.Format("{0:P1}", interimeur.bonus_sal/100) );
            BsInterimeur = new BindingSource {DataSource = DtInterimeur};
            dgvInterimeur.DataSource = BsInterimeur;
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbId.Text)) // id must be empty
            {
                if (string.IsNullOrEmpty(tbNom.Text) || string.IsNullOrEmpty(tbPrenom.Text) ||
                    string.IsNullOrEmpty(tbBonus.Text)) // names must not be empty
                    MessageBox.Show(@"Please fill all require information");
                else // creation 
                {
                    var nId = new G_t_interimeur(SChonn).Ajouter(tbNom.Text, tbPrenom.Text,
                        Convert.ToString(cbMetier.SelectedItem), Convert.ToDouble(tbBonus.Text));
                    DtInterimeur.Rows.Add(nId, tbNom, tbPrenom, cbMetier.SelectedItem, tbBonus);
                    C_t_entreprise entreprise = Entreprises.Find(x => x.nom_entre == cbEntreprise.Text);
                    //chaque fois qu on va creer un interimaire une factures va se creer
                    var nId_fact = new G_t_facture(SChonn).Ajouter(DateTime.Today, nId, entreprise.id_entre);
                }
            }
            else  // modification
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
        private void RemplireComboBox()//remplir le combo box
        {
            Entreprises = new G_t_entreprise(SChonn).Lire("IdEntre");//lire et stockee les donnee dans la liste entreprises
            Categories = new G_t_categorie(SChonn).Lire("IdCateg");//lire les donnees et les metre dans une list
            foreach (C_t_categorie categorie in Categories)
                cbMetier.Items.Add(categorie.nom_categ);
            foreach (var entreprise in Entreprises)
                cbEntreprise.Items.Add(entreprise.nom_entre);
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            ClearTb();
            cbMetier.SelectedItem = null;
            Activer(true);
        }
        private void RefreshDgv() => RemplireDgv();
        private void ClearTb() => tbId.Text = tbNom.Text = tbPrenom.Text = tbBonus.Text = "";
        private void InitialiseListClasses()
        {
            // this function is going to initialise all of my list classes every time i call it
            Categories = new G_t_categorie(SChonn).Lire("IdCateg");
            Entreprises = new G_t_entreprise(SChonn).Lire("IdEntre");
            Interimeurs = new G_t_interimeur(SChonn).Lire("IdInte");
            Factures = new G_t_facture(SChonn).Lire("IdFact");
            Prestations = new G_t_travail(SChonn).Lire("IdTravail");
        }
        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnEmplDuTmp_Click(object sender, EventArgs e)
        {
            // the creation of the repport document of "emploi du temps de l'interimaire"
            if (dgvInterimeur.Rows.Count > 0)//si il y a des trus dans le dgv
            {
                Document doc = new Document(PageSize.LETTER, 40, 40, 30, 25);
                PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\Emploid de temps des interimairs.pdf", FileMode.Create));
                doc.Open();// opening the pdf to write in
                Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
                Paragraph logo_name = new Paragraph("Circle", small_font);
                Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
                Paragraph title = new Paragraph("Emploi de temps de chaque interimaire", header_font);
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
                for (int i = 0; i < dgvInterimeur.RowCount-1; i++)
                {
                    var nId = Convert.ToInt32(dgvInterimeur.Rows[i].Cells[0].Value);
                    C_t_interimeur interimeur = Interimeurs.Find(x => x.id_inte == (int)nId);
                    C_t_categorie categorie = Categories.Find(x => x.nom_categ == interimeur.specialisation);
                    C_t_travail prestation = Prestations.Find(x => x.id_categ == categorie.id_categ);
                    //MessageBox.Show(categorie.nom_categ + "=>" + prestation.nom_travail);
                    PdfPTable table_interimeur = new PdfPTable(2);
                    PdfPCell nom_interimeur = new PdfPCell(new Phrase(interimeur.nom_inte, normal_font));
                    PdfPCell col_date_debut = new PdfPCell(new Phrase("Debut", normal_font));
                    PdfPCell col_date_fin = new PdfPCell(new Phrase("Fin", normal_font));
                    nom_interimeur.Colspan = 2;
                    nom_interimeur.BackgroundColor = BaseColor.ORANGE;
                    nom_interimeur.HorizontalAlignment = 1;
                    col_date_debut.HorizontalAlignment = 1;
                    col_date_fin.HorizontalAlignment = 1;
                    table_interimeur.AddCell(nom_interimeur);
                    table_interimeur.AddCell(col_date_debut);
                    table_interimeur.AddCell(col_date_fin);
                    table_interimeur.AddCell(prestation.date_debut.ToString("dd/MM/yyyy"));
                    table_interimeur.AddCell(prestation.date_fin.ToString("dd/MM/yyyy"));
                    //table_interimeur.AddCell(interimeur.nom_inte);
                    //table_interimeur.AddCell("nothing");
                    doc.Add(table_interimeur);
                    doc.Add(newLine);
                }
                doc.Close(); //closing the pdf
            }
            else
                MessageBox.Show(@"Vous n'aves pas d'interimaire dans vorte base de donneés");
        }
        private void btnMomntLbr_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.LETTER, 40, 40, 30, 25);
            doc.Open();
            //the creation of the repport concerning " les moments libre de l'interimaire"
            PdfWriter pw = PdfWriter.GetInstance(doc, new FileStream(@"E:\C#\InterimDesktopApp\Doc\moments libres des interimaires.pdf", FileMode.Create));
            doc.Open();//open for writing
            Image logo = Image.GetInstance(@"E:\C#\InterimDesktopApp\Images\circle.png");
            Paragraph logo_name = new Paragraph("Circle", small_font);
            Paragraph date = new Paragraph("Le" + " " + DateTime.Today.ToString("dd/MM/yyyy"), date_font);
            Paragraph title = new Paragraph("Moments libres des interimaires par specialisation", header_font);
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
            for (int i = 0; i < dgvInterimeur.RowCount - 1; i++)
            {
                string specialite = (string)dgvInterimeur.Rows[i].Cells[3].Value;
                Paragraph nom_specialite = new Paragraph(specialite,header_font);
                nom_specialite.Alignment = 1;
                doc.Add(nom_specialite);
                doc.Add(newLine);
                for (int j = 0; j < dgvInterimeur.RowCount - 1; j++)
                {
                    var nId = Convert.ToInt32(dgvInterimeur.Rows[j].Cells[0].Value);
                    C_t_interimeur interimeur = Interimeurs.Find(x => x.id_inte == (int)nId);
                    if (interimeur.specialisation == specialite)
                    {
                        C_t_categorie categorie = Categories.Find(x => x.nom_categ == interimeur.specialisation);
                        C_t_travail prestation = Prestations.Find(x => x.id_categ == categorie.id_categ);
                        //MessageBox.Show(categorie.nom_categ + "=>" + prestation.nom_travail);
                        //if (interimeur.specialisation != specialite) continue;
                        //else
                        //{
                        //MessageBox.Show(interimeur.specialisation+" "+specialite+" "+ "=>" +prestation.date_fin.ToString("dd/MM/yyyy"));

                        PdfPTable table_interimeur = new PdfPTable(2);
                        PdfPCell nom_interimeur = new PdfPCell(new Phrase(interimeur.nom_inte, normal_font));
                        PdfPCell col_date_debut = new PdfPCell(new Phrase("Debut", normal_font));
                        PdfPCell col_date_fin = new PdfPCell(new Phrase("Fin", normal_font));
                        nom_interimeur.Colspan = 2;
                        nom_interimeur.BackgroundColor = BaseColor.ORANGE;
                        nom_interimeur.HorizontalAlignment = 1;
                        col_date_debut.HorizontalAlignment = 1;
                        col_date_fin.HorizontalAlignment = 1;
                        table_interimeur.AddCell(nom_interimeur);
                        table_interimeur.AddCell(col_date_debut);
                        table_interimeur.AddCell(col_date_fin);
                        table_interimeur.AddCell("Libre depuis");
                        table_interimeur.AddCell(prestation.date_fin.ToString("dd/MM/yyyy"));
                        //table_interimeur.AddCell(interimeur.nom_inte);
                        //table_interimeur.AddCell("nothing");
                        doc.Add(table_interimeur);
                        doc.Add(newLine);// simply adding a new line
                                         //}
                    }
                    else continue;
                }
            }
            doc.Close();
        }
    }
}
