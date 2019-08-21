using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class HumanCell : Prototype
    {
        string Membrane { get; set; }
        string Kernel { get; set; }

        public HumanCell(string kernel,string membrane)
        {
            Kernel = kernel;
            Membrane = membrane;
        }
        public override Prototype Clone()
        {
            return new HumanCell(Kernel, Membrane);
        }

        public override string GetInfo()
        {
            return String.Format("Curent cell with Kernel {0} and Memebrane {1}", Kernel, Membrane);
        }
    }
}
