using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class GoogleQuestions
    {
        public int FirstFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
        public string FirstReverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public void LogAllPairsinArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == array.Length && array[i] == array.Length)
                        break;
                    if (array[i] == array[j])
                        j++;

                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
        public (int[] array, int sum, bool result) FindPairSum(int[] array, int sum)
        {
            (int[] array, int sum, bool result) result = (null, 0, false);
            int[] temp = new int[2];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + array[i + 1] == sum)
                {
                    temp.SetValue(array[i], 0);
                    temp.SetValue(array[i + 1], 1);
                    result = (temp, sum, true);
                    break;
                }
                else result = (temp, sum, false);

            }
            return result;
        }

        //beter solution
        public bool FindPairSum2(int[] arr, int sum)
        {
            Hashtable hashtable = new Hashtable();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashtable.Contains(arr[i]))
                    return true;
                else
                    hashtable.Add(sum - arr[i], true);
            }
            return false;
        }
        /// <summary>
        /// Get first duplicate element in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int GetFirstDublicate(int[] array)
        {
           Dictionary<int,bool> dic = new Dictionary<int,bool>();
            int i = 0;
            while (array.Length - 1 > i)
            {
                if (dic.ContainsKey(array[i]))
                    return array[i];
                dic.Add(array[i], true);
                i++;
            }
            return 0;
        }
        /// <summary>
        /// Get first duplicate element in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int GetFirstDublicateNested(int[] array)
        {
           int result = 0;
           for(int i = 0; i < array.Length-1; i++)
           {
                for(int j = i+1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j] && (j-i==1))
                    {
                        result = array[i];
                        break;
                    }
                }
                if (result > 0) break;
            }
            return result;
        }

        public void metod()
        {
            Stack<int> stack = new Stack<int>();
            
        }
    }
}

