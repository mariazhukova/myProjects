using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Milk:MilkProduct
    {
        Task milk = new Task(()=> {
            Thread.Sleep(1000);
            Console.WriteLine("Milk is ready!");
        });
        
        public Milk()
        {
            ShowResult += start;
            ResultIs();
        }
        private void start()
        {
            milk.Start();
        }
    }
}
