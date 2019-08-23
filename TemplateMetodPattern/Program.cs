using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMetodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            School school = new School();
            Universaty universaty = new Universaty();

            school.Learn();
            universaty.Learn();

            Console.ReadKey();
        }
    }
}
