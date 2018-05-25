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
    class casque : MonRectangle_tournant
    {
        #region Arguments
        private MonRectangle_tournant _part1;
        #endregion

        #region Constructeurs
        public casque(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg, longueur, hauteur, angle, crayon, pot)
        {
            this._part1 = new MonRectangle_tournant(hebergeur, xsg, hauteur + ysg, longueur/3, hauteur, Alpha, Color.Brown, Color.DarkRed);
            //this._part2 = new MonRectangle_tournant(hebergeur, xsg*3, hauteur+xsg, longueur/3, hauteur, Alpha, Color.Brown, Color.White);

        }
        #endregion


        #region Méthodes
        public new void Bouger(int deplX, int deplY)
        {
            //Angle
            //base.Alpha += angleH;
            //this._part1.Alpha += angleM;
            //this._part2.Alpha += angleB;
            //Repositionnement des membres
            this._part1.X = base.CIG.X;
            this._part1.Y = base.CIG.Y;
            //this._part2.X = this._part1.CIG.X;
            //this._part2.Y = this._part1.CIG.Y;


            //Déplacement
            base.Bouger(deplX, deplY);
            this._part1.Bouger(deplX, deplY);
            //this._part2.Bouger(deplX, deplY);
        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this._part1.Cacher(handle);
            //this._part2.Cacher(handle);
        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this._part1.Afficher(handle);
            //this._part2.Afficher(handle);
        }
        #endregion



    }
}
