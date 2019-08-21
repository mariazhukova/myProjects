using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class Run : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Run run run");
        }
    }
}
