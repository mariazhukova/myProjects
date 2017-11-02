using System;

namespace Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Point  p= new Point(5,5);
            //p.X = 5;
            //p.Y = 5;
            Console.WriteLine("{0},{1}", p[0], p[1]);
            Console.WriteLine("{0},{1}", p['x'], p['y']);
            Console.ReadKey();

        }

    }

    struct Point
    {
        private int x;
        private int y;

        public Point(int x,int y)
        {
            this.x = x;
            this.y = y;
        }
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
          get { return y; }
          set { y = value; }
        }

        //throw special properties for indexes
        public int this [int i]
        {
            get
            {
                switch (i)
                    {
                    case 0:
                        return X;
                    case 1:
                        return Y;
                    default:
                        throw new Exception("Invalid data");

                }
            }
        }

        public int this[char i]
        {
            get
            {
                switch (i)
                {
                    case 'x':
                    case 'X':
                        return X;
                    case 'y':
                    case 'Y':
                        return Y;
                    default:
                        throw new Exception("Invalid data");

                }
            }
        }
    }
}