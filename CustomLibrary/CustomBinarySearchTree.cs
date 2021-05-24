using System;

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
            return FindMinimumValueInBinarySearchTree(root);
        }

        public int FindMaximumValueInBinarySearchTree()
        {
            return FindMaximumValueInBinarySearchTree(root);
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

            if (IsLeaf(root))
            {
                return 0;
            }

            int leftChildHeight = CalculateHeightOfTree(root.leftChild);
            int rightChildHeight = CalculateHeightOfTree(root.rightChild);

            return 1 + Math.Max(leftChildHeight, rightChildHeight);
        }

        private int FindMinimumValueInTree(Node root)
        {
            if(root == null)
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
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            var current = root;
            var last = current;

            while(current != null)
            {
                last = current;
                current = current.leftChild;
            }

            return last.value;
        }

        private int FindMaximumValueInBinarySearchTree(Node root)
        {
            if (root == null)
            {
                throw new Exception("Tree is empty");
            }

            var current = root;
            var last = current;

            while (current != null)
            {
                last = current;
                current = current.rightChild;
            }

            return last.value;
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
