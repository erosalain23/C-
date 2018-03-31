using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Toc_TOE
{
    public partial class Message_Box : Form
    {
        public Message_Box(string message)
        {
            InitializeComponent();
            lblMessage.Text = message;
        }
    }
}
