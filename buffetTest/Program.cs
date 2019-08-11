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
       

        static void Main()
        {
            //[0,3,4,31] [4,6,30]
            int[] array = { 0, 3, 8, 2, 5 };
            int[] array2 = { 6,5,3,1,8,7,2,4 };
            MyLinkedList myLinkedList = new MyLinkedList("first");
            myLinkedList.Append("second");
            myLinkedList.Append("third");
            myLinkedList.Prepend("zero");// myLinkedList.Reverse();

            Recursion rec = new Recursion();
            Sorting sorting = new Sorting();
            sorting.quicksort(array2,0,array2.Length-1);
 
            Console.ReadKey();
        }
    
    }
}
