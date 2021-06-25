using System;
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

        public List<string> TopologicalSort()
        {
            HashSet<Node> visited = new HashSet<Node>();
            Stack<Node> stack = new Stack<Node>();

            foreach (KeyValuePair<string, Node> kvp in nodes)
            {
                TopologicalSort(kvp.Value, visited, stack);
            }

            List<string> sorted = new List<string>();
            while (stack.Count != 0)
            {
                sorted.Add(stack.Pop().label);
            }

            return sorted;
        }

        public bool HasCycle()
        {
            List<Node> all = new List<Node>();
            foreach (Node item in nodes.Values)
            {
                all.Add(item);
            }

            HashSet<Node> visiting = new HashSet<Node>();
            HashSet<Node> visited = new HashSet<Node>();

            while (all.Count != 0)
            {
                for (int i = 0; i < all.Count; i++)
                {
                    if (HasCycle(all[i], all, visiting, visited))
                    {
                        return true;
                    }
                }
            }

            return false;
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

        private void TopologicalSort(Node node, HashSet<Node> visited, Stack<Node> stack)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);

            foreach (Node neighbour in adjacencyList[node])
            {
                TopologicalSort(neighbour, visited, stack);
            }

            stack.Push(node);
        }

        private bool HasCycle(Node node, List<Node> all, HashSet<Node> visiting, HashSet<Node> visited)
        {
            all.Remove(node);
            visiting.Add(node);

            foreach (Node item in adjacencyList[node])
            {
                if (visited.Contains(item))
                {
                    continue;
                }

                if (visiting.Contains(item))
                {
                    return true;
                }

                var result = HasCycle(item, all, visiting, visited);
                if (result)
                {
                    return true;
                }
            }

            visiting.Remove(node);
            visited.Add(node);

            return false;
        }
        #endregion
    }
}
