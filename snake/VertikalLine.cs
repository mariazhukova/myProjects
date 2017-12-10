using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class VertikalLine
    {
        List<Point> pList;
        public VertikalLine(int lenght, Point point)
        {
            pList = new List<Point>();
            for (int i = point.y; i < lenght; i++)
            {
                Point newpoint = new Point(point.x,i);
                pList.Add(newpoint);
            }
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
