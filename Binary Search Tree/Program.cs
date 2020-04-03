using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Search_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();
            binarySearchTree.Add(100);
            binarySearchTree.Add(75);
            binarySearchTree.Add(125);
            binarySearchTree.Add(130);
            binarySearchTree.Add(111);
            binarySearchTree.Add(130);
            binarySearchTree.Add(1000);
        }
    }
}
