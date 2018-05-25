namespace Memory_Game
{
    partial class frmInputNames
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
            this.lblPlyr1Nm = new System.Windows.Forms.TextBox();
            this.lblPlyr2Nm = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(36, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(36, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Player 2";
            // 
            // lblPlyr1Nm
            // 
            this.lblPlyr1Nm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr1Nm.Location = new System.Drawing.Point(157, 64);
            this.lblPlyr1Nm.Name = "lblPlyr1Nm";
            this.lblPlyr1Nm.Size = new System.Drawing.Size(231, 26);
            this.lblPlyr1Nm.TabIndex = 2;
            // 
            // lblPlyr2Nm
            // 
            this.lblPlyr2Nm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlyr2Nm.Location = new System.Drawing.Point(157, 127);
            this.lblPlyr2Nm.Name = "lblPlyr2Nm";
            this.lblPlyr2Nm.Size = new System.Drawing.Size(231, 26);
            this.lblPlyr2Nm.TabIndex = 3;
            // 
            // btnGo
            // 
            this.btnGo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGo.Location = new System.Drawing.Point(235, 168);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 58);
            this.btnGo.TabIndex = 4;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // frmInputNames
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(526, 250);
            this.ControlBox = false;
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.lblPlyr2Nm);
            this.Controls.Add(this.lblPlyr1Nm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInputNames";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmInputNames";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lblPlyr1Nm;
        private System.Windows.Forms.TextBox lblPlyr2Nm;
        private System.Windows.Forms.Button btnGo;
    }
}