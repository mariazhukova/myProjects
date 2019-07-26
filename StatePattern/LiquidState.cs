using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class LiquidState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("to solid");
            water.State = new SolidWaterState();
        }

        public void Heat(Water water)
        {
            Console.WriteLine("to gas");
            water.State = new GasState();

        }
    }
}
