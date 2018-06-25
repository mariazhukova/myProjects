using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public class GrnericDelegate
    {
        delegate void GenericDelegate<T>(T obj);

        public void CreateGenericDelegate()
        {
            GenericDelegate<string> strgenericdekegete = new GenericDelegate<string>(MygenericFun);
            strgenericdekegete("string");
           
            GenericDelegate<int> intgenericDelegate = new GenericDelegate<int>(MygenericFun);
            intgenericDelegate.Invoke(109);
        }

        private void MygenericFun(string obj)
        {
            Console.WriteLine("Generig delegate by {0}",obj);
        }

        private void MygenericFun(int obj)
        {
            Console.WriteLine("Generig delegate by integer {0}",obj);
        }
    }
}
