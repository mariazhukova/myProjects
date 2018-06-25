using System;
using System.Collections.Generic;

namespace yeld
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var el in Power(3))
                Console.WriteLine("yield number {0}", el);
            Console.ReadKey();
        }

        public static IEnumerable<int> Power(int number)
        {
            int _number = number;
            int result=0;
            for (int i = 0; i < 5; i++)
            {
                result = result + number;
                number++;
                yield return result;
            }
        } 
    }
}
