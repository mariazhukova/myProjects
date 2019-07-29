using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ExamQuestions
{
    class Program
    {
        private static void Work()
        {
            Thread.Sleep(1000);
        }



        private static Object syncObject = new Object();
        private static void Write()
        {
            lock (syncObject)
            {
                Console.WriteLine("test");
            }
        }
       
        static void Main(string[] args)
        {

            object sync = new object();
            var thread = new Thread(() =>
            {
                try
                {
                    Work();
                }
                finally
                {
                    lock (sync)
                    {
                        Monitor.PulseAll(sync);
                    }
                }
            });
            thread.Start();
            lock (sync)
            {
                Monitor.Wait(sync);
            }
            Console.WriteLine("test");


            var test = new Test1();
            try
            {
                test.Print();
            }
            catch (Exception)
            {
                Console.Write("5");
            }
            finally
            {
                Console.Write("4");
            }
            Console.ReadLine();


            int cc=3;
            Console.Write(Sum(5, 3, ref cc) + " ");
            Console.Write(cc);
            Console.ReadLine();


            lock (syncObject)
            {
                Write();
            }
            A obj1 = new A();
            obj1.Foo();

            B obj2 = new B();
            obj2.Foo();

            A obj3 = new B();
            obj3.Foo();
            
            var s = new S();
            using (s)
            {
                Console.WriteLine(s.GetDispose());
            }
            Console.WriteLine(s.GetDispose());

            List<Action> actions = new List<Action>();
            for (var count = 0; count < 10; count++)
            {
                actions.Add(() => Console.WriteLine(count));
            }
            foreach (var action in actions)
            {
                action();
            }

            int i = 1;
            object obj = i;
            i++;
            Console.WriteLine(i);
            Console.WriteLine(obj);
            // Console.WriteLine((short)obj);
            var s1 = string.Format("{0}{1}", "abc", "cba");
            var s2 = "abc" + "cba";
            var s3 = "abccba";

            Console.WriteLine(s1 == s2);
            Console.WriteLine((object)s1 == (object)s2);
            Console.WriteLine(s2 == s3);
            Console.WriteLine((object)s2 == (object)s3);

            var c = new C();
            AA a = c;

            a.Print2();
            a.Print1();
            c.Print2();
            Console.ReadKey();
        }
        static int Sum(int a, int b, ref int c)
        {
            return a + b;
        }
    }
    public struct S : IDisposable
    {
        private bool dispose;
        public void Dispose()
        {
            dispose = true;
        }
        public bool GetDispose()
        {
            return dispose;
        }
    }
    public class A
    {
        public virtual void Foo()
        {
            Console.Write("Class A");
        }
    }
    public class B : A
    {
        public override void Foo()
        {
            Console.Write("Class B");
        }
    }

    public class AA
    {
        public virtual void Print1()
        {
            Console.Write("A");
        }
        public void Print2()
        {
            Console.Write("A");
        }
    }
    public class BB : AA
    {
        public override void Print1()
        {
            Console.Write("B");
        }
    }
    public class C : BB
    {
        new public void Print2()
        {
            Console.Write("C");
        }
    }
    public class Test1
    {
        public void Print()
        {
            try
            {
                throw new Exception();
            }
            catch (Exception)
            {
                Console.Write("9");
                throw new Exception();
            }
            finally
            {
                Console.Write("2");
            }
        }
    }
}
