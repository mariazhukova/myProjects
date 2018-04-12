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
        public char simb='*';

        public Point(int _x,int _y)
        {
            this.x = _x;
            this.y = _y;

        }

        public Point (Point point)
        {
            this.x = point.x;
            this.y = point.y;
        }

         public void MovePoint(int i,Direction direction)
        {
            switch (direction)
            {
                case Direction.RIGHT:
                   x= x+i;
                    break;

                case Direction.LEFT:
                    x = x - i;
                    break;

                case Direction.UP:
                    y=y-i;
                    break;

                case Direction.DOWN:
                    y=y+i;
                    break;

            }
        }

        public void Clean()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }

         public virtual void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(simb);
        }

      public bool IsCross(Point p)
        {
            if (p.x == x && p.y == y)
                return true;
            return false;
            
        }

    }
}
