using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class EasyQuestions
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
        /// <summary>
        /// Write a program that outputs the string representation of numbers from 1 to n.
        /// But for multiples of three it should output “Fizz” instead of the number and for the multiples of five output “Buzz”. 
        /// For numbers which are multiples of both three and five output “FizzBuzz”.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 
        public IList<string> FizzBuzz(int n)
        {
            return FizzBuzzIter(n).ToList();
        }
        private IEnumerable<string> FizzBuzzIter(int n)
        {
            List<string> fizzbuzz = new List<string>();
            for (int i = 1; i <= n; i++)
            {
                 if ((i % 3 == 0) && (i % 5 == 0))
                    yield return "FizzBuzz";
                else if (i % 3 == 0)
                    yield return "Fizz";
                else if (i % 5 == 0)
                    yield return "Buzz";
                else
                    yield return i.ToString();

            }
           
        }

        /// <summary>
        /// Given a non-empty array of integers, every element appears twice except for one. Find that single one.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int SingleNumber(int[] nums)
        {
            List<int> numscopy = new List<int>();
            Parallel.Invoke(() =>
            {
                for (int i = 0; i <= nums.Length - 1; i++)
                {
                    if (numscopy.Contains(nums[i]))
                        numscopy.Remove(nums[i]);
                    else numscopy.Add(nums[i]);
                }
            });
            return numscopy.ElementAtOrDefault(0);
        }

        //Bit Manipulation
        //Concept

        //If we take XOR of zero and some bit, it will return that bit
        //  a⊕0=a
        //If we take XOR of two same bits, it will return 0
        //  a⊕a=0
        //  a⊕b⊕a=(a⊕a)⊕b=0⊕b=b
        //So we can XOR all bits together to find the unique number.
        public int SingleNumberwithXOR(int[] nums)
        {
            int x = 0;
           foreach(int i in nums)
                x ^= i;
            return x;
        }
    }
}
