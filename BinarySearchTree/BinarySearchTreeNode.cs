using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTreeNode<T>
    {
        public BinarySearchTreeNode<T> leftChild;
        public BinarySearchTreeNode<T> rightChild;
        public T value;

        public BinarySearchTreeNode(T value)
        {
            this.value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
