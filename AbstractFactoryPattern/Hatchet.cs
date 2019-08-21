using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Hatchet : Wepon
    {
        public override void Shoot()
        {
            Console.WriteLine("hack");
        }
    }
}
