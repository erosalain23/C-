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
    class MonRectangle_tournant : MonPoint
    {
        #region Données membres
        private Color _Pot;
        private bool _Remplir = true;
        private int _Hauteur;
        private int _Longueur;
        private double _Alpha = 0;
        #endregion

        #region Constructeurs
        public MonRectangle_tournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = Color.DarkSlateBlue;
        }

        public MonRectangle_tournant(PictureBox hebergeur, int xsg, int ysg, int longueur, double angle, int hauteur, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
            Alpha = angle;
        }

        public MonRectangle_tournant(PictureBox hebergeur, int xsg, int ysg, int longueur, int hauteur, double angle, Color crayon, Color pot) : base(hebergeur, xsg, ysg)
        {
            Longueur = longueur;
            Hauteur = hauteur;
            Pot = pot;
            Alpha = angle;
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
        public double Alpha
        {
            get { return _Alpha; }
            set { _Alpha = value; }
        }

        public Point CSG {
            get { return new Point(X, Y); }
        }
        public Point CSD
        {
            get { return new Point( (int)(X+Longueur*(Math.Cos(_Alpha))), (int)(Y-Longueur*Math.Sin(_Alpha) )); }
        }
        public Point CID
        {
            get { return new Point((int)(X + Longueur * (Math.Cos(_Alpha)) + Hauteur * Math.Cos( (3 * Math.PI/2) + _Alpha)), (int)(Y - Longueur * (Math.Sin(_Alpha)) - Hauteur * ( Math.Sin( (3*Math.PI/2) + _Alpha )))); }
        }
        public Point CIG
        {
            get { return new Point((int)(X + Hauteur * ( Math.Cos( (3*Math.PI/2) + _Alpha))), (int)(Y - Hauteur * Math.Sin( (3*Math.PI/2) + _Alpha))); }
        }

        public Point CIM
        {
            get { return new Point( ( (CIG.X + CID.X) / 2), ((CIG.Y + CID.Y) / 2)); }
        }
        public Point CSM
        {
            get { return new Point( ((CSG.X + CSD.X) / 2), ((CSG.Y + CSD.Y) / 2)); }
        }
        #endregion

        #region Méthodes
        public override void Afficher(IntPtr handle)
        {
            Point[] PointsPoly = new Point[4];
            PointsPoly[0] = CSG;
            PointsPoly[1] = CSD;
            PointsPoly[2] = CID;
            PointsPoly[3] = CIG;
            if (this.Visible)
            {
                Graphics gr = Graphics.FromHwnd(handle);
                if (this.Remplir)
                {
                    gr.FillClosedCurve(new SolidBrush(this.Pot), PointsPoly);
                }
                gr.DrawClosedCurve(new Pen(this.Crayon, 2), PointsPoly);
            }
        }

        public void Afficher(Graphics gr)
        {
            Point[] PointsPoly = new Point[4];
            PointsPoly[0] = CSG;
            PointsPoly[1] = CSD;
            PointsPoly[2] = CID;
            PointsPoly[3] = CIG;
            if (this.Visible)
            {
                if (this.Remplir)
                {
                    gr.FillClosedCurve(new SolidBrush(this.Pot), PointsPoly);
                }
                gr.DrawClosedCurve(new Pen(this.Crayon, 2), PointsPoly);
            }
        }

        public override void Cacher(IntPtr handle)
        {
            Point[] PointsPoly = new Point[4];
            PointsPoly[0] = CSG;
            PointsPoly[1] = CSD;
            PointsPoly[2] = CID;
            PointsPoly[3] = CIG;
            Graphics gr = Graphics.FromHwnd(handle);
            if (this.Remplir)
            {
                gr.FillClosedCurve(new SolidBrush(this.Fond), PointsPoly);
            }
            gr.DrawClosedCurve(new Pen(this.Fond, 2), PointsPoly);
        }
        #endregion MonRectangle_tournant
    }
}
