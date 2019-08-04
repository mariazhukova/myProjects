using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    class MyGraph
    {
        Dictionary<int, List<int>> adjacencyList;
        int Count { get => adjacencyList.Count; }
        public MyGraph()
        {
            adjacencyList = new Dictionary<int, List<int>>();
        }

        public void addNode(int node)
        {
            if(!adjacencyList.ContainsKey(node))
                adjacencyList.Add(node, new List<int>());
        }
        public void addEdge(int parentNode, int childNode)
        {
            if (adjacencyList.ContainsKey(parentNode))
                adjacencyList.ElementAt(parentNode).Value.Add(childNode);
            else addNode(parentNode);
            if (adjacencyList.ContainsKey(childNode))
                adjacencyList.ElementAt(childNode).Value.Add(parentNode);

        }

        public IEnumerable<string> ShowConnections()
        {
            StringBuilder s = new StringBuilder();
            foreach (var el in adjacencyList)
            {
                s.Clear();
                el.Value.ForEach(e => s.Append(e.ToString()+" "));
                yield return String.Format("{0} -> {1}", el.Key, s);
            }
        }

    }

    public class GraphNode
    {
        KeyValuePair<int, List<int>> node;

        public int value { get => node.Key; set { node = new KeyValuePair<int, List<int>>(value, new List<int>()); } }
        public int edge { set { node.Value.Add(value); } }

        public List<int> GetAllEdges => node.Value;

    }
}
