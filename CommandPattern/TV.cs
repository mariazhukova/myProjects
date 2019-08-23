using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class TV
    {
        Volume volume;
        public TV() {
            volume = new Volume();
        }

        public void On()
        {
            Console.WriteLine("TV is on");
        }

        public void Off()
        {
            Console.WriteLine("TV is off");
        }

        public void IcreaseVolume()
        {
            volume.Icrease();
        }

        public void DecreaseVolume()
        {
            volume.Decrease();
        }
    }
}
