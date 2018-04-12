using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class NewCollections
    {
        private static IEnumerable<int> GetNumbers()
        {
            var number = 0;
            while (true)
            {
                if (number > 10)
                    yield break;

                yield return number++;
            }
        }

        public void Linked()
        {
            var tune = new LinkedList<string>();
            tune.AddFirst("do"); // do
            tune.AddLast("so"); // do - so
            tune.AddAfter(tune.First, "re"); // do - re- so
            tune.AddAfter(tune.First.Next, "mi"); // do - re - mi- so
            tune.AddBefore(tune.Last, "fa"); // do - re - mi - fa- so
            tune.RemoveFirst(); // re - mi - fa - so
            tune.RemoveLast(); // re - mi - fa
            LinkedListNode<string> miNode = tune.Find("mi");
            tune.Remove(miNode); // re - fa
            tune.AddFirst(miNode); // mi- re - fa
            foreach (string s in tune) Console.WriteLine(s);
        }

        public void Queue()
        {
            var q = new Queue<int>();
            q.Enqueue(10);
            q.Enqueue(20);
            int[] data = q.ToArray(); // Экспорт в массив
            Console.WriteLine(q.Count); // "2"
            Console.WriteLine(q.Peek()); // "10"
            Console.WriteLine(q.Dequeue()); // "10"
            Console.WriteLine(q.Dequeue()); // "20"
            Console.WriteLine(q.Dequeue()); // выбросит исключение т.к. очередь пуста

        }
    }
}
