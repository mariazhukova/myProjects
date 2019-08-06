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
    }
}
