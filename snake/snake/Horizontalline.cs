using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Horizontalline
    {
        List<Point> pList;

        public Horizontalline(int xleft, int xright, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xleft; x <= xright; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void DrowHorizon()
        {
            foreach(Point p in pList)
            {
                p.Draw_point();
            }
        }
    }
}
