using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class MicrowaveCommand : Command
    {
        Microwave microwave;
        int HeatingTime;
        public MicrowaveCommand(Microwave microwave, int heatingTime)
        {
            this.microwave = microwave;
            this.HeatingTime = heatingTime;
        }

        public void Execute()
        {
            microwave.Heat(HeatingTime);
            microwave.StopHeating();
        }

        public void Undo()
        {
            microwave.StopHeating();
        }
    }
}
