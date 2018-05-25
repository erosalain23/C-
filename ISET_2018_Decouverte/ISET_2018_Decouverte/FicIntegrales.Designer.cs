namespace ISET_2018_Decouverte
{
    partial class EcranIntegrales
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
            this.lbResultats = new System.Windows.Forms.ListBox();
            this.btnPolynome = new System.Windows.Forms.Button();
            this.btnCosinus = new System.Windows.Forms.Button();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.lblDroite = new System.Windows.Forms.Label();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblIntervalle = new System.Windows.Forms.Label();
            this.tbIntervalle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbResultats
            // 
            this.lbResultats.FormattingEnabled = true;
            this.lbResultats.Location = new System.Drawing.Point(12, 77);
            this.lbResultats.Name = "lbResultats";
            this.lbResultats.Size = new System.Drawing.Size(337, 147);
            this.lbResultats.TabIndex = 0;
            // 
            // btnPolynome
            // 
            this.btnPolynome.Location = new System.Drawing.Point(12, 233);
            this.btnPolynome.Name = "btnPolynome";
            this.btnPolynome.Size = new System.Drawing.Size(337, 23);
            this.btnPolynome.TabIndex = 1;
            this.btnPolynome.Text = "Polynome";
            this.btnPolynome.UseVisualStyleBackColor = true;
            this.btnPolynome.Click += new System.EventHandler(this.btnPolynome_Click);
            // 
            // btnCosinus
            // 
            this.btnCosinus.Location = new System.Drawing.Point(12, 262);
            this.btnCosinus.Name = "btnCosinus";
            this.btnCosinus.Size = new System.Drawing.Size(337, 23);
            this.btnCosinus.TabIndex = 2;
            this.btnCosinus.Text = "Cosinus";
            this.btnCosinus.UseVisualStyleBackColor = true;
            this.btnCosinus.Click += new System.EventHandler(this.btnCosinus_Click);
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(12, 9);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(45, 13);
            this.lblGauche.TabIndex = 3;
            this.lblGauche.Text = "Gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(15, 26);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.Size = new System.Drawing.Size(61, 20);
            this.tbGauche.TabIndex = 4;
            this.tbGauche.Text = "0";
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Location = new System.Drawing.Point(148, 9);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(35, 13);
            this.lblDroite.TabIndex = 3;
            this.lblDroite.Text = "Droite";
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(151, 26);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.Size = new System.Drawing.Size(61, 20);
            this.tbDroite.TabIndex = 4;
            this.tbDroite.Text = "2";
            // 
            // lblIntervalle
            // 
            this.lblIntervalle.AutoSize = true;
            this.lblIntervalle.Location = new System.Drawing.Point(249, 9);
            this.lblIntervalle.Name = "lblIntervalle";
            this.lblIntervalle.Size = new System.Drawing.Size(50, 13);
            this.lblIntervalle.TabIndex = 3;
            this.lblIntervalle.Text = "Intervalle";
            // 
            // tbIntervalle
            // 
            this.tbIntervalle.Location = new System.Drawing.Point(252, 26);
            this.tbIntervalle.Name = "tbIntervalle";
            this.tbIntervalle.Size = new System.Drawing.Size(61, 20);
            this.tbIntervalle.TabIndex = 4;
            this.tbIntervalle.Text = "2";
            // 
            // EcranIntegrales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 324);
            this.Controls.Add(this.tbIntervalle);
            this.Controls.Add(this.lblIntervalle);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.btnCosinus);
            this.Controls.Add(this.btnPolynome);
            this.Controls.Add(this.lbResultats);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranIntegrales";
            this.Text = "Calcul d\'integrales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResultats;
        private System.Windows.Forms.Button btnPolynome;
        private System.Windows.Forms.Button btnCosinus;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblIntervalle;
        private System.Windows.Forms.TextBox tbIntervalle;
    }
}