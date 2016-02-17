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

            p1.Drow();
            p2.Drow();

            HorizontalLine hl = new HorizontalLine(5, 10, 4, '+');
            VerticalLine vl = new VerticalLine(10, 0, 16, '-');

            hl.Drow();
            vl.Drow();

            Console.ReadLine();


        }
       
    }
}
