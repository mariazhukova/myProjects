using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class Volume
    {
        int State = 0;
        int MaxState = 50;
        public void Icrease()
        {
            State = (State == MaxState) ? MaxState : State+1;
            Console.WriteLine($"Volume is {State}");
        }

        public void Decrease()
        {
            State = (State == 0) ? 0 : State - 1;
            Console.WriteLine($"Volume is {State}");

        }
    }
}
