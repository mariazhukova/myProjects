using System;

namespace checkedVDunchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxValue=int.MaxValue;
            var i = unchecked(maxValue + 10);
            Console.WriteLine("Unchecked: {0}",i.ToString());
            var it = checked(maxValue );
            Console.WriteLine("Checked: {0}",it.ToString());
            Console.ReadKey();
        }
    }
}
