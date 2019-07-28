using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyStackBasedArray
    {
        List<int> array;
        
        public MyStackBasedArray()
        {
            array = new List<int>();
        }
        public int peek()
        {
            if (array.Count > 0)
                return array.Last();
            return 0;
        }

        public void push(int value)
        {
            array.Add(value);
        }

        public int pop()
        {
            var last = array.Last();
            array.Remove(last);
            return last;
        }

        public bool IsEmpty
        {
            get
            {
                if (array.Count > 0) return false;
                return true;
            }
            private set { }
        }
    }
}
