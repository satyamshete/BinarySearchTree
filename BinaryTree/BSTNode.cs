using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    internal class BSTNode<K>
    {
        public K key;
        public BSTNode<K> LeftNode;
        public BSTNode<K> RightNode;

        public BSTNode(K key)
        {
            this.key = key;
            this.LeftNode = null;
            this.RightNode = null;
        }
    }
}

