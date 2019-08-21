using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create fruts cake");
            Baker baker = new Baker();
            CakeBuilder cakeBuilder = new FrutCake();
            var cake = baker.BakeCake(cakeBuilder);
            Console.WriteLine(cake.GetIngredients());
            Console.ReadKey();
        }
    }
}
