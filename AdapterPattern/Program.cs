using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Camel camel = new Camel();
            Auto auto = new Auto("Volvo");
            Driver driver = new Driver();
            AnimalToTransportAdapter Transportadapter = new AnimalToTransportAdapter(camel);
            driver.Drive(auto);
            driver.Drive(Transportadapter);

            Console.ReadKey();

        }
    }
}
