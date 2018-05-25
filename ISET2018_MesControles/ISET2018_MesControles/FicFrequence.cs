using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel.Design;

namespace ISET2018_MesControles
{
    public partial class Frequence : UserControl
    {
        private IComponentChangeService Espion;
        private int xmin = 0, xmax = 100, ymin = 0, ymax=100;
        private List<MonPoint> entrees = null;
        private Color trait = Color.Black;
        [Category("Apparence")]
        [Description("Abscisse minimum affichée")]
        public int XMin
        {
            get { return xmin; }
            set
            {
                if (value > xmax) xmin = xmax = -1;
                else xmin = value;
                Refresh();
            }

        }
        [Category("Apparence")]
        [Description("Abscisse maximum affichée")]
        public int XMax
        {
            get { return xmax; }
            set
            {
                if (value < xmin) xmax = xmin = +1;
                else xmax = value;
                Refresh();
            }

        }
        [Category("Apparence")]
        [Description("Ordonées minimum affichée")]
        public int YMin
        {
            get { return ymin; }
            set
            {
                if (value > ymax) ymin = ymax = -1;
                else ymin = value;
                Refresh();
            }

        }
        [Category("Apparence")]
        [Description("Ordonée maximum affichée")]
        public int YMax
        {
            get { return ymax; }
            set
            {
                if (value < ymin) ymax = ymin = +1;
                else ymax = value;
                Refresh();
            }

        }
        [Category("Données")]
        [Description("Données statique (x,y) à afficher")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<MonPoint> Entrees
        {
            get { return entrees; }
            set { entrees = value; Refresh(); }

        }
        [Category("Apparence")]
        [Description("Couleur de tracé")]
        public Color Trait
        {
            get { return trait; }
            set { trait = value; Refresh(); }

        }
        public Frequence()
        {
            InitializeComponent();
            Entrees = new List<MonPoint>();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (Entrees != null && Entrees.Count > 1)
            {
                float x1 = Width * (Entrees[0].X - XMin) / (XMax - XMin), x2;
                float y1 = Height * (Entrees[0].Y - YMin) / (YMax - YMin), y2;
                for (int i = 1; i < Entrees.Count; i++)
                {
                     x2 = Width * (Entrees[i].X - XMin) / (XMax - XMin);
                     y2 = Height * (Entrees[i].Y - YMin) / (YMax - YMin);
                    e.Graphics.DrawLine(new Pen(trait), x1, y1, x2, y1);
                    e.Graphics.DrawLine(new Pen(trait), x2, y1, x2, y2);
                    x1 = x2;y1 = y2;
                }
            }
        }
        public override ISite Site
        {
            get => base.Site;
            set
            {
                ClearChangeNotifications();
                base.Site = value;
                Espion = (IComponentChangeService)GetService(typeof(IComponentChangeService));
                RegisterChangeNotifications();
            }
        }
        private void ClearChangeNotifications()
        {
            if (Espion != null)
            {
                Espion.ComponentAdded -= new ComponentEventHandler(Changement);
                Espion.ComponentRemoved -= new ComponentEventHandler(Changement);
                Espion.ComponentChanged -= new ComponentChangedEventHandler(Changement);
            }
        }
        private void RegisterChangeNotifications()
        {
            if (Espion != null)
            {
                Espion.ComponentAdded += new ComponentEventHandler(Changement);
                Espion.ComponentRemoved += new ComponentEventHandler(Changement);
                Espion.ComponentChanged += new ComponentChangedEventHandler(Changement);
            }
        }
        private void Changement(object sender,ComponentChangedEventArgs ce)
        {
            Refresh();
        }
        private void Changement(object sender,ComponentEventArgs ce)
        {
            Refresh();
        }
    }
    [Serializable]
    public class MonPoint
    {
        private int x, y;
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public MonPoint()
        { X = Y = 0; }
        public MonPoint(int xy_)
        { X = Y = xy_; }
        public MonPoint(int x_,int y_)
        { X = x_; Y = y_; }
    }
}
