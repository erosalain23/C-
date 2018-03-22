namespace ISET_2018_Decouverte
{
    partial class EcranSpirographe
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
            this.gbControle = new System.Windows.Forms.GroupBox();
            this.lblNbSommets = new System.Windows.Forms.Label();
            this.tbNbSommets = new System.Windows.Forms.TrackBar();
            this.tbDensite = new System.Windows.Forms.TrackBar();
            this.lblDensite = new System.Windows.Forms.Label();
            this.lblProfondeur = new System.Windows.Forms.Label();
            this.tbProfondeur = new System.Windows.Forms.TrackBar();
            this.btnGo = new System.Windows.Forms.Button();
            this.btnTrait = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.dlgCouleur = new System.Windows.Forms.ColorDialog();
            this.gbControle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).BeginInit();
            this.SuspendLayout();
            // 
            // gbControle
            // 
            this.gbControle.Controls.Add(this.btnFont);
            this.gbControle.Controls.Add(this.btnTrait);
            this.gbControle.Controls.Add(this.btnGo);
            this.gbControle.Controls.Add(this.tbProfondeur);
            this.gbControle.Controls.Add(this.lblProfondeur);
            this.gbControle.Controls.Add(this.tbDensite);
            this.gbControle.Controls.Add(this.lblDensite);
            this.gbControle.Controls.Add(this.tbNbSommets);
            this.gbControle.Controls.Add(this.lblNbSommets);
            this.gbControle.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbControle.Location = new System.Drawing.Point(0, 0);
            this.gbControle.Name = "gbControle";
            this.gbControle.Size = new System.Drawing.Size(400, 719);
            this.gbControle.TabIndex = 0;
            this.gbControle.TabStop = false;
            this.gbControle.Text = "Controle";
            // 
            // lblNbSommets
            // 
            this.lblNbSommets.AutoSize = true;
            this.lblNbSommets.Location = new System.Drawing.Point(12, 35);
            this.lblNbSommets.Name = "lblNbSommets";
            this.lblNbSommets.Size = new System.Drawing.Size(201, 20);
            this.lblNbSommets.TabIndex = 0;
            this.lblNbSommets.Text = "Nombre de sommets(3 à 8)";
            // 
            // tbNbSommets
            // 
            this.tbNbSommets.Location = new System.Drawing.Point(16, 70);
            this.tbNbSommets.Maximum = 8;
            this.tbNbSommets.Minimum = 3;
            this.tbNbSommets.Name = "tbNbSommets";
            this.tbNbSommets.Size = new System.Drawing.Size(314, 69);
            this.tbNbSommets.TabIndex = 1;
            this.tbNbSommets.Value = 5;
            // 
            // tbDensite
            // 
            this.tbDensite.Location = new System.Drawing.Point(16, 198);
            this.tbDensite.Maximum = 20;
            this.tbDensite.Minimum = 5;
            this.tbDensite.Name = "tbDensite";
            this.tbDensite.Size = new System.Drawing.Size(314, 69);
            this.tbDensite.TabIndex = 3;
            this.tbDensite.Value = 10;
            // 
            // lblDensite
            // 
            this.lblDensite.AutoSize = true;
            this.lblDensite.Location = new System.Drawing.Point(12, 163);
            this.lblDensite.Name = "lblDensite";
            this.lblDensite.Size = new System.Drawing.Size(194, 20);
            this.lblDensite.TabIndex = 2;
            this.lblDensite.Text = "Densité de dessin (5 à 20)";
            // 
            // lblProfondeur
            // 
            this.lblProfondeur.AutoSize = true;
            this.lblProfondeur.Location = new System.Drawing.Point(12, 276);
            this.lblProfondeur.Name = "lblProfondeur";
            this.lblProfondeur.Size = new System.Drawing.Size(223, 20);
            this.lblProfondeur.TabIndex = 2;
            this.lblProfondeur.Text = "Profondeur de dessin(20 à 80)";
            // 
            // tbProfondeur
            // 
            this.tbProfondeur.Location = new System.Drawing.Point(16, 311);
            this.tbProfondeur.Maximum = 80;
            this.tbProfondeur.Minimum = 20;
            this.tbProfondeur.Name = "tbProfondeur";
            this.tbProfondeur.Size = new System.Drawing.Size(314, 69);
            this.tbProfondeur.TabIndex = 3;
            this.tbProfondeur.TickFrequency = 5;
            this.tbProfondeur.Value = 40;
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(16, 399);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(314, 83);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnTrait
            // 
            this.btnTrait.Location = new System.Drawing.Point(16, 506);
            this.btnTrait.Name = "btnTrait";
            this.btnTrait.Size = new System.Drawing.Size(108, 47);
            this.btnTrait.TabIndex = 5;
            this.btnTrait.Text = "Trait";
            this.btnTrait.UseVisualStyleBackColor = true;
            this.btnTrait.Click += new System.EventHandler(this.btnTrait_Click);
            // 
            // btnFont
            // 
            this.btnFont.Location = new System.Drawing.Point(222, 506);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(108, 47);
            this.btnFont.TabIndex = 5;
            this.btnFont.Text = "Font";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // EcranSpirographe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 719);
            this.Controls.Add(this.gbControle);
            this.Name = "EcranSpirographe";
            this.Text = "FicSpirographe";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranSpirographe_Paint);
            this.gbControle.ResumeLayout(false);
            this.gbControle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbNbSommets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbDensite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbProfondeur)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbControle;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnTrait;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TrackBar tbProfondeur;
        private System.Windows.Forms.Label lblProfondeur;
        private System.Windows.Forms.TrackBar tbDensite;
        private System.Windows.Forms.Label lblDensite;
        private System.Windows.Forms.TrackBar tbNbSommets;
        private System.Windows.Forms.Label lblNbSommets;
        private System.Windows.Forms.ColorDialog dlgCouleur;
    }
}