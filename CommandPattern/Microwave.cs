using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Microwave
    {
        public Microwave()
        {

        }

        public void Heat(int sec)
        {
            Console.WriteLine("Food is heating...");
            Task.Delay(sec * 1000).GetAwaiter().GetResult();
        }

        public void StopHeating()
        {
            Console.WriteLine("Food is ready");
        }
    }
}
