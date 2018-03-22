namespace ISET_2018_Decouverte
{
    partial class FicBD1
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
            this.lbContenu = new System.Windows.Forms.ListBox();
            this.btnCharger = new System.Windows.Forms.Button();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbPrenom = new System.Windows.Forms.TextBox();
            this.tbSupp = new System.Windows.Forms.TextBox();
            this.btnSauver = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnCompter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbContenu
            // 
            this.lbContenu.FormattingEnabled = true;
            this.lbContenu.Location = new System.Drawing.Point(26, 12);
            this.lbContenu.Name = "lbContenu";
            this.lbContenu.Size = new System.Drawing.Size(528, 95);
            this.lbContenu.TabIndex = 0;
            // 
            // btnCharger
            // 
            this.btnCharger.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCharger.Location = new System.Drawing.Point(26, 113);
            this.btnCharger.Name = "btnCharger";
            this.btnCharger.Size = new System.Drawing.Size(528, 26);
            this.btnCharger.TabIndex = 1;
            this.btnCharger.Text = "Charger";
            this.btnCharger.UseVisualStyleBackColor = true;
            this.btnCharger.Click += new System.EventHandler(this.btnCharger_Click);
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(26, 157);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(303, 20);
            this.tbNom.TabIndex = 2;
            // 
            // tbPrenom
            // 
            this.tbPrenom.Location = new System.Drawing.Point(26, 183);
            this.tbPrenom.Name = "tbPrenom";
            this.tbPrenom.Size = new System.Drawing.Size(303, 20);
            this.tbPrenom.TabIndex = 2;
            // 
            // tbSupp
            // 
            this.tbSupp.Location = new System.Drawing.Point(26, 247);
            this.tbSupp.Name = "tbSupp";
            this.tbSupp.Size = new System.Drawing.Size(303, 20);
            this.tbSupp.TabIndex = 2;
            // 
            // btnSauver
            // 
            this.btnSauver.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSauver.Location = new System.Drawing.Point(403, 157);
            this.btnSauver.Name = "btnSauver";
            this.btnSauver.Size = new System.Drawing.Size(151, 46);
            this.btnSauver.TabIndex = 1;
            this.btnSauver.Text = "Sauver";
            this.btnSauver.UseVisualStyleBackColor = true;
            this.btnSauver.Click += new System.EventHandler(this.btnSauver_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.Location = new System.Drawing.Point(403, 247);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(151, 32);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnCompter
            // 
            this.btnCompter.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompter.Location = new System.Drawing.Point(41, 309);
            this.btnCompter.Name = "btnCompter";
            this.btnCompter.Size = new System.Drawing.Size(513, 34);
            this.btnCompter.TabIndex = 4;
            this.btnCompter.Text = "Compter";
            this.btnCompter.UseVisualStyleBackColor = true;
            this.btnCompter.Click += new System.EventHandler(this.btnCompter_Click);
            // 
            // EcranBD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 376);
            this.Controls.Add(this.btnCompter);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.tbSupp);
            this.Controls.Add(this.tbPrenom);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.btnSauver);
            this.Controls.Add(this.btnCharger);
            this.Controls.Add(this.lbContenu);
            this.Name = "EcranBD1";
            this.Text = "EcranBD1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbContenu;
        private System.Windows.Forms.Button btnCharger;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbPrenom;
        private System.Windows.Forms.TextBox tbSupp;
        private System.Windows.Forms.Button btnSauver;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnCompter;
    }
}