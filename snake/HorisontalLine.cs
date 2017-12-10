using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class HorisontalLine
    {
        List<Point> pList;

        public HorisontalLine(int lenght,Point point)
        {
            pList = new List<Point>();
            for(int i=point.x;i<lenght;i++)
            {
                Point newpoint = new Point(i,point.y);
                pList.Add(newpoint); 
            }
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }

       
    }
}
