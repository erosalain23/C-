using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dessin2D
{
    public partial class DessinForm : Form
    {
        MyPoints pts = new MyPoints();
        public DessinForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyPoints pts = new MyPoints();
            allPoints.Text = string.Empty;
            this.xShow.Text = pts.Points[0].X.ToString();
            this.yShow.Text = pts.Points[0].Y.ToString();
            this.nbShow.Text = pts.NbPoint.ToString();
            //pts.Points.ForEach(p => allPoints.Text += p);
            foreach (var p in pts.Points)
            {
                allPoints.Text += "("+ p.X.ToString() +" ; " + p.Y.ToString() + ")";
            }
           
        }

        private void Display_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            Graphics g = Display.CreateGraphics();
            Display.Refresh();
            MyPoints pts = new MyPoints();
            int height = ClientSize.Height;
            int width = ClientSize.Width;
            g.DrawLine(new Pen(Color.Red), 0, height / 2, width, height / 2);

            for (int i = 1; i < pts.NbPoint; i++)
            {
                g.DrawLine(new Pen(Color.Black), pts.Points[i - 1].X, pts.Points[i - 1].Y + height / 2, pts.Points[i - 1].X, pts.Points[i].Y + height / 2);
                g.DrawLine(new Pen(Color.Black), pts.Points[i - 1].X, pts.Points[i].Y + height / 2, pts.Points[i].X, pts.Points[i].Y + height / 2);

            }
        }
    }
}
