namespace InterimDesktopApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnGePresta = new MetroFramework.Controls.MetroTile();
            this.btnGInte = new MetroFramework.Controls.MetroTile();
            this.btnGeEntre = new MetroFramework.Controls.MetroTile();
            this.btnGeFact = new MetroFramework.Controls.MetroTile();
            this.dgvInterimeur = new System.Windows.Forms.DataGridView();
            this.dgvEntreprise = new System.Windows.Forms.DataGridView();
            this.dgvTravails = new System.Windows.Forms.DataGridView();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.dgvPrestations = new System.Windows.Forms.DataGridView();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.IdFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConfirmer = new MetroFramework.Controls.MetroButton();
            this.BtnSupprimer = new MetroFramework.Controls.MetroButton();
            this.dtpDebut = new System.Windows.Forms.DateTimePicker();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.tbPrix = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.tbNomPresta = new MetroFramework.Controls.MetroTextBox();
            this.IdTravail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomTravail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPresta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Interimaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entreprise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Travail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Jours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Facture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestations)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 74);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(98, 77);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TileImage = ((System.Drawing.Image)(resources.GetObject("btnRefresh.TileImage")));
            this.btnRefresh.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnRefresh.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnRefresh.UseTileImage = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGePresta
            // 
            this.btnGePresta.Location = new System.Drawing.Point(337, 74);
            this.btnGePresta.Name = "btnGePresta";
            this.btnGePresta.Size = new System.Drawing.Size(98, 77);
            this.btnGePresta.TabIndex = 0;
            this.btnGePresta.Text = "Add Prestation";
            this.btnGePresta.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGePresta.TileImage")));
            this.btnGePresta.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGePresta.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGePresta.UseTileImage = true;
            this.btnGePresta.Click += new System.EventHandler(this.btnGePresta_Click);
            // 
            // btnGInte
            // 
            this.btnGInte.Location = new System.Drawing.Point(127, 74);
            this.btnGInte.Name = "btnGInte";
            this.btnGInte.Size = new System.Drawing.Size(98, 77);
            this.btnGInte.TabIndex = 0;
            this.btnGInte.Text = "Add Interimaire";
            this.btnGInte.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGInte.TileImage")));
            this.btnGInte.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGInte.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGInte.UseTileImage = true;
            this.btnGInte.Click += new System.EventHandler(this.btnGInte_Click);
            // 
            // btnGeEntre
            // 
            this.btnGeEntre.Location = new System.Drawing.Point(232, 74);
            this.btnGeEntre.Name = "btnGeEntre";
            this.btnGeEntre.Size = new System.Drawing.Size(98, 77);
            this.btnGeEntre.TabIndex = 0;
            this.btnGeEntre.Text = "Add Entreprise";
            this.btnGeEntre.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGeEntre.TileImage")));
            this.btnGeEntre.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeEntre.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGeEntre.UseTileImage = true;
            this.btnGeEntre.Click += new System.EventHandler(this.btnGeEntre_Click);
            // 
            // btnGeFact
            // 
            this.btnGeFact.Location = new System.Drawing.Point(442, 74);
            this.btnGeFact.Name = "btnGeFact";
            this.btnGeFact.Size = new System.Drawing.Size(98, 77);
            this.btnGeFact.TabIndex = 0;
            this.btnGeFact.Text = "Print";
            this.btnGeFact.TileImage = ((System.Drawing.Image)(resources.GetObject("btnGeFact.TileImage")));
            this.btnGeFact.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGeFact.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.btnGeFact.UseTileImage = true;
            this.btnGeFact.Click += new System.EventHandler(this.btnGeFact_Click);
            // 
            // dgvInterimeur
            // 
            this.dgvInterimeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterimeur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInte,
            this.NomInte,
            this.PrenomInte});
            this.dgvInterimeur.Location = new System.Drawing.Point(977, 462);
            this.dgvInterimeur.Name = "dgvInterimeur";
            this.dgvInterimeur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInterimeur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInterimeur.Size = new System.Drawing.Size(364, 154);
            this.dgvInterimeur.TabIndex = 1;
            // 
            // dgvEntreprise
            // 
            this.dgvEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntreprise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntre,
            this.NomEntre});
            this.dgvEntreprise.Location = new System.Drawing.Point(661, 462);
            this.dgvEntreprise.Name = "dgvEntreprise";
            this.dgvEntreprise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEntreprise.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntreprise.Size = new System.Drawing.Size(290, 154);
            this.dgvEntreprise.TabIndex = 1;
            // 
            // dgvTravails
            // 
            this.dgvTravails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTravails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdTravail,
            this.NomTravail});
            this.dgvTravails.Location = new System.Drawing.Point(23, 462);
            this.dgvTravails.Name = "dgvTravails";
            this.dgvTravails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvTravails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTravails.Size = new System.Drawing.Size(287, 154);
            this.dgvTravails.TabIndex = 1;
            // 
            // dgvFacture
            // 
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFact,
            this.DateFact});
            this.dgvFacture.Location = new System.Drawing.Point(337, 462);
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFacture.Size = new System.Drawing.Size(284, 154);
            this.dgvFacture.TabIndex = 1;
            // 
            // dgvPrestations
            // 
            this.dgvPrestations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPresta,
            this.Interimaire,
            this.Entreprise,
            this.Travail,
            this.DtDebut,
            this.DtFin,
            this.Jours,
            this.Facture,
            this.Status});
            this.dgvPrestations.Location = new System.Drawing.Point(23, 184);
            this.dgvPrestations.Name = "dgvPrestations";
            this.dgvPrestations.Size = new System.Drawing.Size(1318, 195);
            this.dgvPrestations.TabIndex = 2;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(127, 428);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Travails";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(442, 428);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(56, 19);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Factures";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(768, 428);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(72, 19);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Entreprises";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1121, 428);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(77, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Interimaires";
            // 
            // IdFact
            // 
            this.IdFact.DataPropertyName = "IdFact";
            this.IdFact.HeaderText = "ID";
            this.IdFact.Name = "IdFact";
            this.IdFact.Width = 80;
            // 
            // DateFact
            // 
            this.DateFact.DataPropertyName = "dateFact";
            this.DateFact.HeaderText = "DATE";
            this.DateFact.Name = "DateFact";
            this.DateFact.Width = 200;
            // 
            // IdEntre
            // 
            this.IdEntre.DataPropertyName = "IdEntre";
            this.IdEntre.HeaderText = "ID";
            this.IdEntre.Name = "IdEntre";
            this.IdEntre.Width = 80;
            // 
            // NomEntre
            // 
            this.NomEntre.DataPropertyName = "NomEntre";
            this.NomEntre.HeaderText = "NOM";
            this.NomEntre.Name = "NomEntre";
            this.NomEntre.Width = 220;
            // 
            // IdInte
            // 
            this.IdInte.DataPropertyName = "IdInte";
            this.IdInte.HeaderText = "ID";
            this.IdInte.Name = "IdInte";
            this.IdInte.Width = 80;
            // 
            // NomInte
            // 
            this.NomInte.DataPropertyName = "NomInte";
            this.NomInte.HeaderText = "NOM";
            this.NomInte.Name = "NomInte";
            this.NomInte.Width = 130;
            // 
            // PrenomInte
            // 
            this.PrenomInte.DataPropertyName = "PrenomInte";
            this.PrenomInte.HeaderText = "PRENOM";
            this.PrenomInte.Name = "PrenomInte";
            this.PrenomInte.Width = 180;
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(977, 650);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(179, 41);
            this.btnConfirmer.TabIndex = 7;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // BtnSupprimer
            // 
            this.BtnSupprimer.Location = new System.Drawing.Point(1162, 650);
            this.BtnSupprimer.Name = "BtnSupprimer";
            this.BtnSupprimer.Size = new System.Drawing.Size(179, 41);
            this.BtnSupprimer.TabIndex = 7;
            this.BtnSupprimer.Text = "Supprimer";
            // 
            // dtpDebut
            // 
            this.dtpDebut.Location = new System.Drawing.Point(24, 670);
            this.dtpDebut.Name = "dtpDebut";
            this.dtpDebut.Size = new System.Drawing.Size(200, 20);
            this.dtpDebut.TabIndex = 8;
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(337, 672);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 8;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(24, 635);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(94, 19);
            this.metroLabel5.TabIndex = 9;
            this.metroLabel5.Text = "Date de Debut";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(337, 636);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(76, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Date de Fin";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(543, 672);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(112, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Prix de Prestation";
            // 
            // tbPrix
            // 
            this.tbPrix.Location = new System.Drawing.Point(661, 666);
            this.tbPrix.Name = "tbPrix";
            this.tbPrix.PromptText = "Prix par jour";
            this.tbPrix.Size = new System.Drawing.Size(290, 23);
            this.tbPrix.TabIndex = 11;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(543, 641);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(120, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Nom de Prestation";
            // 
            // tbNomPresta
            // 
            this.tbNomPresta.Location = new System.Drawing.Point(661, 631);
            this.tbNomPresta.Name = "tbNomPresta";
            this.tbNomPresta.PromptText = "Nom de la prestation";
            this.tbNomPresta.Size = new System.Drawing.Size(290, 23);
            this.tbNomPresta.TabIndex = 12;
            // 
            // IdTravail
            // 
            this.IdTravail.DataPropertyName = "IdCat";
            this.IdTravail.HeaderText = "ID";
            this.IdTravail.Name = "IdTravail";
            this.IdTravail.Width = 60;
            // 
            // NomTravail
            // 
            this.NomTravail.DataPropertyName = "NomTravail";
            this.NomTravail.HeaderText = "NOM";
            this.NomTravail.Name = "NomTravail";
            this.NomTravail.Width = 243;
            // 
            // IdPresta
            // 
            this.IdPresta.DataPropertyName = "IdPresta";
            this.IdPresta.HeaderText = "ID";
            this.IdPresta.Name = "IdPresta";
            // 
            // Interimaire
            // 
            this.Interimaire.DataPropertyName = "Interimaire";
            this.Interimaire.HeaderText = "Interimaire";
            this.Interimaire.Name = "Interimaire";
            this.Interimaire.Width = 146;
            // 
            // Entreprise
            // 
            this.Entreprise.DataPropertyName = "Entreprise";
            this.Entreprise.HeaderText = "Entreprise";
            this.Entreprise.Name = "Entreprise";
            this.Entreprise.Width = 146;
            // 
            // Travail
            // 
            this.Travail.DataPropertyName = "Travail";
            this.Travail.HeaderText = "Travail";
            this.Travail.Name = "Travail";
            this.Travail.Width = 146;
            // 
            // DtDebut
            // 
            this.DtDebut.DataPropertyName = "DateDebut";
            this.DtDebut.HeaderText = "Date Debut";
            this.DtDebut.Name = "DtDebut";
            this.DtDebut.Width = 146;
            // 
            // DtFin
            // 
            this.DtFin.DataPropertyName = "DateFin";
            this.DtFin.HeaderText = "Date Fin";
            this.DtFin.Name = "DtFin";
            this.DtFin.Width = 146;
            // 
            // Jours
            // 
            this.Jours.DataPropertyName = "JourRestant";
            this.Jours.HeaderText = "Jours restant";
            this.Jours.Name = "Jours";
            this.Jours.Width = 146;
            // 
            // Facture
            // 
            this.Facture.DataPropertyName = "Facture";
            this.Facture.HeaderText = "Facture";
            this.Facture.Name = "Facture";
            this.Facture.Width = 146;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.Width = 146;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 724);
            this.Controls.Add(this.tbNomPresta);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbPrix);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.dtpFin);
            this.Controls.Add(this.dtpDebut);
            this.Controls.Add(this.BtnSupprimer);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvPrestations);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.dgvEntreprise);
            this.Controls.Add(this.dgvTravails);
            this.Controls.Add(this.dgvInterimeur);
            this.Controls.Add(this.btnGInte);
            this.Controls.Add(this.btnGeEntre);
            this.Controls.Add(this.btnGeFact);
            this.Controls.Add(this.btnGePresta);
            this.Controls.Add(this.btnRefresh);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTravails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnGePresta;
        private MetroFramework.Controls.MetroTile btnGInte;
        private MetroFramework.Controls.MetroTile btnGeEntre;
        private MetroFramework.Controls.MetroTile btnGeFact;
        private System.Windows.Forms.DataGridView dgvInterimeur;
        private System.Windows.Forms.DataGridView dgvEntreprise;
        private System.Windows.Forms.DataGridView dgvTravails;
        private System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.DataGridView dgvPrestations;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFact;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroButton btnConfirmer;
        private MetroFramework.Controls.MetroButton BtnSupprimer;
        private System.Windows.Forms.DateTimePicker dtpDebut;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox tbPrix;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox tbNomPresta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdTravail;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomTravail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPresta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Interimaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn Travail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Jours;
        private System.Windows.Forms.DataGridViewTextBoxColumn Facture;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}