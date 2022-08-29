using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BSTOperations<K>
    {

        BSTNode<K> Root;

        public void AddNode(K key)
        {
            if (Root == null)
            {
                Root = new BSTNode<K>(key);
                Console.WriteLine("{0} is added at Root", key);
            }
            else
            {
                BSTNode<K> Temp;
                Temp = Root;
                int CompareWithKey;

                while (true)
                {
                    CompareWithKey = ((int.Parse(Convert.ToString(key))) - (int.Parse(Convert.ToString(Temp.key))));
                    if (CompareWithKey < 0)
                    {
                        if (Temp.LeftNode == null)
                        {
                            Temp.LeftNode = new BSTNode<K>(key);

                            Console.WriteLine("{0} is added at left Node of Parent Node {1}", key, Temp.key);
                            break;
                        }
                        else
                        {
                            Temp = Temp.LeftNode;
                        }
                    }
                    else
                    {
                        if (Temp.RightNode == null)
                        {
                            Temp.RightNode = new BSTNode<K>(key);

                            Console.WriteLine("{0} is added at Right Node of Parent Node {1}", key, Temp.key);
                            break;
                        }
                        else
                        {
                            Temp = Temp.RightNode;
                        }
                    }
                }
            }

        }
        public void SearchNode(K key)
        {
            if (Root == null)
            {
                Console.WriteLine("BST is Null");
            }
            else
            {
                BSTNode<K> Temp;
                Temp = Root;
                int Compare = 1;
                int count = 0;


                while (Compare != 0 && Temp != null)
                {
                    Compare = ((int.Parse(Convert.ToString(key))) - (int.Parse(Convert.ToString(Temp.key))));
                    if (Compare < 0)
                    {
                        Temp = Temp.LeftNode;
                    }
                    else if (Compare > 0)
                    {
                        Temp = Temp.RightNode;
                    }
                    else
                    {

                        count++;
                        Console.WriteLine();
                        Console.WriteLine("{0} is found  ", key);

                    }
                }
                if (count == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Element {0} isnot Found", key);
                }

            }
        }
    }
}
