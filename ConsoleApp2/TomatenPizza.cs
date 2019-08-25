using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class TomatenPizza : PizzaDecorator
    {
        Pizza Pizza;
        public TomatenPizza(Pizza pizza) : base(pizza.Name+" mit tomaten",pizza)
        {
            Pizza = pizza;
        }
        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}
