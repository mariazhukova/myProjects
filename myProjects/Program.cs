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
                where (int)hashtable[name]> 25
                orderby name
                select name;

            var r2 =
                from int age in hashtable.Values
                orderby hashtable[age] descending
                select age;

            var youngest = r2.First<int>();
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
