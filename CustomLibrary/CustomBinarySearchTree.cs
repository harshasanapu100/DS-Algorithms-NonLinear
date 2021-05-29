using System;
using System.Collections.Generic;

namespace CustomLibrary
{
    public class CustomBinarySearchTree
    {
        #region private fileds
        private class Node
        {
            public int value;
            public Node leftChild;
            public Node rightChild;

            public Node(int value)
            {
                this.value = value;
            }
        }

        private Node root;
        private int height;
        #endregion

        #region public methods
        public void Insert(int value)
        {
            Node node = new Node(value);

            if (IsEmpty())
            {
                root = node;
            }
            else
            {
                var current = root;

                while (true)
                {
                    if (value < current.value)
                    {
                        if (current.leftChild == null)
                        {
                            current.leftChild = node;
                            break;
                        }
                        current = current.leftChild;
                    }
                    else
                    {
                        if (current.rightChild == null)
                        {
                            current.rightChild = node;
                            break;
                        }
                        current = current.rightChild;
                    }
                }
            }
        }

        public bool Find(int value)
        {
            if (IsEmpty())
            {
                throw new Exception("Tree is empty");
            }

            var current = root;
            while (current != null)
            {
                if (value < current.value)
                {
                    current = current.leftChild;
                }
                else if (value > current.value)
                {
                    current = current.rightChild;
                }
                else
                {
                    return true;
                }
            }

            return false;
        }

        public void TraversePreOrder()
        {
            TraversePreOrder(root);
        }

        public void TraverseInOrder()
        {
            TraverseInOrder(root);
        }

        public void TraversePostOrder()
        {
            TraversePostOrder(root);
        }

        public int CalculateHeightOfTree()
        {
            return CalculateHeightOfTree(root);
        }

        public int FindMinimumValueInTree()
        {
            return FindMinimumValueInTree(root);
        }

        public int FindMaximumValueInTree()
        {
            return FindMaximumValueInTree(root);
        }

        public int FindMinimumValueInBinarySearchTree()
        {
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            return FindMinimumValueInBinarySearchTree(root);
        }

        public int FindMaximumValueInBinarySearchTree()
        {
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            return FindMaximumValueInBinarySearchTree(root);
        }

        public bool Equals(CustomBinarySearchTree other)
        {
            if (other.root == null)
            {
                return false;
            }

            return Equals(root, other.root);
        }

        public bool IsBinarySearchTree()
        {
            return IsBinarySearchTree(root, int.MinValue, int.MaxValue);
        }

        public void PrintNodesAtDistance(int distance)
        {
            PrintNodesAtDistance(root, distance);
        }

        public void LevelOrderTraversal()
        {
            for (int i = 0; i <= CalculateHeightOfTree(); i++)
            {
                PrintNodesAtDistance(i);
            }
        }

        public int CalculateSizeOfTree()
        {
            return CalculateSizeOfTree(root);
        }

        public int CalculateTotalLeaves()
        {
            return CalculateTotalLeaves(root);
        }

        public bool IsTreeContainsValue(int value)
        {
            return IsTreeContainsValue(root, value);
        }

        public bool AreSiblings(int first, int second)
        {
            return AreSiblings(root, first, second);
        }

        public bool GetAncestors(int value)
        {
            return GetAncestors(root, value);
        }

        public bool IsBalanced()
        {
            return IsBalanced(root);
        }

        public bool IsPerfect()
        {
            return CalculateSizeOfTree() == Math.Pow(2, CalculateHeightOfTree() + 1) - 1;
        }

        public int DepthOfNode(int item)
        {
            return DepthOfANode(root, item);
        }

        public int HeightOfANode(int item)
        {
            return FindHeightOfANode(root, item);
        }

        public List<int> FindLongestPathFromRootToLeaf()
        {
            return FindLongestPathFromRootToLeaf(root);
        }

        public List<int> GetRootToLeafSumBinaryTreePath(int sum)
        {
            List<int> path = new List<int>();
            GetRootToLeafSumBinaryTreePath(root, sum, path);
            return path;
        }
        #endregion

        #region private methods
        private void TraversePreOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            Console.WriteLine(root.value);
            TraversePreOrder(root.leftChild);
            TraversePreOrder(root.rightChild);
        }

        private void TraverseInOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraverseInOrder(root.leftChild);
            Console.WriteLine(root.value);
            TraverseInOrder(root.rightChild);
        }

        private void TraversePostOrder(Node root)
        {
            if (root == null)
            {
                return;
            }

            TraversePostOrder(root.leftChild);
            TraversePostOrder(root.rightChild);
            Console.WriteLine(root.value);
        }

        private int CalculateHeightOfTree(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            int leftChildHeight = CalculateHeightOfTree(root.leftChild);
            int rightChildHeight = CalculateHeightOfTree(root.rightChild);

            return 1 + Math.Max(leftChildHeight, rightChildHeight);
        }

        private int FindMinimumValueInTree(Node root)
        {
            if (root == null)
            {
                return int.MaxValue;
            }

            if (IsLeaf(root))
            {
                return root.value;
            }

            int leftMiniValue = FindMinimumValueInTree(root.leftChild);
            int rightMinValue = FindMinimumValueInTree(root.rightChild);

            return Math.Min(Math.Min(leftMiniValue, rightMinValue), root.value);
        }

        private int FindMaximumValueInTree(Node root)
        {
            if (root == null)
            {
                return int.MinValue;
            }

            if (IsLeaf(root))
            {
                return root.value;
            }

            int leftMiniValue = FindMaximumValueInTree(root.leftChild);
            int rightMinValue = FindMaximumValueInTree(root.rightChild);

            return Math.Max(Math.Max(leftMiniValue, rightMinValue), root.value);
        }

        private int FindMinimumValueInBinarySearchTree(Node root)
        {
            if (root.leftChild == null)
            {
                return root.value;
            }

            return FindMinimumValueInBinarySearchTree(root.leftChild);
        }

        private int FindMaximumValueInBinarySearchTree(Node root)
        {
            if (root.rightChild == null)
            {
                return root.value;
            }

            return FindMaximumValueInBinarySearchTree(root.rightChild);
        }

        private bool Equals(Node first, Node second)
        {
            if (first == null && second == null)
            {
                return true;
            }

            if (first != null && second != null)
            {
                return first.value == second.value &&
                    Equals(first.leftChild, second.leftChild) &&
                    Equals(first.rightChild, second.rightChild);
            }

            return false;
        }

        private bool IsBinarySearchTree(Node root, int min, int max)
        {
            if (root == null)
            {
                return true;
            }

            if (root.value < min || root.value > max)
            {
                return false;
            }

            return IsBinarySearchTree(root.leftChild, min, root.value - 1)
                && IsBinarySearchTree(root.rightChild, root.value + 1, max);
        }

        private void PrintNodesAtDistance(Node root, int distance)
        {
            if (root == null)
            {
                return;
            }

            if (distance == 0)
            {
                Console.WriteLine(root.value);
            }

            PrintNodesAtDistance(root.leftChild, distance - 1);
            PrintNodesAtDistance(root.rightChild, distance - 1);
        }

        private int CalculateSizeOfTree(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (IsLeaf(root))
            {
                return 1;
            }

            int leftTreeSize = CalculateSizeOfTree(root.leftChild);
            int rightTreeSize = CalculateSizeOfTree(root.rightChild);

            return 1 + leftTreeSize + rightTreeSize;
        }

        private int CalculateTotalLeaves(Node root)
        {
            if (root == null)
            {
                return 0;
            }

            if (IsLeaf(root))
            {
                return 1;
            }

            int leftSideLeaves = CalculateTotalLeaves(root.leftChild);
            int rightSideLeaves = CalculateTotalLeaves(root.rightChild);

            return leftSideLeaves + rightSideLeaves;
        }

        private bool IsTreeContainsValue(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.value == value)
            {
                return true;
            }

            bool isLeftTreeContainsValue = IsTreeContainsValue(root.leftChild, value);
            bool isRightTreeContainsValue = IsTreeContainsValue(root.rightChild, value);

            return isLeftTreeContainsValue || isRightTreeContainsValue;
        }

        private bool AreSiblings(Node root, int first, int second)
        {
            if (root == null)
            {
                return false;
            }

            if (root.leftChild != null && root.rightChild != null)
            {
                if (root.leftChild.value == first && root.rightChild.value == second
                        || root.leftChild.value == second && root.rightChild.value == first)
                {
                    return true;
                }
            }

            bool isLeftTreeHasSiblings = AreSiblings(root.leftChild, first, second);
            bool isRightTreeHasSiblings = AreSiblings(root.rightChild, first, second);

            return isLeftTreeHasSiblings || isRightTreeHasSiblings;
        }

        private bool GetAncestors(Node root, int value)
        {
            if (root == null)
            {
                return false;
            }

            if (root.value == value)
            {
                return true;
            }

            bool isLeftTreeContainsAncestors = GetAncestors(root.leftChild, value);
            bool isRightTreeContainsAncestors = GetAncestors(root.rightChild, value);

            if (isLeftTreeContainsAncestors || isRightTreeContainsAncestors)
            {
                Console.WriteLine(root.value);
                return true;
            }

            return false;
        }

        private bool IsBalanced(Node root)
        {
            if (root == null)
            {
                return true;
            }

            int leftTreeHeight = CalculateHeightOfTree(root.leftChild);
            int rightTreeHeight = CalculateHeightOfTree(root.rightChild);

            int heightDifference = Math.Abs(leftTreeHeight - rightTreeHeight);

            bool isLeftTreeBalanced = IsBalanced(root.leftChild);
            bool isRightTreeBalanced = IsBalanced(root.rightChild);

            return heightDifference <= 1 && isLeftTreeBalanced && isRightTreeBalanced;
        }

        private int DepthOfANode(Node root, int item)
        {
            if (root == null)
            {
                return -1;
            }

            int dist = -1;

            if ((root.value == item) || (dist = DepthOfANode(root.leftChild, item)) >= 0 || (dist = DepthOfANode(root.rightChild, item)) >= 0)
            {
                return dist + 1;
            }

            return dist;
        }

        private int HeightOfANode(Node root, int item)
        {
            if (root == null)
            {
                return -1;
            }

            int leftHeight = HeightOfANode(root.leftChild, item);
            int rightHeight = HeightOfANode(root.rightChild, item);

            int mainHeight = 1 + Math.Max(leftHeight, rightHeight);

            if (root.value == item)
            {
                height = mainHeight;
            }

            return mainHeight;
        }

        private int FindHeightOfANode(Node root, int x)
        {
            HeightOfANode(root, x);
            return height;
        }

        private List<int> FindLongestPathFromRootToLeaf(Node root)
        {
            if (root == null)
            {
                List<int> output = new List<int>();
                return output;
            }

            List<int> left = FindLongestPathFromRootToLeaf(root.leftChild);
            List<int> right = FindLongestPathFromRootToLeaf(root.rightChild);


            if (right.Count < left.Count)
            {
                left.Add(root.value);
            }
            else
            {
                right.Add(root.value);
            }

            return left.Count > right.Count ? left : right;
        }

        private bool GetRootToLeafSumBinaryTreePath(Node root, int sum, List<int> path)
        {
            if (root == null)
            {
                return false;
            }

            if (IsLeaf(root))
            {
                if (root.value == sum)
                {
                    path.Add(root.value);
                    return true;
                }
                else
                {
                    return false;
                }
            }

            bool isLeftTreePath = GetRootToLeafSumBinaryTreePath(root.leftChild, sum - root.value, path);
            bool isRightTreePath = GetRootToLeafSumBinaryTreePath(root.rightChild, sum - root.value, path);

            if (isLeftTreePath || isRightTreePath)
            {
                path.Add(root.value);
                return true;
            }

            return false;
        }

        private bool IsLeaf(Node node)
        {
            return node.leftChild == null && node.rightChild == null;
        }

        private bool IsEmpty()
        {
            return root == null;
        }

        #endregion
    }
}
