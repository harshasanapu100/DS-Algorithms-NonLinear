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

            SetHeight(root);

            return Balance(root);
        }

        private AVLNode Balance(AVLNode root)
        {
            if (IsLeftHeavy(root))
            {
                if (GetBalanceFactor(root.leftChild) < 0)
                {
                    root.leftChild = RotateLeft(root.leftChild);
                }
                return RotateRight(root);
            }
            else if (IsRightHeavy(root))
            {
                if (GetBalanceFactor(root.rightChild) > 0)
                {
                    root.rightChild = RotateRight(root.rightChild);
                }
                return RotateLeft(root);
            }

            return root;
        }

        private AVLNode RotateLeft(AVLNode root)
        {
            var newRoot = root.rightChild;

            root.rightChild = newRoot.leftChild;
            newRoot.leftChild = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private AVLNode RotateRight(AVLNode root)
        {
            var newRoot = root.leftChild;

            root.leftChild = newRoot.rightChild;
            newRoot.rightChild = root;

            SetHeight(root);
            SetHeight(newRoot);

            return newRoot;
        }

        private void SetHeight(AVLNode node)
        {
            node.height = 1 + Math.Max(GetHeight(node.leftChild), GetHeight(node.rightChild));
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
