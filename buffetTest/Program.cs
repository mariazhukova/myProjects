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
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(170);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(14);
            binarySearchTree.Insert(16);
            binarySearchTree.Remove(20);
            binarySearchTree.Remove(170);



            Console.WriteLine(result);
 
            Console.ReadKey();
        }
    
    }
}
