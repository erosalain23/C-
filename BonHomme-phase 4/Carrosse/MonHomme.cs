using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Carrosse
{
    class MonHomme : MonRecTournant
    {

        private MonCercle head,eye;
        private MonRectangle mouth ;
        private MonBras armG, armD;
        private MaJambe legD,legG;

        public MonHomme(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur-5, hauteur)
        {
            this.head = new MonCercle(hebergeur, (xsg+longueur/2), (ysg + hauteur)/3, hauteur / 4, Color.Brown, Color.Blue);
            this.eye = new MonCercle(hebergeur, (xsg + longueur-2), (ysg + hauteur) / 3, hauteur / 25, Color.Black, Color.White);
            this.mouth = new MonRectangle(hebergeur, xsg + longueur-15 , ysg - hauteur / 8, Longueur / 5, hauteur / 40,Color.White);
            this.armD = new MonBras(hebergeur, xsg + longueur / 3, ysg + hauteur/5, Longueur / 3, hauteur-30);
            this.armG = new MonBras(hebergeur, xsg + longueur / 3, ysg + hauteur/5, Longueur / 3, hauteur-30);
            this.legD = new MaJambe(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 2, hauteur / 2);
            this.legG = new MaJambe(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 2, hauteur / 2);
            //this.shoeD = new MonRectangle(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 4, hauteur / 8,Color.Yellow);
            //this.shoeG = new MonRectangle(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 4, hauteur / 8,Color.Yellow);
        }
        public MonHomme(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur,double ABGH, double ABGB, double ABDH, double ABDB, double AJGH, double AJGB, double AJDH, double AJDB) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {
            this.head = new MonCercle(hebergeur, (xsg + longueur / 2), (ysg + hauteur) / 3, hauteur / 4, Color.Brown, Color.Blue);
            this.eye = new MonCercle(hebergeur, (xsg + longueur - 2), (ysg + hauteur) / 3, hauteur / 25, Color.Black, Color.White);
            this.mouth = new MonRectangle(hebergeur, xsg + longueur / 2, ysg - hauteur / 8, Longueur / 5, hauteur / 40, Color.White);
            this.armD = new MonBras(hebergeur, xsg + longueur / 3, ysg + hauteur / 5, Longueur / 4, hauteur / 2 , ABGH , ABGB);
            this.armG = new MonBras(hebergeur, xsg + longueur / 3, ysg + hauteur / 5, Longueur / 4, hauteur / 2 , ABDH , ABDB);
            this.legD = new MaJambe(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 3, hauteur / 2 , AJDH , AJDB);
            this.legG = new MaJambe(hebergeur, xsg + longueur / 3, ysg + hauteur, Longueur / 3, hauteur / 2 , AJGH , AJGB);
        }

        //methodes
        public void Bouger(int deplX, int deplY, double ABGH, double ABGB, double ABDH, double ABDB, double AJGH, double AJGB, double AJDH, double AJDB)
        {
            this.armG.Bouger(deplX, deplY, ABDH, ABDB);
            this.legD.Bouger(deplX, deplY, AJDH, AJDB);
            base.Bouger(deplX, deplY);
            this.eye.Bouger(deplX, deplY);
            this.mouth.Bouger(deplX, deplY);
            this.head.Bouger(deplX, deplY);
            this.armD.Bouger(deplX, deplY, ABGH, ABGB);
            this.legG.Bouger(deplX, deplY, AJGH, AJGB);

        }
        public new void Cacher(IntPtr handle)
        {
            this.armG.Cacher(handle);
            this.legG.Cacher(handle);
            base.Cacher(handle);
            this.eye.Cacher(handle);
            this.mouth.Cacher(handle);
            this.head.Cacher(handle);
            this.armD.Cacher(handle);
            this.legD.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            this.armG.Afficher(handle);
            this.legG.Afficher(handle);
            base.Afficher(handle);
            this.head.Afficher(handle);
            this.eye.Afficher(handle);
            this.mouth.Afficher(handle);
            this.armD.Afficher(handle);
            this.legD.Afficher(handle);

        }

        // animating function
       
    }
}
