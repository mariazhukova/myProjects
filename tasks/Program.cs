using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryT fac = new FactoryT();
            fac.ShowEvent += Console.WriteLine;
            fac.GetMessEvent += Console.ReadLine;
            fac.StartTasks();
            fac.ContinueTask();
            fac.ParallelExample();
            Console.ReadKey();
            //var numbers = new int[] { 7, 2, 5, 5, 7, 6, 7 };
            //var result = numbers.Sum() + numbers.Skip(2).Take(3).Sum();
            //var y = numbers.GroupBy(x => x).Select(x =>
            //{
            //    return Delegat(x.Key);
            //});
            //var i = numbers.GroupBy(x => x);
            //var oo = i.Select(x => { return Delegat(x.Key); });
            //Console.WriteLine(result);


            //string res;
            //try
            //{
            //    res = GetNumber(1);
            //}
            //catch (Exception e)
            //{
            //    res = e.Message;
            //}

            //Console.WriteLine(int.Parse(res) * 100);


            //var magicValue = new MagicValue(1, 2);
            //MagicValue.ApplyRef(ref magicValue);
            //MagicValue.ApplyOut(out magicValue);
            //MagicValue.Apply(magicValue);

            //Console.WriteLine(magicValue.Left * magicValue.Right);
        }

        private static int Delegat(int el)
        {
            int re = 0;
            re += el;
            return re;
        }

        private static string GetNumber(int input)
        {
            try
            {
                throw new Exception(input.ToString());
            }
            catch (Exception e)
            {
                throw new Exception((int.Parse(e.Message) + 3).ToString());
            }
            finally
            {
                throw new Exception((++input).ToString());
            }

            return (input += 4).ToString();
        }


    }
    class MagicValue
    {
        public int Left { get; set; }
        public int Right { get; set; }

        public MagicValue(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public static void Apply(MagicValue magicValue)
        {
            magicValue.Left += 3;
            magicValue.Right += 4;
            magicValue = new MagicValue(5, 6);
        }

        public static void ApplyRef(ref MagicValue magicValue)
        {
            magicValue.Left += 7;
            magicValue.Right += 8;
            magicValue = new MagicValue(9, 10);
        }

        public static void ApplyOut(out MagicValue magicValue)
        {
            magicValue = new MagicValue(5, 2);
            magicValue.Left += 7;
            magicValue.Right += 8;

        }

    }

    class FactoryT
    {
        public delegate void ShowMDel(string message);
        public delegate string GetMessDel();
        public event ShowMDel ShowEvent;
        public event GetMessDel GetMessEvent;

        static CancellationTokenSource cancellation = new CancellationTokenSource();
        CancellationToken token = cancellation.Token;

        public void StartTasks()
        {
            Task outer = Task.Factory.StartNew(() =>
             {
                 ShowEvent("outer started");
                 var inner = Task.Factory.StartNew(() =>
                   {
                       ShowEvent("inner started");
                       Thread.Sleep(100);
                       ShowEvent("inner finished");
                   }, TaskCreationOptions.AttachedToParent);
                 ShowEvent("outer finished");
             });
            outer.Wait();
            Task.WaitAll(outer);
            ShowEvent("Main finished");
        }

        public void ContinueTask()
        {
            Task task1 = new Task(() =>
              {
                  ShowEvent(string.Format("Id task {0}", Task.CurrentId));
                  Display(token);
              });
            Task task2 = task1.ContinueWith(Display);

            task1.Start();
            task2.Wait();
            ShowEvent("UI is workig");
            ShowEvent("Press Y to cancel task");
            string input=GetMessEvent.Invoke();
            if (input == "Y")
            {
                cancellation.Cancel();
                ShowEvent("You pressed " + input + " prosess was canceled");
            }
            else ShowEvent("You pressed " + input + " prosess wasn't canceled");

            Task task3 = new Task(() =>
            {
                ShowEvent(string.Format("Id task {0}", Task.CurrentId));
                Display(token);
            });
            task3.Start();
        }


        private void Display(Task task)
        {
            ShowEvent(string.Format("Id current task {0}", Task.CurrentId));
            ShowEvent(string.Format("Id previos task {0},", task.Id));
            Thread.Sleep(200);
        }
        private void Display()
        {
            ShowEvent(string.Format("Id current task {0}", Task.CurrentId));
            Thread.Sleep(200);
        }
        private void Display(CancellationToken token)
        {
           if(token.IsCancellationRequested)
            ShowEvent(string.Format("Id current task canceled {0}", Task.CurrentId));
        }
        public void ParallelExample()
        {
            Parallel.Invoke(Display,
                () => ShowEvent("Parallel task 1"),
                () => ShowEvent("Parallel task 2"));
            new Task(() =>
            {
                Thread.Sleep(200);
                cancellation.Cancel();

            }).Start();
            try
            {
                Parallel.For(1, 10, new ParallelOptions { CancellationToken = token }, Factorial);
            }
            catch(OperationCanceledException ex)
            {
                ShowEvent("Cancel by token "+ex.HResult);
            }
            ParallelLoopResult result = Parallel.ForEach<int>(
                new List<int> { 1, 2, 3, 4, 5 }, FactorialBreak);
            if (!result.IsCompleted)
                ShowEvent(string.Format("Break parallel {0}",result.LowestBreakIteration));

        }

        private void Factorial(int x)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
            }
            Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            Console.WriteLine("Факториал числа {0} равен {1}", x, result);
            Thread.Sleep(3000);
        }

        private void FactorialBreak(int x,ParallelLoopState loopState)
        {
            int result = 1;

            for (int i = 1; i <= x; i++)
            {
                result *= i;
                if (i == 5) loopState.Break();
            }
            Console.WriteLine("Выполняется задача {0}", Task.CurrentId);
            Console.WriteLine("Факториал числа {0} равен {1}", x, result);
            Thread.Sleep(3000);
        }


    }

}
