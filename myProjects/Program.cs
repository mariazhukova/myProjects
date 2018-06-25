using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myProjects
{
    class Program
    {


        static void Main(string[] args)
        {
            TestLinq();

        }
        static void PersonLinq()
        {
            List<string> personsList = new List<string>();
            Hashtable hashtable = new Hashtable();
            Person personV = new Person("Василий", 32);
            Person personB = new Person("Борис", 25);
            Person personL = new Person("Людмила", 27);

            hashtable.Add("Василий", 32);
            hashtable.Add("Борис", 25);
            hashtable.Add("Людмила", 27);


            var result =
                from string name in hashtable.Keys
                where (int)hashtable[name] > 25
                orderby name
                select name;

            var r2 =
                from int age in hashtable.Values
                orderby hashtable[age] descending
                select age;

            var youngest = r2.First<int>();
            Console.WriteLine(result);
            Console.ReadLine();


            // The Three Parts of a LINQ Query:
            //  1. Data source.
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

            // 2. Query creation.
            // numQuery is an IEnumerable<int>
            var numQuery =
                from num in numbers
                where (num % 2) == 0
                select num;

            // 3. Query execution.
            foreach (int num in numQuery)
            {
                Console.Write("{0,1} ", num);
            }

            List<int> numQuery2 =
        (from num in numbers
         where (num % 2) == 0
         select num).ToList();

            // or like this:
            // numQuery3 is still an int[]

            var numQuery3 =
                (from num in numbers
                 where (num % 2) == 0
                 select num).ToArray();

            var numCount = numbers.Where(n => n < 3 || n > 7).Count();
        }

        static IEnumerable TestLinq()
        {
            decimal[] loan = { 303m, 1000m, 85579m, 501.51m, 603m, 1200m, 400m, 22m };

            IEnumerable<decimal> lingQuery =
                from amount in loan
                where amount % 2 == 0
                orderby amount ascending
                select amount;
            return lingQuery;
        }
    }


}
