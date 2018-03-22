namespace EncDecApp
{
    partial class Form1
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
            this.encBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.encLabel = new MaterialSkin.Controls.MaterialLabel();
            this.myCrypt = new MaterialSkin.Controls.MaterialCheckBox();
            this.builtInCrypt = new MaterialSkin.Controls.MaterialCheckBox();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.tabs = new MaterialSkin.Controls.MaterialTabControl();
            this.encControl = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabSelectore = new MaterialSkin.Controls.MaterialTabSelector();
            this.tabs.SuspendLayout();
            this.encControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // encBtn
            // 
            this.encBtn.AutoSize = true;
            this.encBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.encBtn.Depth = 0;
            this.encBtn.Location = new System.Drawing.Point(477, 611);
            this.encBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.encBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.encBtn.Name = "encBtn";
            this.encBtn.Primary = false;
            this.encBtn.Size = new System.Drawing.Size(105, 36);
            this.encBtn.TabIndex = 0;
            this.encBtn.Text = "Encrypt";
            this.encBtn.UseVisualStyleBackColor = true;
            // 
            // encLabel
            // 
            this.encLabel.AutoSize = true;
            this.encLabel.Depth = 0;
            this.encLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.encLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.encLabel.Location = new System.Drawing.Point(482, 88);
            this.encLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.encLabel.Name = "encLabel";
            this.encLabel.Size = new System.Drawing.Size(62, 27);
            this.encLabel.TabIndex = 1;
            this.encLabel.Text = "Logo";
            // 
            // myCrypt
            // 
            this.myCrypt.AutoSize = true;
            this.myCrypt.Depth = 0;
            this.myCrypt.Font = new System.Drawing.Font("Roboto", 10F);
            this.myCrypt.Location = new System.Drawing.Point(242, 449);
            this.myCrypt.Margin = new System.Windows.Forms.Padding(0);
            this.myCrypt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.myCrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.myCrypt.Name = "myCrypt";
            this.myCrypt.Ripple = true;
            this.myCrypt.Size = new System.Drawing.Size(121, 30);
            this.myCrypt.TabIndex = 2;
            this.myCrypt.Text = "eCrytpion";
            this.myCrypt.UseVisualStyleBackColor = true;
            // 
            // builtInCrypt
            // 
            this.builtInCrypt.AutoSize = true;
            this.builtInCrypt.Depth = 0;
            this.builtInCrypt.Font = new System.Drawing.Font("Roboto", 10F);
            this.builtInCrypt.Location = new System.Drawing.Point(655, 449);
            this.builtInCrypt.Margin = new System.Windows.Forms.Padding(0);
            this.builtInCrypt.MouseLocation = new System.Drawing.Point(-1, -1);
            this.builtInCrypt.MouseState = MaterialSkin.MouseState.HOVER;
            this.builtInCrypt.Name = "builtInCrypt";
            this.builtInCrypt.Ripple = true;
            this.builtInCrypt.Size = new System.Drawing.Size(110, 30);
            this.builtInCrypt.TabIndex = 3;
            this.builtInCrypt.Text = "msCrypt";
            this.builtInCrypt.UseVisualStyleBackColor = true;
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(11, 131);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(1053, 10);
            this.materialDivider1.TabIndex = 4;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(11, 247);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(1053, 32);
            this.materialSingleLineTextField1.TabIndex = 5;
            this.materialSingleLineTextField1.Text = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.encControl);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Depth = 0;
            this.tabs.Location = new System.Drawing.Point(3, 182);
            this.tabs.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1087, 942);
            this.tabs.TabIndex = 6;
            // 
            // encControl
            // 
            this.encControl.BackColor = System.Drawing.Color.White;
            this.encControl.Controls.Add(this.encLabel);
            this.encControl.Controls.Add(this.encBtn);
            this.encControl.Controls.Add(this.builtInCrypt);
            this.encControl.Controls.Add(this.materialSingleLineTextField1);
            this.encControl.Controls.Add(this.myCrypt);
            this.encControl.Controls.Add(this.materialDivider1);
            this.encControl.Location = new System.Drawing.Point(4, 29);
            this.encControl.Name = "encControl";
            this.encControl.Padding = new System.Windows.Forms.Padding(3);
            this.encControl.Size = new System.Drawing.Size(1079, 909);
            this.encControl.TabIndex = 0;
            this.encControl.Text = "Encryption";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1079, 909);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Decryption";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabSelectore
            // 
            this.tabSelectore.BaseTabControl = this.tabs;
            this.tabSelectore.Depth = 0;
            this.tabSelectore.Location = new System.Drawing.Point(-4, 99);
            this.tabSelectore.MouseState = MaterialSkin.MouseState.HOVER;
            this.tabSelectore.Name = "tabSelectore";
            this.tabSelectore.Size = new System.Drawing.Size(1094, 47);
            this.tabSelectore.TabIndex = 7;
            this.tabSelectore.Text = "materialTabSelector1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 1045);
            this.Controls.Add(this.tabSelectore);
            this.Controls.Add(this.tabs);
            this.Location = new System.Drawing.Point(100, 0);
            this.Name = "Form1";
            this.Text = "ENC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabs.ResumeLayout(false);
            this.encControl.ResumeLayout(false);
            this.encControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialFlatButton encBtn;
        private MaterialSkin.Controls.MaterialLabel encLabel;
        private MaterialSkin.Controls.MaterialCheckBox myCrypt;
        private MaterialSkin.Controls.MaterialCheckBox builtInCrypt;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private MaterialSkin.Controls.MaterialTabControl tabs;
        private System.Windows.Forms.TabPage encControl;
        private System.Windows.Forms.TabPage tabPage2;
        private MaterialSkin.Controls.MaterialTabSelector tabSelectore;
    }
}

