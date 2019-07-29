using System;
using System.Collections.Generic;
using System.Text;

namespace StatePattern
{
    class SolidWaterState : IWaterState
    {
        public void Frost(Water water)
        {
            Console.WriteLine("freezing...");
        }

        public void Heat(Water water)
        {
            Console.WriteLine("to liquid");
            water.State = new LiquidState();
        }
    }
}
