using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    public class PtrolEngine : MovableStratagy
    {
        public void Move()
        {
            Console.WriteLine("Patrol engine started");
        }
    }
}
