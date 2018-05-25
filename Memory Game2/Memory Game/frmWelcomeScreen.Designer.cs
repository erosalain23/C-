namespace Memory_Game
{
    partial class frmWelcomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWelcomeScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnResumeGame = new System.Windows.Forms.Button();
            this.btnQuitGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(285, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Memory game";
            // 
            // btnNewGame
            // 
            this.btnNewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewGame.Location = new System.Drawing.Point(251, 217);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(233, 55);
            this.btnNewGame.TabIndex = 1;
            this.btnNewGame.Text = "New game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnResumeGame
            // 
            this.btnResumeGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResumeGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnResumeGame.Location = new System.Drawing.Point(251, 278);
            this.btnResumeGame.Name = "btnResumeGame";
            this.btnResumeGame.Size = new System.Drawing.Size(233, 55);
            this.btnResumeGame.TabIndex = 1;
            this.btnResumeGame.Text = "Resume game";
            this.btnResumeGame.UseVisualStyleBackColor = true;
            this.btnResumeGame.Click += new System.EventHandler(this.btnResumeGame_Click);
            // 
            // btnQuitGame
            // 
            this.btnQuitGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuitGame.ForeColor = System.Drawing.Color.Transparent;
            this.btnQuitGame.Location = new System.Drawing.Point(251, 339);
            this.btnQuitGame.Name = "btnQuitGame";
            this.btnQuitGame.Size = new System.Drawing.Size(233, 55);
            this.btnQuitGame.TabIndex = 1;
            this.btnQuitGame.Text = "Quit game";
            this.btnQuitGame.UseVisualStyleBackColor = true;
            this.btnQuitGame.Click += new System.EventHandler(this.btnQuitGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("OCR A Extended", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(336, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Menu";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(251, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // frmWelcomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(735, 479);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitGame);
            this.Controls.Add(this.btnResumeGame);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmWelcomeScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to the Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnResumeGame;
        private System.Windows.Forms.Button btnQuitGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}