using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ISET2018_MesControles
{
    public partial class BoutonColores: Button
    {
        private Color cGauche = Color.LightGreen, cDroit = Color.DarkBlue;
        private int tGauche = 64, tDroit = 64;

        [Category("Apparence")]
        [Description("la couleur sur la gauche du boutton")]
        public Color couleurGaucheBouton
        {
            get { return cGauche; }
            set { cGauche = value; Invalidate(); }
        }
        [Category("Apparence")]
        [Description("la couleur sur la droite du boutton")]
        public Color couleurDroiteBouton
        {
            get { return cDroit; }
            set { cDroit = value; Invalidate(); }
        }
        [Category("Apparence")]
        [Description("Trasparence de la couleur sur la droite du boutton")]
        public int TransparenceGaucheBouton
        {
            get { return tGauche; }
            set
            {
                if (value < 0) tGauche = 0;
                else if (value > 255) tGauche = 255;
                else tGauche = value;
                Invalidate();
            }
        }
        [Category("Apparence")]
        [Description("Trasparence de la couleur sur la droite du boutton")]
        public int TransparenceDroiteBouton
        {
            get { return tDroit; }
            set
            {
                if (value < 0) tDroit = 0;
                else if (value > 255) tDroit = 255;
                else tDroit = value;
                Invalidate();
            }
        }
        public BoutonColores()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            Color cg = Color.FromArgb(TransparenceGaucheBouton, couleurGaucheBouton);
            Color cd = Color.FromArgb(TransparenceDroiteBouton, couleurDroiteBouton);
            Brush br = new LinearGradientBrush(ClientRectangle, cg, cd, 0f);
            pevent.Graphics.FillRectangle(br, ClientRectangle);
        }
    }
}
