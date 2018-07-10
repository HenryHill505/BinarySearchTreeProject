using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeNode<T>
    {
        BinarySearchTreeNode<T> LeftChild;
        BinarySearchTreeNode<T> RightChild;
        T value;

        public BinarySearchTreeNode(T value)
        {
            this.value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
