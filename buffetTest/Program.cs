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
            int[] array2 = { 8, 6, 3,4,1,9 };
            MyLinkedList myLinkedList = new MyLinkedList("first");
            myLinkedList.Append("second");
            myLinkedList.Append("third");
            myLinkedList.Prepend("zero");// myLinkedList.Reverse();

            Recursion rec = new Recursion();
            Sorting sorting = new Sorting();
            sorting.selectionSort(array2);
 
            Console.ReadKey();
        }
    
    }
}
