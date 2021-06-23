﻿using System;
using System.Collections.Generic;

namespace CustomLibrary
{
    public class CustomGraph
    {
        #region private fields
        private class Node
        {
            public string label;

            public Node(string label)
            {
                this.label = label;
            }

        }

        private Dictionary<string, Node> nodes = new Dictionary<string, Node>();
        private Dictionary<Node, List<Node>> adjacencyList = new Dictionary<Node, List<Node>>();
        #endregion

        #region public methods
        public void AddNode(string label)
        {
            Node node = new Node(label);

            if (!nodes.ContainsKey(label))
            {
                nodes.Add(label, node);
                adjacencyList.Add(node, new List<Node>());
            }
        }

        public void AddEdge(string from, string to)
        {
            Node fromNode = nodes.ContainsKey(from) ? nodes[from] : null;
            if (fromNode == null)
            {
                throw new Exception("Node or vertex is not found");
            }

            Node toNode = nodes.ContainsKey(to) ? nodes[to] : null;
            if (toNode == null)
            {
                throw new Exception("Node or vertex is not found");
            }

            adjacencyList[fromNode].Add(toNode);
        }

        public void RemoveNode(string label)
        {
            Node node = nodes.ContainsKey(label) ? nodes[label] : null;

            if (node == null)
            {
                return;
            }

            foreach (KeyValuePair<Node, List<Node>> kvp in adjacencyList)
            {
                adjacencyList[kvp.Key].Remove(node);
            }

            adjacencyList.Remove(node);
            nodes.Remove(label);
        }

        public void RemoveEdge(string from, string to)
        {
            Node fromNode = nodes.ContainsKey(from) ? nodes[from] : null;
            if (fromNode == null)
            {
                return;
            }

            Node toNode = nodes.ContainsKey(to) ? nodes[to] : null;
            if (toNode == null)
            {
                return;
            }

            adjacencyList[fromNode].Remove(toNode);
        }

        public void Print()
        {
            foreach (KeyValuePair<Node, List<Node>> kvp in adjacencyList)
            {
                if (kvp.Value.Count > 0)
                {
                    string edges = "[ ";
                    foreach (Node item in kvp.Value)
                    {
                        edges += item.label + " ";
                    }

                    edges += "]";

                    Console.WriteLine(kvp.Key.label + " is connected to " + edges);
                }
            }
        }

        public void DFSTraversalUsingRecurssion(string label)
        {
            Node node = nodes.ContainsKey(label) ? nodes[label] : null;

            if (node == null)
            {
                return;
            }

            DFSTraversalUsingRecurssion(node, new HashSet<Node>());
        }

        public void DFSTraversaUsingIteration(string label)
        {
            Node node = nodes.ContainsKey(label) ? nodes[label] : null;

            if (node == null)
            {
                return;
            }

            HashSet<Node> visited = new HashSet<Node>();

            Stack<Node> stack = new Stack<Node>();
            stack.Push(node);

            while (stack.Count > 0)
            {
                var current = stack.Pop();

                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine(current.label);
                visited.Add(current);

                foreach (Node edge in adjacencyList[current])
                {
                    if (!visited.Contains(edge))
                    {
                        stack.Push(edge);
                    }
                }
            }

        }

        public void BFSTraversaUsingIteration(string label)
        {
            Node node = nodes.ContainsKey(label) ? nodes[label] : null;

            if (node == null)
            {
                return;
            }

            HashSet<Node> visited = new HashSet<Node>();

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(node);

            while (queue.Count > 0)
            {
                var current = queue.Dequeue();

                if (visited.Contains(current))
                {
                    continue;
                }

                Console.WriteLine(current.label);
                visited.Add(current);

                foreach (Node edge in adjacencyList[current])
                {
                    if (!visited.Contains(edge))
                    {
                        queue.Enqueue(edge);
                    }
                }
            }
        }
        #endregion

        #region private methods
        private void DFSTraversalUsingRecurssion(Node root, HashSet<Node> visited)
        {
            Console.WriteLine(root.label);
            visited.Add(root);

            foreach (Node edge in adjacencyList[root])
            {
                if (!visited.Contains(edge))
                {
                    DFSTraversalUsingRecurssion(edge, visited);
                }
            }
        }
        #endregion
    }
}
