namespace ISET_2018_Decouverte
{
    partial class EcranExplorateur
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExplorateur));
            this.tsCommande = new System.Windows.Forms.ToolStrip();
            this.tsQuitter = new System.Windows.Forms.ToolStripButton();
            this.tsSeparateur = new System.Windows.Forms.ToolStripSeparator();
            this.tsApparence = new System.Windows.Forms.ToolStripSplitButton();
            this.tsPetitesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsGrandesIcones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsListe = new System.Windows.Forms.ToolStripMenuItem();
            this.tsDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.ssMessage = new System.Windows.Forms.StatusStrip();
            this.slMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.tvRepertoire = new System.Windows.Forms.TreeView();
            this.ilVueArbre = new System.Windows.Forms.ImageList(this.components);
            this.sSeparateur = new System.Windows.Forms.Splitter();
            this.lvFichier = new System.Windows.Forms.ListView();
            this.NOM = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TAI = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CRE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MOD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ilVueGrand = new System.Windows.Forms.ImageList(this.components);
            this.ilVuePetit = new System.Windows.Forms.ImageList(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tsCommande.SuspendLayout();
            this.ssMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tsCommande
            // 
            this.tsCommande.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsQuitter,
            this.tsSeparateur,
            this.tsApparence});
            this.tsCommande.Location = new System.Drawing.Point(0, 0);
            this.tsCommande.Name = "tsCommande";
            this.tsCommande.Size = new System.Drawing.Size(584, 25);
            this.tsCommande.TabIndex = 0;
            this.tsCommande.Text = "toolStrip1";
            // 
            // tsQuitter
            // 
            this.tsQuitter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsQuitter.Image = ((System.Drawing.Image)(resources.GetObject("tsQuitter.Image")));
            this.tsQuitter.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsQuitter.Name = "tsQuitter";
            this.tsQuitter.Size = new System.Drawing.Size(23, 22);
            this.tsQuitter.Text = "toolStripButton1";
            this.tsQuitter.Click += new System.EventHandler(this.tsQuitter_Click);
            // 
            // tsSeparateur
            // 
            this.tsSeparateur.Name = "tsSeparateur";
            this.tsSeparateur.Size = new System.Drawing.Size(6, 25);
            // 
            // tsApparence
            // 
            this.tsApparence.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsApparence.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsPetitesIcones,
            this.tsGrandesIcones,
            this.tsListe,
            this.tsDetail});
            this.tsApparence.Image = ((System.Drawing.Image)(resources.GetObject("tsApparence.Image")));
            this.tsApparence.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsApparence.Name = "tsApparence";
            this.tsApparence.Size = new System.Drawing.Size(32, 22);
            this.tsApparence.Text = "toolStripSplitButton1";
            // 
            // tsPetitesIcones
            // 
            this.tsPetitesIcones.Name = "tsPetitesIcones";
            this.tsPetitesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsPetitesIcones.Text = "Petites icones";
            this.tsPetitesIcones.Click += new System.EventHandler(this.tsPetitesIcones_Click);
            // 
            // tsGrandesIcones
            // 
            this.tsGrandesIcones.Name = "tsGrandesIcones";
            this.tsGrandesIcones.Size = new System.Drawing.Size(154, 22);
            this.tsGrandesIcones.Text = "Grandes icones";
            this.tsGrandesIcones.Click += new System.EventHandler(this.tsGrandesIcones_Click);
            // 
            // tsListe
            // 
            this.tsListe.Name = "tsListe";
            this.tsListe.Size = new System.Drawing.Size(154, 22);
            this.tsListe.Text = "Liste";
            this.tsListe.Click += new System.EventHandler(this.tsListe_Click);
            // 
            // tsDetail
            // 
            this.tsDetail.Name = "tsDetail";
            this.tsDetail.Size = new System.Drawing.Size(154, 22);
            this.tsDetail.Text = "Detail";
            this.tsDetail.Click += new System.EventHandler(this.tsDetail_Click);
            // 
            // ssMessage
            // 
            this.ssMessage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slMessage});
            this.ssMessage.Location = new System.Drawing.Point(0, 339);
            this.ssMessage.Name = "ssMessage";
            this.ssMessage.Size = new System.Drawing.Size(584, 22);
            this.ssMessage.TabIndex = 1;
            this.ssMessage.Text = "statusStrip1";
            // 
            // slMessage
            // 
            this.slMessage.Name = "slMessage";
            this.slMessage.Size = new System.Drawing.Size(28, 17);
            this.slMessage.Text = "###";
            // 
            // tvRepertoire
            // 
            this.tvRepertoire.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvRepertoire.ImageIndex = 0;
            this.tvRepertoire.ImageList = this.ilVueArbre;
            this.tvRepertoire.Location = new System.Drawing.Point(0, 25);
            this.tvRepertoire.Name = "tvRepertoire";
            this.tvRepertoire.SelectedImageIndex = 0;
            this.tvRepertoire.Size = new System.Drawing.Size(200, 314);
            this.tvRepertoire.TabIndex = 2;
            this.tvRepertoire.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvRepertoire_AfterSelect);
            // 
            // ilVueArbre
            // 
            this.ilVueArbre.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVueArbre.ImageStream")));
            this.ilVueArbre.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVueArbre.Images.SetKeyName(0, "WEOrdi.bmp");
            this.ilVueArbre.Images.SetKeyName(1, "WEFloppy.bmp");
            this.ilVueArbre.Images.SetKeyName(2, "WERepertoire.bmp");
            this.ilVueArbre.Images.SetKeyName(3, "WERepertoireActif.bmp");
            this.ilVueArbre.Images.SetKeyName(4, "WEPoubelle.bmp");
            // 
            // sSeparateur
            // 
            this.sSeparateur.Location = new System.Drawing.Point(200, 25);
            this.sSeparateur.Name = "sSeparateur";
            this.sSeparateur.Size = new System.Drawing.Size(3, 314);
            this.sSeparateur.TabIndex = 3;
            this.sSeparateur.TabStop = false;
            // 
            // lvFichier
            // 
            this.lvFichier.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NOM,
            this.TAI,
            this.CRE,
            this.MOD});
            this.lvFichier.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvFichier.FullRowSelect = true;
            this.lvFichier.LargeImageList = this.ilVueGrand;
            this.lvFichier.Location = new System.Drawing.Point(203, 25);
            this.lvFichier.Name = "lvFichier";
            this.lvFichier.Size = new System.Drawing.Size(381, 314);
            this.lvFichier.SmallImageList = this.ilVuePetit;
            this.lvFichier.TabIndex = 4;
            this.lvFichier.UseCompatibleStateImageBehavior = false;
            this.lvFichier.View = System.Windows.Forms.View.Details;
            // 
            // NOM
            // 
            this.NOM.Text = "Nom";
            this.NOM.Width = 120;
            // 
            // TAI
            // 
            this.TAI.Text = "Taille";
            // 
            // CRE
            // 
            this.CRE.Text = "Creation";
            // 
            // MOD
            // 
            this.MOD.Text = "Modification";
            // 
            // ilVueGrand
            // 
            this.ilVueGrand.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVueGrand.ImageStream")));
            this.ilVueGrand.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVueGrand.Images.SetKeyName(0, "WELVGrandeIcone.bmp");
            // 
            // ilVuePetit
            // 
            this.ilVuePetit.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilVuePetit.ImageStream")));
            this.ilVuePetit.TransparentColor = System.Drawing.Color.Transparent;
            this.ilVuePetit.Images.SetKeyName(0, "WELVPetiteIcone.bmp");
            // 
            // EcranExplorateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.lvFichier);
            this.Controls.Add(this.sSeparateur);
            this.Controls.Add(this.tvRepertoire);
            this.Controls.Add(this.ssMessage);
            this.Controls.Add(this.tsCommande);
            this.Name = "EcranExplorateur";
            this.Text = "Explorateur de fichiers";
            this.tsCommande.ResumeLayout(false);
            this.tsCommande.PerformLayout();
            this.ssMessage.ResumeLayout(false);
            this.ssMessage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsCommande;
        private System.Windows.Forms.StatusStrip ssMessage;
        private System.Windows.Forms.TreeView tvRepertoire;
        private System.Windows.Forms.Splitter sSeparateur;
        private System.Windows.Forms.ListView lvFichier;
        private System.Windows.Forms.ToolStripButton tsQuitter;
        private System.Windows.Forms.ToolStripSeparator tsSeparateur;
        private System.Windows.Forms.ToolStripSplitButton tsApparence;
        private System.Windows.Forms.ToolStripMenuItem tsPetitesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsGrandesIcones;
        private System.Windows.Forms.ToolStripMenuItem tsListe;
        private System.Windows.Forms.ToolStripMenuItem tsDetail;
        private System.Windows.Forms.ToolStripStatusLabel slMessage;
        private System.Windows.Forms.ImageList ilVueArbre;
        private System.Windows.Forms.ColumnHeader NOM;
        private System.Windows.Forms.ColumnHeader TAI;
        private System.Windows.Forms.ColumnHeader CRE;
        private System.Windows.Forms.ColumnHeader MOD;
        private System.Windows.Forms.ImageList ilVueGrand;
        private System.Windows.Forms.ImageList ilVuePetit;
        private System.Windows.Forms.BindingSource bindingSource1;
    }
}