using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create new Heroes?");
            var input = Console.ReadKey().Key;
            if (input == ConsoleKey.Enter)
            {
                Hero elf = new Hero(new ElfHero());
                Hero orc = new Hero(new OrcHero());
                elf.Run();
                orc.Run();
                elf.Shoot();
                orc.Shoot();

            }
            else Console.WriteLine("Bay");
            Console.ReadKey();
        }
    }
}
