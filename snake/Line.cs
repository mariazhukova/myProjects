using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Line
    {
        protected List<Point> pList;

        public Line(int lenght,Point point)
        {
            pList = new List<Point>();
                   
        }
        public virtual void Draw(List<Point> list)
        {
            foreach (Point p in list)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(p.simb);
            }
           
        }
        public bool IsCross(Snake snake)
        {
            if (snake.IsCross(pList))
                return true;
            return false;
        }

    }
}
