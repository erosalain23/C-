namespace ISET_2018_Decouverte
{
    partial class EcranExpresssionRegulieres
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EcranExpresssionRegulieres));
            this.lblExpressionRegulieres = new System.Windows.Forms.Label();
            this.tbExpressionRegulieres = new System.Windows.Forms.TextBox();
            this.cbIsValide = new System.Windows.Forms.CheckBox();
            this.cbIsCorrespondance = new System.Windows.Forms.CheckBox();
            this.cbIsRespectCasse = new System.Windows.Forms.CheckBox();
            this.cbRemplacer = new System.Windows.Forms.CheckBox();
            this.cbSeparer = new System.Windows.Forms.CheckBox();
            this.lblRemplacement = new System.Windows.Forms.Label();
            this.tbRemplacement = new System.Windows.Forms.TextBox();
            this.lblATraiter = new System.Windows.Forms.Label();
            this.rtATraiter = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lblExpressionRegulieres
            // 
            this.lblExpressionRegulieres.AutoSize = true;
            this.lblExpressionRegulieres.Location = new System.Drawing.Point(12, 9);
            this.lblExpressionRegulieres.Name = "lblExpressionRegulieres";
            this.lblExpressionRegulieres.Size = new System.Drawing.Size(111, 13);
            this.lblExpressionRegulieres.TabIndex = 0;
            this.lblExpressionRegulieres.Text = "Expression Regulieres";
            // 
            // tbExpressionRegulieres
            // 
            this.tbExpressionRegulieres.Location = new System.Drawing.Point(15, 25);
            this.tbExpressionRegulieres.Name = "tbExpressionRegulieres";
            this.tbExpressionRegulieres.Size = new System.Drawing.Size(520, 20);
            this.tbExpressionRegulieres.TabIndex = 1;
            this.tbExpressionRegulieres.TextChanged += new System.EventHandler(this.tbExpressionRegulieres_TextChanged);
            // 
            // cbIsValide
            // 
            this.cbIsValide.AutoSize = true;
            this.cbIsValide.Enabled = false;
            this.cbIsValide.Location = new System.Drawing.Point(15, 52);
            this.cbIsValide.Name = "cbIsValide";
            this.cbIsValide.Size = new System.Drawing.Size(60, 17);
            this.cbIsValide.TabIndex = 2;
            this.cbIsValide.Text = "Validite";
            this.cbIsValide.UseVisualStyleBackColor = true;
            // 
            // cbIsCorrespondance
            // 
            this.cbIsCorrespondance.AutoSize = true;
            this.cbIsCorrespondance.Enabled = false;
            this.cbIsCorrespondance.Location = new System.Drawing.Point(180, 52);
            this.cbIsCorrespondance.Name = "cbIsCorrespondance";
            this.cbIsCorrespondance.Size = new System.Drawing.Size(143, 17);
            this.cbIsCorrespondance.TabIndex = 3;
            this.cbIsCorrespondance.Text = "Correspondance trouvee";
            this.cbIsCorrespondance.UseVisualStyleBackColor = true;
            // 
            // cbIsRespectCasse
            // 
            this.cbIsRespectCasse.AutoSize = true;
            this.cbIsRespectCasse.Location = new System.Drawing.Point(397, 52);
            this.cbIsRespectCasse.Name = "cbIsRespectCasse";
            this.cbIsRespectCasse.Size = new System.Drawing.Size(123, 17);
            this.cbIsRespectCasse.TabIndex = 4;
            this.cbIsRespectCasse.Text = "Respect de la casse";
            this.cbIsRespectCasse.UseVisualStyleBackColor = true;
            this.cbIsRespectCasse.CheckedChanged += new System.EventHandler(this.cbIsRespectCasse_CheckedChanged);
            // 
            // cbRemplacer
            // 
            this.cbRemplacer.AutoSize = true;
            this.cbRemplacer.Location = new System.Drawing.Point(15, 86);
            this.cbRemplacer.Name = "cbRemplacer";
            this.cbRemplacer.Size = new System.Drawing.Size(77, 17);
            this.cbRemplacer.TabIndex = 5;
            this.cbRemplacer.Text = "Remplacer";
            this.cbRemplacer.UseVisualStyleBackColor = true;
            this.cbRemplacer.CheckedChanged += new System.EventHandler(this.cbRemplacer_CheckedChanged);
            // 
            // cbSeparer
            // 
            this.cbSeparer.AutoSize = true;
            this.cbSeparer.Location = new System.Drawing.Point(180, 86);
            this.cbSeparer.Name = "cbSeparer";
            this.cbSeparer.Size = new System.Drawing.Size(63, 17);
            this.cbSeparer.TabIndex = 6;
            this.cbSeparer.Text = "Separer";
            this.cbSeparer.UseVisualStyleBackColor = true;
            this.cbSeparer.CheckedChanged += new System.EventHandler(this.cbSeparer_CheckedChanged);
            // 
            // lblRemplacement
            // 
            this.lblRemplacement.AutoSize = true;
            this.lblRemplacement.Location = new System.Drawing.Point(12, 131);
            this.lblRemplacement.Name = "lblRemplacement";
            this.lblRemplacement.Size = new System.Drawing.Size(78, 13);
            this.lblRemplacement.TabIndex = 0;
            this.lblRemplacement.Text = "Remplacement";
            // 
            // tbRemplacement
            // 
            this.tbRemplacement.Location = new System.Drawing.Point(15, 147);
            this.tbRemplacement.Name = "tbRemplacement";
            this.tbRemplacement.Size = new System.Drawing.Size(520, 20);
            this.tbRemplacement.TabIndex = 1;
            // 
            // lblATraiter
            // 
            this.lblATraiter.AutoSize = true;
            this.lblATraiter.Location = new System.Drawing.Point(12, 180);
            this.lblATraiter.Name = "lblATraiter";
            this.lblATraiter.Size = new System.Drawing.Size(72, 13);
            this.lblATraiter.TabIndex = 7;
            this.lblATraiter.Text = "Texte a traiter";
            // 
            // rtATraiter
            // 
            this.rtATraiter.Location = new System.Drawing.Point(15, 207);
            this.rtATraiter.Name = "rtATraiter";
            this.rtATraiter.Size = new System.Drawing.Size(520, 140);
            this.rtATraiter.TabIndex = 8;
            this.rtATraiter.Text = resources.GetString("rtATraiter.Text");
            this.rtATraiter.TextChanged += new System.EventHandler(this.rtATraiter_TextChanged);
            // 
            // EcranExpresssionRegulieres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 359);
            this.Controls.Add(this.rtATraiter);
            this.Controls.Add(this.lblATraiter);
            this.Controls.Add(this.cbSeparer);
            this.Controls.Add(this.cbRemplacer);
            this.Controls.Add(this.cbIsRespectCasse);
            this.Controls.Add(this.cbIsCorrespondance);
            this.Controls.Add(this.cbIsValide);
            this.Controls.Add(this.tbRemplacement);
            this.Controls.Add(this.lblRemplacement);
            this.Controls.Add(this.tbExpressionRegulieres);
            this.Controls.Add(this.lblExpressionRegulieres);
            this.Name = "EcranExpresssionRegulieres";
            this.Text = "ExpressionRegulieres";
            this.Load += new System.EventHandler(this.EcranExpresssionRegulieres_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblExpressionRegulieres;
        private System.Windows.Forms.TextBox tbExpressionRegulieres;
        private System.Windows.Forms.CheckBox cbIsValide;
        private System.Windows.Forms.CheckBox cbIsCorrespondance;
        private System.Windows.Forms.CheckBox cbIsRespectCasse;
        private System.Windows.Forms.CheckBox cbRemplacer;
        private System.Windows.Forms.CheckBox cbSeparer;
        private System.Windows.Forms.Label lblRemplacement;
        private System.Windows.Forms.TextBox tbRemplacement;
        private System.Windows.Forms.Label lblATraiter;
        private System.Windows.Forms.RichTextBox rtATraiter;
    }
}