using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class Tasks
    {
        /// <summary>
        /// Write a function that reverses a string. The input string is given as an array of characters char[].
        /// Do not allocate extra space for another array, you must do this by modifying 
        /// the input array in-place with O(1) extra memory.
        /// </summary>
        /// <param name="str"></param>
        public char[] RevertStringWithoutNewArray(char[] str)
        {
            int j = 0;
            int p = str.Length - 1;
            for (int i = (str.Length - 1) / 2; i >= 0; i--)
            {
                char temp = str[j];
                str[j] = str[p];
                str[p] = temp;
                j++;
                p--;
            }
            return str;
        }

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
