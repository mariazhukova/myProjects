using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FranchPizza : Pizza
    {
        public FranchPizza(string name) : base(name) { }
        public override int GetCost()
        {
            return 8;
        }
    }
}
