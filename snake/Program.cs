using snake;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 40);
            Point upstart = new Point(0,0);
            Point downstart = new Point(0, 39);
            Point raightstart = new Point(79, 0);
            Line upLine = new Line(Console.BufferWidth-1,upstart,"h");
            Line downLine = new Line(Console.BufferWidth - 1, downstart,"h");
            Line leftLine = new Line(Console.BufferHeight - 1, upstart,"v");
            Line raightLine = new Line(Console.BufferHeight - 1, raightstart,"v");


            Console.ReadKey();

        }
    }
}
