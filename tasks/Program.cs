using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 7, 2, 5, 5, 7, 6, 7 };
            var result = numbers.Sum() + numbers.Skip(2).Take(3).Sum();
            var y = numbers.GroupBy(x => x).Select(x =>
            {
                return Delegat(x.Key);
            });
            var i = numbers.GroupBy(x => x);
            var oo = i.Select(x => { return Delegat(x.Key);});
            Console.WriteLine(result);


            string res;
            try
            {
                res = GetNumber(1);
            }
            catch (Exception e)
            {
                res = e.Message;
            }

            Console.WriteLine(int.Parse(res) * 100);


            var magicValue = new MagicValue(1, 2);
            MagicValue.ApplyRef(ref magicValue);
            MagicValue.ApplyOut(out magicValue);
            MagicValue.Apply(magicValue);

            Console.WriteLine(magicValue.Left * magicValue.Right);
        }

        private static int Delegat(int el)
        {
            int re=0;
            re+= el;
            return re;
        }

        private static string GetNumber(int input)
        {
            try
            {
                throw new Exception(input.ToString());
            }
            catch (Exception e)
            {
                throw new Exception((int.Parse(e.Message) + 3).ToString());
            }
            finally
            {
                throw new Exception((++input).ToString());
            }

            return (input += 4).ToString();
        }
       

    }
    class MagicValue
    {
        public int Left { get; set; }
        public int Right { get; set; }

        public MagicValue(int left, int right)
        {
            Left = left;
            Right = right;
        }

        public static void Apply(MagicValue magicValue)
        {
            magicValue.Left += 3;
            magicValue.Right += 4;
            magicValue = new MagicValue(5, 6);
        }

        public static void ApplyRef(ref MagicValue magicValue)
        {
            magicValue.Left += 7;
            magicValue.Right += 8;
            magicValue = new MagicValue(9, 10);
        }

        public static void ApplyOut(out MagicValue magicValue)
        {
            magicValue = new MagicValue(5, 2);
            magicValue.Left += 7;
            magicValue.Right += 8;
            
        }

    }
}
