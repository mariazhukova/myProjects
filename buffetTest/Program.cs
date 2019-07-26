using buffetTest;
using buffetTest.System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Algoritms
{

    class MainClass
    {
        static int FirstFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
        static string FirstReverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        static void LogAllPairsinArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[j] == array.Length && array[i] == array.Length)
                        break;
                    if (array[i] == array[j])
                        j++;
                   
                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
       static (int[] array, int sum, bool result) FindPairSum(int[] array, int sum)
        {
            (int[] array, int sum, bool result) result = (null, 0, false);
            int[] temp = new int[2];
            for(int i=0; i<array.Length-1; i++)
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
        static bool FindPairSum2(int[] arr, int sum)
        {
            Hashtable hashtable = new Hashtable();

            for(int i = 0; i < arr.Length; i++)
            {
                if (hashtable.Contains(arr[i]))
                    return true;
                else
                    hashtable.Add(sum - arr[i], true);
            }
            return false;
        }

        static void Main()
        {
            //[0,3,4,31] [4,6,30]
            int[] array = { 0, 3, 4, 31, 56 };
            int[] array2 = { 4, 6, 30,40 };
            int[] array3 = { 1, 2, 3, 4 };
            ArraysAlgoritms arraysAlgoritms = new ArraysAlgoritms();
            HashTable hs = new HashTable(10);
            hs.set("test", 123);
          //var result = arraysAlgoritms.mergeSortedArray(array,array2);
            var result2 = arraysAlgoritms.ContainsDuplicate(array3);
             arraysAlgoritms.Rotate(array3, 3);
            var n=hs.getValue("test");
            Console.WriteLine(n);
           Console.WriteLine(result2);
           // var beterResult = FindPairSum2(array, 8);
           // var result = FindPairSum(array, 8);
           // var result2 = FindPairSum(array2, 8);
           // Console.WriteLine(beterResult ? "yes" : "no");
           // Console.WriteLine((result.result) ? String.Format("Pair {0} {1} is match to sum {2}",result.array.GetValue(0), result.array.GetValue(1),result.sum) : "no any pairs");
            //Console.WriteLine((result2.result) ? String.Format("Pair {0} {1} is match to sum {2}", result2.array.GetValue(0), result2.array.GetValue(1), result2.sum) : "no any pairs");
            // LogAllPairsinArray(array);
            // Console.WriteLine(FirstReverse("Argument goes here"));
             //Console.WriteLine("Factorial 4 = " + FirstFactorial(4));
            Console.ReadKey();
        }
    

      /* [STAThread]
        static void Main(string[] args)
        {
            Console.WriteLine("Copy than press enter");
            Console.ReadKey();
            var n = Clipboard.GetText();
            Console.ReadKey();

        }*/
    }
}
