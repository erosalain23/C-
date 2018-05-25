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
            this.btnStopDeplacerCTick = new System.Windows.Forms.Button();
            this.btnCreationCarrosse = new System.Windows.Forms.Button();
            this.cHomme = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBallon = new System.Windows.Forms.Button();
            this.buttonJouer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TV)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.Location = new System.Drawing.Point(13, 13);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(782, 241);
            this.TV.TabIndex = 0;
            this.TV.TabStop = false;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // timerImage
            // 
            this.timerImage.Interval = 500;
            this.timerImage.Tick += new System.EventHandler(this.timerImage_Tick);
            // 
            // btnEffacer
            // 
            this.btnEffacer.Location = new System.Drawing.Point(13, 305);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(389, 23);
            this.btnEffacer.TabIndex = 10;
            this.btnEffacer.Text = "Effacer Tout";
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // btnStopDeplacerCTick
            // 
            this.btnStopDeplacerCTick.Enabled = false;
            this.btnStopDeplacerCTick.Location = new System.Drawing.Point(408, 305);
            this.btnStopDeplacerCTick.Name = "btnStopDeplacerCTick";
            this.btnStopDeplacerCTick.Size = new System.Drawing.Size(387, 23);
            this.btnStopDeplacerCTick.TabIndex = 9;
            this.btnStopDeplacerCTick.Text = "Stop Tick";
            this.btnStopDeplacerCTick.UseVisualStyleBackColor = true;
            this.btnStopDeplacerCTick.Click += new System.EventHandler(this.btnStopDeplacerCTick_Click);
            // 
            // btnCreationCarrosse
            // 
            this.btnCreationCarrosse.Location = new System.Drawing.Point(13, 276);
            this.btnCreationCarrosse.Name = "btnCreationCarrosse";
            this.btnCreationCarrosse.Size = new System.Drawing.Size(782, 23);
            this.btnCreationCarrosse.TabIndex = 11;
            this.btnCreationCarrosse.Text = "Creer Carrosse";
            this.btnCreationCarrosse.UseVisualStyleBackColor = true;
            this.btnCreationCarrosse.Click += new System.EventHandler(this.btnCreationCarrosse_Click);
            // 
            // cHomme
            // 
            this.cHomme.Location = new System.Drawing.Point(13, 344);
            this.cHomme.Margin = new System.Windows.Forms.Padding(2);
            this.cHomme.Name = "cHomme";
            this.cHomme.Size = new System.Drawing.Size(230, 38);
            this.cHomme.TabIndex = 12;
            this.cHomme.Text = "Homme";
            this.cHomme.UseVisualStyleBackColor = true;
            this.cHomme.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(291, 344);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Marcher";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonBallon
            // 
            this.buttonBallon.Location = new System.Drawing.Point(472, 345);
            this.buttonBallon.Name = "buttonBallon";
            this.buttonBallon.Size = new System.Drawing.Size(127, 37);
            this.buttonBallon.TabIndex = 14;
            this.buttonBallon.Text = "Ballon";
            this.buttonBallon.UseVisualStyleBackColor = true;
            this.buttonBallon.Click += new System.EventHandler(this.buttonBallon_Click);
            // 
            // buttonJouer
            // 
            this.buttonJouer.Location = new System.Drawing.Point(652, 344);
            this.buttonJouer.Name = "buttonJouer";
            this.buttonJouer.Size = new System.Drawing.Size(143, 37);
            this.buttonJouer.TabIndex = 15;
            this.buttonJouer.Text = "Jouer";
            this.buttonJouer.UseVisualStyleBackColor = true;
            this.buttonJouer.Click += new System.EventHandler(this.buttonJouer_Click);
            // 
            // EcranAccueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 415);
            this.Controls.Add(this.buttonJouer);
            this.Controls.Add(this.buttonBallon);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cHomme);
            this.Controls.Add(this.btnCreationCarrosse);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnStopDeplacerCTick);
            this.Controls.Add(this.TV);
            this.Name = "EcranAccueil";
            this.Text = "Dessins Animés";
            ((System.ComponentModel.ISupportInitialize)(this.TV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TV;
        private System.Windows.Forms.Timer timerImage;
        private System.Windows.Forms.Button btnEffacer;
        private System.Windows.Forms.Button btnStopDeplacerCTick;
        private System.Windows.Forms.Button btnCreationCarrosse;
        private System.Windows.Forms.Button cHomme;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonBallon;
        private System.Windows.Forms.Button buttonJouer;
    }
}

