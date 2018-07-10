using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree<int> testTree = new BinarySearchTree<int>(100);
            testTree.Add(105);
            testTree.Add(95);
            testTree.Add(90);
        }
    }
}
