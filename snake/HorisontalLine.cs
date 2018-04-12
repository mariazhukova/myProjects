using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorisontalLine:Line
    {
       
         public HorisontalLine(int lenght, Point point) : base(lenght, point)
        {
            for (int i = point.y; i < lenght; i++)
            {
                Point newpoint = new Point(point.x, i);
                pList.Add(newpoint);
            }
            Draw(pList);
            
        }

        public override void Draw(List<Point> list)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (Point p in list)
            {
                p.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
