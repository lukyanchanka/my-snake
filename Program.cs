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
            
            Point p1 = new Point(1,3,'*');
           
            p1.Drow();

            Point p2 = new Point(2,4,'#');
           

            p2.Drow();


            Console.ReadLine();


        }
       
    }
}
