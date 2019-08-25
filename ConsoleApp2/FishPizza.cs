using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class FishPizza : PizzaDecorator
    {
        Pizza Pizza;
        public FishPizza(Pizza pizza):base(pizza.Name+" with fish", pizza)
        {
            Pizza = pizza;
        }
        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}
