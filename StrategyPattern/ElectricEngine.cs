using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class ElectricEngine : MovableStratagy
    {
        public void Move()
        {
            Console.WriteLine("Electric engine started");
        }
    }
}
