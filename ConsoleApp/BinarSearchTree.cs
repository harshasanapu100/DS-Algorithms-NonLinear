﻿using System;
using CustomLibrary;

namespace ConsoleApp
{
    class BinarSearchTree
    {
        static void Main(string[] args)
        {
            try
            {
                #region CustomBinarySearchTree
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the Binary Search Tree with basic Operations");
                Console.ForegroundColor = ConsoleColor.White;

                CustomBinarySearchTree customBinarySearchTree = new CustomBinarySearchTree();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements 20, 10, 30, 6, 14, 24, 3, 8, 26 to Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;

                customBinarySearchTree.Insert(20);
                customBinarySearchTree.Insert(10);
                customBinarySearchTree.Insert(30);
                customBinarySearchTree.Insert(6);
                customBinarySearchTree.Insert(14);
                customBinarySearchTree.Insert(24);
                customBinarySearchTree.Insert(3);
                customBinarySearchTree.Insert(8);
                customBinarySearchTree.Insert(26);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 26 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(26));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 24 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(24));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 20 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(20));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 4 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(4));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pre order Traversal results");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.TraversePreOrder();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In order Traversal results");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.TraverseInOrder();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Post order Traversal results");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.TraversePostOrder();

                Console.ReadKey();
                #endregion
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
    }
}