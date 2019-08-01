using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritms
{
    class BinarySearchTree
    {
        private BinarySearchTreeElement root { get; set; }

        public BinarySearchTree()
        {
            root = null;
        }
        public void Insert(int value)
        {
            var newelement = new BinarySearchTreeElement() { Value = value, Left = null, Right = null };
            if (root == null)
                root = newelement;
            else
            {
                var curent = new BinarySearchTreeElement();
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
                        curent = (BinarySearchTreeElement)curent.Right;
                    else if (newelement.Value < curent.Value)
                        curent = (BinarySearchTreeElement)curent.Left;
                        
                }
            }
        }

        public BinarySearchTreeElement Lookup(int value)
        {
            if (root == null)
                return null;
            else
            {
                var curent = new BinarySearchTreeElement();
                curent = root;
                while (curent != null)
                {
                    if (value > curent.Value)
                       curent = (BinarySearchTreeElement)curent.Right;
                    else if (value < curent.Value)
                       curent = (BinarySearchTreeElement)curent.Left;
                    else if (value == curent.Value)
                        return curent;
                }

                return null;
            }
        }
        public void Remove(int value)
        {
            var deliting = Lookup(value);
            var curent = new BinarySearchTreeElement();
            var temp = new BinarySearchTreeElement();

            if ((BinarySearchTreeElement)deliting.Left != null)
            {
                curent = (BinarySearchTreeElement)deliting.Left;
                
                do
                {
                    temp = curent;
                    if (curent.Right != null)
                        curent = (BinarySearchTreeElement)curent.Right;

                }
                while (curent.Right != null);

            deliting.Value = curent.Value;
            if (curent .Left == null)
                temp.Right = null;
            else
                temp.Left = null;
            }
         
        }
    }
    public class BinarySearchTreeElement
    {
        public int Value { get; set; }
        public object Left { get; set; }
        public object Right { get; set; }
    }
}
