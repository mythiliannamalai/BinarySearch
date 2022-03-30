using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[]args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node node = new Node(56);
            Node node1 = new Node(30);
            Node Node2=new Node(70);
            tree.insertroot(node);
            tree.insertroot(node1);
            tree.insertroot(Node2);


        }
    }
}