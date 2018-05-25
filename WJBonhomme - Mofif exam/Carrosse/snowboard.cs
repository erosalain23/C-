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
    class snowboard : MonRectangle_tournant
    {
        #region Arguments
        private MonRectangle_tournant _part1, _part2;
        #endregion

        #region Constructeurs
        public snowboard(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, angle, crayon, pot)
        {
            this._part1 = new MonRectangle_tournant(hebergeur, xsg, ysg-10, longueur / 3, hauteur, Alpha, Color.Brown, Color.DarkGray);
            this._part2 = new MonRectangle_tournant(hebergeur, xsg+60, ysg-10, longueur / 3, hauteur, Alpha, Color.Brown, Color.DarkGray);
        }
        #endregion


        #region Méthodes
        public void Bouger(int deplX, int deplY, double angleH, double angleM, double angleB)
        {
            //Angle
            base.Alpha += angleH;
            this._part1.Alpha += angleM;
            this._part2.Alpha += angleB;

            base.Bouger(deplX, deplY);
            this._part1.Bouger(deplX, deplY);
            this._part2.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._part1.Cacher(handle);
            this._part2.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._part1.Afficher(handle);
            this._part2.Afficher(handle);
        }
        #endregion



    }
}
