using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyGraph
    {
    }

    public class GraphNode
    {
        KeyValuePair<int, List<int>> node;

        public int value { get => node.Key; set { node = new KeyValuePair<int, List<int>>(value, new List<int>()); } }
        public int edge { set { node.Value.Add(value); } }

        public List<int> GetAllEdges => node.Value;

    }
}
