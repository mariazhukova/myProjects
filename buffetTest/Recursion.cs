using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
   public class Recursion
    {
        public int allNumbers(int from,int untill)
        {
            if (untill < 1)
                return 1;
            Console.Write(" " + from);
            return allNumbers(from+1,untill - 1);
            
        }
        public int allNumbersreverse(int untill)
        {
            if (untill < 1)
                return 1;
            Console.Write(" " + untill);
            return allNumbersreverse(untill - 1);

        }

        public int SumNaturalNumbers(int num)
        {
            if (num == 1)
                return 1;
            return num+ SumNaturalNumbers(num - 1);
        }
        public int numberofdigits(int number)
        {
            int counter = 1;
            if (number < 10)
                return 1;
            return counter += numberofdigits(number / 10);
        }
        public void individualdigits(int number)
        {
            if (number < 10)
                return;
            Console.WriteLine(" ", number % 10);
            individualdigits(number / 10);
        }
        public int FactorialRecursion(int number)
        {
            if (number > 1)
                return number * FactorialRecursion(number - 1);
            return 1;
        }
        public int FactorialIterative(int number)
        {
            int fac = number;
            for(int i=number; i > 1; i--)
                fac *= i - 1;
            return fac;
        }

        public int FibonachiRecursion(int index)
        {
            if (index < 2) {
                return index;
            }
            return FibonachiRecursion(index - 1) + FibonachiRecursion(index - 2);
        }

        public string reverseString(string str)
        {
            if (str.Length == 0)
                return  str;
            //Console.Write(str[str.Length-1]);
            return reverseString(str.Substring(1))+str[0];
        }
        public int FibonachiIterative(int index)
        {
            int fib = 0;
            int[] elements = new int[] {0,1};
            for(int i=1; i < index; i++)
            {
                fib = elements[0] + elements[1];
                elements[0] = elements[1];
                elements[1] = fib;
            }
            return fib;
        }
    }
}
