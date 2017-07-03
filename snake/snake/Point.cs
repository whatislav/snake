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

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if(direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if(direction == Direction.UP)
            {
                y = y + offset;
            }
            else if(direction == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        public void Draw_point()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
       
    }
}
