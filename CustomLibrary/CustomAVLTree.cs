using System;

namespace CustomLibrary
{
    public class CustomAVLTree
    {
        #region private fields
        private class AVLNode
        {
            public int value;
            public int height;
            public AVLNode leftChild;
            public AVLNode rightChild;

            public AVLNode(int value)
            {
                this.value = value;
            }
        }

        private AVLNode root;
        #endregion

        #region public methods
        public void Insert(int value)
        {
            root = Insert(root, value);
        }
        #endregion

        #region private methods
        private AVLNode Insert(AVLNode root, int value)
        {
            if (root == null)
            {
                return new AVLNode(value);
            }

            if (value < root.value)
            {
                root.leftChild = Insert(root.leftChild, value);
            }
            else
            {
                root.rightChild = Insert(root.rightChild, value);
            }

            root.height = 1 + Math.Max(GetHeight(root.leftChild), GetHeight(root.rightChild));

            if (IsLeftHeavy(root))
            {
                Console.WriteLine(root.value + " is left heavy");
            }
            else if(IsRightHeavy(root))
            {
                Console.WriteLine(root.value + " is right heavy");
            }

            return root;
        }

        private int GetHeight(AVLNode node)
        {
            return node == null ? -1 : node.height;
        }

        private bool IsLeftHeavy(AVLNode node)
        {
            return GetBalanceFactor(node) > 1;
        }

        private bool IsRightHeavy(AVLNode node)
        {
            return GetBalanceFactor(node) < -1;
        }

        private int GetBalanceFactor(AVLNode node)
        {
            return node == null ? 0 : GetHeight(node.leftChild) - GetHeight(node.rightChild);
        }
        #endregion
    }
}
