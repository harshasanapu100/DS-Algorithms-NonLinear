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
                #region CustomHeaps
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Implementing the Heaps with basic Operations");
                Console.ForegroundColor = ConsoleColor.White;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Pushing the elements  10, 5, 17, 25, 4, 22 to Heap");
                Console.ForegroundColor = ConsoleColor.White;

                CustomHeaps customHeaps = new CustomHeaps(6);

                customHeaps.Insert(10);
                customHeaps.Insert(5);
                customHeaps.Insert(17);
                customHeaps.Insert(25);
                customHeaps.Insert(4);
                customHeaps.Insert(22);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements from the heap");
                Console.ForegroundColor = ConsoleColor.White;
                customHeaps.Print();
                Console.WriteLine();

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("In heap we can delete only a root node. So we are deleting root node now");
                Console.ForegroundColor = ConsoleColor.White;

                int result = customHeaps.Remove();
                Console.WriteLine("Deleted root node is {0}", result);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements from the heap");
                Console.ForegroundColor = ConsoleColor.White;
                customHeaps.Print();
                Console.WriteLine();

                customHeaps.Insert(25);
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Creating new heap with 5, 3, 10, 1, 4, 2 for sorting");
                Console.ForegroundColor = ConsoleColor.White;

                int[] numbers = { 8, 3, 10, 1, 4, 2, 7 };
                CustomHeaps descending = new CustomHeaps(numbers.Length);
                foreach (var number in numbers)
                {
                    descending.Insert(number);
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Descending order of the Heaps");
                Console.ForegroundColor = ConsoleColor.White;

                for (int i = 0; i < numbers.Length; i++)
                {
                    numbers[i] = descending.Remove();
                }

                foreach (var number in numbers)
                {
                    Console.Write(number + " ");
                }

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Ascending order of the Heaps");
                Console.ForegroundColor = ConsoleColor.White;

                int[] items = { 8, 5, 3, 10, 1, 4, 2, 7 };
                CustomHeaps ascending = new CustomHeaps(items.Length);
                foreach (var item in items)
                {
                    ascending.Insert(item);
                }

                for (int i = items.Length - 1; i >= 0; i--)
                {
                    items[i] = ascending.Remove();
                }

                foreach (var item in items)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                #endregion

                #region PriorityQueueWithHeap
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Implemeting Priority Queues with Heaps");
                Console.WriteLine("Creating a Priority Queue wit  10, 5, 17, 25, 4, 22 using Heap");
                Console.ForegroundColor = ConsoleColor.White;

                PriorityQueueWithHeap priorityQueueWithHeap = new PriorityQueueWithHeap(7);

                priorityQueueWithHeap.Enqueue(10);
                priorityQueueWithHeap.Enqueue(5);
                priorityQueueWithHeap.Enqueue(7);
                priorityQueueWithHeap.Enqueue(17);
                priorityQueueWithHeap.Enqueue(25);
                priorityQueueWithHeap.Enqueue(4);
                priorityQueueWithHeap.Enqueue(22);

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements of Priority Queue");
                Console.ForegroundColor = ConsoleColor.White;
                priorityQueueWithHeap.customHeaps.Print();
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Removing 2 items from the Priority Queue");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Removed items {0} {1}", priorityQueueWithHeap.Dequeue(), priorityQueueWithHeap.Dequeue());

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Printing the elements of Priority Queue");
                Console.ForegroundColor = ConsoleColor.White;
                priorityQueueWithHeap.customHeaps.Print();
                Console.WriteLine();
                #endregion

                #region HeapifyDemo
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Implementing Heapify method - means Transforming an array to heap inplace");
                Console.WriteLine("Input array is 5, 3, 8, 4, 1, 2");
                Console.ForegroundColor = ConsoleColor.White;

                int[] input = { 5, 3, 8, 4, 1, 2, 10 };
                HeapifyDemo.Heapify(input);
                foreach (var item in input)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
                #endregion

                #region KthLargest
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Finding 2nd largest element in the array");
                Console.WriteLine("Input array is 5, 3, 8, 4, 1, 2, 10");
                Console.ForegroundColor = ConsoleColor.White;

                KthLargest kthLargest = new KthLargest(7);
                int largest = kthLargest.getKthLargest(input, 2);
                Console.WriteLine("2nd largest in array is {0}", largest);
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
