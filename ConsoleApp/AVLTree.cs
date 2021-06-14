using System;
using CustomLibrary;

namespace ConsoleApp
{
    class AVLTree
    {
        static void AVLTreeMain(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the AVL Tree with basic Operations");
                Console.ForegroundColor = ConsoleColor.White;

                CustomAVLTree customAVLTree = new CustomAVLTree();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements 20, 10, 30, 6, 14, 24, 3, 8, 26 to Binary Search Tree");
                Console.ForegroundColor = ConsoleColor.White;

                customAVLTree.Insert(20);
                customAVLTree.Insert(10);
                customAVLTree.Insert(30);
                customAVLTree.Insert(6);
                customAVLTree.Insert(14);
                customAVLTree.Insert(24);
                customAVLTree.Insert(3);
                customAVLTree.Insert(8);
                customAVLTree.Insert(26);
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
