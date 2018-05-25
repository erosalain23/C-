using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;

namespace Carrosse
{
    class Bras : MonRectangle_tournant
    {
        #region Arguments
        private MonRectangle_tournant _Main, _AvantBras;
        #endregion

        #region Constructeurs
        public Bras(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, angle, crayon, pot)
        {
        this._AvantBras = new MonRectangle_tournant(hebergeur, xsg, hauteur + ysg, longueur, hauteur, Alpha, Color.Brown, Color.DarkRed);
        this._Main = new MonRectangle_tournant(hebergeur, xsg, hauteur * 2 + ysg, longueur, hauteur / 4, Alpha, Color.Brown, Color.Black);

        }
        #endregion
    

        #region Méthodes
        public void Bouger(int deplX, int deplY, double angleH, double angleM, double angleB)
        {
            //Angle
            base.Alpha += angleH;
            this._AvantBras.Alpha += angleM; 
            this._Main.Alpha += angleB;
            //Repositionnement des membres
            this._AvantBras.X = base.CIG.X;
            this._AvantBras.Y = base.CIG.Y;
            this._Main.X = this._AvantBras.CIG.X;
            this._Main.Y = this._AvantBras.CIG.Y;

            //Déplacement
            base.Bouger(deplX, deplY);
            this._AvantBras.Bouger(deplX, deplY);
            this._Main.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._AvantBras.Cacher(handle);
            this._Main.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._AvantBras.Afficher(handle);
            this._Main.Afficher(handle);
        }
        #endregion
    }
}
