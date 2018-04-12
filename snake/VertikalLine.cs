using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertikalLine:Line
    {
        public VertikalLine(int lenght, Point point) : base(lenght, point)
        {
            for (int i = point.x; i < lenght; i++)
            {
                Point newpoint = new Point(i, point.y);
                pList.Add(newpoint);
            }
            Draw(pList);
        }

        public override void Draw(List<Point> list)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (Point p in list)
            {
                p.Draw();
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
