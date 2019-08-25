using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    interface Animal
    {
        string Name { get; set; }
        void Run();
    }
}
