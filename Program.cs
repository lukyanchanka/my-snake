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
            Point p = new Point(4, 5, '#'); 
          
            //Point p2 = new Point(2,2,'#');

            HorizontalLine hl = new HorizontalLine(5, 10, 4, '+');
            VerticalLine vl = new VerticalLine(20, 1, 16, '+');


            //hl.Drow();
            //vl.Drow();
            Snake snake = new Snake(p, 4, Direction.RIGHT);

            snake.Drow();

            Console.ReadLine();


        }
       
    }
}
