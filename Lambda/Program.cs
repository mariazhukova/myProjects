using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2,8,10,12,25,0,5,89};
            Predicate<int> predicate = new Predicate<int>(Sort);
            var sortNumbersone = numbers.FindAll(predicate);
            var sortNumbers = numbers.FindAll(new Predicate<int>(Sort));
            var sortNumbersLambda = numbers.FindAll(i => i % 2 == 0);
            var sortNumbersLambda1 = numbers.Where(i => i % 2 == 0).Sum(i=>(long)i);
            foreach (int el in sortNumbersone) Console.WriteLine("elsement {0}", el);
            foreach (int el in sortNumbers) Console.WriteLine("elsement {0}", el);
            foreach (int el in sortNumbersLambda) Console.WriteLine("elsement {0}", el);
            Console.ReadKey();
        }

        private static bool Sort(int number)
        {
            return number % 2 == 0;
        }
    }
}
