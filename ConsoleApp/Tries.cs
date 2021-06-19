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
                Console.WriteLine("Pushing the words  bat, cat, dog, car, battery, catch, batting, care to tries");
                Console.ForegroundColor = ConsoleColor.White;

                customTries.Insert("bat");
                customTries.Insert("cat");
                customTries.Insert("dog");
                customTries.Insert("car");
                customTries.Insert("battery");
                customTries.Insert("catch");
                customTries.Insert("batting");
                customTries.Insert("care");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Checking the words exists in the trie or not");
                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine("Is catch word exists: " + customTries.Contains("catch"));
                Console.WriteLine("Is dog word exists: " + customTries.Contains("dog"));
                Console.WriteLine("Is ant word exists: " + customTries.Contains("ant"));

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing the delete operationvand deleting car, battery words");
                Console.ForegroundColor = ConsoleColor.White;
                customTries.Remove("car");
                customTries.Remove("battery");
                Console.WriteLine("Is bat word exists: " + customTries.Contains("bat"));
                Console.WriteLine("Is cat word exists: " + customTries.Contains("cat"));
                Console.WriteLine("Is dog word exists: " + customTries.Contains("dog"));
                Console.WriteLine("Is car word exists: " + customTries.Contains("car"));
                Console.WriteLine("Is battery word exists: " + customTries.Contains("battery"));
                Console.WriteLine("Is catch word exists: " + customTries.Contains("catch"));
                Console.WriteLine("Is batting word exists: " + customTries.Contains("batting"));
                Console.WriteLine("Is care word exists: " + customTries.Contains("care"));
                customTries.Insert("car");
                customTries.Insert("battery");

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Performing search to get the list of words available for search key");
                Console.ForegroundColor = ConsoleColor.White;

                var words = customTries.FindWords(null);
                foreach (string item in words)
                {
                    Console.WriteLine(item);
                }

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
