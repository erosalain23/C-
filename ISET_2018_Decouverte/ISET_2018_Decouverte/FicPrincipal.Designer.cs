namespace ISET_2018_Decouverte
{
    partial class EcranPrincipal
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
            this.mMenu = new System.Windows.Forms.MenuStrip();
            this.mFenetres = new System.Windows.Forms.ToolStripMenuItem();
            this.mfProgression = new System.Windows.Forms.ToolStripMenuItem();
            this.mfListe = new System.Windows.Forms.ToolStripMenuItem();
            this.mfEditeur = new System.Windows.Forms.ToolStripMenuItem();
            this.horlogeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spirographeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dessinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mfCarnaval = new System.Windows.Forms.ToolStripMenuItem();
            this.mfClavierSouris = new System.Windows.Forms.ToolStripMenuItem();
            this.mfExplorateur = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mfBD3 = new System.Windows.Forms.ToolStripMenuItem();
            this.mAide = new System.Windows.Forms.ToolStripMenuItem();
            this.mQuitter = new System.Windows.Forms.ToolStripMenuItem();
            this.mMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mMenu
            // 
            this.mMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFenetres,
            this.mAide,
            this.mQuitter});
            this.mMenu.Location = new System.Drawing.Point(0, 0);
            this.mMenu.Name = "mMenu";
            this.mMenu.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.mMenu.Size = new System.Drawing.Size(719, 24);
            this.mMenu.TabIndex = 0;
            this.mMenu.Text = "menuStrip1";
            // 
            // mFenetres
            // 
            this.mFenetres.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mfProgression,
            this.mfListe,
            this.mfEditeur,
            this.horlogeToolStripMenuItem,
            this.spirographeToolStripMenuItem,
            this.dessinToolStripMenuItem,
            this.mfCarnaval,
            this.mfClavierSouris,
            this.mfExplorateur,
            this.mfBD1,
            this.mfBD2,
            this.mfBD3});
            this.mFenetres.Name = "mFenetres";
            this.mFenetres.Size = new System.Drawing.Size(63, 22);
            this.mFenetres.Text = "Fenetres";
            // 
            // mfProgression
            // 
            this.mfProgression.Name = "mfProgression";
            this.mfProgression.Size = new System.Drawing.Size(187, 22);
            this.mfProgression.Text = "Barres de Progression";
            this.mfProgression.Click += new System.EventHandler(this.mfProgression_Click);
            // 
            // mfListe
            // 
            this.mfListe.Name = "mfListe";
            this.mfListe.Size = new System.Drawing.Size(187, 22);
            this.mfListe.Text = "Liste";
            this.mfListe.Click += new System.EventHandler(this.mfListe_Click);
            // 
            // mfEditeur
            // 
            this.mfEditeur.Name = "mfEditeur";
            this.mfEditeur.Size = new System.Drawing.Size(187, 22);
            this.mfEditeur.Text = "Editeur";
            this.mfEditeur.Click += new System.EventHandler(this.mfEditeur_Click);
            // 
            // horlogeToolStripMenuItem
            // 
            this.horlogeToolStripMenuItem.Name = "horlogeToolStripMenuItem";
            this.horlogeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.horlogeToolStripMenuItem.Text = "Horloge";
            this.horlogeToolStripMenuItem.Click += new System.EventHandler(this.horlogeToolStripMenuItem_Click);
            // 
            // spirographeToolStripMenuItem
            // 
            this.spirographeToolStripMenuItem.Name = "spirographeToolStripMenuItem";
            this.spirographeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.spirographeToolStripMenuItem.Text = "Spirographe";
            this.spirographeToolStripMenuItem.Click += new System.EventHandler(this.spirographeToolStripMenuItem_Click);
            // 
            // dessinToolStripMenuItem
            // 
            this.dessinToolStripMenuItem.Name = "dessinToolStripMenuItem";
            this.dessinToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.dessinToolStripMenuItem.Text = "Dessin";
            this.dessinToolStripMenuItem.Click += new System.EventHandler(this.dessinToolStripMenuItem_Click);
            // 
            // mfCarnaval
            // 
            this.mfCarnaval.Name = "mfCarnaval";
            this.mfCarnaval.Size = new System.Drawing.Size(187, 22);
            this.mfCarnaval.Text = "Carnaval";
            this.mfCarnaval.Click += new System.EventHandler(this.mfCarnaval_Click);
            // 
            // mfClavierSouris
            // 
            this.mfClavierSouris.Name = "mfClavierSouris";
            this.mfClavierSouris.Size = new System.Drawing.Size(187, 22);
            this.mfClavierSouris.Text = "Clavier-Souris";
            this.mfClavierSouris.Click += new System.EventHandler(this.mfClavierSouris_Click);
            // 
            // mfExplorateur
            // 
            this.mfExplorateur.Name = "mfExplorateur";
            this.mfExplorateur.Size = new System.Drawing.Size(187, 22);
            this.mfExplorateur.Text = "Explorateur";
            this.mfExplorateur.Click += new System.EventHandler(this.mfExplorateur_Click);
            // 
            // mfBD1
            // 
            this.mfBD1.Name = "mfBD1";
            this.mfBD1.Size = new System.Drawing.Size(187, 22);
            this.mfBD1.Text = "Base de donnees1";
            this.mfBD1.Click += new System.EventHandler(this.mfBD1_Click);
            // 
            // mfBD2
            // 
            this.mfBD2.Name = "mfBD2";
            this.mfBD2.Size = new System.Drawing.Size(187, 22);
            this.mfBD2.Text = "Base de donnees2";
            this.mfBD2.Click += new System.EventHandler(this.mfBD2_Click);
            // 
            // mfBD3
            // 
            this.mfBD3.Name = "mfBD3";
            this.mfBD3.Size = new System.Drawing.Size(187, 22);
            this.mfBD3.Text = "Base de donnees3";
            this.mfBD3.Click += new System.EventHandler(this.mfBD3_Click);
            // 
            // mAide
            // 
            this.mAide.Name = "mAide";
            this.mAide.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAide.Size = new System.Drawing.Size(43, 22);
            this.mAide.Text = "Aide";
            this.mAide.Click += new System.EventHandler(this.mAide_Click);
            // 
            // mQuitter
            // 
            this.mQuitter.Name = "mQuitter";
            this.mQuitter.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mQuitter.Size = new System.Drawing.Size(56, 22);
            this.mQuitter.Text = "Quitter";
            this.mQuitter.Click += new System.EventHandler(this.mQuitter_Click);
            // 
            // EcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 411);
            this.Controls.Add(this.mMenu);
            this.MainMenuStrip = this.mMenu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EcranPrincipal";
            this.Text = "Ecran Principal";
            this.mMenu.ResumeLayout(false);
            this.mMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mMenu;
        private System.Windows.Forms.ToolStripMenuItem mFenetres;
        private System.Windows.Forms.ToolStripMenuItem mAide;
        private System.Windows.Forms.ToolStripMenuItem mQuitter;
        private System.Windows.Forms.ToolStripMenuItem mfProgression;
        private System.Windows.Forms.ToolStripMenuItem mfListe;
        private System.Windows.Forms.ToolStripMenuItem mfEditeur;
        private System.Windows.Forms.ToolStripMenuItem horlogeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem spirographeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dessinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mfCarnaval;
        private System.Windows.Forms.ToolStripMenuItem mfClavierSouris;
        private System.Windows.Forms.ToolStripMenuItem mfExplorateur;
        private System.Windows.Forms.ToolStripMenuItem mfBD1;
        private System.Windows.Forms.ToolStripMenuItem mfBD2;
        private System.Windows.Forms.ToolStripMenuItem mfBD3;
    }
}