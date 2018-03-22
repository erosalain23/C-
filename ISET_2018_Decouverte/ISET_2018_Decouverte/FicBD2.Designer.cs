namespace ISET_2018_Decouverte
{
    partial class FicBD2
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
            this.lblPre = new System.Windows.Forms.Label();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.clientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dsPerso = new ISET_2018_Decouverte.dsPerso();
            this.lblNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.dtdNaissance = new System.Windows.Forms.Label();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.btnPrec = new System.Windows.Forms.Button();
            this.btnPrem = new System.Windows.Forms.Button();
            this.btnDern = new System.Windows.Forms.Button();
            this.btnSuiv = new System.Windows.Forms.Button();
            this.lblPos = new System.Windows.Forms.Label();
            this.btnSupp = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModi = new System.Windows.Forms.Button();
            this.btnAnn = new System.Windows.Forms.Button();
            this.btnConf = new System.Windows.Forms.Button();
            this.clientTableAdapter = new ISET_2018_Decouverte.dsPersoTableAdapters.ClientTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPre
            // 
            this.lblPre.AutoSize = true;
            this.lblPre.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPre.Location = new System.Drawing.Point(12, 9);
            this.lblPre.Name = "lblPre";
            this.lblPre.Size = new System.Drawing.Size(44, 13);
            this.lblPre.TabIndex = 0;
            this.lblPre.Text = "Prenom";
            // 
            // tbPre
            // 
            this.tbPre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "PRE", true));
            this.tbPre.Location = new System.Drawing.Point(12, 25);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(279, 20);
            this.tbPre.TabIndex = 1;
            // 
            // clientBindingSource
            // 
            this.clientBindingSource.DataMember = "Client";
            this.clientBindingSource.DataSource = this.dsPerso;
            // 
            // dsPerso
            // 
            this.dsPerso.DataSetName = "dsPerso";
            this.dsPerso.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNom.Location = new System.Drawing.Point(9, 48);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(29, 13);
            this.lblNom.TabIndex = 0;
            this.lblNom.Text = "Nom";
            // 
            // tbNom
            // 
            this.tbNom.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientBindingSource, "NOM", true));
            this.tbNom.Location = new System.Drawing.Point(12, 64);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(279, 20);
            this.tbNom.TabIndex = 1;
            // 
            // dtdNaissance
            // 
            this.dtdNaissance.AutoSize = true;
            this.dtdNaissance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtdNaissance.Location = new System.Drawing.Point(12, 87);
            this.dtdNaissance.Name = "dtdNaissance";
            this.dtdNaissance.Size = new System.Drawing.Size(94, 13);
            this.dtdNaissance.TabIndex = 0;
            this.dtdNaissance.Text = "Date de naissance";
            // 
            // dtPicker
            // 
            this.dtPicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.clientBindingSource, "NAI", true));
            this.dtPicker.Location = new System.Drawing.Point(12, 103);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(279, 20);
            this.dtPicker.TabIndex = 2;
            // 
            // btnPrec
            // 
            this.btnPrec.Location = new System.Drawing.Point(58, 139);
            this.btnPrec.Name = "btnPrec";
            this.btnPrec.Size = new System.Drawing.Size(40, 35);
            this.btnPrec.TabIndex = 3;
            this.btnPrec.Text = "<";
            this.btnPrec.UseVisualStyleBackColor = true;
            this.btnPrec.Click += new System.EventHandler(this.btnPrec_Click);
            // 
            // btnPrem
            // 
            this.btnPrem.Location = new System.Drawing.Point(12, 139);
            this.btnPrem.Name = "btnPrem";
            this.btnPrem.Size = new System.Drawing.Size(40, 35);
            this.btnPrem.TabIndex = 3;
            this.btnPrem.Text = "| <";
            this.btnPrem.UseVisualStyleBackColor = true;
            this.btnPrem.Click += new System.EventHandler(this.btnPrem_Click);
            // 
            // btnDern
            // 
            this.btnDern.Location = new System.Drawing.Point(251, 140);
            this.btnDern.Name = "btnDern";
            this.btnDern.Size = new System.Drawing.Size(40, 35);
            this.btnDern.TabIndex = 3;
            this.btnDern.Text = "> |";
            this.btnDern.UseVisualStyleBackColor = true;
            this.btnDern.Click += new System.EventHandler(this.btnDern_Click);
            // 
            // btnSuiv
            // 
            this.btnSuiv.Location = new System.Drawing.Point(205, 140);
            this.btnSuiv.Name = "btnSuiv";
            this.btnSuiv.Size = new System.Drawing.Size(40, 35);
            this.btnSuiv.TabIndex = 3;
            this.btnSuiv.Text = ">";
            this.btnSuiv.UseVisualStyleBackColor = true;
            this.btnSuiv.Click += new System.EventHandler(this.btnSuiv_Click);
            // 
            // lblPos
            // 
            this.lblPos.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPos.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPos.Location = new System.Drawing.Point(119, 140);
            this.lblPos.Name = "lblPos";
            this.lblPos.Size = new System.Drawing.Size(63, 35);
            this.lblPos.TabIndex = 4;
            this.lblPos.Text = "p/n";
            this.lblPos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSupp
            // 
            this.btnSupp.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupp.Location = new System.Drawing.Point(208, 199);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(83, 38);
            this.btnSupp.TabIndex = 5;
            this.btnSupp.Text = "Supprimer";
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(12, 199);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(75, 38);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnModi
            // 
            this.btnModi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModi.Location = new System.Drawing.Point(107, 199);
            this.btnModi.Name = "btnModi";
            this.btnModi.Size = new System.Drawing.Size(75, 38);
            this.btnModi.TabIndex = 5;
            this.btnModi.Text = "Modifier";
            this.btnModi.UseVisualStyleBackColor = true;
            this.btnModi.Click += new System.EventHandler(this.btnModi_Click);
            // 
            // btnAnn
            // 
            this.btnAnn.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnn.Location = new System.Drawing.Point(159, 243);
            this.btnAnn.Name = "btnAnn";
            this.btnAnn.Size = new System.Drawing.Size(75, 36);
            this.btnAnn.TabIndex = 5;
            this.btnAnn.Text = "Annuler";
            this.btnAnn.UseVisualStyleBackColor = true;
            this.btnAnn.Click += new System.EventHandler(this.btnAnn_Click);
            // 
            // btnConf
            // 
            this.btnConf.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConf.Location = new System.Drawing.Point(58, 243);
            this.btnConf.Name = "btnConf";
            this.btnConf.Size = new System.Drawing.Size(75, 36);
            this.btnConf.TabIndex = 5;
            this.btnConf.Text = "Confirmer";
            this.btnConf.UseVisualStyleBackColor = true;
            this.btnConf.Click += new System.EventHandler(this.btnConf_Click);
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // EcranBD2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 311);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnConf);
            this.Controls.Add(this.btnAnn);
            this.Controls.Add(this.btnModi);
            this.Controls.Add(this.btnSupp);
            this.Controls.Add(this.lblPos);
            this.Controls.Add(this.btnSuiv);
            this.Controls.Add(this.btnPrem);
            this.Controls.Add(this.btnDern);
            this.Controls.Add(this.btnPrec);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.dtdNaissance);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBD2";
            this.Text = "Gestion de base de donnees";
            this.Load += new System.EventHandler(this.EcranBD2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dsPerso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPre;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.Label dtdNaissance;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.Button btnPrec;
        private System.Windows.Forms.Button btnPrem;
        private System.Windows.Forms.Button btnDern;
        private System.Windows.Forms.Button btnSuiv;
        private System.Windows.Forms.Label lblPos;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModi;
        private System.Windows.Forms.Button btnAnn;
        private System.Windows.Forms.Button btnConf;
        private dsPerso dsPerso;
        private System.Windows.Forms.BindingSource clientBindingSource;
        private dsPersoTableAdapters.ClientTableAdapter clientTableAdapter;
    }
}