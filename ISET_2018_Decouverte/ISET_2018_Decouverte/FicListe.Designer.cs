namespace ISET_2018_Decouverte
{
    partial class EcranList
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
            this.lblFichier = new System.Windows.Forms.Label();
            this.lbPresonnes = new System.Windows.Forms.ListBox();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEnregistre = new System.Windows.Forms.Button();
            this.btnSuprimer = new System.Windows.Forms.Button();
            this.gbDetail = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.lblNom = new System.Windows.Forms.Label();
            this.cbQualite = new System.Windows.Forms.ComboBox();
            this.dlgOuvrir = new System.Windows.Forms.OpenFileDialog();
            this.dlgEnregistre = new System.Windows.Forms.SaveFileDialog();
            this.gbDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFichier
            // 
            this.lblFichier.AutoSize = true;
            this.lblFichier.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFichier.Location = new System.Drawing.Point(46, 25);
            this.lblFichier.Name = "lblFichier";
            this.lblFichier.Size = new System.Drawing.Size(175, 32);
            this.lblFichier.TabIndex = 0;
            this.lblFichier.Text = "Nom de fichier";
            // 
            // lbPresonnes
            // 
            this.lbPresonnes.FormattingEnabled = true;
            this.lbPresonnes.ItemHeight = 20;
            this.lbPresonnes.Location = new System.Drawing.Point(52, 75);
            this.lbPresonnes.Name = "lbPresonnes";
            this.lbPresonnes.Size = new System.Drawing.Size(789, 324);
            this.lbPresonnes.Sorted = true;
            this.lbPresonnes.TabIndex = 0;
            this.lbPresonnes.DoubleClick += new System.EventHandler(this.lbPresonnes_DoubleClick);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.Location = new System.Drawing.Point(52, 434);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(197, 54);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.Text = "Ouvrir";
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(52, 586);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(197, 54);
            this.btnAjouter.TabIndex = 3;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEnregistre
            // 
            this.btnEnregistre.Location = new System.Drawing.Point(52, 505);
            this.btnEnregistre.Name = "btnEnregistre";
            this.btnEnregistre.Size = new System.Drawing.Size(197, 54);
            this.btnEnregistre.TabIndex = 2;
            this.btnEnregistre.Text = "Enregistre";
            this.btnEnregistre.UseVisualStyleBackColor = true;
            this.btnEnregistre.Click += new System.EventHandler(this.btnEnregistre_Click);
            // 
            // btnSuprimer
            // 
            this.btnSuprimer.Location = new System.Drawing.Point(52, 669);
            this.btnSuprimer.Name = "btnSuprimer";
            this.btnSuprimer.Size = new System.Drawing.Size(197, 54);
            this.btnSuprimer.TabIndex = 4;
            this.btnSuprimer.Text = "Supprimer";
            this.btnSuprimer.UseVisualStyleBackColor = true;
            this.btnSuprimer.Click += new System.EventHandler(this.btnSuprimer_Click);
            // 
            // gbDetail
            // 
            this.gbDetail.Controls.Add(this.btnAnnuler);
            this.gbDetail.Controls.Add(this.btnConfirmer);
            this.gbDetail.Controls.Add(this.tbNom);
            this.gbDetail.Controls.Add(this.lblNom);
            this.gbDetail.Controls.Add(this.cbQualite);
            this.gbDetail.Location = new System.Drawing.Point(301, 434);
            this.gbDetail.Name = "gbDetail";
            this.gbDetail.Size = new System.Drawing.Size(540, 289);
            this.gbDetail.TabIndex = 5;
            this.gbDetail.TabStop = false;
            this.gbDetail.Text = "Détail Personne";
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(335, 235);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(181, 47);
            this.btnAnnuler.TabIndex = 4;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(26, 235);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(181, 47);
            this.btnConfirmer.TabIndex = 3;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // tbNom
            // 
            this.tbNom.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNom.Location = new System.Drawing.Point(30, 111);
            this.tbNom.Multiline = true;
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(486, 43);
            this.tbNom.TabIndex = 2;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(26, 88);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(42, 20);
            this.lblNom.TabIndex = 1;
            this.lblNom.Text = "Nom";
            // 
            // cbQualite
            // 
            this.cbQualite.FormattingEnabled = true;
            this.cbQualite.Items.AddRange(new object[] {
            "Madame",
            "Mademoiselle",
            "Monsieur",
            "MonDamoiseau",
            "Indefini"});
            this.cbQualite.Location = new System.Drawing.Point(26, 39);
            this.cbQualite.Name = "cbQualite";
            this.cbQualite.Size = new System.Drawing.Size(490, 28);
            this.cbQualite.TabIndex = 0;
            // 
            // dlgOuvrir
            // 
            this.dlgOuvrir.FileName = "openFileDialog1";
            // 
            // EcranList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 751);
            this.Controls.Add(this.gbDetail);
            this.Controls.Add(this.btnSuprimer);
            this.Controls.Add(this.btnEnregistre);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnOuvrir);
            this.Controls.Add(this.lbPresonnes);
            this.Controls.Add(this.lblFichier);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranList";
            this.Text = "3";
            this.gbDetail.ResumeLayout(false);
            this.gbDetail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFichier;
        private System.Windows.Forms.ListBox lbPresonnes;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEnregistre;
        private System.Windows.Forms.Button btnSuprimer;
        private System.Windows.Forms.GroupBox gbDetail;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.ComboBox cbQualite;
        private System.Windows.Forms.OpenFileDialog dlgOuvrir;
        private System.Windows.Forms.SaveFileDialog dlgEnregistre;
    }
}