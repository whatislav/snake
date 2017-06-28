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
            Console.SetWindowSize(1, 1);
            Console.SetBufferSize(80, 25);
            Console.SetWindowSize(80, 25);

            Horizontalline line = new Horizontalline(0, 78, 0, '+');
            line.Drow();

            Verticalline vertline = new Verticalline(0, 24, 0, '+');
            vertline.Drow();

            Horizontalline line2 = new Horizontalline(0, 78, 24, '+');
            line2.Drow();

            Verticalline vertline2 = new Verticalline(0, 24, 78, '+');
            vertline2.Drow();

            Console.ReadLine();
        }

    }
}
