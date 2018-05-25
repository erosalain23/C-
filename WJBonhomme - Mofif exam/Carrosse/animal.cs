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
    class animal : MonRectangle_tournant
    {
        #region Arguments
        private MonCercle _Tete, _OeilG, _OeilD;
        private MonRectangle_tournant _OrG, _OrD, _PatG, _PatD;
        #endregion

        #region Constructeurs
        public animal(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, angle, crayon, pot)
        {
            this._Tete = new MonCercle(hebergeur, xsg+15, ysg, hauteur / 2, Color.Black, Color.Brown);
            this._OeilG = new MonCercle(hebergeur, xsg+8, ysg, hauteur / 7, Color.Brown, Color.White);
            this._OeilD = new MonCercle(hebergeur, xsg + 22, ysg, hauteur / 7, Color.Brown, Color.White);
            this._OrG = new MonRectangle_tournant(hebergeur, xsg, ysg-40, longueur / 3, hauteur, Alpha, Color.Brown, Color.Brown);
            this._OrD = new MonRectangle_tournant(hebergeur, xsg+20, ysg-40, longueur / 3, hauteur, Alpha, Color.Brown, Color.Brown);
            this._PatG = new MonRectangle_tournant(hebergeur, xsg, ysg+25, longueur / 3, hauteur, Alpha, Color.Brown, Color.Brown);
            this._PatD = new MonRectangle_tournant(hebergeur, xsg + 20, ysg + 25, longueur / 3, hauteur, Alpha, Color.Brown, Color.Brown);
        }
        #endregion


        #region Méthodes
        public void Bouger(int deplX, int deplY, double angleH, double angleM, double angleB)
        {
            //Angle
            //base.Alpha += angleH;
            //this._OrG.Alpha += angleM;
            //this._OrD.Alpha += angleB;

            base.Bouger(deplX, deplY);
            this._Tete.Bouger(deplX, deplY);
            this._OeilG.Bouger(deplX, deplY);
            this._OeilD.Bouger(deplX, deplY);
            this._OrG.Bouger(deplX, deplY);
            this._OrD.Bouger(deplX, deplY);
            this._PatG.Bouger(deplX, deplY);
            this._PatD.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._Tete.Cacher(handle);
            this._OeilG.Cacher(handle);
            this._OeilD.Cacher(handle);
            this._OrG.Cacher(handle);
            this._OrD.Cacher(handle);
            this._PatG.Cacher(handle);
            this._PatD.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._Tete.Afficher(handle);
            this._OeilG.Afficher(handle);
            this._OeilD.Afficher(handle);
            this._OrG.Afficher(handle);
            this._OrD.Afficher(handle);
            this._PatG.Afficher(handle);
            this._PatD.Afficher(handle);
        }
        #endregion
    }
}
