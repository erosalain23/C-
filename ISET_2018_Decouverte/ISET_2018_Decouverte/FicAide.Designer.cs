namespace ISET_2018_Decouverte
{
    partial class FicAide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FicAide));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblCopy = new System.Windows.Forms.Label();
            this.lblVer = new System.Windows.Forms.Label();
            this.lblManip = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(18, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDescription);
            this.panel1.Controls.Add(this.lblCopy);
            this.panel1.Controls.Add(this.lblVer);
            this.panel1.Controls.Add(this.lblManip);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(36, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 366);
            this.panel1.TabIndex = 1;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(126, 267);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(362, 47);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Et l\'application se dit qu\'un jour.elle deviendra aussi grande que .NET ";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopy.Location = new System.Drawing.Point(209, 194);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(196, 26);
            this.lblCopy.TabIndex = 3;
            this.lblCopy.Text = "CopyRight NADA";
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Location = new System.Drawing.Point(216, 114);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(183, 20);
            this.lblVer.TabIndex = 2;
            this.lblVer.Text = "Verison sous alpha 1.0.0";
            // 
            // lblManip
            // 
            this.lblManip.AutoSize = true;
            this.lblManip.Location = new System.Drawing.Point(224, 66);
            this.lblManip.Name = "lblManip";
            this.lblManip.Size = new System.Drawing.Size(166, 20);
            this.lblManip.TabIndex = 1;
            this.lblManip.Text = "Première Manipulation";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(250, 437);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(191, 49);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirmer";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FicAide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(691, 514);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.panel1);
            this.Name = "FicAide";
            this.Text = "FicAide";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblCopy;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.Label lblManip;
        private System.Windows.Forms.Button btnConfirm;
    }
}