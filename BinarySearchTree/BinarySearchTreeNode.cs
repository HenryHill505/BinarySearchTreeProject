using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode<T> LeftChild;
        public BinarySearchTreeNode<T> RightChild;
        public T value;

        public BinarySearchTreeNode(T value)
        {
            this.value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
