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

        public Line(int lenght,Point point,string marker)
        {
            pList = new List<Point>();
            switch (marker)
            {
                case "v":
                    for (int i = point.x; i < lenght; i++)
                    {
                        Point newpoint = new Point(i, point.y);
                        pList.Add(newpoint);
                    }
                    break;
                    
                case "h":
                    for (int i = point.y; i < lenght; i++)
                    {
                        Point newpoint = new Point(point.x, i);
                        pList.Add(newpoint);
                    }
                    break;
            }
         
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

    }
}
