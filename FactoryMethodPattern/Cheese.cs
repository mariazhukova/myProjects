using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Cheese:MilkProduct
    {

        Task milk = new Task(() => {
            Thread.Sleep(2000);
            Console.WriteLine("Cheese is ready!");
        });

        public Cheese()
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
