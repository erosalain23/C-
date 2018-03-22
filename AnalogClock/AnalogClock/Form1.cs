using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogClock
{
    public partial class Form1 : Form
    {

        //three lines of the three hands
        Point[,] hands_coord = new Point[3, 2] {
            {new Point(0,0),new Point(0,120) },//hour hand
            {new Point(0,0),new Point(0,140) },//minute hand
            {new Point(0,0),new Point(0,140) } //second hand
        };
        DateTime cur; // current time definition
        DateTime prev; // previous time definition
        bool change; // boolean if time changed
        public Form1()
        {
            InitializeComponent();
        }
        private void RotatePoint(Point[]pt,int iRotate,int iAngle) // function to make points - only the rotations
        {
            Point ptTemp = new Point(0, 0); // initialisation point
            for (int i = 0; i < iRotate; i++) // who many rotations

            {
                ptTemp.X = (int)(pt[i].X * Math.Cos(2 * Math.PI * iAngle / 360) - pt[i].Y * Math.Sin(2 * Math.PI * iAngle / 360));
                ptTemp.Y = (int)(pt[i].Y * Math.Cos(2 * Math.PI * iAngle / 360) + pt[i].X * Math.Sin(2 * Math.PI * iAngle / 360));
                pt[i] = ptTemp;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TranslateTransform(this.Size.Width / 2, this.Size.Height / 2);
            e.Graphics.RotateTransform(180);
            DrawClock(e.Graphics);
            DrawHands(e.Graphics, prev, true, Color.FromArgb(255, 0, 0, 0));
        }
        private void DrawClock(Graphics e)
        {
            Point[] pt = new Point[2];
            for (int iAngle = 0; iAngle < 360; iAngle += 6)
            {
                pt[0].X = 0;
                pt[0].Y = 150;

                RotatePoint(pt, 1, iAngle);
                pt[1].X = pt[1].Y = (iAngle % 5 == 0 ? 10 : 5);
                pt[0].X -= pt[1].X / 2;
                pt[0].Y -= pt[1].Y / 2;
                Pen p = new Pen(Color.FromArgb(255, 0, 0, 0));
                e.DrawEllipse(p, pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);
                e.FillEllipse(new SolidBrush(Color.FromArgb(255, 0, 0, 0)), pt[0].X, pt[0].Y, pt[1].X, pt[1].Y);

            }
        }
        private void DrawHands(Graphics e, DateTime dt, bool change, Color c)
        {
            Point[,] temppt = new Point[3, 2];
            int[] iAngle = new int[3];
            iAngle[0] = (int)((dt.Hour * 30) % 360 + dt.Minute / 2);
            iAngle[1] = (int)(dt.Minute * 6);
            iAngle[2] = (int)(dt.Second * 6);
            temppt = (Point[,])hands_coord.Clone();
            for (int i = change ?0:2; i < 3; i++)
            {
                Point[] tt = { temppt[i, 0], temppt[i, 1] };
                RotatePoint(tt, 2, iAngle[i]);
                Pen p = new Pen(c);
                e.DrawLine(p, tt[0], tt[1]);
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cur = DateTime.Now;
            change = cur.Hour != prev.Hour || cur.Minute != prev.Minute;
            DrawHands(this.CreateGraphics(), cur, change, Color.FromArgb(255, 255, 255, 255));
            DrawHands(this.CreateGraphics(), cur, true, Color.FromArgb(255, 0, 0, 0));
            prev = cur;
            Invalidate();
        }
    }
   
}
