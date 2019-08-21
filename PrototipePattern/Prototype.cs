using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public abstract class Prototype
    {
        public abstract Prototype Clone();
        public abstract string GetInfo();
    }
}
