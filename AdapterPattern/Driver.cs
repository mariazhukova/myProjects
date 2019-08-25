using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Driver
    {
        public void Drive(Transport transport)
        {
            Console.WriteLine($"Driver drive {transport.Name}");
            transport.Move();
        }
    }
}
