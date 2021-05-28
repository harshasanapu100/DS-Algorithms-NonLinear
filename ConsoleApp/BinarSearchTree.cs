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

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Height of the tree is");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.CalculateHeightOfTree());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Minimum value in tree is");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.FindMinimumValueInTree());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maximum value in tree is");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.FindMaximumValueInTree());


                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Minimum value in Binary Search tree is");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.FindMinimumValueInBinarySearchTree());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Maximum value in Binary Search tree is");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.FindMaximumValueInTree());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Comparing two tress are equal or not");
                Console.ForegroundColor = ConsoleColor.White;

                CustomBinarySearchTree otherBinarySearchTree = new CustomBinarySearchTree();
                otherBinarySearchTree.Insert(20);
                otherBinarySearchTree.Insert(10);
                otherBinarySearchTree.Insert(30);
                otherBinarySearchTree.Insert(6);
                otherBinarySearchTree.Insert(14);
                otherBinarySearchTree.Insert(24);
                otherBinarySearchTree.Insert(3);
                otherBinarySearchTree.Insert(8);
                otherBinarySearchTree.Insert(26);

                bool result = customBinarySearchTree.Equals(otherBinarySearchTree);
                Console.WriteLine("Are both trees are equal: {0}", result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Validating the given tree is Binary Search tree or not");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsBinarySearchTree();
                Console.WriteLine("Is given tree is Binary Search tree: {0}", result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Print the nodes from the root with distance 2");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.PrintNodesAtDistance(2);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Print the nodes from the root with distance 3");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.PrintNodesAtDistance(3);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Level Traversal results");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.LevelOrderTraversal();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculaintg the size of tree");
                Console.ForegroundColor = ConsoleColor.White;
                int size = customBinarySearchTree.CalculateSizeOfTree();
                Console.WriteLine(size);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Calculaintg the total number of leaves in a tree");
                Console.ForegroundColor = ConsoleColor.White;
                size = customBinarySearchTree.CalculateTotalLeaves();
                Console.WriteLine(size);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is Tree contains value 24");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsTreeContainsValue(24);
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is Tree contains value 30");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsTreeContainsValue(30);
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is Tree contains value 25");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsTreeContainsValue(25);
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is tree have siblings as 10, 30");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.AreSiblings(10, 30);
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is tree have siblings as 15, 20");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.AreSiblings(15, 20);
                Console.WriteLine(result);
                
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is tree have siblings as 3, 8");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.AreSiblings(3, 8);
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Get the ancestors for node 26");
                Console.ForegroundColor = ConsoleColor.White;
                customBinarySearchTree.GetAncestors(26);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is tree is balanced");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsBalanced();
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Is tree is Perfect");
                Console.ForegroundColor = ConsoleColor.White;
                result = customBinarySearchTree.IsPerfect();
                Console.WriteLine(result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the depth of node 14");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.DepthOfNode(14));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the depth of node 8");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.DepthOfNode(8));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the depth of node 20");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.DepthOfNode(20));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the height of node 14");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.HeightOfANode(14));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the height of node 10");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.HeightOfANode(10));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the height of node 24");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.HeightOfANode(24));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding the height of node 20");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(customBinarySearchTree.HeightOfANode(20));


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
