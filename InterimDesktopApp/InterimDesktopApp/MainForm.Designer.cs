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
            this.btnRefresh = new MetroFramework.Controls.MetroTile();
            this.btnGePresta = new MetroFramework.Controls.MetroTile();
            this.btnGInte = new MetroFramework.Controls.MetroTile();
            this.btnGeEntre = new MetroFramework.Controls.MetroTile();
            this.btnGeFact = new MetroFramework.Controls.MetroTile();
            this.dgvInterimeur = new System.Windows.Forms.DataGridView();
            this.IdInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrenomInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEntreprise = new System.Windows.Forms.DataGridView();
            this.IdEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPrestation = new System.Windows.Forms.DataGridView();
            this.IdPresta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomPresta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomCateg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.IdFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGClient = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGInterimeur = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGFacture = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGPrestation = new MaterialSkin.Controls.MaterialRaisedButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(23, 74);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 62);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnGePresta
            // 
            this.btnGePresta.Location = new System.Drawing.Point(266, 74);
            this.btnGePresta.Name = "btnGePresta";
            this.btnGePresta.Size = new System.Drawing.Size(75, 62);
            this.btnGePresta.TabIndex = 0;
            this.btnGePresta.Text = "Add P";
            this.btnGePresta.Click += new System.EventHandler(this.btnGePresta_Click);
            // 
            // btnGInte
            // 
            this.btnGInte.Location = new System.Drawing.Point(104, 74);
            this.btnGInte.Name = "btnGInte";
            this.btnGInte.Size = new System.Drawing.Size(75, 62);
            this.btnGInte.TabIndex = 0;
            this.btnGInte.Text = "Add I";
            this.btnGInte.Click += new System.EventHandler(this.btnGInte_Click);
            // 
            // btnGeEntre
            // 
            this.btnGeEntre.Location = new System.Drawing.Point(185, 74);
            this.btnGeEntre.Name = "btnGeEntre";
            this.btnGeEntre.Size = new System.Drawing.Size(75, 62);
            this.btnGeEntre.TabIndex = 0;
            this.btnGeEntre.Text = "Add C";
            this.btnGeEntre.Click += new System.EventHandler(this.btnGeEntre_Click);
            // 
            // btnGeFact
            // 
            this.btnGeFact.Location = new System.Drawing.Point(347, 74);
            this.btnGeFact.Name = "btnGeFact";
            this.btnGeFact.Size = new System.Drawing.Size(75, 62);
            this.btnGeFact.TabIndex = 0;
            this.btnGeFact.Text = "Print";
            this.btnGeFact.Click += new System.EventHandler(this.btnGeFact_Click);
            // 
            // dgvInterimeur
            // 
            this.dgvInterimeur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInterimeur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdInte,
            this.NomInte,
            this.PrenomInte});
            this.dgvInterimeur.Location = new System.Drawing.Point(23, 167);
            this.dgvInterimeur.Name = "dgvInterimeur";
            this.dgvInterimeur.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvInterimeur.Size = new System.Drawing.Size(399, 154);
            this.dgvInterimeur.TabIndex = 1;
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
            this.NomInte.Width = 130;
            // 
            // PrenomInte
            // 
            this.PrenomInte.DataPropertyName = "PrenomInte";
            this.PrenomInte.HeaderText = "PRENOM";
            this.PrenomInte.Name = "PrenomInte";
            this.PrenomInte.Width = 130;
            // 
            // dgvEntreprise
            // 
            this.dgvEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntreprise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntre,
            this.NomEntre});
            this.dgvEntreprise.Location = new System.Drawing.Point(471, 167);
            this.dgvEntreprise.Name = "dgvEntreprise";
            this.dgvEntreprise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEntreprise.Size = new System.Drawing.Size(399, 154);
            this.dgvEntreprise.TabIndex = 1;
            // 
            // IdEntre
            // 
            this.IdEntre.DataPropertyName = "IdEntre";
            this.IdEntre.HeaderText = "ID";
            this.IdEntre.Name = "IdEntre";
            this.IdEntre.Width = 140;
            // 
            // NomEntre
            // 
            this.NomEntre.DataPropertyName = "NomEntre";
            this.NomEntre.HeaderText = "NOM";
            this.NomEntre.Name = "NomEntre";
            this.NomEntre.Width = 220;
            // 
            // dgvPrestation
            // 
            this.dgvPrestation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestation.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPresta,
            this.NomPresta,
            this.NomCateg});
            this.dgvPrestation.Location = new System.Drawing.Point(23, 371);
            this.dgvPrestation.Name = "dgvPrestation";
            this.dgvPrestation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvPrestation.Size = new System.Drawing.Size(399, 154);
            this.dgvPrestation.TabIndex = 1;
            // 
            // IdPresta
            // 
            this.IdPresta.DataPropertyName = "IdPresta";
            this.IdPresta.HeaderText = "ID";
            this.IdPresta.Name = "IdPresta";
            this.IdPresta.Width = 60;
            // 
            // NomPresta
            // 
            this.NomPresta.DataPropertyName = "NomPresta";
            this.NomPresta.HeaderText = "NOM";
            this.NomPresta.Name = "NomPresta";
            this.NomPresta.Width = 143;
            // 
            // NomCateg
            // 
            this.NomCateg.DataPropertyName = "NomCateg";
            this.NomCateg.HeaderText = "CATEGORIE";
            this.NomCateg.Name = "NomCateg";
            this.NomCateg.Width = 155;
            // 
            // dgvFacture
            // 
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFact,
            this.DateFact});
            this.dgvFacture.Location = new System.Drawing.Point(471, 371);
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFacture.Size = new System.Drawing.Size(399, 154);
            this.dgvFacture.TabIndex = 1;
            // 
            // IdFact
            // 
            this.IdFact.DataPropertyName = "IdFact";
            this.IdFact.HeaderText = "ID";
            this.IdFact.Name = "IdFact";
            this.IdFact.Width = 180;
            // 
            // DateFact
            // 
            this.DateFact.DataPropertyName = "dateFact";
            this.DateFact.HeaderText = "DATE";
            this.DateFact.Name = "DateFact";
            this.DateFact.Width = 200;
            // 
            // btnGClient
            // 
            this.btnGClient.Depth = 0;
            this.btnGClient.Location = new System.Drawing.Point(471, 328);
            this.btnGClient.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGClient.Name = "btnGClient";
            this.btnGClient.Primary = true;
            this.btnGClient.Size = new System.Drawing.Size(399, 36);
            this.btnGClient.TabIndex = 3;
            this.btnGClient.Text = "Gerer entreprise";
            this.btnGClient.UseVisualStyleBackColor = true;
            this.btnGClient.Click += new System.EventHandler(this.btnGeEntre_Click);
            // 
            // btnGInterimeur
            // 
            this.btnGInterimeur.BackColor = System.Drawing.Color.White;
            this.btnGInterimeur.Depth = 0;
            this.btnGInterimeur.Location = new System.Drawing.Point(23, 327);
            this.btnGInterimeur.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGInterimeur.Name = "btnGInterimeur";
            this.btnGInterimeur.Primary = true;
            this.btnGInterimeur.Size = new System.Drawing.Size(399, 36);
            this.btnGInterimeur.TabIndex = 3;
            this.btnGInterimeur.Text = "Gerer interimeur";
            this.btnGInterimeur.UseVisualStyleBackColor = false;
            this.btnGInterimeur.Click += new System.EventHandler(this.btnGInte_Click);
            // 
            // btnGFacture
            // 
            this.btnGFacture.Depth = 0;
            this.btnGFacture.Location = new System.Drawing.Point(471, 531);
            this.btnGFacture.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGFacture.Name = "btnGFacture";
            this.btnGFacture.Primary = true;
            this.btnGFacture.Size = new System.Drawing.Size(399, 36);
            this.btnGFacture.TabIndex = 3;
            this.btnGFacture.Text = "Gerer facture";
            this.btnGFacture.UseVisualStyleBackColor = true;
            this.btnGFacture.Click += new System.EventHandler(this.btnGeFact_Click);
            // 
            // btnGPrestation
            // 
            this.btnGPrestation.Depth = 0;
            this.btnGPrestation.Location = new System.Drawing.Point(23, 530);
            this.btnGPrestation.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGPrestation.Name = "btnGPrestation";
            this.btnGPrestation.Primary = true;
            this.btnGPrestation.Size = new System.Drawing.Size(399, 36);
            this.btnGPrestation.TabIndex = 3;
            this.btnGPrestation.Text = "Gerer prestation";
            this.btnGPrestation.UseVisualStyleBackColor = true;
            this.btnGPrestation.Click += new System.EventHandler(this.btnGePresta_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 580);
            this.Controls.Add(this.btnGPrestation);
            this.Controls.Add(this.btnGInterimeur);
            this.Controls.Add(this.btnGFacture);
            this.Controls.Add(this.btnGClient);
            this.Controls.Add(this.dgvFacture);
            this.Controls.Add(this.dgvEntreprise);
            this.Controls.Add(this.dgvPrestation);
            this.Controls.Add(this.dgvInterimeur);
            this.Controls.Add(this.btnGInte);
            this.Controls.Add(this.btnGeEntre);
            this.Controls.Add(this.btnGeFact);
            this.Controls.Add(this.btnGePresta);
            this.Controls.Add(this.btnRefresh);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInterimeur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile btnRefresh;
        private MetroFramework.Controls.MetroTile btnGePresta;
        private MetroFramework.Controls.MetroTile btnGInte;
        private MetroFramework.Controls.MetroTile btnGeEntre;
        private MetroFramework.Controls.MetroTile btnGeFact;
        private System.Windows.Forms.DataGridView dgvInterimeur;
        private System.Windows.Forms.DataGridView dgvEntreprise;
        private System.Windows.Forms.DataGridView dgvPrestation;
        private System.Windows.Forms.DataGridView dgvFacture;
        private MaterialSkin.Controls.MaterialRaisedButton btnGClient;
        private MaterialSkin.Controls.MaterialRaisedButton btnGInterimeur;
        private MaterialSkin.Controls.MaterialRaisedButton btnGFacture;
        private MaterialSkin.Controls.MaterialRaisedButton btnGPrestation;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrenomInte;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPresta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomPresta;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomCateg;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEntre;
    }
}