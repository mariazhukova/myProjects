using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class GasState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("to liquid");
            water.State = new LiquidState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("to gas by heating");
        }
    }
}
