using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserting the following numbers into a Binary Search Tree: { 122, 2, 56, 92, 1, 3, 400, 199, -45 }.\n");
            BinarySearchTree bst = new BinarySearchTree();
            bst.Insert(122);
            bst.Insert(2);
            bst.Insert(56);
            bst.Insert(92);
            bst.Insert(400);
            bst.Insert(199);
            bst.Insert(-45);

            int searchKey = 92;

            Console.WriteLine("Searching for {0} in Binary Search Tree... ", searchKey);
            BinarySearchTreeNode result = bst.Search(searchKey);

            string foundText = result != null ? "Found" : "Did not find";

            Console.WriteLine("{0} {1} in the Binary Search Tree.", foundText, searchKey);

            Console.ReadKey();
        }
    }
}
