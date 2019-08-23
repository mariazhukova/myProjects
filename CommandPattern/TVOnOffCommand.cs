using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TVOnOffCommand : Command
    {
        TV tV;

        public TVOnOffCommand(TV tV)
        {
            this.tV = tV;
        }
        public void Execute()
        {
            tV.On();
        }

        public void Undo()
        {
            tV.Off();
        }

    }
}
