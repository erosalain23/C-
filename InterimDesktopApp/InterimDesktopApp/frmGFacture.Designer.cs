namespace InterimDesktopApp
{
    partial class FrmGFacture
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
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvFacture = new System.Windows.Forms.DataGridView();
            this.IdFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdInte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpFacture = new System.Windows.Forms.DateTimePicker();
            this.cbEntre = new MetroFramework.Controls.MetroComboBox();
            this.cbInte = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.btnCA = new MaterialSkin.Controls.MaterialRaisedButton();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.cbEntre2 = new System.Windows.Forms.ComboBox();
            this.cbInte2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Depth = 0;
            this.btnConfirmer.Location = new System.Drawing.Point(529, 501);
            this.btnConfirmer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Primary = true;
            this.btnConfirmer.Size = new System.Drawing.Size(152, 33);
            this.btnConfirmer.TabIndex = 18;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Depth = 0;
            this.btnAnnuler.Location = new System.Drawing.Point(687, 501);
            this.btnAnnuler.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Primary = true;
            this.btnAnnuler.Size = new System.Drawing.Size(152, 33);
            this.btnAnnuler.TabIndex = 19;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Depth = 0;
            this.btnEditer.Location = new System.Drawing.Point(213, 501);
            this.btnEditer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Primary = true;
            this.btnEditer.Size = new System.Drawing.Size(152, 33);
            this.btnEditer.TabIndex = 20;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Depth = 0;
            this.btnSupprimer.Location = new System.Drawing.Point(371, 501);
            this.btnSupprimer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Primary = true;
            this.btnSupprimer.Size = new System.Drawing.Size(152, 33);
            this.btnSupprimer.TabIndex = 21;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Depth = 0;
            this.btnAjouter.Location = new System.Drawing.Point(49, 501);
            this.btnAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Primary = true;
            this.btnAjouter.Size = new System.Drawing.Size(152, 33);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(48, 374);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(39, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Date:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(152, 338);
            this.tbId.Name = "tbId";
            this.tbId.PromptText = "ID";
            this.tbId.Size = new System.Drawing.Size(154, 23);
            this.tbId.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(48, 342);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(70, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Facture ID:";
            // 
            // dgvFacture
            // 
            this.dgvFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFacture.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdFact,
            this.DateFact,
            this.IdEntre,
            this.IdInte});
            this.dgvFacture.Location = new System.Drawing.Point(48, 98);
            this.dgvFacture.Name = "dgvFacture";
            this.dgvFacture.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvFacture.Size = new System.Drawing.Size(797, 222);
            this.dgvFacture.TabIndex = 7;
            // 
            // IdFact
            // 
            this.IdFact.DataPropertyName = "IdFact";
            this.IdFact.HeaderText = "ID";
            this.IdFact.Name = "IdFact";
            // 
            // DateFact
            // 
            this.DateFact.DataPropertyName = "DateFact";
            this.DateFact.HeaderText = "DATE";
            this.DateFact.Name = "DateFact";
            this.DateFact.Width = 220;
            // 
            // IdEntre
            // 
            this.IdEntre.DataPropertyName = "IdEntre";
            this.IdEntre.HeaderText = "ENTREPRISE";
            this.IdEntre.Name = "IdEntre";
            this.IdEntre.Width = 240;
            // 
            // IdInte
            // 
            this.IdInte.DataPropertyName = "IdInte";
            this.IdInte.HeaderText = "INTERIMEUR";
            this.IdInte.Name = "IdInte";
            this.IdInte.Width = 200;
            // 
            // dtpFacture
            // 
            this.dtpFacture.Location = new System.Drawing.Point(152, 373);
            this.dtpFacture.Name = "dtpFacture";
            this.dtpFacture.Size = new System.Drawing.Size(154, 20);
            this.dtpFacture.TabIndex = 23;
            // 
            // cbEntre
            // 
            this.cbEntre.FormattingEnabled = true;
            this.cbEntre.ItemHeight = 23;
            this.cbEntre.Location = new System.Drawing.Point(529, 332);
            this.cbEntre.Name = "cbEntre";
            this.cbEntre.Size = new System.Drawing.Size(121, 29);
            this.cbEntre.TabIndex = 24;
            // 
            // cbInte
            // 
            this.cbInte.FormattingEnabled = true;
            this.cbInte.ItemHeight = 23;
            this.cbInte.Location = new System.Drawing.Point(529, 364);
            this.cbInte.Name = "cbInte";
            this.cbInte.Size = new System.Drawing.Size(121, 29);
            this.cbInte.TabIndex = 24;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(407, 373);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(88, 19);
            this.metroLabel3.TabIndex = 11;
            this.metroLabel3.Text = "Interimeur ID:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(407, 342);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(86, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "Entreprise ID:";
            // 
            // btnCA
            // 
            this.btnCA.Depth = 0;
            this.btnCA.Location = new System.Drawing.Point(529, 399);
            this.btnCA.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCA.Name = "btnCA";
            this.btnCA.Primary = true;
            this.btnCA.Size = new System.Drawing.Size(152, 33);
            this.btnCA.TabIndex = 25;
            this.btnCA.Text = "PDF";
            this.btnCA.UseVisualStyleBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(407, 415);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(46, 19);
            this.metroLabel5.TabIndex = 26;
            this.metroLabel5.Text = "CA/an";
            // 
            // cbEntre2
            // 
            this.cbEntre2.FormattingEnabled = true;
            this.cbEntre2.Location = new System.Drawing.Point(677, 340);
            this.cbEntre2.Name = "cbEntre2";
            this.cbEntre2.Size = new System.Drawing.Size(121, 21);
            this.cbEntre2.TabIndex = 27;
            // 
            // cbInte2
            // 
            this.cbInte2.FormattingEnabled = true;
            this.cbInte2.Location = new System.Drawing.Point(677, 371);
            this.cbInte2.Name = "cbInte2";
            this.cbInte2.Size = new System.Drawing.Size(121, 21);
            this.cbInte2.TabIndex = 27;
            // 
            // FrmGFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 560);
            this.Controls.Add(this.cbInte2);
            this.Controls.Add(this.cbEntre2);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.btnCA);
            this.Controls.Add(this.cbInte);
            this.Controls.Add(this.cbEntre);
            this.Controls.Add(this.dtpFacture);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvFacture);
            this.Name = "FrmGFacture";
            this.Text = "Info Facture";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFacture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialRaisedButton btnConfirmer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAnnuler;
        private MaterialSkin.Controls.MaterialRaisedButton btnEditer;
        private MaterialSkin.Controls.MaterialRaisedButton btnSupprimer;
        private MaterialSkin.Controls.MaterialRaisedButton btnAjouter;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvFacture;
        private System.Windows.Forms.DateTimePicker dtpFacture;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdInte;
        private MetroFramework.Controls.MetroComboBox cbEntre;
        private MetroFramework.Controls.MetroComboBox cbInte;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MaterialSkin.Controls.MaterialRaisedButton btnCA;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.ComboBox cbEntre2;
        private System.Windows.Forms.ComboBox cbInte2;
    }
}