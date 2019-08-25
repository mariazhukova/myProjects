using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class AnimalToTransportAdapter:Transport
    {
        Animal Animal;
        public AnimalToTransportAdapter(Animal animal)
        {
            Animal = animal;
            Name = animal.Name;
        }

        public string Name { get; set; }

        public void Move()
        {
            Animal.Run();
        }
    }
}
