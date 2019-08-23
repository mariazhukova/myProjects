using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TVVolumeComand : Command
    {
        TV tV;
        public TVVolumeComand(TV tV)
        {
            this.tV = tV;
        }
        public void Execute()
        {
            tV.IcreaseVolume();
        }

        public void Undo()
        {
            tV.DecreaseVolume();
        }
        
    }
}
