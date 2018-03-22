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
    public partial class FormED : Form
    {
        public string normalMessage;
        public FormED()
        {
            InitializeComponent();
        }

        /*Uselss codes again that generates itself*/
        
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }
        /*until here*/

        //button for minimizing the window
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else WindowState = FormWindowState.Normal;
        }
        //button for maximizing the window
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) {
                WindowState = FormWindowState.Maximized;
            }
        }
        // closing button 
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            int count = 0;
            FormKey fk = new FormKey(MessageData.Text);
            FormKey fKey = new FormKey();

            do
            {   
                fKey.ShowDialog();
                count++;
                if (count == 3) {
                    MessageBox.Show("Attempts finished");
                    fKey.Close();
                }
            }
            while (!fKey.passCorrect);
           // MessageBox.Show(MessageData.Text);// for testing
         
        }

        private void MessageData_OnValueChanged(object sender, EventArgs e)
        {
           
        }
    }
}
