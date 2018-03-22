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
    public partial class EcranHorloge : Form
    {
        public EcranHorloge()
        {
            InitializeComponent();
        }

        private void Chronometre_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void EcranHorloge_Load(object sender, EventArgs e)
        {
            this.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }

        private void EcranHorloge_Paint(object sender, PaintEventArgs e)
        {
            int width = 400, height = 400, x = this.ClientSize.Width / 2, y = this.ClientSize.Height / 2;
            Pen bp = new Pen(Color.Black, 2);
            Graphics g;
            g = e.Graphics;
            //Point pt = new Point(10, 10);
            //Rectangle rect = new Rectangle(100,200, 3,4);
            e.Graphics.DrawEllipse(bp, x, y, width,height);
            //DrawCircle(g, bp, this.ClientSize.Width / 2, this.ClientSize.Height / 2, 10);
            e.Graphics.DrawLine(bp, width/2, height/2, 300, 300);
            
        }
        

    }
}
