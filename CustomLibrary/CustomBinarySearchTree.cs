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
        #endregion

        #region private methods
        private bool IsEmpty()
        {
            return root == null;
        }
        #endregion
    }
}
