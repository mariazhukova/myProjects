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
            int[] array = { 1, 3, 8, 2, 5 };
            int[] array2 = { 6, 5, 3, 1, 8, 7, 2, 4 };
            int[] sortedArray = { 1, 4, 5, 8, 12, 34, 41 };
            Sorting sorting1 = new Sorting();
            sorting1.RedixSort(array);
            MyLinkedList myLinkedList = new MyLinkedList("first");
            myLinkedList.Append("second");
            myLinkedList.Append("third");
            myLinkedList.Prepend("zero");// myLinkedList.Reverse();

            Recursion rec = new Recursion();
            Sorting sorting = new Sorting();
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Insert(9);
            binarySearchTree.Insert(4);
            binarySearchTree.Insert(6);
            binarySearchTree.Insert(1);
            binarySearchTree.Insert(20);
            binarySearchTree.Insert(15);
            binarySearchTree.Insert(170);
            var rere = binarySearchTree.GetDepth();
            binarySearchTree.BreadthFirstSearch();
            Queue<BinarySearchNode> binaries = new Queue<BinarySearchNode>();
            // binaries.Enqueue(binarySearchTree.root);
            // binarySearchTree.BreadthFirstSearchRecursion(binaries,new List<int>());
            BST bST = new BST();
            bST.Insert(5);
            bST.Insert(1);
            bST.Insert(4);
            bST.IsValidBST();

            DynamicProgramming dm = new DynamicProgramming();
            dm.Rob(array);
            string str = "Hello! , , op , a Bob";
           

            EasyQuestions easyQuestions = new EasyQuestions();
            var nnn = easyQuestions.RevertStringWithoutNewArray(str.ToCharArray());
            Console.WriteLine(nnn.ToString());
            easyQuestions.SingleNumberwithXOR(new int[]{4, 1, 2, 1, 2});

            Console.ReadKey();
        }
    
    }
}
