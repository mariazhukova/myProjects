using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMetodPattern
{
    public abstract class Education
    {
        public void Learn()
        {
            Enter();
            Study();
            PassExam();
            GetDocument();
        }

        protected abstract void Enter();
        protected abstract void Study();
        protected virtual void PassExam()
        {
            Console.WriteLine("Pass exams");
        }
        protected abstract void GetDocument();
    }
}
