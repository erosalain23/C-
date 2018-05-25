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
    class MonRecTournant : MonPoint
    {
        #region Données membres
        private Color _Pot = Color.Red;
        private bool _Remplir = true;
        private int _Hauteur = 1;
        private int _Longueur = 1;
        private double _Angle=0;

        #endregion

        #region Constructeurs
        public MonRecTournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
        }
        public MonRecTournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur,double Angle_) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Angle = Angle_;
        }
        public MonRecTournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }
        public MonRecTournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color pot,double Angle_) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
            Angle = Angle_;
        }

        public MonRecTournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, Color crayon, Color pot) : base(hebergeur, xsg, ysg,crayon)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
        }

        #endregion

        #region Accesseurs
        public Color Pot
        {
            get { return _Pot; }
            set
            {
                try { _Pot = value; }
                catch (Exception) { }
            }
        }

        public bool Remplir
        {
            get { return _Remplir; }
            set { _Remplir = value; }
        }

        public int Longueur
        {
            get { return _Longueur; }
            set
            {
                if (value < 0) { _Longueur = 1; }
                else { _Longueur = value; }
            }
        }

        public int Hauteur
        {
            get { return _Hauteur; }
            set
            {
                if (value < 0) { _Hauteur = 1; }
                else { _Hauteur = value; }
            }
        }

        #endregion

        #region Méthodes
        public void Bouger(int dx , int dy , double da)
        {
            Bouger(dx, dy);
            Angle += da; 
        }

        public override void Afficher(IntPtr handle)
        {
            Point[] pointPoly = new Point[4];
            pointPoly[0] = CSG;

            pointPoly[1] = CSD;
            pointPoly[2] = CID;
            pointPoly[3] = CIG;

            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    //gr.FillPolygon(new SolidBrush(this.Pot), pointPoly);
                    gr.FillClosedCurve(new SolidBrush(this.Pot), pointPoly);
                }
                //gr.DrawPolygon(new Pen(this.Fond), pointPoly);
                gr.DrawClosedCurve(new Pen(this.Fond), pointPoly);
            }
        }

        public void Afficher(Graphics gr)
        {
            Point[] pointPoly = new Point[4];
            pointPoly[0] = CSG;
            pointPoly[1] = CSD;
            pointPoly[2] = CID;
            pointPoly[3] = CIG;

            if (this.Visible)
            {
                if (this.Remplir)
                {
                    //gr.FillPolygon(new SolidBrush(this.Pot), pointPoly);
                    gr.FillClosedCurve(new SolidBrush(this.Pot), pointPoly);
                }
              //gr.DrawPolygon(new Pen(this.Fond), pointPoly);
                gr.DrawClosedCurve(new Pen(this.Fond), pointPoly);
            }
        }

        public override void Cacher(IntPtr handle)
        {
            Point[] pointPoly = new Point[4];
            pointPoly[0] = CSG;
            pointPoly[1] = CSD;
            pointPoly[2] = CID;
            pointPoly[3] = CIG;

            Graphics gr = Graphics.FromHwnd(handle);
            if (this.Remplir)
            {
                gr.FillClosedCurve(new SolidBrush(this.Fond), pointPoly);
                //gr.FillClosedCurve(new SolidBrush(this.Pot), pointPoly);
            }
            gr.DrawClosedCurve(new Pen(this.Fond), pointPoly);
            //gr.DrawClosedCurve(new Pen(this.Fond), pointPoly);
        }

        public double Angle
        {
            get { return _Angle; }
            set { _Angle = value; }
        }
        public Point CSG
        {
            get { return new System.Drawing.Point(X,Y); }
        }
        public Point CSD
        {
            get { return new System.Drawing.Point((int)(X + Longueur * Math.Cos(Angle)), (int)(Y-Longueur*Math.Sin(Angle))); }
        }
        public Point CIG
        {
            get { return new System.Drawing.Point((int)(X+Hauteur*Math.Sin(Angle)),(int)(Y+Hauteur*Math.Cos(Angle))); }
        }
        public Point CID
        {
            get { return new System.Drawing.Point((int)(X + Longueur * Math.Cos(Angle) + Hauteur * Math.Sin(Angle)), (int)(Y - Longueur * Math.Sin(Angle) + Hauteur * Math.Cos(Angle))); }
        }
        public Point CSM
        {
            get { return new System.Drawing.Point((CSG.X + CSD.X) / 2, (CSG.Y + CSD.Y) / 2); }
        }
        public Point CIM
        {
            get { return new System.Drawing.Point((CID.X + CIG.X) / 2, (CID.Y + CIG.Y) / 2); }
        }
        #endregion
    }
}
