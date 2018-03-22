using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISET_2018_Decouverte
{
    public partial class FicAide : Form
    {
        public FicAide()
        {
            InitializeComponent();
            lblDescription.AutoSize = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
