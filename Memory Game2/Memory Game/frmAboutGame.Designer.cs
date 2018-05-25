namespace Memory_Game
{
    partial class frmAboutGame
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnOkToPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("OCR A Extended", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(187, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "How to play";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(6, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(528, 133);
            this.label2.TabIndex = 1;
            this.label2.Text = "This game is played by clicking some cards on a table to reveal a pair of cards w" +
    "ith the same sign and the one who reveals more pairs is the winnner of the game." +
    "";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnOkToPlay
            // 
            this.btnOkToPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOkToPlay.ForeColor = System.Drawing.Color.Transparent;
            this.btnOkToPlay.Location = new System.Drawing.Point(201, 293);
            this.btnOkToPlay.Name = "btnOkToPlay";
            this.btnOkToPlay.Size = new System.Drawing.Size(138, 63);
            this.btnOkToPlay.TabIndex = 2;
            this.btnOkToPlay.Text = "OK";
            this.btnOkToPlay.UseVisualStyleBackColor = true;
            this.btnOkToPlay.Click += new System.EventHandler(this.btnOkToPlay_Click);
            // 
            // frmAboutGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(541, 440);
            this.ControlBox = false;
            this.Controls.Add(this.btnOkToPlay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAboutGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAboutGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOkToPlay;
    }
}