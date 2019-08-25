using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Camel : Animal
    {
        public string Name { get => "Camel"; set => value = "Camel"; }
         
        public void Run()
        {
            Console.WriteLine("Camel is running");
        }
    }
}
