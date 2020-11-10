using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeRound2
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree1 = new BinarySearchTree();
            Node node1 = new Node(6);
            Node node2 = new Node(8);
            Node node3 = new Node(5);
            Node node4 = new Node(7);
            Node node5 = new Node(3);
            Node node6 = new Node(4);

            tree1.AddNode(node1);
            tree1.AddNode(node2);
            tree1.AddNode(node3);
            tree1.AddNode(node4);
            tree1.AddNode(node5);
            tree1.AddNode(node6);


            Console.WriteLine(tree1.SearchNode(3));
            Console.WriteLine(tree1.SearchNode(10));
        }
    }
}
