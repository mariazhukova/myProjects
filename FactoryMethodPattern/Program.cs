using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write M to product Milk or C to product Cheese");
            Maker maker;
            string input=String.Empty;
            while (input != "exit")
            {
                if (Console.KeyAvailable)
                {
                    input = Console.ReadLine();
                    if (input == "M")
                    {
                        maker = new MilkMaker();
                        maker.MakeProduct();
                    }
                    else if (input == "C")
                    {
                        maker = new CheeseMaker();
                        maker.MakeProduct();
                    }
                    else
                        Console.WriteLine("Wrong answer, you will not have product!");
                        
                }
            }
            
        }
    }
}
