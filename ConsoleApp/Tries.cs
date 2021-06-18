using System;
using CustomLibrary;
namespace ConsoleApp
{
    class Tries
    {
        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the tries with basic operations");
                Console.ForegroundColor = ConsoleColor.White;

                CustomTries customTries = new CustomTries();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the words  bat, cat, dog, battery, catch, batting to tries");
                Console.ForegroundColor = ConsoleColor.White;

                //customTries.Insert("bat");
                //customTries.Insert("cat");
                //customTries.Insert("dog");
               // customTries.Insert("battery");
                //customTries.Insert("catch");
                customTries.Insert("batting");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Checking the words exists in the trie or not");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Is catch word exists: " + customTries.Contains("catch"));
                Console.WriteLine("Is dog word exists: " + customTries.Contains("dog"));
                Console.WriteLine("Is ant word exists: " + customTries.Contains("ant"));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing the Pre order travsersal");
                Console.ForegroundColor = ConsoleColor.White;
                customTries.PreOrderTraversal();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing the Post order travsersal");
                Console.ForegroundColor = ConsoleColor.White;
                customTries.PostOrderTraversal();
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
