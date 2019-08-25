using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class ItalianPizza : Pizza
    {
		public ItalianPizza(string name) : base(name) { }
        public override int GetCost()
        {
            return 5;
        }
    }
}
