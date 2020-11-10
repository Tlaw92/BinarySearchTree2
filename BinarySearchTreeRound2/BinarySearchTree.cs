using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeRound2
{
    class BinarySearchTree
    {
        //variables
        public Node rootNode;


        //constructor
        public BinarySearchTree()
        {
            rootNode = null;
        }

        //methods

        //  Create an ‘Add()’ method to allow theadding of a new node(with data) 
        //  to the binary search tree data structure.
        public void AddNode(Node nodeToAdd)
        {
            if(rootNode == null)
            {
                rootNode = nodeToAdd;
            }
            else
            {
                Node currentNode = rootNode;
                while (true)
                {
                    if (currentNode.data > nodeToAdd.data)
                    {
                        if (currentNode.LeftNode == null)
                        {
                            currentNode.LeftNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                    }
                    else if (currentNode.data < nodeToAdd.data)
                    {
                        if (currentNode.RightNode == null)
                        {
                            currentNode.RightNode = nodeToAdd;
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightNode;
                        }
                    }
                }
            }
        }


        //  Create a ‘Search()’ method to allow the ability to search for a specific value 
        //  within the binary search tree data structure.
        public bool SearchNode(int nodeToFind)
        {
            bool searchContains = false;
            Node currentNode = rootNode;
            while (searchContains == false)
            {
                if (nodeToFind == currentNode.data)
                {
                    searchContains = true;
                }
                else
                {
                    if (nodeToFind < currentNode.data)
                    {
                        if (currentNode.LeftNode == null)
                        {
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.LeftNode;
                        }
                    }
                    else
                    {
                        if (currentNode.RightNode == null)
                        {
                            break;
                        }
                        else
                        {
                            currentNode = currentNode.RightNode;
                        }
                    }

                }
            }
            return searchContains;
        }
    }
}
