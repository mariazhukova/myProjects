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
            int[] array = { 0, 3, 4, 31, 56 };
            int[] array2 = { 4, 6, 30,40 };
            int[] array3 = { 1, 2, 2, 3, 4, 1, 5};
            GoogleQuestions gq = new GoogleQuestions();
            var result = gq.GetFirstDublicateNested(array3);
            MyLinkedList myLinkedList = new MyLinkedList("first");
            myLinkedList.Append("second");
            myLinkedList.Append("third");
            myLinkedList.Prepend("zero");// myLinkedList.Reverse();
            MyStack myStack = new MyStack();
            myStack.push(1);
            myStack.push(2);
            myStack.push(3);
            int res= myStack.peek();
            int r = myStack.pop();
            MyStackBasedArray myStackBasedArray = new MyStackBasedArray();
            myStackBasedArray.push(1);
            myStackBasedArray.push(2);
            myStackBasedArray.push(3);
            myStackBasedArray.pop();
            myStackBasedArray.pop();
            myStackBasedArray.peek();
            Console.WriteLine(result);
 
            Console.ReadKey();
        }
    
    }
}
