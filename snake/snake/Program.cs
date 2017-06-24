using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20, '^');
            /*p1.x = 10;
            p1.y = 10;
            p1.sym = '^';*/
            p1.Draw_point();

            Point p2 = new Point(20, 10, '^');
            /*p2.x = 24;
            p2.y = 40;
            p2.sym = '^';*/
            p2.Draw_point();

            Console.ReadLine();
        }

    }
}
