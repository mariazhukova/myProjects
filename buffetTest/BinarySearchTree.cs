using Algoritms.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class BinarySearchTree
    {
        public BinarySearchNode root { get; set; }
        public int Length { get; set; }
        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            var newelement = new BinarySearchNode() { Value = value, Left = null, Right = null };
            if (root == null)
                root = newelement;
            else
            {
                var curent = new BinarySearchNode();
                curent = root;
                while (true)
                {
                    if (curent.Right == null && newelement.Value > curent.Value)
                    {
                        curent.Right = newelement;
                        break;
                    }
                    else if (curent.Left == null && newelement.Value < curent.Value)
                    {
                        curent.Left = newelement;
                        break;
                    }
                    else if (newelement.Value > curent.Value)
                        curent = (BinarySearchNode)curent.Right;
                    else if (newelement.Value < curent.Value)
                        curent = (BinarySearchNode)curent.Left;
                        
                }
            }
            Length++;
        }

        public BinarySearchNode Lookup(int value)
        {
            if (root == null)
                return null;
            else
            {
                var curent = new BinarySearchNode();
                curent = root;
                while (curent != null)
                {
                    if (value > curent.Value)
                       curent = (BinarySearchNode)curent.Right;
                    else if (value < curent.Value)
                       curent = (BinarySearchNode)curent.Left;
                    else if (value == curent.Value)
                        return curent;
                }

                return null;
            }
        }
        public void Remove(int value)
        {
            var deliting = Lookup(value);
            var curent = new BinarySearchNode();
            var temp = new BinarySearchNode();

            if ((BinarySearchNode)deliting.Left != null)
            {
                curent = (BinarySearchNode)deliting.Left;
                
                do
                {
                    temp = curent;
                    if (curent.Right != null)
                        curent = (BinarySearchNode)curent.Right;

                }
                while (curent.Right != null);

            deliting.Value = curent.Value;
                if (curent.Value == temp.Value)
                    deliting.Left = null;
                else if (curent.Left == null)
                    temp.Right = null;
                else if(curent.Left != null)
                    temp.Right = curent.Left;
            }
            else if ((BinarySearchNode)deliting.Right != null)
            {
                curent = (BinarySearchNode)deliting.Right;

                do
                {
                    temp = curent;
                    if (curent.Left != null)
                        curent = (BinarySearchNode)curent.Left;

                }
                while (curent.Left != null);

                deliting.Value = curent.Value;
                if (curent.Value == temp.Value)
                    deliting.Right = null;
                else if (curent.Right == null)
                    temp.Left = null;
                else if (curent.Right != null)
                    temp.Left = curent.Right;
            }
            else
            {
                curent = root;
                bool isLeft = false;
                do
                {
                    temp = curent;
                    if (deliting.Value > curent.Value)
                    {
                        curent = (BinarySearchNode)curent.Right;
                        isLeft = false;
                    }
                    else
                    {
                        curent = (BinarySearchNode)curent.Left;
                        isLeft = true;
                    }
                        
                } while (curent.Value != deliting.Value);

                if (isLeft)
                    temp.Left = null;
                else
                    temp.Right = null;

            }
         
        }
        //copypast
        public List<int> BreadthFirstSearch()
        {
            List<int> resultList = new List<int>();
            var localroot = root;
            int count = Length;
            Queue<BinarySearchNode> queue = new Queue<BinarySearchNode>();
            queue.Enqueue(root);
           
            while(count>0)
            {
                localroot = queue.Dequeue();
                resultList.Add(localroot.Value);
                
                if (localroot.Left != null)
                {
                    queue.Enqueue((BinarySearchNode)localroot.Left);
                }
                if (localroot.Right != null)
                {
                    queue.Enqueue((BinarySearchNode)localroot.Right);
                }
                count--;
            }
            return resultList;

        }
        //copypasta
        public List<int> BreadthFirstSearchRecursion(Queue<BinarySearchNode> queue, List<int> list)
        {
            if (queue.Count==0)
                return list;
            var localroot = queue.Dequeue();
            list.Add(localroot.Value);
            if (localroot.Left != null)
            {
                queue.Enqueue((BinarySearchNode)localroot.Left);
            }
            if (localroot.Right != null)
            {
                queue.Enqueue((BinarySearchNode)localroot.Right);
            }

            return BreadthFirstSearchRecursion(queue,list);

        }

//        function traverse(node)
//        {
//            const tree = { value: node.value };
//        tree.left = node.left === null ? null : traverse(node.left);
//        tree.right = node.right === null ? null : traverse(node.right);
//  return tree;
//}
}
    public class BinarySearchNode
    {
        public int Value { get; set; }
        public object Left { get; set; }
        public object Right { get; set; }
    }
}
