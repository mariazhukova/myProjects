using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class PizzaDecorator : Pizza
    {
        public PizzaDecorator(string name, Pizza pizza) : base(name) { }
    }
}
