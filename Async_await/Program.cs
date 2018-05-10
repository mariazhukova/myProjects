using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Async_await
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayResultAsync();
            ResultOfCycle();
            Console.ReadLine();
        }
        static async void DisplayResultAsync()
        {
            int num = 5;

            int result = await FactorialAsync(num);
            var result2 = await ResultOfCycle();
            Thread.Sleep(3000);
            Console.WriteLine("Факториал числа {0} равен {1}", num, result);
            Console.WriteLine("2={0}", result2);
              }

        static Task<int> FactorialAsync(int x)
        {
            int result = 1;

            return Task.Run(() =>
            {
                for (int i = 1; i <= x; i++)
                {
                    result *= i;
                }
                return result;
            });
        }
       static async Task SomeCycleAsync()
        {
            var myTask = await ResultOfCycle();

       }
        static Task<int> ResultOfCycle()
        {
            int sum = 0;

            return Task.Run(() =>
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    sum += i;
                }
                return sum;
            });
            
        }
    }
}
