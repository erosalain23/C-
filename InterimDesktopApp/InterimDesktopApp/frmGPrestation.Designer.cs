namespace InterimDesktopApp
{
    partial class FrmGPrestation
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
            this.btnConfirmer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnnuler = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSupprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAjouter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbFacturee = new MetroFramework.Controls.MetroCheckBox();
            this.cbFacture = new MetroFramework.Controls.MetroComboBox();
            this.tbSalPresta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbNomPresta = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvPrestation = new System.Windows.Forms.DataGridView();
            this.IdPresta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomTravail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalTravail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbCategorie = new MetroFramework.Controls.MetroComboBox();
            this.llbCateg = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestation)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Depth = 0;
            this.btnConfirmer.Location = new System.Drawing.Point(524, 482);
            this.btnConfirmer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Primary = true;
            this.btnConfirmer.Size = new System.Drawing.Size(152, 33);
            this.btnConfirmer.TabIndex = 18;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click_1);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Depth = 0;
            this.btnAnnuler.Location = new System.Drawing.Point(688, 483);
            this.btnAnnuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Primary = true;
            this.btnAnnuler.Size = new System.Drawing.Size(152, 33);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click_1);
            // 
            // btnEditer
            // 
            this.btnEditer.Depth = 0;
            this.btnEditer.Location = new System.Drawing.Point(208, 482);
            this.btnEditer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Primary = true;
            this.btnEditer.Size = new System.Drawing.Size(152, 33);
            this.btnEditer.TabIndex = 20;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click_1);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Depth = 0;
            this.btnSupprimer.Location = new System.Drawing.Point(366, 482);
            this.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Primary = true;
            this.btnSupprimer.Size = new System.Drawing.Size(152, 33);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click_1);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Depth = 0;
            this.btnAjouter.Location = new System.Drawing.Point(44, 482);
            this.btnAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Primary = true;
            this.btnAjouter.Size = new System.Drawing.Size(152, 33);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click_1);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(366, 323);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Status";
            // 
            // cbFacturee
            // 
            this.cbFacturee.AutoSize = true;
            this.cbFacturee.Location = new System.Drawing.Point(415, 327);
            this.cbFacturee.Name = "cbFacturee";
            this.cbFacturee.Size = new System.Drawing.Size(68, 15);
            this.cbFacturee.TabIndex = 16;
            this.cbFacturee.Text = "Facturee";
            this.cbFacturee.UseVisualStyleBackColor = true;
            // 
            // cbFacture
            // 
            this.cbFacture.FormattingEnabled = true;
            this.cbFacture.ItemHeight = 23;
            this.cbFacture.Location = new System.Drawing.Point(640, 447);
            this.cbFacture.Name = "cbFacture";
            this.cbFacture.Size = new System.Drawing.Size(200, 29);
            this.cbFacture.TabIndex = 15;
            // 
            // tbSalPresta
            // 
            this.tbSalPresta.Location = new System.Drawing.Point(153, 391);
            this.tbSalPresta.Name = "tbSalPresta";
            this.tbSalPresta.PromptText = "Prenom";
            this.tbSalPresta.Size = new System.Drawing.Size(154, 23);
            this.tbSalPresta.TabIndex = 12;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(43, 391);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(91, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = "Salaire Travail:";
            // 
            // tbNomPresta
            // 
            this.tbNomPresta.Location = new System.Drawing.Point(153, 355);
            this.tbNomPresta.Name = "tbNomPresta";
            this.tbNomPresta.PromptText = "Nom";
            this.tbNomPresta.Size = new System.Drawing.Size(154, 23);
            this.tbNomPresta.TabIndex = 13;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(43, 355);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(104, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Nom Prestation:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(153, 319);
            this.tbId.Name = "tbId";
            this.tbId.PromptText = "ID";
            this.tbId.Size = new System.Drawing.Size(154, 23);
            this.tbId.TabIndex = 14;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(560, 456);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(54, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = "Facture:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(43, 323);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Prestation ID:";
            // 
            // dgvPrestation
            // 
            this.dgvPrestation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPresta,
            this.NomTravail,
            this.DtDebut,
            this.dtFin,
            this.SalTravail,
            this.IdCateg,
            this.IdFact});
            this.dgvPrestation.Location = new System.Drawing.Point(43, 79);
            this.dgvPrestation.Name = "dgvPrestation";
            this.dgvPrestation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrestation.Size = new System.Drawing.Size(797, 222);
            this.dgvPrestation.TabIndex = 7;
            // 
            // IdPresta
            // 
            this.IdPresta.DataPropertyName = "IdPresta";
            this.IdPresta.HeaderText = "ID";
            this.IdPresta.Name = "IdPresta";
            // 
            // NomTravail
            // 
            this.NomTravail.DataPropertyName = "NomTravail";
            this.NomTravail.HeaderText = "PRESTATION";
            this.NomTravail.Name = "NomTravail";
            this.NomTravail.Width = 130;
            // 
            // DtDebut
            // 
            this.DtDebut.DataPropertyName = "DtDebut";
            this.DtDebut.HeaderText = "DEBUT";
            this.DtDebut.Name = "DtDebut";
            // 
            // dtFin
            // 
            this.dtFin.DataPropertyName = "DtFin";
            this.dtFin.HeaderText = "FIN";
            this.dtFin.Name = "dtFin";
            // 
            // SalTravail
            // 
            this.SalTravail.DataPropertyName = "SalTravail";
            this.SalTravail.HeaderText = "SALAIRE";
            this.SalTravail.Name = "SalTravail";
            // 
            // IdCateg
            // 
            this.IdCateg.DataPropertyName = "IdCateg";
            this.IdCateg.HeaderText = "CATEGORIE";
            this.IdCateg.Name = "IdCateg";
            this.IdCateg.Width = 130;
            // 
            // IdFact
            // 
            this.IdFact.DataPropertyName = "IdFact";
            this.IdFact.HeaderText = "Facture";
            this.IdFact.Name = "IdFact";
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(640, 319);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(200, 20);
            this.dtpStart.TabIndex = 23;
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(640, 356);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 23;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(560, 356);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(61, 19);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "End date";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(560, 323);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(67, 19);
            this.metroLabel7.TabIndex = 24;
            this.metroLabel7.Text = "Start date";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(560, 395);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 10;
            this.metroLabel8.Text = "Categorie:";
            // 
            // cbCategorie
            // 
            this.cbCategorie.FormattingEnabled = true;
            this.cbCategorie.ItemHeight = 23;
            this.cbCategorie.Location = new System.Drawing.Point(640, 386);
            this.cbCategorie.Name = "cbCategorie";
            this.cbCategorie.Size = new System.Drawing.Size(200, 29);
            this.cbCategorie.TabIndex = 15;
            // 
            // llbCateg
            // 
            this.llbCateg.ForeColor = System.Drawing.SystemColors.Highlight;
            this.llbCateg.Location = new System.Drawing.Point(640, 418);
            this.llbCateg.Name = "llbCateg";
            this.llbCateg.Size = new System.Drawing.Size(152, 23);
            this.llbCateg.TabIndex = 25;
            this.llbCateg.Text = "New Categorie";
            this.llbCateg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.llbCateg.Click += new System.EventHandler(this.llbCateg_Click);
            // 
            // FrmGPrestation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 539);
            this.Controls.Add(this.llbCateg);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.cbFacturee);
            this.Controls.Add(this.cbCategorie);
            this.Controls.Add(this.cbFacture);
            this.Controls.Add(this.tbSalPresta);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbNomPresta);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvPrestation);
            this.Name = "FrmGPrestation";
            this.Text = "Info Prestation";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAnnuler;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditer;
        private MaterialSkin.Controls.MaterialRaisedButton btnSupprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAjouter;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroCheckBox cbFacturee;
        private MetroFramework.Controls.MetroComboBox cbFacture;
        private MetroFramework.Controls.MetroTextBox tbSalPresta;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbNomPresta;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbId;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvPrestation;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbCategorie;
        private MetroFramework.Controls.MetroLink llbCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPresta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomTravail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DtDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalTravail;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFact;
    }
}