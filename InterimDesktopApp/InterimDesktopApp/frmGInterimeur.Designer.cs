namespace InterimDesktopApp
{
    partial class btnEmpDuTemps
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
            this.dgvInterimeur = new System.Windows.Forms.DataGridView();
            this.IdInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdSpecialisation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BonusSal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.tbId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbNom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.tbPrenom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.cbMetier = new MetroFramework.Controls.MetroComboBox();
            this.btnAjouter = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnSupprimer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEditer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnAnnuler = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnConfirmer = new MaterialSkin.Controls.MaterialRaisedButton();
            this.lbBonus = new MetroFramework.Controls.MetroLabel();
            this.tbBonus = new MetroFramework.Controls.MetroTextBox();
            this.btnEmplDuTmp = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnMomntLbr = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cbEntreprise = new MetroFramework.Controls.MetroComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInterimeur
            // 
            this.dgvInterimeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterimeur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInte,
            this.NomInte,
            this.PrenomInte,
            this.IdSpecialisation,
            this.BonusSal});
            this.dgvInterimeur.Location = new System.Drawing.Point(23, 73);
            this.dgvInterimeur.Name = "dgvInterimeur";
            this.dgvInterimeur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInterimeur.Size = new System.Drawing.Size(797, 222);
            this.dgvInterimeur.TabIndex = 0;
            // 
            // IdInte
            // 
            this.IdInte.DataPropertyName = "IdInte";
            this.IdInte.HeaderText = "ID";
            this.IdInte.Name = "IdInte";
            // 
            // NomInte
            // 
            this.NomInte.DataPropertyName = "NomInte";
            this.NomInte.HeaderText = "NOM";
            this.NomInte.Name = "NomInte";
            this.NomInte.Width = 180;
            // 
            // PrenomInte
            // 
            this.PrenomInte.DataPropertyName = "PrenomInte";
            this.PrenomInte.HeaderText = "PRENOM";
            this.PrenomInte.Name = "PrenomInte";
            this.PrenomInte.Width = 180;
            // 
            // IdSpecialisation
            // 
            this.IdSpecialisation.DataPropertyName = "IdSpec";
            this.IdSpecialisation.HeaderText = "Metier";
            this.IdSpecialisation.Name = "IdSpecialisation";
            this.IdSpecialisation.Width = 200;
            // 
            // BonusSal
            // 
            this.BonusSal.DataPropertyName = "BonusSal";
            this.BonusSal.HeaderText = "BONUS";
            this.BonusSal.Name = "BonusSal";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 317);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(88, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Interimeur ID:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(127, 313);
            this.tbId.Name = "tbId";
            this.tbId.PromptText = "ID";
            this.tbId.Size = new System.Drawing.Size(154, 23);
            this.tbId.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(23, 349);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 1;
            this.metroLabel2.Text = "Nom:";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(127, 349);
            this.tbNom.Name = "tbNom";
            this.tbNom.PromptText = "Nom";
            this.tbNom.Size = new System.Drawing.Size(154, 23);
            this.tbNom.TabIndex = 2;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 385);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 1;
            this.metroLabel3.Text = "Prenom:";
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(127, 385);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.PromptText = "Prenom";
            this.tbPrenom.Size = new System.Drawing.Size(154, 23);
            this.tbPrenom.TabIndex = 2;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(23, 424);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(90, 19);
            this.metroLabel4.TabIndex = 1;
            this.metroLabel4.Text = "Specialisation:";
            // 
            // cbMetier
            // 
            this.cbMetier.FormattingEnabled = true;
            this.cbMetier.ItemHeight = 23;
            this.cbMetier.Location = new System.Drawing.Point(127, 414);
            this.cbMetier.Name = "cbMetier";
            this.cbMetier.Size = new System.Drawing.Size(154, 29);
            this.cbMetier.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Depth = 0;
            this.btnAjouter.Location = new System.Drawing.Point(24, 505);
            this.btnAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Primary = true;
            this.btnAjouter.Size = new System.Drawing.Size(152, 33);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Depth = 0;
            this.btnSupprimer.Location = new System.Drawing.Point(346, 505);
            this.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Primary = true;
            this.btnSupprimer.Size = new System.Drawing.Size(152, 33);
            this.btnSupprimer.TabIndex = 6;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Depth = 0;
            this.btnEditer.Location = new System.Drawing.Point(188, 505);
            this.btnEditer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Primary = true;
            this.btnEditer.Size = new System.Drawing.Size(152, 33);
            this.btnEditer.TabIndex = 6;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Depth = 0;
            this.btnAnnuler.Location = new System.Drawing.Point(662, 505);
            this.btnAnnuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Primary = true;
            this.btnAnnuler.Size = new System.Drawing.Size(152, 33);
            this.btnAnnuler.TabIndex = 6;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Depth = 0;
            this.btnConfirmer.Location = new System.Drawing.Point(504, 505);
            this.btnConfirmer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Primary = true;
            this.btnConfirmer.Size = new System.Drawing.Size(152, 33);
            this.btnConfirmer.TabIndex = 6;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // lbBonus
            // 
            this.lbBonus.AutoSize = true;
            this.lbBonus.Location = new System.Drawing.Point(346, 349);
            this.lbBonus.Name = "lbBonus";
            this.lbBonus.Size = new System.Drawing.Size(42, 19);
            this.lbBonus.TabIndex = 1;
            this.lbBonus.Text = "Bonu:";
            // 
            // tbBonus
            // 
            this.tbBonus.Location = new System.Drawing.Point(502, 349);
            this.tbBonus.Name = "tbBonus";
            this.tbBonus.PromptText = "Bonus rate";
            this.tbBonus.Size = new System.Drawing.Size(154, 23);
            this.tbBonus.TabIndex = 2;
            // 
            // btnEmplDuTmp
            // 
            this.btnEmplDuTmp.Depth = 0;
            this.btnEmplDuTmp.Location = new System.Drawing.Point(662, 385);
            this.btnEmplDuTmp.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmplDuTmp.Name = "btnEmplDuTmp";
            this.btnEmplDuTmp.Primary = true;
            this.btnEmplDuTmp.Size = new System.Drawing.Size(152, 36);
            this.btnEmplDuTmp.TabIndex = 7;
            this.btnEmplDuTmp.Text = "PDF";
            this.btnEmplDuTmp.UseVisualStyleBackColor = true;
            this.btnEmplDuTmp.Click += new System.EventHandler(this.btnEmplDuTmp_Click);
            // 
            // btnMomntLbr
            // 
            this.btnMomntLbr.Depth = 0;
            this.btnMomntLbr.Location = new System.Drawing.Point(662, 427);
            this.btnMomntLbr.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMomntLbr.Name = "btnMomntLbr";
            this.btnMomntLbr.Primary = true;
            this.btnMomntLbr.Size = new System.Drawing.Size(152, 36);
            this.btnMomntLbr.TabIndex = 7;
            this.btnMomntLbr.Text = "PDF";
            this.btnMomntLbr.UseVisualStyleBackColor = true;
            this.btnMomntLbr.Click += new System.EventHandler(this.btnMomntLbr_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(346, 402);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(187, 19);
            this.metroLabel6.TabIndex = 9;
            this.metroLabel6.Text = "Document d\'emploi du temps:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(346, 444);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(216, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "Les moments libres de l\'interimaire:";
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(23, 459);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(70, 19);
            this.metroLabel8.TabIndex = 1;
            this.metroLabel8.Text = "Entreprise:";
            // 
            // cbEntreprise
            // 
            this.cbEntreprise.FormattingEnabled = true;
            this.cbEntreprise.ItemHeight = 23;
            this.cbEntreprise.Location = new System.Drawing.Point(127, 449);
            this.cbEntreprise.Name = "cbEntreprise";
            this.cbEntreprise.Size = new System.Drawing.Size(154, 29);
            this.cbEntreprise.TabIndex = 3;
            // 
            // btnEmpDuTemps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 573);
            this.Controls.Add(this.metroLabel7);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.btnMomntLbr);
            this.Controls.Add(this.btnEmplDuTmp);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.cbEntreprise);
            this.Controls.Add(this.cbMetier);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.tbBonus);
            this.Controls.Add(this.lbBonus);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvInterimeur);
            this.Name = "btnEmpDuTemps";
            this.Text = "Info Interimeur";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInterimeur;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox tbId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbNom;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox tbPrenom;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroComboBox cbMetier;
        private MaterialSkin.Controls.MaterialRaisedButton btnAjouter;
        private MaterialSkin.Controls.MaterialRaisedButton btnSupprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAnnuler;
        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmer;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdSpecialisation;
        private System.Windows.Forms.DataGridViewTextBoxColumn BonusSal;
        private MetroFramework.Controls.MetroLabel lbBonus;
        private MetroFramework.Controls.MetroTextBox tbBonus;
        private MaterialSkin.Controls.MaterialRaisedButton btnEmplDuTmp;
        private MaterialSkin.Controls.MaterialRaisedButton btnMomntLbr;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cbEntreprise;
    }
}