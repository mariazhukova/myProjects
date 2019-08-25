using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
   public class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Code is writing");
        }
        public void SaveCode()
        {
            Console.WriteLine("Code saved");
        }
    }
}
