namespace Carrosse
{
    partial class EcranAccueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TV = new System.Windows.Forms.PictureBox();
            this.timerImage = new System.Windows.Forms.Timer(this.components);
            this.btnEffacer = new System.Windows.Forms.Button();
            this.btnCreationCarrosse = new System.Windows.Forms.Button();
            this.Act_marche = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.BackColor = System.Drawing.Color.SkyBlue;
            this.TV.Location = new System.Drawing.Point(4, 4);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(966, 341);
            this.TV.TabIndex = 0;
            this.TV.TabStop = false;
            // 
            // btnEffacer
            // 
            this.btnEffacer.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEffacer.Location = new System.Drawing.Point(552, 351);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(389, 40);
            this.btnEffacer.TabIndex = 10;
            this.btnEffacer.Text = "Effacer Tout";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnCreationCarrosse
            // 
            this.btnCreationCarrosse.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.btnCreationCarrosse.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreationCarrosse.Location = new System.Drawing.Point(37, 351);
            this.btnCreationCarrosse.Name = "btnCreationCarrosse";
            this.btnCreationCarrosse.Size = new System.Drawing.Size(389, 40);
            this.btnCreationCarrosse.TabIndex = 11;
            this.btnCreationCarrosse.Text = "Initier l\'animation";
            this.btnCreationCarrosse.UseVisualStyleBackColor = true;
            this.btnCreationCarrosse.Click += new System.EventHandler(this.btnCreationCarrosse_Click);
            // 
            // Act_marche
            // 
            this.Act_marche.BackColor = System.Drawing.Color.Yellow;
            this.Act_marche.Enabled = false;
            this.Act_marche.Font = new System.Drawing.Font("Mistral", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Act_marche.Location = new System.Drawing.Point(292, 397);
            this.Act_marche.Name = "Act_marche";
            this.Act_marche.Size = new System.Drawing.Size(389, 42);
            this.Act_marche.TabIndex = 13;
            this.Act_marche.Text = "Gooo, c\'est parti";
            this.Act_marche.UseVisualStyleBackColor = false;
            this.Act_marche.Click += new System.EventHandler(this.Act_marche_Click);
            // 
            // EcranAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 442);
            this.Controls.Add(this.Act_marche);
            this.Controls.Add(this.btnCreationCarrosse);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.TV);
            this.Name = "EcranAccueil";
            this.Text = "Dessin Animé Snowboard Jonathan Wuytens 2eme IS 2017-2018";
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnCreationCarrosse;
        private System.Windows.Forms.Button Act_marche;
    }
}

