using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    public class Point
    {
        public int x;
        public int y;
        private char simb='*';

        public Point(int _x,int _y)
        {
            this.x = _x;
            this.y = _y;

        }
         public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }

    }
}
