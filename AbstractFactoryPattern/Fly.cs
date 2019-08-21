using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Fly : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Fly fly fly");
        }
    }
}
