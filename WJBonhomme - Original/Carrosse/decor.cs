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
    class decor : MonRectangle_tournant
    {
        #region Arguments
        private MonRectangle_tournant _part1, _part2, _part3, _part4, _part5, _part6, _part7, _part8;
        private MonCercle _Sun;
        #endregion

        #region Constructeurs
        public decor(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, angle, crayon, pot)
        {
            this._part1 = new MonRectangle_tournant(hebergeur, xsg, hauteur + ysg/2, longueur/2, hauteur, Alpha, Color.Brown, Color.White);
            this._part2 = new MonRectangle_tournant(hebergeur, xsg, hauteur + ysg/4, longueur/8, hauteur, Alpha, Color.Brown, Color.White);
            this._part3 = new MonRectangle_tournant(hebergeur, xsg, hauteur, longueur/10, hauteur, Alpha, Color.Brown, Color.White);
            this._part4 = new MonRectangle_tournant(hebergeur, xsg, hauteur + ysg / 9, longueur / 10, hauteur, Alpha, Color.Brown, Color.White);
            this._part5 = new MonRectangle_tournant(hebergeur, xsg+900, hauteur + ysg/2, longueur / 9, hauteur, Alpha, Color.Brown, Color.White);
            this._part6 = new MonRectangle_tournant(hebergeur, xsg + 1100, hauteur + ysg / 2, longueur / 15, hauteur, Alpha, Color.Brown, Color.White);
            this._part7 = new MonRectangle_tournant(hebergeur, xsg + 1200, hauteur + ysg / 2, longueur / 4, hauteur, Alpha, Color.Brown, Color.White);
            this._part8 = new MonRectangle_tournant(hebergeur, xsg + 1550, hauteur + ysg / 3, longueur / 2, hauteur, Alpha, Color.Brown, Color.White);
            this._Sun = new MonCercle(hebergeur, xsg + 900, ysg /12, hauteur / 5, Color.Yellow, Color.Yellow);

        }
        #endregion


        #region Méthodes
        public new void Bouger(int deplX, int deplY)
        {
            //Déplacement
            base.Bouger(deplX, deplY);
            this._part1.Bouger(deplX, deplY);
            this._part2.Bouger(deplX, deplY);
            this._part3.Bouger(deplX, deplY);
            this._part4.Bouger(deplX, deplY);
            this._part5.Bouger(deplX, deplY);
            this._part6.Bouger(deplX, deplY);
            this._part7.Bouger(deplX, deplY);
            this._part8.Bouger(deplX, deplY);
            this._Sun.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._part1.Cacher(handle);
            this._part2.Cacher(handle);
            this._part3.Cacher(handle);
            this._part4.Cacher(handle);
            this._part5.Cacher(handle);
            this._part6.Cacher(handle);
            this._part7.Cacher(handle);
            this._part8.Cacher(handle);
            this._Sun.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._part1.Afficher(handle);
            this._part2.Afficher(handle);
            this._part3.Afficher(handle);
            this._part4.Afficher(handle);
            this._part5.Afficher(handle);
            this._part6.Afficher(handle);
            this._part7.Afficher(handle);
            this._part8.Afficher(handle);
            this._Sun.Afficher(handle);

        }
        #endregion
    }
}
