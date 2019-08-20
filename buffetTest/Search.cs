using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    public class Search
    {
        public int[] binarySearchRecursion(int[] array,int element)
        {
            if (array.Length == 1)
                return array;

            int pivotElement = array.Length / 2;
           

            if (array[pivotElement] > element)
            {
                int[] copyarray = new int[pivotElement];
                for (int i = 0; i < pivotElement; i++)
                    copyarray[i] = array[i];
                return binarySearchRecursion(copyarray, element);
            }
            else if (array[pivotElement] < element)
            {
                int[] copyarray = new int[array.Length - pivotElement];
                int j = 0;
                for (int i = pivotElement; i < array.Length; i++)
                {
                    copyarray[j] = array[i];
                    j ++;
                }
                   
                return binarySearchRecursion(copyarray, element);
            }
            else
            {
                int[] copyarray = { array[pivotElement] };
                return binarySearchRecursion(copyarray, element);
            }
                

        }

        public int binarySearch(int[] array, int element)
        {

            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (array[mid] < element)
                    min = mid+1;
                else if (array[mid] > element)
                    max =mid- 1;
                else
                    return array[mid];
            }
            return 0;
        }
    }
}
