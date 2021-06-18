using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomTries
    {
        #region fields
        private class Node
        {
            public char value;
            public Dictionary<char, Node> children = new Dictionary<char, Node>();
            public bool isEndOfWord;

            public Node(char value)
            {
                this.value = value;
            }
        }

        private Node root = new Node(' ');
        #endregion

        #region public methods
        public void Insert(string word)
        {
            var current = root;

            foreach (var ch in word.ToCharArray())
            {
                if (!current.children.ContainsKey(ch))
                {
                    current.children[ch] = new Node(ch);
                }

                current = current.children[ch];
            }

            current.isEndOfWord = true;
        }

        public bool Contains(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return false;
            }

            var current = root;
            foreach (var ch in word.ToCharArray())
            {
                if (!current.children.ContainsKey(ch))
                {
                    return false;
                }

                current = current.children[ch];
            }

            return current.isEndOfWord;
        }

        public void PreOrderTraversal()
        {
            PreOrderTraversal(root);
        }

        public void PostOrderTraversal()
        {
            PostOrderTraversal(root);
        }
        #endregion

        #region private methods
        private void PreOrderTraversal(Node root)
        {
            Console.WriteLine(root.value);

            foreach (var item in root.children.Values)
            {
                PreOrderTraversal(item);
            }
        }

        private void PostOrderTraversal(Node root)
        {
            foreach (var item in root.children.Values)
            {
                PostOrderTraversal(item);
            }

            Console.WriteLine(root.value);
        }
        #endregion
    }
}
