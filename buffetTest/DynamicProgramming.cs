using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class DynamicProgramming
    {
        private Dictionary<int, int> cash = new Dictionary<int, int>();

        public int FibonachiRecursion(int index)
        {
            if (cash.Keys.Contains(index))
                return cash.Keys.ElementAt(index);
            else
            {
                if (index < 2)
                    return index;
                else
                {
                    cash.Add(index, FibonachiRecursion(index - 1) + FibonachiRecursion(index - 2));
                    return cash.Keys.ElementAt(index);
                }
               
            }
        }

        /// <summary>
        /// Given a list of non-negative integers representing the amount of money of each house, 
        /// determine the maximum amount of money you can rob tonight without alerting the police.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int Rob(int[] nums)
        {
            int firstLine = 0;
            int secondLine = 0;
            for (int i = 0; i < nums.Length; i +=2)
            {
                firstLine += nums[i];
                secondLine += nums.ElementAtOrDefault(i+1);
            }
            return Math.Max(firstLine, secondLine);
        }
    }
}
