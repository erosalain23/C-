namespace ISET_2018_Decouverte
{
    partial class EcranEditeur
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
            this.mEditeur = new System.Windows.Forms.MenuStrip();
            this.meFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefNouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.mefOuvrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mefSauver = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mefQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.meEditer = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCouper = new System.Windows.Forms.ToolStripMenuItem();
            this.meeCopier = new System.Windows.Forms.ToolStripMenuItem();
            this.meeColler = new System.Windows.Forms.ToolStripMenuItem();
            this.meFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.mefJustifier = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjGauche = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjDroite = new System.Windows.Forms.ToolStripMenuItem();
            this.mefjCentre = new System.Windows.Forms.ToolStripMenuItem();
            this.mefPolice = new System.Windows.Forms.ToolStripMenuItem();
            this.mefCaractere = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcGras = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcItalique = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcSouligne = new System.Windows.Forms.ToolStripMenuItem();
            this.mefcBarre = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgOuvrirFichier = new System.Windows.Forms.OpenFileDialog();
            this.dlgSauverFichier = new System.Windows.Forms.SaveFileDialog();
            this.dlgPolice = new System.Windows.Forms.FontDialog();
            this.pBarreBouton = new System.Windows.Forms.Panel();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnEnregitsrer = new System.Windows.Forms.Button();
            this.btnOuvrir = new System.Windows.Forms.Button();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.rtbTexte = new System.Windows.Forms.RichTextBox();
            this.mEditeur.SuspendLayout();
            this.pBarreBouton.SuspendLayout();
            this.SuspendLayout();
            // 
            // mEditeur
            // 
            this.mEditeur.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mEditeur.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meFichier,
            this.meEditer,
            this.meFormat});
            this.mEditeur.Location = new System.Drawing.Point(0, 0);
            this.mEditeur.Name = "mEditeur";
            this.mEditeur.Size = new System.Drawing.Size(999, 33);
            this.mEditeur.TabIndex = 0;
            this.mEditeur.Text = "menuStrip1";
            // 
            // meFichier
            // 
            this.meFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefNouveau,
            this.mefOuvrir,
            this.mefSauver,
            this.toolStripMenuItem1,
            this.mefQuitter});
            this.meFichier.Name = "meFichier";
            this.meFichier.Size = new System.Drawing.Size(78, 29);
            this.meFichier.Text = "Filchier";
            // 
            // mefNouveau
            // 
            this.mefNouveau.Name = "mefNouveau";
            this.mefNouveau.Size = new System.Drawing.Size(210, 30);
            this.mefNouveau.Text = "Nouveau";
            this.mefNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // mefOuvrir
            // 
            this.mefOuvrir.Name = "mefOuvrir";
            this.mefOuvrir.Size = new System.Drawing.Size(210, 30);
            this.mefOuvrir.Text = "Ouvrir";
            this.mefOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // mefSauver
            // 
            this.mefSauver.Name = "mefSauver";
            this.mefSauver.Size = new System.Drawing.Size(210, 30);
            this.mefSauver.Text = "Sauver";
            this.mefSauver.Click += new System.EventHandler(this.mefSauver_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(207, 6);
            // 
            // mefQuitter
            // 
            this.mefQuitter.Name = "mefQuitter";
            this.mefQuitter.Size = new System.Drawing.Size(210, 30);
            this.mefQuitter.Text = "Quitter";
            this.mefQuitter.Click += new System.EventHandler(this.mefQuitter_Click);
            // 
            // meEditer
            // 
            this.meEditer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.meeCouper,
            this.meeCopier,
            this.meeColler});
            this.meEditer.Name = "meEditer";
            this.meEditer.Size = new System.Drawing.Size(69, 29);
            this.meEditer.Text = "Editer";
            // 
            // meeCouper
            // 
            this.meeCouper.Name = "meeCouper";
            this.meeCouper.Size = new System.Drawing.Size(210, 30);
            this.meeCouper.Text = "Couper";
            this.meeCouper.Click += new System.EventHandler(this.meeCouper_Click);
            // 
            // meeCopier
            // 
            this.meeCopier.Name = "meeCopier";
            this.meeCopier.Size = new System.Drawing.Size(210, 30);
            this.meeCopier.Text = "Copier";
            this.meeCopier.Click += new System.EventHandler(this.meeCopier_Click);
            // 
            // meeColler
            // 
            this.meeColler.Name = "meeColler";
            this.meeColler.Size = new System.Drawing.Size(210, 30);
            this.meeColler.Text = "Coller";
            this.meeColler.Click += new System.EventHandler(this.meeColler_Click);
            // 
            // meFormat
            // 
            this.meFormat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefJustifier,
            this.mefPolice,
            this.mefCaractere});
            this.meFormat.Name = "meFormat";
            this.meFormat.Size = new System.Drawing.Size(81, 29);
            this.meFormat.Text = "Format";
            // 
            // mefJustifier
            // 
            this.mefJustifier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefjGauche,
            this.mefjDroite,
            this.mefjCentre});
            this.mefJustifier.Name = "mefJustifier";
            this.mefJustifier.Size = new System.Drawing.Size(210, 30);
            this.mefJustifier.Text = "Justifier";
            // 
            // mefjGauche
            // 
            this.mefjGauche.Name = "mefjGauche";
            this.mefjGauche.Size = new System.Drawing.Size(210, 30);
            this.mefjGauche.Text = "Gauche";
            this.mefjGauche.Click += new System.EventHandler(this.mefjGauche_Click);
            // 
            // mefjDroite
            // 
            this.mefjDroite.Name = "mefjDroite";
            this.mefjDroite.Size = new System.Drawing.Size(210, 30);
            this.mefjDroite.Text = "Droite";
            this.mefjDroite.Click += new System.EventHandler(this.mefjDroite_Click);
            // 
            // mefjCentre
            // 
            this.mefjCentre.Name = "mefjCentre";
            this.mefjCentre.Size = new System.Drawing.Size(210, 30);
            this.mefjCentre.Text = "Centré";
            this.mefjCentre.Click += new System.EventHandler(this.mefjCentre_Click);
            // 
            // mefPolice
            // 
            this.mefPolice.Name = "mefPolice";
            this.mefPolice.Size = new System.Drawing.Size(210, 30);
            this.mefPolice.Text = "Police";
            this.mefPolice.Click += new System.EventHandler(this.mefPolice_Click);
            // 
            // mefCaractere
            // 
            this.mefCaractere.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mefcGras,
            this.mefcItalique,
            this.mefcSouligne,
            this.mefcBarre});
            this.mefCaractere.Name = "mefCaractere";
            this.mefCaractere.Size = new System.Drawing.Size(210, 30);
            this.mefCaractere.Text = "Caractère";
            // 
            // mefcGras
            // 
            this.mefcGras.Name = "mefcGras";
            this.mefcGras.Size = new System.Drawing.Size(210, 30);
            this.mefcGras.Text = "Gras";
            this.mefcGras.Click += new System.EventHandler(this.mefcGras_Click);
            // 
            // mefcItalique
            // 
            this.mefcItalique.Name = "mefcItalique";
            this.mefcItalique.Size = new System.Drawing.Size(210, 30);
            this.mefcItalique.Text = "Italique";
            this.mefcItalique.Click += new System.EventHandler(this.mefcItalique_Click);
            // 
            // mefcSouligne
            // 
            this.mefcSouligne.Name = "mefcSouligne";
            this.mefcSouligne.Size = new System.Drawing.Size(210, 30);
            this.mefcSouligne.Text = "Souligné";
            this.mefcSouligne.Click += new System.EventHandler(this.mefcSouligne_Click);
            // 
            // mefcBarre
            // 
            this.mefcBarre.Name = "mefcBarre";
            this.mefcBarre.Size = new System.Drawing.Size(210, 30);
            this.mefcBarre.Text = "Barré";
            this.mefcBarre.Click += new System.EventHandler(this.mefcBarre_Click);
            // 
            // dlgOuvrirFichier
            // 
            this.dlgOuvrirFichier.FileName = "openFileDialog1";
            this.dlgOuvrirFichier.Filter = " Nos fichiers(*.mesdocs)|*.mesdocs|Tous fichiers(*.*)|*.* ";
            // 
            // dlgSauverFichier
            // 
            this.dlgSauverFichier.Filter = " Nos fichiers(*.mesdocs)|*.mesdocs|Tous fichiers(*.*)|*.* ";
            // 
            // pBarreBouton
            // 
            this.pBarreBouton.Controls.Add(this.btnQuitter);
            this.pBarreBouton.Controls.Add(this.btnEnregitsrer);
            this.pBarreBouton.Controls.Add(this.btnOuvrir);
            this.pBarreBouton.Controls.Add(this.btnNouveau);
            this.pBarreBouton.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBarreBouton.Location = new System.Drawing.Point(0, 33);
            this.pBarreBouton.Name = "pBarreBouton";
            this.pBarreBouton.Size = new System.Drawing.Size(999, 67);
            this.pBarreBouton.TabIndex = 1;
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.close_2;
            this.btnQuitter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnQuitter.Location = new System.Drawing.Point(295, 3);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(60, 60);
            this.btnQuitter.TabIndex = 3;
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.mefQuitter_Click);
            // 
            // btnEnregitsrer
            // 
            this.btnEnregitsrer.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.save;
            this.btnEnregitsrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEnregitsrer.Location = new System.Drawing.Point(193, 3);
            this.btnEnregitsrer.Name = "btnEnregitsrer";
            this.btnEnregitsrer.Size = new System.Drawing.Size(60, 60);
            this.btnEnregitsrer.TabIndex = 2;
            this.btnEnregitsrer.UseVisualStyleBackColor = true;
            this.btnEnregitsrer.Click += new System.EventHandler(this.mefSauver_Click);
            // 
            // btnOuvrir
            // 
            this.btnOuvrir.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.open;
            this.btnOuvrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOuvrir.Location = new System.Drawing.Point(109, 3);
            this.btnOuvrir.Name = "btnOuvrir";
            this.btnOuvrir.Size = new System.Drawing.Size(60, 60);
            this.btnOuvrir.TabIndex = 1;
            this.btnOuvrir.UseVisualStyleBackColor = true;
            this.btnOuvrir.Click += new System.EventHandler(this.btnOuvrir_Click);
            // 
            // btnNouveau
            // 
            this.btnNouveau.BackgroundImage = global::ISET_2018_Decouverte.Properties.Resources.new2;
            this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNouveau.Location = new System.Drawing.Point(12, 3);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(60, 60);
            this.btnNouveau.TabIndex = 0;
            this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // rtbTexte
            // 
            this.rtbTexte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbTexte.Location = new System.Drawing.Point(0, 100);
            this.rtbTexte.Name = "rtbTexte";
            this.rtbTexte.Size = new System.Drawing.Size(999, 620);
            this.rtbTexte.TabIndex = 2;
            this.rtbTexte.Text = "";
            this.rtbTexte.TextChanged += new System.EventHandler(this.rtbTexte_TextChanged);
            // 
            // EcranEditeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 720);
            this.Controls.Add(this.rtbTexte);
            this.Controls.Add(this.pBarreBouton);
            this.Controls.Add(this.mEditeur);
            this.MainMenuStrip = this.mEditeur;
            this.Name = "EcranEditeur";
            this.Text = "Traitement de text en toute modestie";
            this.mEditeur.ResumeLayout(false);
            this.mEditeur.PerformLayout();
            this.pBarreBouton.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mEditeur;
        private System.Windows.Forms.OpenFileDialog dlgOuvrirFichier;
        private System.Windows.Forms.SaveFileDialog dlgSauverFichier;
        private System.Windows.Forms.FontDialog dlgPolice;
        private System.Windows.Forms.Panel pBarreBouton;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnEnregitsrer;
        private System.Windows.Forms.Button btnOuvrir;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.RichTextBox rtbTexte;
        private System.Windows.Forms.ToolStripMenuItem meFichier;
        private System.Windows.Forms.ToolStripMenuItem mefNouveau;
        private System.Windows.Forms.ToolStripMenuItem mefOuvrir;
        private System.Windows.Forms.ToolStripMenuItem mefSauver;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mefQuitter;
        private System.Windows.Forms.ToolStripMenuItem meEditer;
        private System.Windows.Forms.ToolStripMenuItem meeCouper;
        private System.Windows.Forms.ToolStripMenuItem meeCopier;
        private System.Windows.Forms.ToolStripMenuItem meeColler;
        private System.Windows.Forms.ToolStripMenuItem meFormat;
        private System.Windows.Forms.ToolStripMenuItem mefJustifier;
        private System.Windows.Forms.ToolStripMenuItem mefjGauche;
        private System.Windows.Forms.ToolStripMenuItem mefjDroite;
        private System.Windows.Forms.ToolStripMenuItem mefjCentre;
        private System.Windows.Forms.ToolStripMenuItem mefPolice;
        private System.Windows.Forms.ToolStripMenuItem mefCaractere;
        private System.Windows.Forms.ToolStripMenuItem mefcGras;
        private System.Windows.Forms.ToolStripMenuItem mefcItalique;
        private System.Windows.Forms.ToolStripMenuItem mefcSouligne;
        private System.Windows.Forms.ToolStripMenuItem mefcBarre;
    }
}