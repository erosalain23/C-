using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Carrosse
{
    public partial class EcranAccueil : Form
    {
        private snowboarder ca;
        private animal lapin;
        private Perso2 perso2;

        private BufferedGraphics bufferG = null;
        private Graphics g;

        public EcranAccueil()
        {
            InitializeComponent();
            // Modification contre le scintillement - Creation d'une mémoire tampon graphique
            bufferG = BufferedGraphicsManager.Current.Allocate(TV.CreateGraphics(), TV.DisplayRectangle);
            g = bufferG.Graphics;
        }

        /*private void timerImage_Tick(object sender, EventArgs e)
        {
            if (this.ca.X + this.ca.Longueur >= this.TV.Width)
            {
                this.timerImage.Stop();
                this.btnStopDeplacerCTick.Enabled = false;
            }
            else
            {
                this.ca.Cacher(this.TV.Handle);
                this.ca.Bouger(4, 0);
                this.ca.Afficher(this.TV.Handle);
            }
        }

        private void btnStopDeplacerCTick_Click(object sender, EventArgs e)
        {
            this.timerImage.Stop();
            this.btnStopDeplacerCTick.Enabled = false;
        }*/

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromHwnd(this.TV.Handle);
            gr.FillRectangle(new SolidBrush(this.TV.BackColor), 0, 0, this.TV.Bounds.Width, this.TV.Bounds.Height);
        }
        
        private void btnCreationCarrosse_Click(object sender, EventArgs e)
        {
            //this.dec = new decor(this.TV, 0, 60*7, 30*80, 80*3, 0, Color.White, Color.White);
            //this.dec.Afficher(this.TV.Handle);
            this.ca = new snowboarder(this.TV, 10, 60, 30, 80);
            this.ca.Afficher(this.TV.Handle);

            this.lapin = new animal(this.TV, 850, 300, 30, 30, 0, Color.Black, Color.Brown);
            this.lapin.Afficher(this.TV.Handle);

            this.perso2 = new Perso2(this.TV, 20, 150, 30, 80);
            this.perso2.Afficher(this.TV.Handle);

            this.Act_marche.Enabled = true;
        }

        private void Act_marche_Click(object sender, EventArgs e)
        {
            this.ca.Cacher(this.TV.Handle);
            this.ca.Marcher(4, 0, this.TV.Handle);
            this.ca.Afficher(this.TV.Handle);

            //this.dec.Cacher(this.TV.Handle);
            //this.dec.Bouger(0, 0);
            //this.dec.Afficher(this.TV.Handle);

            this.Act_marche.Enabled = false;
        }

    }
}
