using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySearchTree
    {
        public Node left;
        public Node right;
        public Node root;
        public BinarySearchTree()
        {            
            root = null;
        }
        public void insertroot(Node node)
        {
            if(root == null)
            {
               root = node;
                Console.WriteLine("root: "+root.data);
            }
            else
            {
                if(root.data > node.data)
                {
                    left = node;
                    Console.WriteLine("left side:"+left.data);
                    
                }
                if(root.data < node.data)
                {
                    right = node;
                    Console.WriteLine("right side:"+node.data);
                }
            }
        }
        
    }
}
