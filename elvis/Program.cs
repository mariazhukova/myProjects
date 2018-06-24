using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elvis
{
    class Program
    {
        static void Main(string[] args)
        {
            var x=DoWork() ?? false;
            var y = false;
            y = x ?? true;
        }

        public static bool? DoWork()
        {
            bool? x;
            
            if(x ?? null) { return true; }
            { return null; }
        }
    }
}
