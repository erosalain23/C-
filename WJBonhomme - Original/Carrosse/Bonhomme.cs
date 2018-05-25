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
        MonCercle _Tete, _Oeil;
        casque _Casque;
        snowboard _Snowboard;
        decor _Decor;
        MonRectangle_tournant _Sacados;
        Bras _BrasDroit, _BrasGauche;
        Jambe _JambeDroite, _JambeGauche;
        #endregion

        #region Constructeur
        public Bonhomme(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur, 0)
        {  //  (10, 60, 30, 80);
            this._Decor = new decor(hebergeur, 0, longueur * 7, longueur * 80, hauteur * 3, 0, Color.White, Color.White);
            this._Casque = new casque(hebergeur, (longueur/2)-5, (hauteur/4)-2, longueur, hauteur / 4, 0, Color.Black, Color.DarkRed);
            this._Tete = new MonCercle(hebergeur, xsg + (longueur/2), ysg - (hauteur/5), hauteur / 5, Color.Black, Color.Aquamarine);
            this._Oeil = new MonCercle(hebergeur, xsg/2 + (longueur), ysg - (hauteur / 5), hauteur / 20, Color.Black, Color.White);
            this._JambeDroite = new Jambe(hebergeur, longueur, hauteur + ysg, longueur / 2, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            this._JambeGauche = new Jambe(hebergeur, longueur, hauteur + ysg, longueur / 2, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            this._BrasDroit = new Bras(hebergeur, longueur / 2 + xsg / 2, hauteur - xsg/2, (longueur/3)+xsg/5, hauteur / 2, 0, Color.Black, Color.DarkRed);
            this._BrasGauche = new Bras(hebergeur, longueur / 2 + xsg / 2, hauteur - xsg / 2, (longueur / 3) + xsg / 5, hauteur / 2, 0, Color.Black, Color.DarkRed);
            this._Sacados = new MonRectangle_tournant(hebergeur, xsg-22, hauteur-xsg-8, longueur, hauteur / 2, 0, Color.Black, Color.DarkSlateGray);
            this._Snowboard = new snowboard(hebergeur, xsg*10, longueur*7+xsg, longueur*3, hauteur / 3, 0, Color.Black, Color.DarkSlateBlue);
        }
        #endregion


        #region Méthodes
        public new void Cacher(IntPtr handle)
        {
            this._Decor.Cacher(handle);
            this._Snowboard.Cacher(handle);
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

        public new void Afficher(IntPtr handle)
        {
            this._Decor.Afficher(handle);
            this._Snowboard.Afficher(handle);
            this._BrasGauche.Afficher(handle);
            base.Afficher(handle);
            this._Tete.Afficher(handle);
            this._Oeil.Afficher(handle);
            this._Casque.Afficher(handle);
            this._JambeDroite.Afficher(handle);
            this._JambeGauche.Afficher(handle);
            this._Sacados.Afficher(handle);
            this._BrasDroit.Afficher(handle);
        }

        public void Marcher(int deplX, int deplY, IntPtr handle)
        {
                                                 //ajbd,            ajg,                abd,             abg 
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    -0.05, -0.1, -0.05,     -0.2, -0.1, 0,     0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    -0.05, -0.1, -0.05,     -0.05, -0.1, 0,     0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.2, 0.05, 0,    -0.05, -0.1, -0.05,     -0.05, -0.1, 0,     0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0, 0.05, 0,    -0.05, -0.1, -0.05,     -0.05, -0.1, 0,     0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0, 0.1, 0,    -0.05, -0.1, -0.05,     -0.05, -0.1, 0,     0.05, 0.1, 0, handle);

            ProceedMouvement(deplX, deplY, -0, -0.1, 0,   0.05, 0.1, 0.05,    0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0, -0.05, 0,   0.05, 0.1, 0.05,    0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.2, -0.05, 0,   0.05, 0.1, 0.05,    0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0.05, 0.1, 0.05,    0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0.05, 0.1, 0.05,    0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            //1 mouvement complet d'une jambe

            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0.1, 0.1, 0.05,  0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0.1, 0.1, 0.05,  0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0.2, 0.1, 0.05,  0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0, 0.1, 0.05,  0.05, 0.1, 0,   -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0,   0, 0.1, 0.05,  0.05, 0.1, 0,   -0.05, -0.1, 0, handle);

            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    0, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    0, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    -0.2, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    -0.1, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0,    -0.1, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            //OK
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0, -0.05, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0, -0.05, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0, -0.05, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0, -0.05, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);
            ProceedMouvement(deplX, deplY, 0.1, 0.05, 0, -0.05, -0.1, -0.05, -0.05, -0.1, 0, 0.05, 0.1, 0, handle);

            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0, 0.05, 0.1, 0.05, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0, 0.05, 0.1, 0.05, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0, 0.05, 0.1, 0.05, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0, 0.05, 0.1, 0.05, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(deplX, deplY, -0.1, -0.05, 0, 0.05, 0.1, 0.05, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);

            //ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            //ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            //ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            //ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            //ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);

            ProceedMouvement(0, 0, -0.1, -0.2, 0, 0.2, -0.3, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.3, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);
            ProceedMouvement(0, 0, -0.1, -0.05, 0, 0.05, 0.1, 0, 0.05, 0.1, 0, -0.05, -0.1, 0, handle);

            //Transition lève les mains en l'air
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0,     0.4, 0.2, 0,    0.9, 0.9, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0,     0.4, 0.4, 0.4,  0.9, 0.9, 0.4, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0,     0.6, 0.5, 0.4,  0.9, 0.9, 0.4, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0,     0.6, 0.4, 0,   0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0,     0, 0, 0,    0, 0, 0, handle);

            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, -0.4, -0.2, 0, -0.9, -0.9, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, -0.4, -0.4, -0.4, -0.9, -0.9, -0.4, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, -0.6, -0.5, -0.4, -0.9, -0.9, -0.4, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, -0.6, -0.4, 0, 0, 0, 0, handle);
            ProceedMouvement(0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            //With snowboard
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, -0.1, 0,    0.05, 0.1, 0, -0.05, -0.1, 0,   0, 0, 0,     0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, -0.1, 0,    0.05, 0.1, 0, -0.05, -0.1, 0,   0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0,    0.05, 0.1, 0, -0.05, -0.1, 0,   0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0,    0.05, 0.1, 0, -0.05, -0.1, 0,   0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0,    0.05, 0.1, 0, -0.05, -0.1, 0,   0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,     0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,     0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(deplX, 3, 0, 0,   0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, 3, 0, 0,    0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(deplX, deplY, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(6, 3, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(6, 3, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.2, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(8, 9, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(8, 9, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(8, 9, 0, 0, 0,     0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(8, 4, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(10, 3, 0, 0, 0,    0, -0.1, 0, 0, 0, 0, 0, 0, 0.2, 0, -0.1, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(10, 3, 0, 0, 0,   0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(17, 3, 0, 0, 0,    0, -0.2, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(19, 7, 0, 0, 0,   0, -0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(19, 3, 0, 0, 0, 0, 0, 0, 0.2, 0, 0, 0.1, 0, -0.2, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(19, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.2, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(19, 4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(19, 4, 0, 0, 0, 0, 0, 0, -0.5, 0, 0, 0.3, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(19, -5, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0,    0, 0.1, 0, 0.3, 0, 0, -0.3, 0, 0, 0, 0.1, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0,    0, 0.1, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(14, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(13, deplY, 0, 0, 0,    0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(12, -8, 0, 0, 0,   0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(12, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(12, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(12, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(12, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, handle);
            ProceedMouvementWithSnowboard(12, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -0.1, 0, 0, 0, 0, handle);

            ProceedMouvementWithSnowboard(5, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, -4, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0.1, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(2, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(3, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(7, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(10, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);

            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(15, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, deplY, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
            ProceedMouvementWithSnowboard(13, -8, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, -10, 0, handle);
        }

        public void ProceedMouvement(int deplX, int deplY, double ajd1, double ajd2, double ajd3, double ajg1, double ajg2, double ajg3, double abd1, double abd2, double abd3, double abg1, double abg2, double abg3, IntPtr handle)
        {
            Thread.Sleep(10);
            Cacher(handle);
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
            Thread.Sleep(10);
        }

        public void ProceedMouvementWithSnowboard(int deplX, int deplY, double ajd1, double ajd2, double ajd3, double ajg1, double ajg2, double ajg3, double abd1, double abd2, double abd3, double abg1, double abg2, double abg3, double sa1, double sa2, double sa3, int dx, int dy, IntPtr handle)
        {
            Thread.Sleep(5);
            Cacher(handle);
            this._Decor.Bouger(dx, dy);
            this._BrasGauche.Bouger(deplX, deplY, abg1, abg2, abg3);
            base.Bouger(deplX, deplY);
            this._Tete.Bouger(deplX, deplY);
            this._Oeil.Bouger(deplX, deplY);
            this._Casque.Bouger(deplX, deplY);
            this._JambeDroite.Bouger(deplX, deplY, ajd1, ajd2, ajd3);
            this._JambeGauche.Bouger(deplX, deplY, ajg1, ajg2, ajg3);
            this._Sacados.Bouger(deplX, deplY);
            this._BrasDroit.Bouger(deplX, deplY, abd1, abd2, abd3);
            this._Snowboard.Bouger(deplX, deplY, sa1, sa2, sa3);
            Afficher(handle);
            Thread.Sleep(5);
        }
        #endregion
    }
}
