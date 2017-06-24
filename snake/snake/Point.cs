using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
      
        public int x;
        public int y;
        public char sym;

        public Point(int xx, int yy, char symsym)
        {
            x = xx;
            y = yy;
            sym = symsym;
        }

        public void Draw_point()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
       
    }
}
