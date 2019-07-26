using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyLinkedList
    {
        LinkedListElement _head { get; set; }
        LinkedListElement _tail { get; set; }
        int Lenght { get; set; }
        public MyLinkedList(string value)
        {
            LinkedListElement head = new LinkedListElement();
            head.Value = value;
            head.Pointe = null;
            _head = head;
            _tail = head;
            Lenght = 1;

        }
    }
    public class LinkedListElement
    {
        public string Value { get; set; }
        public object Pointe { get; set; }
    }
}
