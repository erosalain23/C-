namespace ISET_2018_Decouverte
{
    partial class EcranAccueil
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
            this.btnPoussez = new System.Windows.Forms.Button();
            this.btnEntrez = new System.Windows.Forms.Button();
            this.lblTitre = new System.Windows.Forms.Label();
            this.pbImageDepart = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPoussez
            // 
            this.btnPoussez.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPoussez.Location = new System.Drawing.Point(139, 369);
            this.btnPoussez.Name = "btnPoussez";
            this.btnPoussez.Size = new System.Drawing.Size(190, 80);
            this.btnPoussez.TabIndex = 0;
            this.btnPoussez.Text = "poussez";
            this.btnPoussez.UseVisualStyleBackColor = true;
            this.btnPoussez.Click += new System.EventHandler(this.btnPoussez_Click);
            // 
            // btnEntrez
            // 
            this.btnEntrez.Font = new System.Drawing.Font("Segoe Print", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrez.Location = new System.Drawing.Point(623, 369);
            this.btnEntrez.Name = "btnEntrez";
            this.btnEntrez.Size = new System.Drawing.Size(190, 80);
            this.btnEntrez.TabIndex = 1;
            this.btnEntrez.Text = "Entrez";
            this.btnEntrez.UseVisualStyleBackColor = true;
            this.btnEntrez.Click += new System.EventHandler(this.btnEntrez_Click);
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.Font = new System.Drawing.Font("Comic Sans MS", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(168, 57);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(586, 72);
            this.lblTitre.TabIndex = 2;
            this.lblTitre.Text = "Découverte de Csharp";
            this.lblTitre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbImageDepart
            // 
            this.pbImageDepart.Location = new System.Drawing.Point(411, 154);
            this.pbImageDepart.Name = "pbImageDepart";
            this.pbImageDepart.Size = new System.Drawing.Size(101, 179);
            this.pbImageDepart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImageDepart.TabIndex = 3;
            this.pbImageDepart.TabStop = false;
            // 
            // EcranAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(923, 546);
            this.Controls.Add(this.pbImageDepart);
            this.Controls.Add(this.lblTitre);
            this.Controls.Add(this.btnEntrez);
            this.Controls.Add(this.btnPoussez);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EcranAccueil";
            this.Text = "Bienvenue,Welcome,.";
            ((System.ComponentModel.ISupportInitialize)(this.pbImageDepart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPoussez;
        private System.Windows.Forms.Button btnEntrez;
        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.PictureBox pbImageDepart;
    }
}

