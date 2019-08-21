using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create blood cell");
            Prototype prototype = new HumanCell("bloodKernel", "bloodMembrane");
            var cloned = prototype.Clone();
            Console.WriteLine(prototype.GetInfo());
            Console.WriteLine("BloodCloned" + cloned.GetInfo());
            Console.WriteLine("Create skin cell");
            prototype = new HumanCell("skinKernel", "skinMembrane");
            var skinCloned = prototype.Clone();
            Console.WriteLine(prototype.GetInfo());
            Console.WriteLine("SkinCloned" + skinCloned.GetInfo());
            Console.ReadKey();

        }
    }
}
