using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Line> AllLines;
        public Walls(int width,int hight)
        {
            AllLines = new List<Line>();
            Point widthdownstart = new Point(0, 0);
            Point widthupstart = new Point(0, hight-1);
            Point hightraightstart = new Point(width-1, 0);
            Point hightleftstart = new Point(0, 0);

            HorisontalLine LeftLine = new HorisontalLine(Console.BufferHeight - 1, hightleftstart);
            HorisontalLine RaightLine = new HorisontalLine(Console.BufferHeight - 1, hightraightstart);
            VertikalLine UpLine = new VertikalLine(Console.BufferWidth - 1, widthupstart);
            VertikalLine DownLine = new VertikalLine(Console.BufferWidth - 1, widthdownstart);
            AllLines.Add(LeftLine);
            AllLines.Add(RaightLine);
            AllLines.Add(UpLine);
            AllLines.Add(DownLine);
        }
        internal bool IsCross(Snake snake)
        {
            foreach(var wall in AllLines)
            {
                if(wall.IsCross(snake))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
