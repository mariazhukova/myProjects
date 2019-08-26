using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Tasks
    {
        public int FibonachiIterative(int index)
        {
            int fib = 0;
            int[] elements = new int[] { 0, 1 };
            for (int i = 1; i < index; i++)
            {
                fib = elements[0] + elements[1];
                elements[0] = elements[1];
                elements[1] = fib;
            }
            return fib;
        }

        public int FactorialIterative(int number)
        {
            int fac = number;
            for (int i = number; i > 1; i--)
                fac *= i - 1;
            return fac;
        }
    }
}
