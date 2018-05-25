namespace InterimDesktopApp
{
    partial class FrmGEntreprise
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
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.tbNom = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.tbId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvEntreprise = new System.Windows.Forms.DataGridView();
            this.IdEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomEntre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Depth = 0;
            this.btnConfirmer.Location = new System.Drawing.Point(517, 495);
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
            this.btnAnnuler.Location = new System.Drawing.Point(675, 495);
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
            this.btnEditer.Location = new System.Drawing.Point(201, 495);
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
            this.btnSupprimer.Location = new System.Drawing.Point(359, 495);
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
            this.btnAjouter.Location = new System.Drawing.Point(37, 495);
            this.btnAjouter.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Primary = true;
            this.btnAjouter.Size = new System.Drawing.Size(152, 33);
            this.btnAjouter.TabIndex = 22;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(359, 336);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(43, 19);
            this.metroLabel5.TabIndex = 17;
            this.metroLabel5.Text = "Status";
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Location = new System.Drawing.Point(408, 340);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(68, 15);
            this.metroCheckBox1.TabIndex = 16;
            this.metroCheckBox1.Text = "Facturee";
            this.metroCheckBox1.UseVisualStyleBackColor = true;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(140, 368);
            this.tbNom.Name = "tbNom";
            this.tbNom.PromptText = "Nom";
            this.tbNom.Size = new System.Drawing.Size(154, 23);
            this.tbNom.TabIndex = 13;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(36, 368);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(42, 19);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Nom:";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(140, 332);
            this.tbId.Name = "tbId";
            this.tbId.PromptText = "ID";
            this.tbId.Size = new System.Drawing.Size(154, 23);
            this.tbId.TabIndex = 14;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(36, 336);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(86, 19);
            this.metroLabel1.TabIndex = 11;
            this.metroLabel1.Text = "Entreprise ID:";
            // 
            // dgvEntreprise
            // 
            this.dgvEntreprise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntreprise.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdEntre,
            this.NomEntre});
            this.dgvEntreprise.Location = new System.Drawing.Point(36, 92);
            this.dgvEntreprise.Name = "dgvEntreprise";
            this.dgvEntreprise.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvEntreprise.Size = new System.Drawing.Size(440, 222);
            this.dgvEntreprise.TabIndex = 7;
            // 
            // IdEntre
            // 
            this.IdEntre.DataPropertyName = "IdEntre";
            this.IdEntre.HeaderText = "ID";
            this.IdEntre.Name = "IdEntre";
            // 
            // NomEntre
            // 
            this.NomEntre.DataPropertyName = "NomEntre";
            this.NomEntre.HeaderText = "Entreprise";
            this.NomEntre.Name = "NomEntre";
            this.NomEntre.Width = 300;
            // 
            // FrmGEntreprise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 554);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.metroLabel5);
            this.Controls.Add(this.metroCheckBox1);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.dgvEntreprise);
            this.Name = "FrmGEntreprise";
            this.Text = "Info Entreprise";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntreprise)).EndInit();
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
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroTextBox tbNom;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox tbId;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridView dgvEntreprise;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdEntre;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomEntre;
    }
}