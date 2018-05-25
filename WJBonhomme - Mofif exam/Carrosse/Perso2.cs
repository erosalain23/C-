using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Math;
using System.Threading;

namespace Carrosse
{
    class Perso2 : Bonhomme
    {
        #region Données bonhomme
        public casque _Casque;
        #endregion

        #region Constructeur
        public Perso2(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur)
        {

        }
        #endregion


        #region Méthodes
        public override void Cacher(IntPtr handle)
        {
            this._BrasGauche.Cacher(handle);
            base.Cacher(handle);
            this._Tete.Cacher(handle);
            this._Oeil.Cacher(handle);
            this._Casque.Cacher(handle);
            this._JambeDroite.Cacher(handle);
            this._JambeGauche.Cacher(handle);
            this._Sacados.Cacher(handle);
            this._BrasDroit.Cacher(handle);
        }

        public override void Afficher(IntPtr handle)
        {
            this._BrasGauche.Afficher(handle);
            base.Afficher(handle);
            this._Tete.Afficher(handle);
            this._Oeil.Afficher(handle);
            //this._Casque.Afficher(handle);
            this._JambeDroite.Afficher(handle);
            this._JambeGauche.Afficher(handle);
            this._Sacados.Afficher(handle);
            this._BrasDroit.Afficher(handle);
        }

        public void ProceedMouvementWithSnowboard(int deplX, int deplY, double ajd1, double ajd2, double ajd3, double ajg1, double ajg2, double ajg3, double abd1, double abd2, double abd3, double abg1, double abg2, double abg3, double sa1, double sa2, double sa3, int dx, int dy, IntPtr handle)
        {
            Thread.Sleep(5);
            Cacher(handle);
            //this._Decor.Bouger(dx, dy);
            this._BrasGauche.Bouger(deplX, deplY, abg1, abg2, abg3);
            base.Bouger(deplX, deplY);
            this._Tete.Bouger(deplX, deplY);
            this._Oeil.Bouger(deplX, deplY);
            this._Casque.Bouger(deplX, deplY);
            this._JambeDroite.Bouger(deplX, deplY, ajd1, ajd2, ajd3);
            this._JambeGauche.Bouger(deplX, deplY, ajg1, ajg2, ajg3);
            this._Sacados.Bouger(deplX, deplY);
            this._BrasDroit.Bouger(deplX, deplY, abd1, abd2, abd3);
            Afficher(handle);
            Thread.Sleep(5);
        }
        #endregion
    }
}
