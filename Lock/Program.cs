using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lock
{
    class Program
    {
        static Object locker = new Object();
        static List<int> list = new List<int>();
        static void Main(string[] args)
        {
            Thread t1 = new Thread(lWrite);
            Thread t2 = new Thread(lRead);
            t1.Start();
            t2.Start();
        }
        static void lWrite()
        {
            while (true)
            {
                lock (locker)
                {
                    list.Add(5);
                }
                Thread.Sleep(5000);
            }
        }

        static void lRead()
        {
            while (true)
            {
                lock (locker)
                {
                    Console.WriteLine(list.Count.ToString());
                    Thread.Sleep(500);
                }
            }
        }
    }
}
