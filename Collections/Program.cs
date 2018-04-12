using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            var listEmployee = new List<Tuple<int, string, string>>

           {

               Tuple.Create(1, "Joydip Kanjilal", "INDIA"),

               Tuple.Create(2, "Michael Stevens", "USA" ),

               Tuple.Create(3, "Steve Barnes", "USA" )

           };

            foreach (Tuple<int, string, string> tuple in listEmployee)

            {

                Console.WriteLine(tuple.Item2);

            }

            Console.Read();
        }
    }
}
