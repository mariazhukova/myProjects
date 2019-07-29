using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyQueue
    {
        Node node = new Node();
        Node first { get; set; }
        Node last { get; set; }

        int Lenght = 0;

        public int peek()
        {
            if (Lenght > 0)
                return first.Value;
            return 0;
        }

        public void enqueue(int value)
        {
            if (Lenght == 0)
            {
                node.Value = value;
                node.Pointer = null;
                first = node;
                last = node;
            }
            else
            {
                var newelement = new Node() { Value = value, Pointer = null };
                var temp = GetLast();
                temp.Pointer = newelement;
                last = newelement;
            }
            Lenght++;
        }

        public int dequeue()
        {
            if (Lenght == 0)
                return 0;
          
                var temp = node;
                node = (Node)node.Pointer;
                first = node;
                Lenght--;

                return temp.Value;
        }

        public bool IsEmpty
        {
            get
            {
                if (Lenght > 0) return false;
                return true;
            }
            private set { }
        }

        private Node GetLast()
        {
            var temp = this.node;
            while (temp.Pointer != null)
                temp = (Node)temp.Pointer;
            return temp;
        }

    }
   
}

