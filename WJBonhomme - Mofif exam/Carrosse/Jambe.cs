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
    class Jambe : MonRectangle_tournant
    {
        #region Arguments
        private MonRectangle_tournant _Tibia, _Pied;
     
        #endregion

        #region Constructeurs
        public Jambe(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg/2, ysg, longueur, hauteur, angle, crayon, pot)
        {
            this._Tibia = new MonRectangle_tournant(hebergeur, xsg / 2, ysg + hauteur, longueur, hauteur, Alpha, Color.Brown, Color.DarkRed);
            this._Pied = new MonRectangle_tournant(hebergeur, xsg / 2, ysg + hauteur * 2, longueur * 2, hauteur / 4, Alpha, Color.Brown, Color.Black);
        }

        #endregion

        #region Méthodes
        public void Bouger(int deplX, int deplY, double angleH, double angleM, double angleB)
        {
            //Angle
            base.Alpha += angleH;
            this._Tibia.Alpha += angleM;
            this._Pied.Alpha += angleB;
            //Repositionnement des membres
            this._Tibia.X = base.CIG.X;
            this._Tibia.Y = base.CIG.Y;
            this._Pied.X = this._Tibia.CIG.X;
            this._Pied.Y = this._Tibia.CIG.Y;

            //Déplacement
            base.Bouger(deplX, deplY);
            this._Tibia.Bouger(deplX, deplY);
            this._Pied.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._Tibia.Cacher(handle);
            this._Pied.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._Tibia.Afficher(handle);
            this._Pied.Afficher(handle);
        }
        #endregion
    }
}
