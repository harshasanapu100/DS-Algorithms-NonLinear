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

        public void Remove(string word)
        {
            Remove(root, word, 0);
        }

        public List<string> FindWords(string prefix)
        {
            List<string> words = new List<string>();
            var lastNode = FindLastNodeOfWord(prefix);
            FindWords(lastNode, prefix, words);

            return words;
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

        private void Remove(Node root, string word, int index)
        {
            if (index == word.Length)
            {
                root.isEndOfWord = false;
                return;
            }

            var ch = word[index];
            var child = root.children.ContainsKey(ch) ? root.children[ch] : null;

            if (child == null)
            {
                return;
            }

            Remove(child, word, index + 1);

            if (child.children.Count == 0 && !child.isEndOfWord)
            {
                child.children.Remove(ch);
            }
        }

        private Node FindLastNodeOfWord(string prefix)
        {
            if (prefix == null)
            {
                return null;
            }

            var current = root;

            foreach (char ch in prefix.ToCharArray())
            {
                if (!current.children.ContainsKey(ch))
                {
                    return null;
                }

                current = current.children[ch];
            }

            return current;
        }

        private void FindWords(Node root, string prefix, List<string> words)
        {
            if (root == null)
            {
                return;
            }

            if (root.isEndOfWord)
            {
                words.Add(prefix);
            }

            foreach (var child in root.children)
            {
                FindWords(child.Value, prefix + child.Value.value, words);
            }

        }
        #endregion
    }
}
