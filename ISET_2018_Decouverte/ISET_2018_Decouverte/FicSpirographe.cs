using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Threading;

namespace ISET_2018_Decouverte
{
    public partial class EcranSpirographe : Form
    {
        private Color Fond, Trait;
        private GraphicsPath GraphEnr = null;//pour enregistre le graphic

        private double d(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
        }

        private void btnTrait_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Trait;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Trait = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            dlgCouleur.Color = Fond;
            if (dlgCouleur.ShowDialog() == DialogResult.OK)
            {
                Fond = dlgCouleur.Color;
                Invalidate();
            }
        }

        private void EcranSpirographe_Paint(object sender, PaintEventArgs e)
        {
            if (GraphEnr != null)
            {
                Rectangle zone = new Rectangle(new Point(248,0),ClientSize);
                e.Graphics.FillRectangle(new SolidBrush(Fond), zone);
                e.Graphics.DrawPath(new Pen(Trait), GraphEnr);
            }
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            int nSom = tbNbSommets.Value;
            int nDen = tbDensite.Value;
            int nPro = 100-tbProfondeur.Value;// dans l'autre sens  80 shapes
            GraphEnr = new GraphicsPath();
            Rectangle zone = new Rectangle(new Point(248, 0), ClientSize);
            Graphics gr = CreateGraphics();
            gr.FillRectangle(new SolidBrush(Fond), zone);
            int xc = 248+(ClientSize.Width - 248) / 2;//determination of the center
            int yc = ClientSize.Height / 2;
            int rayon = 9*Math.Min(ClientSize.Width-248,ClientSize.Height)/20;//
            float[] sX = new float[nSom + 1];
            float[] sY = new float[nSom + 1];
            for (int i = 0; i <= nSom; i++)
            {
                sX[i] = (int)(xc + rayon * Math.Cos(2 * Math.PI * i / nSom));
                sY[i] = (int)(yc + rayon * Math.Sin(2 * Math.PI * i / nSom));
            }
            while (d(sX[0],sY[0],xc,yc)>rayon*nPro/100)
            {
                //Dessine
                for(int i = 1; i <= nSom; i++)
                {
                    gr.DrawLine(new Pen(Trait), sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    GraphEnr.AddLine(sX[i - 1], sY[i - 1], sX[i], sY[i]);
                    Application.DoEvents();
                    Thread.Sleep(15);
                }
                //calcule
                for(int i =0; i<nSom; i++)
                {
                    sX[i] = sX[i] + (sX[1 + i] - sX[i]) / nDen;// augmente la distance 
                    sY[i] = sY[i] + (sY[1 + i] - sY[i]) / nDen;
                }
                sX[nSom] = sX[0];
                sY[nSom] = sY[0];
            }
        }

        public EcranSpirographe()
        {
            InitializeComponent();
            Fond = Color.DarkBlue;
            Trait = Color.Cyan;
        }
    }
}
