namespace ISET_2018_Decouverte
{
    partial class EcranClavierSouris
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
            this.lblClavier = new System.Windows.Forms.Label();
            this.btnRAZ = new System.Windows.Forms.Button();
            this.btnQuiter = new System.Windows.Forms.Button();
            this.lbClavier = new System.Windows.Forms.ListBox();
            this.lblGauche = new System.Windows.Forms.Label();
            this.tbGauche = new System.Windows.Forms.TextBox();
            this.pSouris = new System.Windows.Forms.Panel();
            this.tbDroite = new System.Windows.Forms.TextBox();
            this.lblDroite = new System.Windows.Forms.Label();
            this.tbPosX = new System.Windows.Forms.TextBox();
            this.lblPosX = new System.Windows.Forms.Label();
            this.tbPosY = new System.Windows.Forms.TextBox();
            this.lblPosY = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblClavier
            // 
            this.lblClavier.AutoSize = true;
            this.lblClavier.Location = new System.Drawing.Point(9, 22);
            this.lblClavier.Name = "lblClavier";
            this.lblClavier.Size = new System.Drawing.Size(79, 13);
            this.lblClavier.TabIndex = 0;
            this.lblClavier.Text = "Suivi du clavier";
            // 
            // btnRAZ
            // 
            this.btnRAZ.Location = new System.Drawing.Point(12, 254);
            this.btnRAZ.Name = "btnRAZ";
            this.btnRAZ.Size = new System.Drawing.Size(127, 23);
            this.btnRAZ.TabIndex = 1;
            this.btnRAZ.Text = "Remise a zero";
            this.btnRAZ.UseVisualStyleBackColor = true;
            this.btnRAZ.Click += new System.EventHandler(this.btnRAZ_Click);
            // 
            // btnQuiter
            // 
            this.btnQuiter.Location = new System.Drawing.Point(140, 254);
            this.btnQuiter.Name = "btnQuiter";
            this.btnQuiter.Size = new System.Drawing.Size(127, 23);
            this.btnQuiter.TabIndex = 1;
            this.btnQuiter.Text = "Quiter";
            this.btnQuiter.UseVisualStyleBackColor = true;
            this.btnQuiter.Click += new System.EventHandler(this.btnQuiter_Click);
            // 
            // lbClavier
            // 
            this.lbClavier.FormattingEnabled = true;
            this.lbClavier.Location = new System.Drawing.Point(13, 48);
            this.lbClavier.Name = "lbClavier";
            this.lbClavier.Size = new System.Drawing.Size(246, 186);
            this.lbClavier.TabIndex = 2;
            // 
            // lblGauche
            // 
            this.lblGauche.AutoSize = true;
            this.lblGauche.Location = new System.Drawing.Point(269, 21);
            this.lblGauche.Name = "lblGauche";
            this.lblGauche.Size = new System.Drawing.Size(52, 13);
            this.lblGauche.TabIndex = 3;
            this.lblGauche.Text = "a gauche";
            // 
            // tbGauche
            // 
            this.tbGauche.Location = new System.Drawing.Point(272, 48);
            this.tbGauche.Name = "tbGauche";
            this.tbGauche.ReadOnly = true;
            this.tbGauche.Size = new System.Drawing.Size(76, 20);
            this.tbGauche.TabIndex = 4;
            // 
            // pSouris
            // 
            this.pSouris.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pSouris.Location = new System.Drawing.Point(272, 75);
            this.pSouris.Name = "pSouris";
            this.pSouris.Size = new System.Drawing.Size(474, 193);
            this.pSouris.TabIndex = 5;
            this.pSouris.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSouris_MouseDown);
            this.pSouris.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pSouris_MouseMove);
            // 
            // tbDroite
            // 
            this.tbDroite.Location = new System.Drawing.Point(354, 49);
            this.tbDroite.Name = "tbDroite";
            this.tbDroite.ReadOnly = true;
            this.tbDroite.Size = new System.Drawing.Size(76, 20);
            this.tbDroite.TabIndex = 7;
            // 
            // lblDroite
            // 
            this.lblDroite.AutoSize = true;
            this.lblDroite.Location = new System.Drawing.Point(351, 21);
            this.lblDroite.Name = "lblDroite";
            this.lblDroite.Size = new System.Drawing.Size(44, 13);
            this.lblDroite.TabIndex = 6;
            this.lblDroite.Text = "a Droite";
            // 
            // tbPosX
            // 
            this.tbPosX.Location = new System.Drawing.Point(584, 49);
            this.tbPosX.Name = "tbPosX";
            this.tbPosX.ReadOnly = true;
            this.tbPosX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPosX.Size = new System.Drawing.Size(76, 20);
            this.tbPosX.TabIndex = 9;
            // 
            // lblPosX
            // 
            this.lblPosX.AutoSize = true;
            this.lblPosX.Location = new System.Drawing.Point(581, 22);
            this.lblPosX.Name = "lblPosX";
            this.lblPosX.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosX.Size = new System.Drawing.Size(48, 13);
            this.lblPosX.TabIndex = 8;
            this.lblPosX.Text = "abscisse";
            // 
            // tbPosY
            // 
            this.tbPosY.Location = new System.Drawing.Point(667, 49);
            this.tbPosY.Name = "tbPosY";
            this.tbPosY.ReadOnly = true;
            this.tbPosY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbPosY.Size = new System.Drawing.Size(76, 20);
            this.tbPosY.TabIndex = 11;
            // 
            // lblPosY
            // 
            this.lblPosY.AutoSize = true;
            this.lblPosY.Location = new System.Drawing.Point(664, 22);
            this.lblPosY.Name = "lblPosY";
            this.lblPosY.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblPosY.Size = new System.Drawing.Size(52, 13);
            this.lblPosY.TabIndex = 10;
            this.lblPosY.Text = "ordonnee";
            // 
            // EcranClavierSouris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 289);
            this.Controls.Add(this.tbPosX);
            this.Controls.Add(this.tbPosY);
            this.Controls.Add(this.lblPosY);
            this.Controls.Add(this.lblPosX);
            this.Controls.Add(this.tbDroite);
            this.Controls.Add(this.lblDroite);
            this.Controls.Add(this.pSouris);
            this.Controls.Add(this.tbGauche);
            this.Controls.Add(this.lblGauche);
            this.Controls.Add(this.lbClavier);
            this.Controls.Add(this.btnQuiter);
            this.Controls.Add(this.btnRAZ);
            this.Controls.Add(this.lblClavier);
            this.KeyPreview = true;
            this.Name = "EcranClavierSouris";
            this.Text = "Suivi du clavier et la souris";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EcranClavierSouris_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.EcranClavierSouris_KeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblClavier;
        private System.Windows.Forms.Button btnRAZ;
        private System.Windows.Forms.Button btnQuiter;
        private System.Windows.Forms.ListBox lbClavier;
        private System.Windows.Forms.Label lblGauche;
        private System.Windows.Forms.TextBox tbGauche;
        private System.Windows.Forms.Panel pSouris;
        private System.Windows.Forms.TextBox tbDroite;
        private System.Windows.Forms.Label lblDroite;
        private System.Windows.Forms.TextBox tbPosX;
        private System.Windows.Forms.Label lblPosX;
        private System.Windows.Forms.TextBox tbPosY;
        private System.Windows.Forms.Label lblPosY;
    }
}