using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dessin2D
{
    public class MyPoint
    {
        private int x;
        private int y;
        public int X { get { return x; } set { x = value; } }
        public int Y { get { return y; } set { y = value; } }
        public MyPoint()
        { X = Y = 0; }
        public MyPoint(int x_,int y_)
        { X = x_; Y = y_; }
    }
    public class MyPoints
    {
        private int nbPoint;
        private List<MyPoint> points = new List<MyPoint>();
        // accessors
        public int NbPoint { get { return nbPoint; } set { nbPoint = value; } }
        public List<MyPoint> Points { get { return points; } set { points = value; } }
        //constructor
        public MyPoints()
        {
            FillPoints();
        }
        private void FillPoints()
        {
            Random rnd = new Random();
            this.nbPoint = rnd.Next(10, 25);
            int prevPoint =0;
            for (int i = 0; i < nbPoint; i++)
            {
                int x = rnd.Next(5, 20);
                int y = rnd.Next(-100, 100);
                Points.Add(new MyPoint(prevPoint + x, y));
                prevPoint += x;
            }
                
        }

    }

}

