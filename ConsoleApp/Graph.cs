using System;
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

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the lables A, B, C to graph");
                Console.WriteLine("Adding edges A-->B, A-->C, B-->C, B-->A");
                Console.ForegroundColor = ConsoleColor.White;

                customGraph.AddNode("A");
                customGraph.AddNode("B");
                customGraph.AddNode("C");

                customGraph.AddEdge("A", "B");
                customGraph.AddEdge("A", "C");
                customGraph.AddEdge("B", "C");
                customGraph.AddEdge("B", "A");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing nodes connected with edges");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing edge A-->B and B-->C");
                Console.ForegroundColor = ConsoleColor.White;
                customGraph.RemoveEdge("A", "B");
                customGraph.RemoveEdge("B", "C");
                customGraph.Print();
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
