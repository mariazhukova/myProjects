using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Point
    {
        public int x;
        public int y;
        public char symb;

      public Point(int _x, int _y,char _symb)
      {
       this.x = _x;
            this.y = _y;
            this.symb = _symb;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symb);
        }

        public void Clean()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(' ');
        }
}

    class Snake
    {
        int x, y;
        char symb;
        List<Point> snake = new List<Point>();
        public Snake(int _x, int _y, char _symb) 
        {
            this.x = _x;
            this.y = _y;
            this.symb = _symb;
            CreateSnake();
        }

        private void CreateSnake()
        {
           for(int i = 0; i < 5; i++)
            {
                snake.Add(new Point(x, y, symb));
                x += 1;
            }
        }

        public void Draw()
        {
            foreach(Point p in snake)
            {
                Console.SetCursorPosition(p.x,p.y);
                Console.Write(symb);
            }
           
        }

        public void Move()
        {
            Point oldhead= snake.Last();
            Point newhead = new Point(oldhead.x + 1, oldhead.y, oldhead.symb);
            snake.Add(newhead);
            Point tail = snake.First<Point>();
            snake.Remove(tail);
            newhead.Draw();
            tail.Clean();

        }
       
    }
    class Program
    {
        static void Main(string[] args)
        {
            Snake snake = new Snake(5, 5, '*');
            snake.Draw();

            while (true)
            {
                Thread.Sleep(100);
                snake.Move();
            }
        }
    }
}
