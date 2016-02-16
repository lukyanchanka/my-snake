using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)

        {
            Point p1 = new Point(1, 1, '#'); ;
          
            Point p2 = new Point(2,2,'#');
       
            
            List <Point> pointList = new List<Point>();
            pointList.Add(p1);
            pointList.Add(p2);
            foreach (Point p in pointList)
            {
                p.Drow();
            }

            Console.ReadLine();


        }
       
    }
}
