using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest.System
{
   public class ArraysAlgoritms
    {
        public List<int> mergeSortedArray(int[] arr, int[] arr2)
        {
            List<int> mergearray = new List<int>();
            int j = 0;
            int i = 0;
            while (i <= arr.Length-1 || j <= arr2.Length-1)
            {
                if(j > arr2.Length - 1 && i <= arr.Length - 1)
                {
                    mergearray.Add(arr[i]);
                    i++;
                }
                else if(i > arr.Length - 1 && j <= arr2.Length - 1)
                {
                    mergearray.Add(arr2[j]);
                    j++;
                }
                else if (arr[i] <= arr2[j])
                {
                    mergearray.Add(arr[i]);
                    i++;
                }
                else
                {
                    mergearray.Add(arr2[j]);
                    j++;
                }
            }
            return mergearray;

        }

        public bool ContainsDuplicate(int[] nums)
        {
            int first = 0;
            int next = 1;
            bool result = false;
            while(first < nums.Length - 1)
            {
                if(nums[next] == nums[first])
                {
                    result = true;
                    break;
                }
                else if (next == nums.Length-1 && first < nums.Length - 1)
                {
                    first++;
                    next = first+1;
                }
                else
                    next++;
                    
            }
            return result;
        }

        public int[] Rotate(int[] nums, int k)
        {
            while (k != 0)
            {
                int temp = nums[nums.Length - 1];
                for (int i = nums.Length - 1; i > 0; i--)
                {
                    nums[i] = nums[i-1];
                };
                nums[0] = temp;
                k--;
            }
            return nums;
        }
    }
}
