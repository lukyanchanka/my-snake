using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine(int x, int yBottom, int yTop, char sym) 
        {
            pList = new List<Point>();
            for(int y = yBottom; y <= yTop; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Drow();
            }
        }
    }
}
