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
            /*Point p1 = new Point(10, 20, '^');
            Point p2 = new Point(20, 10, '^');
            Point p3 = new Point(7, 22, '#');
            Point p4 = new Point(35, 5, '*');
            Point p5 = new Point(56, 8, '%');*/

            Horizontalline line = new Horizontalline(17, 30, 6, '+');
            line.DrowHorizon();

            Verticalline vertline = new Verticalline(7, 15, 17, '+');
            vertline.DrowVertical();

            Horizontalline line2 = new Horizontalline(17, 30, 15, '+');
            line2.DrowHorizon();

            Verticalline vertline2 = new Verticalline(7, 15, 30, '+');
            vertline2.DrowVertical();

            Console.ReadLine();
        }

    }
}
