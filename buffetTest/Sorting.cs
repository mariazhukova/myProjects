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
            for(int i=0; i < array.Length;)
            {
                int temp = 0;
                if (array[i] > array[i + 1])
                {
                    temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    i = (i + 1 < array.Length - 1) ? i++:i ;
                }
                else if (array[i] < array[i + 1] && i!= 0 && i + 1 < array.Length - 1)
                {
                    i--;
                }
                else if (array[i] < array[i + 1] && i+1 < array.Length-1)
                {
                    i++;
                }
                else break;
            }
            return array;
        }

    }
}
