using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Auto : Transport
    {
        public string Name { get ; set; }

        public Auto(string name)
        {
            Name = name;
        }
        public void Move()
        {
            Console.WriteLine($"{Name} is moving");
        }
    }
}
