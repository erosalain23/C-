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
    class MaJambe : MonRecTournant
    {
        #region Données membres
        //private bool _Remplir = true;
        //private int _Hauteur = 1;
        //private int _Longueur = 1;
        private MonRecTournant jambe,pied;
        #endregion

        #region Constructeurs
        public MaJambe(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg, longueur, hauteur+4 )
        {
            this.jambe = new MonRecTournant(hebergeur, xsg, ysg + hauteur-3, longueur, hauteur-10 , Color.Blue);
            this.pied = new MonRecTournant(hebergeur, xsg+longueur-13, 20+ysg + hauteur, longueur + 10 , hauteur /4, Color.Yellow);
        }
        public MaJambe(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur,double AH,double AB) : base(hebergeur, xsg, ysg, longueur, hauteur + 4,AH)
        {
            this.jambe = new MonRecTournant(hebergeur, xsg, ysg + hauteur-3, longueur, hauteur - 10, Color.Blue,AB);
            this.pied = new MonRecTournant(hebergeur, xsg + longueur - 13, 20+ysg + hauteur, longueur + 10, hauteur / 4, Color.Yellow,AB);
        }
        #endregion
        #region Méthodes
        public void Bouger(int deplX, int deplY , double AH , double AB)
        {
            base.Bouger(deplX, deplY , AH);
            this.jambe.X = base.CIG.X;
            this.jambe.Y = base.CIG.Y;
            jambe.Bouger(0, 0 , AB);
            jambe.Bouger(base.CIM.X - jambe.CSM.X, base.CIM.Y - jambe.CSM.Y, 0);
            this.pied.X = this.jambe.CIG.X;
            this.pied.Y = this.jambe.CIG.Y;
            pied.Bouger(0, 0, AB);
            pied.Bouger(jambe.CIM.X - pied.CSM.X, jambe.CIM.Y - pied.CSM.Y, 0);


        }

        public new void Cacher(IntPtr handle)
        {
            base.Cacher(handle);
            this.jambe.Cacher(handle);
            this.pied.Cacher(handle);

        }

        public new void Afficher(IntPtr handle)
        {
            base.Afficher(handle);
            this.jambe.Afficher(handle);
            this.pied.Afficher(handle);

        } 
        #endregion
    }

}
