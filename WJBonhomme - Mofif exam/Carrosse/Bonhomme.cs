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
    class Bonhomme : MonRectangle_tournant
    {
        #region Données bonhomme
        public MonCercle _Tete, _Oeil;

        public MonRectangle_tournant _Sacados;
        public Bras _BrasDroit, _BrasGauche;
        public Jambe _JambeDroite, _JambeGauche;
        public bool decvisibility = false;
        #endregion

        #region Constructeur
        public Bonhomme(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur, 0)
        {  //  (10, 60, 30, 80);
            this._Tete = new MonCercle(hebergeur, xsg + (longueur/2), ysg - (hauteur/5), hauteur / 5, Color.Black, Color.Aquamarine);
            this._Oeil = new MonCercle(hebergeur, xsg/2 + (longueur), ysg - (hauteur / 5), hauteur / 20, Color.Black, Color.White);
            this._JambeDroite = new Jambe(hebergeur, longueur, hauteur + ysg, longueur / 2, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            this._JambeGauche = new Jambe(hebergeur, longueur, hauteur + ysg, longueur / 2, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            this._BrasDroit = new Bras(hebergeur, longueur / 2 + xsg / 2, hauteur - xsg/2, (longueur/3)+xsg/5, hauteur / 2, 0, Color.Black, Color.DarkRed);
            this._BrasGauche = new Bras(hebergeur, longueur / 2 + xsg / 2, hauteur - xsg / 2, (longueur / 3) + xsg / 5, hauteur / 2, 0, Color.Black, Color.DarkRed);
            this._Sacados = new MonRectangle_tournant(hebergeur, xsg-22, hauteur-xsg-8, longueur, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            //this._Snowboard = new snowboard(hebergeur, xsg*10, longueur*7+xsg, longueur*3, hauteur / 3, 0, Color.Black, Color.DarkSlateBlue);
        }
        #endregion


        #region Méthodes
        public override void Cacher(IntPtr handle)
        {
            this._BrasGauche.Cacher(handle);
            base.Cacher(handle);
            this._Tete.Cacher(handle);
            this._Oeil.Cacher(handle);
            //this._Casque.Cacher(handle);
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

        
        #endregion
    }
}
