using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yeldExample
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Power(2, 10))
                Console.WriteLine("exponent is {0}", i);
            Console.ReadKey();

        }

        private static IEnumerable<int> Power(int el, int exp)
        {
            for (int i = 1; i < exp; i++)
                yield return el * i;

        }
    }
}
