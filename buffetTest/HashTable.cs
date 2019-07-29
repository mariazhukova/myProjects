using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    /// <summary>
    /// this code implements theoretical methods 
    /// how HashTable works under the hood
    /// </summary>
    class HashTable
    {
        private List<KeyValuePair<int, KeyValuePair<string,int>>> data;
        public HashTable(int size)
        {
            data = new List<KeyValuePair<int, KeyValuePair<string, int>>>(size);
        }


        private int hash(string key)
        {
            int _hash = 0;
            for (int i = 0; i < key.Length; i++)
                _hash = (_hash + key.ElementAt(i) * i) % this.data.Capacity;
            return _hash;
        }

        public void set(string key, int value)
        {
            KeyValuePair<string, int> obj = new KeyValuePair<string, int>(key, value);
            var h = hash(key);
            data.Add(new KeyValuePair<int, KeyValuePair<string, int>>(h,obj));
        }

        public IEnumerable<string> keys()
        {
            if (data.Count > 0)
                return data.Select(el => el.Value.Key);
            else return null;
        }

        public int getValue(string key)
        {
            int _hash = hash(key);
            return data.Select(el =>
            {
                if (el.Key == _hash)
                    return el.Value.Value;
                else return 0;
            }).First();
        }
    }
}
