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
            Point p2 = new Point(20, 10, '^');
            Point p3 = new Point(7, 22, '#');
            Point p4 = new Point(35, 5, '*');
            Point p5 = new Point(56, 8, '%');

            List<Point> pointlist = new List<Point>();
            pointlist.Add(p1);
            pointlist.Add(p2);
            pointlist.Add(p3);
            pointlist.Add(p4);
            pointlist.Add(p5);

            foreach (Point i in pointlist)
            {
                i.Draw_point();
            }

            List<char> charlist = new List<char>();
            charlist.Add('%');
            charlist.Add('c');
            charlist.Add('[');

            foreach(char i in charlist)
            {
                Console.Write(i);
            }

            Console.ReadLine();
        }

    }
}
