using System;
using System.Collections.Generic;
using CustomLibrary;

namespace ConsoleApp
{
    class Graph
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the Graph with basic operations");
                Console.ForegroundColor = ConsoleColor.White;

                CustomGraph customGraph = new CustomGraph();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the lables A, B, C, D, E to graph");
                Console.WriteLine("Adding edges A-->B, B-->D, D-->C, A-->C, A-->D, B-->E");
                Console.ForegroundColor = ConsoleColor.White;

                customGraph.AddNode("A");
                customGraph.AddNode("B");
                customGraph.AddNode("C");
                customGraph.AddNode("D");
                customGraph.AddNode("E");

                customGraph.AddEdge("A", "B");
                customGraph.AddEdge("B", "D");
                customGraph.AddEdge("D", "C");
                customGraph.AddEdge("A", "C");
                customGraph.AddEdge("A", "D");
                customGraph.AddEdge("B", "E");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing nodes connected with edges");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing edge A-->B and D-->C");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.RemoveEdge("A", "B");
                customGraph.RemoveEdge("D", "C");
                customGraph.Print();
                customGraph.AddEdge("A", "B");
                customGraph.AddEdge("D", "C");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Perform the DFS Traversal for node  A using recurssion");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.DFSTraversalUsingRecurssion("A");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Perform the DFS Traversal for node  A using iteration");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.DFSTraversaUsingIteration("A");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Perform the DFS Traversal for node  A using iteration");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.BFSTraversaUsingIteration("B");

                #region Topological Sort
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing topological sort");
                Console.ForegroundColor = ConsoleColor.White;

                CustomGraph topologicalSort = new CustomGraph();

                topologicalSort.AddNode("P");
                topologicalSort.AddNode("A");
                topologicalSort.AddNode("B");
                topologicalSort.AddNode("X");

                topologicalSort.AddEdge("A", "P");
                topologicalSort.AddEdge("X", "A");
                topologicalSort.AddEdge("X", "B");
                topologicalSort.AddEdge("B", "A");

                List<string> nodes = topologicalSort.TopologicalSort();
                foreach (var item in nodes)
                {
                    Console.WriteLine(item);
                }
                #endregion

                #region Cycle Detection
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Checking whether the  graph");
                Console.ForegroundColor = ConsoleColor.White;

                CustomGraph cycleDetection = new CustomGraph();

                cycleDetection.AddNode("A");
                cycleDetection.AddNode("B");
                cycleDetection.AddNode("C");
                cycleDetection.AddNode("D");

                cycleDetection.AddEdge("A", "D");
                cycleDetection.AddEdge("B", "C");
                cycleDetection.AddEdge("C", "B");

                Console.WriteLine(cycleDetection.HasCycle());
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
