using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Node
    {
        public int data;
        public Node(int data)
        {
            this.data = data;           
        }
        BinarySearchTree tree = new BinarySearchTree();
        public void Add(Node node)
        {
            tree.insertroot(node);
        }
    }
}
