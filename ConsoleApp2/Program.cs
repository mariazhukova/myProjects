using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza = new ItalianPizza("italian");
            Pizza pizzaFrench = new FranchPizza("french");

            pizza = new TomatenPizza(pizza);
            pizzaFrench = new FishPizza(pizzaFrench);

            Console.WriteLine($"{pizza.Name} cost {pizza.GetCost()}");
            Console.WriteLine($"{pizzaFrench.Name} cost {pizzaFrench.GetCost()}");

            Console.ReadKey();
        }
    }
}
