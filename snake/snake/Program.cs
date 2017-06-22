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
            int x1 = 5;
            int y1 = 6;
            char sym1 = '*';

            Draw_point(x1, y1, sym1);

            int x2 = 30;
            int y2 = 30;
            char sym2 = '^';
            Draw_point(x2, y2, sym2);

            Console.ReadLine();
        }
        static void Draw_point(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.Write ( sym );
        }
    }
}
