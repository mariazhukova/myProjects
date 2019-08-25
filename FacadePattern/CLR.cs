using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    public class CLR
    {
        public void Execute()
        {
            Console.WriteLine("Application is executing");
        }
        public void Finish()
        {
            Console.WriteLine("Application is finished");
        }
    }
}
