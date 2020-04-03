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
            binarySearchTree.DisplaySearchResults(100);
            binarySearchTree.DisplaySearchResults(75);
            binarySearchTree.DisplaySearchResults(125);
            binarySearchTree.DisplaySearchResults(130);
            binarySearchTree.DisplaySearchResults(111);
            binarySearchTree.DisplaySearchResults(130);
            binarySearchTree.DisplaySearchResults(1000);
            binarySearchTree.DisplaySearchResults(1);
            binarySearchTree.DisplaySearchResults(80);
            binarySearchTree.DisplaySearchResults(105);
            binarySearchTree.DisplaySearchResults(120);
            binarySearchTree.DisplaySearchResults(129);
            binarySearchTree.DisplaySearchResults(200);

        }
    }
}
