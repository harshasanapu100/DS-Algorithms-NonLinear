using System;
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
                Console.WriteLine("Pushing the elements 10, 5, 15, 6, 1, 8, 12, 18, 17 to Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;

                customBinarySearchTree.Insert(10);
                customBinarySearchTree.Insert(5);
                customBinarySearchTree.Insert(15);
                customBinarySearchTree.Insert(6);
                customBinarySearchTree.Insert(1);
                customBinarySearchTree.Insert(8);
                customBinarySearchTree.Insert(12);
                customBinarySearchTree.Insert(18);
                customBinarySearchTree.Insert(6);
                customBinarySearchTree.Insert(17);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 15 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(15));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 12 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(12));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 20 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(20));

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the element 6 in Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.Find(6));

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
