using Algoritms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms.Extensions
{
    public static class SortingExtensions
    {

        public static int[] splice(this int[] arr, int indexfrom, int count)
        {
            var array = arr.ToList();
            for (int i = indexfrom; i <=indexfrom + count; i++)
                array.RemoveAt(i);
            return array.ToArray();
        }
        public static int[] splice(this int[] arr, int indexfrom, int count, int[] newelement)
        {
            var array = arr.ToList();
            for (int i = indexfrom; i <= indexfrom + count; i++)
            {
                array.RemoveAt(i);
                array.Insert(i, newelement[i]);
            }
                

            return array.ToArray();
        }

        public static void unshift(this int[] arr, int element)
        {
            var arraylocal = arr.ToList();
            arraylocal.Insert(0, element);
            arr = arraylocal.ToArray();
        }

        public static int shift(this BinarySearchNode array)
        {
            return array.Value;
        }
    }
}
