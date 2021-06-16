using System;
using CustomLibrary;

namespace ConsoleApp
{
    class Heaps
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the Heaps with basic Operations");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements  10, 5, 17,25, 4, 22 to Heap");
                Console.ForegroundColor = ConsoleColor.White;

                CustomHeaps customHeaps = new CustomHeaps(6);

                customHeaps.Insert(10);
                customHeaps.Insert(5);
                customHeaps.Insert(17);
                customHeaps.Insert(25);
                customHeaps.Insert(4);
                customHeaps.Insert(22);

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements from the heap");
                Console.ForegroundColor = ConsoleColor.White;

                customHeaps.Print();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In heap we can delete only a root node. So we are deleting root node now");
                Console.ForegroundColor = ConsoleColor.White;

                int result = customHeaps.Remove();
                Console.WriteLine("Deleted root node is {0}", result);
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
