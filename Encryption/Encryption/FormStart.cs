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
    public partial class FormStart : Form
    {
        public FormStart()
        {
            InitializeComponent();
        }

        /*Useless codes which generated its self , and when i delete them it creates some errors*/
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCheckbox1_OnChange(object sender, EventArgs e)
        {

        }
        /*until here*/

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            FormED fED = new FormED();
            this.Hide();
            fED.ShowDialog();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else WindowState = FormWindowState.Normal;
        }

        private void btnMaxi_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();

        }
    }
}
