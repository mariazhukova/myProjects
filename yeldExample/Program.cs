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
            int iterator = 0;
            foreach (var i in Power(2, 10))
            {
                Console.WriteLine("exponent of {0} in {1} is {2}", 2, iterator, i);
                ++iterator;
            }
                
            Console.ReadKey();

        }

        private static IEnumerable<double> Power(double el, double exp)
        {
            for (int i = 0; i < exp+1; i++)
                yield return Math.Pow(el,i);

        }
    }
}
