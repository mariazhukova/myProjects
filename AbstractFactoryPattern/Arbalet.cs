using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Arbalet: Wepon
    {
        public override void Shoot()
        {
            Console.WriteLine("soaring arrow");
        }
    }
}
