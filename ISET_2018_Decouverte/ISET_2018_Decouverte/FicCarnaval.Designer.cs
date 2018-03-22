namespace ISET_2018_Decouverte
{
    partial class EcranCarnaval
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
            this.btnText = new System.Windows.Forms.Button();
            this.btnGeometrique = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnText
            // 
            this.btnText.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnText.Location = new System.Drawing.Point(10, 10);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(324, 48);
            this.btnText.TabIndex = 0;
            this.btnText.Text = "button1";
            this.btnText.UseVisualStyleBackColor = false;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // btnGeometrique
            // 
            this.btnGeometrique.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGeometrique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeometrique.Location = new System.Drawing.Point(10, 72);
            this.btnGeometrique.Name = "btnGeometrique";
            this.btnGeometrique.Size = new System.Drawing.Size(324, 48);
            this.btnGeometrique.TabIndex = 1;
            this.btnGeometrique.Text = "button1";
            this.btnGeometrique.UseVisualStyleBackColor = false;
            this.btnGeometrique.Click += new System.EventHandler(this.btnGeometrique_Click);
            // 
            // EcranCarnaval
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(344, 361);
            this.Controls.Add(this.btnGeometrique);
            this.Controls.Add(this.btnText);
            this.Name = "EcranCarnaval";
            this.Text = "C\'est lq fete,la fete...";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.EcranCarnaval_Paint);
            this.Resize += new System.EventHandler(this.EcranCarnaval_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnText;
        private System.Windows.Forms.Button btnGeometrique;
    }
}