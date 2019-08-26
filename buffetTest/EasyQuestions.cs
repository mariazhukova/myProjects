﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class EasyQuestions
    {
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
            List<int> numscopy = nums.ToList();
            for(int i = 0; i < nums.Length - 1; i++)
            {
                if (numscopy.Count(e=>e==nums[i])>1)
                    numscopy.RemoveAll(e=>e==nums[i]);
            }
            return numscopy.ElementAtOrDefault(0);
        }
    }
}
