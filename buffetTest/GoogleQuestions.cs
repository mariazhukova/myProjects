using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace buffetTest
{
    public class GoogleQuestions
    {
        public int FirstFactorial(int num)
        {
            int factorial = 1;
            for (int i = 1; i <= num; i++)
            {
                factorial *= i;
            }
            return factorial;

        }
        public string FirstReverse(string str)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public void LogAllPairsinArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] == array.Length && array[i] == array.Length)
                        break;
                    if (array[i] == array[j])
                        j++;

                    Console.WriteLine(array[i] + " " + array[j]);
                }
            }
        }
        public (int[] array, int sum, bool result) FindPairSum(int[] array, int sum)
        {
            (int[] array, int sum, bool result) result = (null, 0, false);
            int[] temp = new int[2];
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] + array[i + 1] == sum)
                {
                    temp.SetValue(array[i], 0);
                    temp.SetValue(array[i + 1], 1);
                    result = (temp, sum, true);
                    break;
                }
                else result = (temp, sum, false);

            }
            return result;
        }

        //beter solution
        public bool FindPairSum2(int[] arr, int sum)
        {
            Hashtable hashtable = new Hashtable();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (hashtable.Contains(arr[i]))
                    return true;
                else
                    hashtable.Add(sum - arr[i], true);
            }
            return false;
        }
        /// <summary>
        /// Get first duplicate element in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int GetFirstDublicate(int[] array)
        {
           Dictionary<int,bool> dic = new Dictionary<int,bool>();
            int i = 0;
            while (array.Length - 1 > i)
            {
                if (dic.ContainsKey(array[i]))
                    return array[i];
                dic.Add(array[i], true);
                i++;
            }
            return 0;
        }
        /// <summary>
        /// Get first duplicate element in an array
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int GetFirstDublicateNested(int[] array)
        {
           int result = 0;
           for(int i = 0; i < array.Length-1; i++)
           {
                for(int j = i+1; j < array.Length - 1; j++)
                {
                    if (array[i] == array[j] && (j-i==1))
                    {
                        result = array[i];
                        break;
                    }
                }
                if (result > 0) break;
            }
            return result;
        }
        
    }

    public class BSTNode
    {
        public int value { get; set; }
        public object Left { get; set; }
        public object Right { get; set; }
    }

    class BST
    {
        BSTNode node;
        private int Length { get; set; }
        public BST()
        {
          //  node = new BSTNode();
        }

        public void Insert(int item)
        {
            
            if (node==null)
                node = new BSTNode { Left = null, Right = null, value = item }; 
            else
            {
                var tempNode = node;
                var newelement = new BSTNode { Left = null, Right = null, value = item };
                tempNode = traverse(item, tempNode);
                if (tempNode.Left==null)
                    tempNode.Left = newelement;
                else tempNode.Right = newelement;
            }
            Length++;
        }

        /// <summary>
        /// Given a binary tree, determine if it is a valid binary search tree (BST).
        ///   2
        ///  / \
        /// 1   3
        /// </summary>
        /// input [2,1,3]
        /// output true
        public bool IsValidBST()
        {
           bool result = true;
           var localroot = node;
           Queue<BSTNode> queue = new Queue<BSTNode>();
           queue.Enqueue(node);

          while (queue.Count > 0)
          {
              localroot = queue.Dequeue();

              if (localroot.Left != null)
              {
                    if (localroot.value > ((BSTNode)localroot.Left).value)
                        queue.Enqueue((BSTNode)localroot.Left);
                    else
                    { result = false; break; }
                }
             if (localroot.Right != null)
              {
                    if (localroot.value < ((BSTNode)localroot.Right).value)
                        queue.Enqueue((BSTNode)localroot.Right);
                    else
                    { result = false; break; }
              }
          }
          return result;
            
        }

        //private BSTNode traverse(int item, BSTNode bSTNode)
        //{
        //    if (bSTNode.Left == null || bSTNode.Right == null)
        //        return bSTNode;

        //    if (item > bSTNode.value && bSTNode.Right != null)
        //        return traverse(item, (BSTNode)bSTNode.Right);
        //    else if (item < bSTNode.value && bSTNode.Left != null)
        //        return traverse(item, (BSTNode)bSTNode.Left);
        //    else return traverse(item, bSTNode);
        //}

        private BSTNode traverse(int item, BSTNode bSTNode)
        {
            if (bSTNode.Left == null || bSTNode.Right == null)
                return bSTNode;

            if (bSTNode.Left != null)
                return traverse(item, (BSTNode)bSTNode.Left);
            else if (bSTNode.Right != null)
                return traverse(item, (BSTNode)bSTNode.Right);
            else return traverse(item, bSTNode);
        }
    }
}

