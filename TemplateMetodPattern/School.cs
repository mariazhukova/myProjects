using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMetodPattern
{
    public class School : Education
    {
        protected override sealed void Enter()
        {
            Console.WriteLine("Go to school");
        }

        protected override sealed void GetDocument()
        {
            Console.WriteLine("Get an attistate");
        }

        protected override sealed void Study()
        {
            Console.WriteLine("Attend lessons");
            Console.WriteLine("Do a homework");
        }
    }
}
