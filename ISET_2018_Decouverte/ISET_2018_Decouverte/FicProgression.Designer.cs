namespace ISET_2018_Decouverte
{
    partial class EcranProgression
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
            this.label1 = new System.Windows.Forms.Label();
            this.pbSecondaire = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.pbPrincipal = new System.Windows.Forms.ProgressBar();
            this.btnExecuter = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fichier (virtuel)";
            // 
            // pbSecondaire
            // 
            this.pbSecondaire.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbSecondaire.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pbSecondaire.Location = new System.Drawing.Point(34, 87);
            this.pbSecondaire.Name = "pbSecondaire";
            this.pbSecondaire.Size = new System.Drawing.Size(842, 84);
            this.pbSecondaire.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(38, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Copy (virtuel)";
            // 
            // pbPrincipal
            // 
            this.pbPrincipal.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbPrincipal.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.pbPrincipal.Location = new System.Drawing.Point(34, 322);
            this.pbPrincipal.Name = "pbPrincipal";
            this.pbPrincipal.Size = new System.Drawing.Size(842, 84);
            this.pbPrincipal.TabIndex = 3;
            // 
            // btnExecuter
            // 
            this.btnExecuter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExecuter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnExecuter.Location = new System.Drawing.Point(34, 498);
            this.btnExecuter.Name = "btnExecuter";
            this.btnExecuter.Size = new System.Drawing.Size(233, 72);
            this.btnExecuter.TabIndex = 4;
            this.btnExecuter.Text = "Executer";
            this.btnExecuter.UseVisualStyleBackColor = true;
            this.btnExecuter.Click += new System.EventHandler(this.btnExecuter_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnQuitter.Location = new System.Drawing.Point(643, 498);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(233, 72);
            this.btnQuitter.TabIndex = 5;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // EcranProgression
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 662);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnExecuter);
            this.Controls.Add(this.pbPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbSecondaire);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranProgression";
            this.Text = "Barres de Progression";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbSecondaire;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar pbPrincipal;
        private System.Windows.Forms.Button btnExecuter;
        private System.Windows.Forms.Button btnQuitter;
    }
}