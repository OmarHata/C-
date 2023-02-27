using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication2
{
    public enum TYPE { rect,ellipse,polygon};
    public enum TYPE2 { DRAW,FILL};
    class Shape
    {
        TYPE2 stype;

        public TYPE2 Stype
        {
            get { return stype; }
            set { stype = value; }
        }
        public void FILL(Graphics g)
        {
            stype = TYPE2.FILL;
            
           
        }
        public void MOVE(int dx, int dy)
        {
            topLeft.X += dx;
            topLeft.Y += dy;
            lowerright.X += dx;
            lowerright.Y += dy;
        }
        public void select(Graphics g)
        {
          
        }
        public bool IsInside(int x, int y)
        {
            if (x > topLeft.X && x < lowerright.X && y > topLeft.Y && y < lowerright.Y)
                return true;
            return false;
        }
        TYPE shapetype;

        public TYPE Shapetype
        {
            get { return shapetype; }
            set { shapetype = value; }
        }
        public void DRAW(Graphics g, Color C)
        {
            Pen P = new Pen(C, 3);
            if (shapetype == TYPE.rect)
            {
               // g.DrawRectangle(P, topLeft.X, topLeft.Y, width, height);
                Point[] poly = new Point[]
                {
                    new Point(topLeft.X+width/4,topLeft.Y),
                    new Point(topLeft.X+3*width/4,topLeft.Y),
                    lowerright,
                    new Point(topLeft.X,lowerright.Y)
                };
                if (stype == TYPE2.DRAW)
                    g.DrawPolygon(P, poly);
                
            }
            else if (shapetype == TYPE.ellipse)
                if(stype==TYPE2.DRAW)
                g.DrawEllipse(P, topLeft.X, topLeft.Y, width, height);
                
        }
        Point topLeft;

        public Point TopLeft
        {
            get { return topLeft; }
            set { topLeft = value; }
        }
        int width;

        public int Width
        {
            get { return width; }
            set { width = value; }
        }
        int height;

        public int Height
        {
            get { return height; }
            set { height = value; }
        }
        Point lowerright;

        public Point Lowerright
        {
            get { return lowerright; }
            set { lowerright = value; }
        }
        public Shape(int x1, int y1, int x2,int y2,TYPE T,TYPE2 TT)
        {
            topLeft = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            lowerright = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
            width = lowerright.X - topLeft.X;
            height = lowerright.Y - topLeft.Y;
            shapetype = T;
            stype = TT;
        }
    }
}
