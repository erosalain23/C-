using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encryption
{
    public partial class FormKey : Form
    {
        public string passwordKey;
        public string tries;
        public bool passCorrect = false;
        public string normalMessage;
        public FormKey( string _normalMessage)
        {
            this.normalMessage = _normalMessage;
            //MessageBox.Show(this.normalMessage);// for testing
        }
        public FormKey()
        {
            InitializeComponent();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            this.passwordKey = bunifuMaterialTextbox1.Text;
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            this.tries = bunifuCustomLabel2.Text;
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int count = 0;
            char[] encMsg = new char[normalMessage.Length];
            if (bunifuMaterialTextbox1.Text == "people11")
            {
                this.passCorrect = true;
                MessageBox.Show("Encrypting the message");
                foreach ( char c in normalMessage)
                {
                    int i = 0;
                    encMsg[i] = normalMessage[i];
                }
                MessageBox.Show(encMsg.ToString());
                this.Close();

            }
            else
            {
                count++;
                this.Close();
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}