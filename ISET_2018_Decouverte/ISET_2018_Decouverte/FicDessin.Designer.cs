namespace Dessin2D
{
    partial class DessinForm
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
            this.xShow = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.Display = new System.Windows.Forms.PictureBox();
            this.yShow = new System.Windows.Forms.TextBox();
            this.nbShow = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.allPoints = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Display)).BeginInit();
            this.SuspendLayout();
            // 
            // xShow
            // 
            this.xShow.Location = new System.Drawing.Point(103, 127);
            this.xShow.Name = "xShow";
            this.xShow.Size = new System.Drawing.Size(100, 20);
            this.xShow.TabIndex = 0;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(10, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 1;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.button1_Click);
            // 
            // Display
            // 
            this.Display.Location = new System.Drawing.Point(227, 12);
            this.Display.Name = "Display";
            this.Display.Size = new System.Drawing.Size(487, 289);
            this.Display.TabIndex = 2;
            this.Display.TabStop = false;
            this.Display.Paint += new System.Windows.Forms.PaintEventHandler(this.Display_Paint);
            // 
            // yShow
            // 
            this.yShow.Location = new System.Drawing.Point(103, 153);
            this.yShow.Name = "yShow";
            this.yShow.Size = new System.Drawing.Size(100, 20);
            this.yShow.TabIndex = 3;
            // 
            // nbShow
            // 
            this.nbShow.Location = new System.Drawing.Point(103, 179);
            this.nbShow.Name = "nbShow";
            this.nbShow.Size = new System.Drawing.Size(100, 20);
            this.nbShow.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre de points";
            // 
            // allPoints
            // 
            this.allPoints.Location = new System.Drawing.Point(10, 42);
            this.allPoints.Multiline = true;
            this.allPoints.Name = "allPoints";
            this.allPoints.Size = new System.Drawing.Size(193, 79);
            this.allPoints.TabIndex = 8;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(10, 234);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // DessinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 313);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.allPoints);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nbShow);
            this.Controls.Add(this.yShow);
            this.Controls.Add(this.Display);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.xShow);
            this.Name = "DessinForm";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Display)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox xShow;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.PictureBox Display;
        private System.Windows.Forms.TextBox yShow;
        private System.Windows.Forms.TextBox nbShow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox allPoints;
        private System.Windows.Forms.Button btnCreate;
    }
}

