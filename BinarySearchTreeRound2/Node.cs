using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTreeRound2
{
    class Node
    {

        //variables
        public int data;
        public Node RightNode;
        public Node LeftNode;
        
        //constructor
        public Node(int data)
        {
            this.data = data;
            RightNode = null;
            LeftNode = null;
        }

        //methods
    }
}
