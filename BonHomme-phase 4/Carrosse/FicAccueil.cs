using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Carrosse
{
    public partial class EcranAccueil : Form
    {
        private MonCarrosse ca;
        private MonHomme ho;
        private MaBalle ba;
        private BufferedGraphics bufferG = null;
        private Graphics g;

        public EcranAccueil()
        {
            InitializeComponent();
            // Modification contre le scintillement - Creation d'une mémoire tampon graphique
            bufferG = BufferedGraphicsManager.Current.Allocate(TV.CreateGraphics(), TV.DisplayRectangle);
            g = bufferG.Graphics;
        }

        private void timerImage_Tick(object sender, EventArgs e)
        {
            // i replaced the ho(homme) object with the ca(carrousse)
            if (this.ba.X + this.ba.Rayon >= this.TV.Width)
            {
                this.timerImage.Stop();
                this.btnStopDeplacerCTick.Enabled = false;
            }
            else
            {
                this.ba.Cacher(this.TV.Handle);
                this.ba.Bouger(4, 0);
                // this.ho.Bouger(4, 0, -0.1, 0.3, -0.3, +0.3, +0.3, -0.3, +0.1, -0.1);
                this.ba.Afficher(this.TV.Handle);
            }
        }


        private void btnStopDeplacerCTick_Click(object sender, EventArgs e)
        {
            this.timerImage.Stop();
            this.btnStopDeplacerCTick.Enabled = false;
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            Graphics gr = Graphics.FromHwnd(this.TV.Handle);
            gr.FillRectangle(new SolidBrush(this.TV.BackColor), 0, 0, this.TV.Bounds.Width, this.TV.Bounds.Height);
        }

        private void btnCreationCarrosse_Click(object sender, EventArgs e)
        {
            this.ca = new MonCarrosse(this.TV, 10, 75, 140, 60);
            this.ca.Afficher(this.TV.Handle);
            this.btnStopDeplacerCTick.Enabled = true;
            this.timerImage.Start();            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.ho = new MonHomme(this.TV, 180, 72, 40, 80);
            this.ho.Afficher(this.TV.Handle);
            this.btnStopDeplacerCTick.Enabled=true;
         //   this.timerImage.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            for(int j = 0; j < 5; j++)
            {
                marche();
            }
        }
        private void marche()
        {
            int i;
            for (i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 0:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, 0, 0, 0, 0, 0, 0, 0, 0);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 1:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, -1, -0.5, 1, 1.5, 0.7, 0.4, -0.6, -0.9);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 2:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, 0.4, 0.2, -0.2, -0.5, -0.2, -0.2, 0.3, 0.1);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 3:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, 0.4, 0.4, -0.8, 0.2, -0.2, -0.2, 0.3, 0.1);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 4:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, 0.7, 0.7, -1.5, -0.8, -0.4, -0.4, 0.7, 1);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 5:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, 0.1, 0.4, 0.1, -0.9, -0.4, -0.4, -0.3, -0.3);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 6:
                        this.ho.Cacher(this.TV.Handle);
                        this.ho.Bouger(4, 0, -0.6, -1.2, 0.9, 0.5, 0.5, 0.8, -0.4, 0);
                        this.ho.Afficher(this.TV.Handle);
                        Thread.Sleep(200);
                        break;
                    case 7:
                        i = 1;
                        break;

                    default:
                        MessageBox.Show("Fin");
                        break;
                }

            }
        }
        private void TV_Click(object sender, EventArgs e)
        {

        }

        private void buttonBallon_Click(object sender, EventArgs e)
        {
            this.ba = new MaBalle(this.TV, 400, 210, 15);
            this.ba.Afficher(this.TV.Handle);
            this.btnStopDeplacerCTick.Enabled = true;
        }

        private void buttonJouer_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 5; j++)
            {
                marche();
                if (j == 4)
                {
                    jouer();
                }
            }
            //this.timerImage.Start();
        }
        private void jouer()
        {
            this.ba.Cacher(this.TV.Handle);
            this.ba.Bouger(4, 0);
            this.ba.Afficher(this.TV.Handle);
            this.timerImage.Interval = 20;
            this.timerImage.Start();
            Thread.Sleep(200);

        }
    }
}
