using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyDoublyLinkedList
    {

        DoublyLinkedListElement _head { get; set; }
        DoublyLinkedListElement _tail { get; set; }
        public int Lenght { get; private set; }
        public MyDoublyLinkedList(string value)
        {
            DoublyLinkedListElement head = new DoublyLinkedListElement();
            head.Value = value;
            head.PointerBefore = null;
            head.PointerAfter = null;
            _head = head;
            _tail = head;
            Lenght = 1;

        }

        public void Append(string value)
        {
            var newelement = new DoublyLinkedListElement()
            {
                Value = value,
                PointerBefore = this._head,
                PointerAfter = null
            };
            this._head.PointerAfter = newelement;
            this._tail = newelement;
            Lenght++;
        }

        public void Prepend(string value)
        {
            var newelement = new DoublyLinkedListElement()
            {
                Value = value,
                PointerBefore = null,
                PointerAfter = this._head
            };
            this._head = newelement;
            Lenght++;
        }

        public List<string> PrintValues()
        {
            List<string> printer = new List<string>(Lenght);
            var element = new DoublyLinkedListElement()
            {
                Value = this._head.Value,
                PointerAfter = this._head.PointerAfter
            };
            var next = new DoublyLinkedListElement();

            while (next != null)
            {
                printer.Add(element.Value);
                next = (DoublyLinkedListElement)element.PointerAfter;
                element.Value = next?.Value;
                element.PointerAfter = next?.PointerAfter;
            }
            return printer;
        }

        public void Insert(string pointer, string value)
        {
            var nextEl = this._head;
            var previusEl = this._head;
            DoublyLinkedListElement beforeEl = null;
            while (nextEl.Value != pointer)
            {
                previusEl = nextEl;
                nextEl = (DoublyLinkedListElement)nextEl.PointerAfter;
                beforeEl = (DoublyLinkedListElement)nextEl.PointerBefore;
            }
            previusEl.PointerAfter = new DoublyLinkedListElement()
            { Value = value, PointerAfter = nextEl, PointerBefore = beforeEl };
            Lenght++;
        }

        public void Remove(string pointer)
        {
            var nextEl = this._head;
            var previusEl = this._head;
            DoublyLinkedListElement beforeEl = null;
            while (nextEl.Value != pointer)
            {
                previusEl = nextEl;
                nextEl = (DoublyLinkedListElement)nextEl.PointerAfter;
                beforeEl = previusEl;
            }
            nextEl.PointerBefore = beforeEl;
            previusEl.PointerAfter = (LinkedListElement)nextEl.PointerAfter;
            Lenght++;
        }
    }

    public class DoublyLinkedListElement
    {
        public string Value { get; set; }
        public object PointerBefore { get; set; }
        public object PointerAfter { get; set; }
    }
}
