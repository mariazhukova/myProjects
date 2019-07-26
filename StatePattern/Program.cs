using System;

namespace StatePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Water water = new Water(new LiquidState());
            water.Heat();
            water.Frost();
            water.Frost();

            Console.Read();
        }
    }
}
