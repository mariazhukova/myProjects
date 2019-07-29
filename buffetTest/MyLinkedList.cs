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
        public int Lenght { get; private set; }
        public MyLinkedList(string value)
        {
            LinkedListElement head = new LinkedListElement();
            head.Value = value;
            head.Pointer = null;
            _head = head;
            _tail = head;
            Lenght = 1;

        }

        public void Append(string value)
        {
            var newelement = new LinkedListElement() { Value = value, Pointer = null };
            var last = GetLast(this._head);
            last.Pointer = newelement;
            this._tail = newelement;
            Lenght++;
        }
        
        public void Prepend(string value)
        {
            var newelement = new LinkedListElement()
            {
                Value = value,
                Pointer = this._head
            };
            this._head = newelement;
            Lenght++;
        }

        public List<string> PrintValues()
        {
            List<string> printer = new List<string>(Lenght);
            var element = new LinkedListElement()
            {
                Value = this._head.Value,
                Pointer = this._head.Pointer
            };
            var next = new LinkedListElement();
            
            while (next != null )
            {
                printer.Add(element.Value);
                next = (LinkedListElement)element.Pointer;
                element.Value = next?.Value;
                element.Pointer = next?.Pointer;
            }
            return printer;
        }

        public void Insert(string pointer,  string value)
        {
            var nextEl = this._head;
            var previusEl = this._head;
            while(nextEl.Value != pointer)
            {
                previusEl = nextEl;
                nextEl = (LinkedListElement)nextEl.Pointer;
            }
            previusEl.Pointer = new LinkedListElement()
            { Value = value, Pointer = nextEl };
            Lenght--;
        }

        public void Remove(string pointer)
        {
            var nextEl = this._head;
            var previusEl = this._head;
            while (nextEl.Value != pointer)
            {
                previusEl = nextEl;
                nextEl = (LinkedListElement)nextEl.Pointer;
            }
            previusEl.Pointer = (LinkedListElement)nextEl.Pointer;
            Lenght--;
        }

        public void Reverse()
        {
            var newhead = new LinkedListElement() { Value = this._head.Value, Pointer = this._head.Pointer };
            var newtail = new LinkedListElement() { Value = this._tail.Value, Pointer = this._tail.Pointer };
            //create code here

        }

        private LinkedListElement GetLinkedElement(LinkedListElement linkedListel)
        {
            var element = this._head;
            var elementPointer = (LinkedListElement)element.Pointer;
            while (linkedListel.Value != elementPointer.Value)
            {
                element = (LinkedListElement)element.Pointer;
                elementPointer = (LinkedListElement)element.Pointer;
            }
            return element;
        }

        private LinkedListElement GetLast(LinkedListElement elements)
        { 
            while (elements.Pointer != null)
                elements = (LinkedListElement)elements.Pointer;
            return elements;
        }
    }
    public class LinkedListElement
    {
        public string Value { get; set; }
        public object Pointer { get; set; }
    }
}
