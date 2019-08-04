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

            MyGraph graph = new MyGraph();
            graph.addNode(0);
            graph.addNode(1);
                graph.addNode(2) ;
                graph.addNode(3) ;
                graph.addNode(4) ;
                graph.addNode(5) ;
            graph.addNode(6);
            graph.addEdge(0, 1);
            graph.addEdge(0, 2);
            graph.addEdge(3, 1);
            graph.addEdge(3, 4);
            graph.addEdge(4, 2);
            graph.addEdge(4, 5);
            graph.addEdge(1, 2);
            graph.addEdge(6, 5);
            var list = graph.ShowConnections();
           foreach(var l in list)
            {
                Console.WriteLine(l);
            }




            Console.WriteLine(result);
 
            Console.ReadKey();
        }
    
    }
}
