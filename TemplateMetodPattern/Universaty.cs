using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMetodPattern
{
    public class Universaty : Education
    {
        protected override sealed void PassExam()
        {
            Console.WriteLine("Pass general exams");
            Console.WriteLine("Pass a diploma work");
        }
        protected override sealed void Enter()
        {
            Console.WriteLine("Pass enter exams");
        }

        protected override sealed void GetDocument()
        {
            Console.WriteLine("Get a diploma");
        }

        protected override sealed void Study()
        {
            Console.WriteLine("Attend lessons");
            Console.WriteLine("Do homework");
            Console.WriteLine("Attend practis");
        }
    }
}
