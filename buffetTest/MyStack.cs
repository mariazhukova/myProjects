using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class MyStack
    {
        Node node = new Node();
        public Node top { get; private set; }
        public Node bottom { get; private set; }
        int Lenght = 0;

        public int peek()
        {
            if(Lenght>0)
                return bottom.Value;
            return 0;
        }

        public void push(int value)
        {
            if (Lenght == 0)
            {
                node.Value = value;
                node.Pointer = null;
                top = node;
                bottom = node;
            }
            else
            {
                var newelement = new Node() { Value = value, Pointer=null };
                var temp = node;
                node = newelement;
                node.Pointer = temp;
                bottom = newelement;
            }
            Lenght++;
        }

        public int pop()
        {
            if (Lenght == 1)
            {
                node = null;
                return 0;
            }
            else
            {
                var temp = node;
                node = (Node)node.Pointer;
                bottom = node;
                Lenght--;

                return bottom.Value;
            }
        }

        public bool IsEmpty {
            get {
                if (Lenght > 0) return false;
                return true;
            }
            private set { }
        }
      
    }
    public class Node{
       public int Value { get; set; }
       public object Pointer { get; set; }
    }
}
