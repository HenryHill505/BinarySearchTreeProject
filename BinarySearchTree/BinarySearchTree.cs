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

        public void Add(T valueToAdd)
        {
            BinarySearchTreeNode<T> currentNode = rootNode;

            while (true)
            {
                if (valueToAdd.CompareTo(currentNode.value) < 0)
                {
                    //Value goes left
                    if (currentNode.leftChild == null)
                    {
                        currentNode.leftChild = new BinarySearchTreeNode<T>(valueToAdd);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.leftChild;
                    }
                }
                else
                {
                    //Value goes right
                    if (currentNode.rightChild == null)
                    {
                        currentNode.rightChild = new BinarySearchTreeNode<T>(valueToAdd);
                        break;
                    }
                    else
                    {
                        currentNode = currentNode.rightChild;
                    }
                }
            }
        }
        public bool Search(T searchValue)
        {
            BinarySearchTreeNode<T> currentNode = rootNode;

            while (true)
            {
                if (searchValue.CompareTo(currentNode.value) == 0)
                {
                    //Value found
                    return true;
                }
                else if (searchValue.CompareTo(currentNode.value) < 0)
                {
                    //Go left
                    currentNode = currentNode.leftChild;
                }
                else
                {
                    //Go right
                    currentNode = currentNode.rightChild;
                }
                if (currentNode == null)
                {
                    return false;
                }
            }
        }
    }
}
