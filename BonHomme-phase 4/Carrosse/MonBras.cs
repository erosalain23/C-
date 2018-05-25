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
    class MonBras : MonRecTournant
    {
        #region Données membres
        //private bool _Remplir = true;
        //private int _Hauteur = 1;
        //private int _Longueur = 1;
        private MonRecTournant avbras, main;
        #endregion

        #region Constructeurs
        public MonBras(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg,longueur,hauteur/2)
        {
            this.avbras = new MonRecTournant(hebergeur, xsg, ysg+28, longueur, hauteur/2,Color.Blue);
            this.main   = new MonRecTournant(hebergeur, xsg, ysg+hauteur, longueur, hauteur/4,Color.Yellow);
        }
        public MonBras(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur,double AH,double AB) : base(hebergeur, xsg, ysg, longueur, hauteur / 2,AH)
        {
            this.avbras = new MonRecTournant(hebergeur, xsg, ysg + hauteur, longueur, hauteur / 4, Color.Blue,AB);
            this.main = new MonRecTournant(hebergeur, xsg, ysg + hauteur / 2, longueur, hauteur -10, Color.Yellow,AB);
        }
        #endregion
        #region Méthodes
        public void Bouger(int deplX, int deplY , double AH , double AB )
        {
            base.Bouger(deplX, deplY , AH);
            this.avbras.X = base.CIG.X;
            this.avbras.Y = base.CIG.Y;
            avbras.Bouger(0, 0, AB);
            avbras.Bouger(base.CIM.X - avbras.CSM.X, base.CIM.Y - avbras.CSM.Y, 0);
            this.main.X = this.avbras.CIG.X;
            this.main.Y = this.avbras.CIG.Y;
            main.Bouger(0, 0, AB);
            main.Bouger(avbras.CIM.X - main.CSM.X, avbras.CIM.Y - main.CSM.Y, 0);

        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this.avbras.Cacher(handle);
            this.main.Cacher(handle);
           
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this.avbras.Afficher(handle);
            this.main.Afficher(handle);
            
        }
        #endregion
    }

}
