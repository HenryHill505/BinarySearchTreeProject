using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree<T> where T:IComparable
    {
        BinarySearchTreeNode<T> rootNode;

        public BinarySearchTree(T rootValue)
        {
            rootNode = new BinarySearchTreeNode<T>(rootValue);
        }

        
    }
}
