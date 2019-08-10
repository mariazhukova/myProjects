using buffetTest.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class Sorting
    {
        public int[] bubleSort(int[] array)
        {
            for(int i=0; i < array.Length-1;i++)
            {
                for(int j=0; j<array.Length-1;j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
        public int[] insertionSort(int[] array)
        {
            int last = 0;
            for (int i = 0; i < array.Length;++i)
            {
                last = array[i];
                for (int j = i; j >= 0; j--)
                 {
                    if (last < array[j])
                    {
                        array[j+1] = array[j];
                        array[j] = last;
                    }
                    
                }
                
            }
                return array;
        }

        public int[] selectionSort(int[] array)
        {
            int min = 0;
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                index = i;
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        min = array[j];
                        index = j;
                    }
                }
                array[index] = array[i];
                array[i] = min;

            }
            return array;
        }

        public List<int> MergeSort(int[] array)
        {
            if (array.Length == 1)
                return array.ToList();

            //split array
            int[] left = new int[array.Length /2];
            int[] right = new int[array.Length / 2];
            for (int i = 0; i < array.Length / 2; i++)
                left[i] = array[i];
            int j = 0;
            for (int i = array.Length/2; i < array.Length; i++)
            {
                right[j] = array[i];
                j++;
            }
                
            return merge(MergeSort(left), MergeSort(right));
        }

        private List<int> merge(List<int> left, List<int> right)
        {
            List<int> result = new List<int>();
            while (left.Count > 0 || right.Count > 0)
            {
                if (left.Count > 0 && right.Count > 0)
                {
                    if (left.First() <= right.First())  //Comparing First two elements to see which is smaller
                    {
                        result.Add(left.First());
                        left.Remove(left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        result.Add(right.First());
                        right.Remove(right.First());
                    }
                }
                else if (left.Count > 0)
                {
                    result.Add(left.First());
                    left.Remove(left.First());
                }
                else if (right.Count > 0)
                {
                    result.Add(right.First());

                    right.Remove(right.First());
                }
            }
            return result;
        }

        public void insertionSortLikeJS(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < array[0])
                {
                    //move number to the first position
                    array.unshift(array.splice(i, 1)[0]);
                }
                else
                {
                    // only sort number smaller than number on the left of it. This is the part of insertion sort that makes it fast if the array is almost sorted.
                    if (array[i] < array[i - 1])
                    {
                        //find where number should go
                        for (var j = 1; j < i; j++)
                        {
                            if (array[i] >= array[j - 1] && array[i] < array[j])
                            {
                                //move number to the right spot
                                array.splice(j, 0, array.splice(i, 1));
                            }
                        }
                    }
                }
            }
        }
    }
}
