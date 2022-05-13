// See https://aka.ms/new-console-template for more information
using System;
namespace BinarySearchTree
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Welcome to binary tree search!");
            BST<int> bst = new(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Insert(22);
            bst.Insert(40);
            bst.Insert(60);
            bst.Insert(95);
            bst.Insert(11);
            bst.Insert(65);
            bst.Display();
            bst.GetSize();
        }
    }
}

