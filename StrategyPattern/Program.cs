using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Volvo", 4, new PtrolEngine());
            car.Move();
            car.movable = new ElectricEngine();
            car.Move();
            Console.ReadKey();
        }
    }
}
