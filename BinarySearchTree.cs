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
            List<int> list = new List<int>();
            if(root == null)
            {
                root = node;
                list.Add(root.data);
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
        public void search(int i)
        {
            i = i;
            while (right.data==i||left.data==i)
            {
                Console.WriteLine("founded");
            }
        }
        
    }
}
