namespace ISET_2018_Decouverte
{
    partial class EcranBD3
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
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnConfirmer = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.dtpNai = new System.Windows.Forms.DateTimePicker();
            this.lblNai = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.dgvPersonne = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(487, 24);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 0;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(487, 53);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(75, 23);
            this.btnEditer.TabIndex = 0;
            this.btnEditer.Text = "Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(487, 82);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimer.TabIndex = 0;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnConfirmer
            // 
            this.btnConfirmer.Location = new System.Drawing.Point(490, 313);
            this.btnConfirmer.Name = "btnConfirmer";
            this.btnConfirmer.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmer.TabIndex = 0;
            this.btnConfirmer.Text = "Confirmer";
            this.btnConfirmer.UseVisualStyleBackColor = true;
            this.btnConfirmer.Click += new System.EventHandler(this.btnConfirmer_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(490, 342);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 0;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // dtpNai
            // 
            this.dtpNai.Location = new System.Drawing.Point(42, 341);
            this.dtpNai.Name = "dtpNai";
            this.dtpNai.Size = new System.Drawing.Size(439, 20);
            this.dtpNai.TabIndex = 1;
            // 
            // lblNai
            // 
            this.lblNai.AutoSize = true;
            this.lblNai.Location = new System.Drawing.Point(42, 312);
            this.lblNai.Name = "lblNai";
            this.lblNai.Size = new System.Drawing.Size(96, 13);
            this.lblNai.TabIndex = 2;
            this.lblNai.Text = "Date de naissance";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(45, 284);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(436, 20);
            this.tbNom.TabIndex = 3;
            // 
            // tbPre
            // 
            this.tbPre.Location = new System.Drawing.Point(45, 226);
            this.tbPre.Name = "tbPre";
            this.tbPre.Size = new System.Drawing.Size(436, 20);
            this.tbPre.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Prenom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Identifiant";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(42, 175);
            this.tbId.Name = "tbId";
            this.tbId.ReadOnly = true;
            this.tbId.Size = new System.Drawing.Size(436, 20);
            this.tbId.TabIndex = 3;
            // 
            // dgvPersonne
            // 
            this.dgvPersonne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Afficher});
            this.dgvPersonne.Location = new System.Drawing.Point(45, 13);
            this.dgvPersonne.Name = "dgvPersonne";
            this.dgvPersonne.RowHeadersVisible = false;
            this.dgvPersonne.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonne.Size = new System.Drawing.Size(433, 121);
            this.dgvPersonne.TabIndex = 4;
            this.dgvPersonne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPersonne_CellContentClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Afficher
            // 
            this.Afficher.DataPropertyName = "Afficher";
            this.Afficher.HeaderText = "Nom et Prénom";
            this.Afficher.Name = "Afficher";
            this.Afficher.ReadOnly = true;
            this.Afficher.Width = 360;
            // 
            // EcranBD3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 390);
            this.Controls.Add(this.dgvPersonne);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.tbPre);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNai);
            this.Controls.Add(this.dtpNai);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnConfirmer);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.btnAjouter);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranBD3";
            this.Text = "Manipulations BD en couches";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnConfirmer;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.DateTimePicker dtpNai;
        private System.Windows.Forms.Label lblNai;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.DataGridView dgvPersonne;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Afficher;
    }
}