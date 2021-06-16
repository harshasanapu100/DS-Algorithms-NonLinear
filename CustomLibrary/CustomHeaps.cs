using System;
using System.Collections.Generic;
using System.Text;

namespace CustomLibrary
{
    public class CustomHeaps
    {
        #region private fields
        private int[] items;
        private int size;
        #endregion

        #region constructor
        public CustomHeaps(int capacity)
        {
            items = new int[capacity];
        }
        #endregion

        #region public methods
        public void Insert(int value)
        {
            if (IsFull())
            {
                throw new ArgumentException("Array index is outside of the capacity");
            }

            items[size++] = value;

            BubbleUp();
        }

        public int Remove()
        {
            if (IsEmpty())
            {
                throw new Exception("Array is empty");
            }

            int root = items[0];

            items[0] = items[--size];

            BubbleDown();

            return root;
        }

        public bool IsFull()
        {
            return size == items.Length;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public void Print()
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write(items[i] + " ");
            }
        }

        public int Max()
        {
            if (IsEmpty())
            {
                throw new Exception("Array is empty");
            }

            return items[0];
        }
        #endregion

        #region private methods
        private void BubbleUp()
        {
            var index = size - 1;

            while (index > 0 && items[index] > items[GetParentIndex(index)])
            {
                Swap(index, GetParentIndex(index));
                index = GetParentIndex(index);
            }
        }

        private void BubbleDown()
        {
            var index = 0;

            while (index <= size && !IsValidParent(index))
            {
                int largerChildIndex = GetLargerChildIndex(index);
                Swap(index, largerChildIndex);
                index = largerChildIndex;
            }
        }

        private int GetParentIndex(int index)
        {
            return (index - 1) / 2;
        }

        private void Swap(int first, int second)
        {
            var temp = items[first];
            items[first] = items[second];
            items[second] = temp;
        }

        private int GetLeftChildIndex(int index)
        {
            return index * 2 + 1;
        }

        private int GetRightChildIndex(int index)
        {
            return index * 2 + 2;
        }

        private int GetLeftChild(int index)
        {
            return items[GetLeftChildIndex(index)];
        }

        private int GetRightChild(int index)
        {
            return items[GetRightChildIndex(index)];
        }

        private bool IsValidParent(int index)
        {
            if (!HasLeftChild(index))
            {
                return true;
            }

            if (!HasRightChild(index))
            {
                return items[index] >= GetLeftChild(index);
            }

            return items[index] >= GetLeftChild(index) && items[index] >= GetRightChild(index);
        }

        private int GetLargerChildIndex(int index)
        {
            if (!HasLeftChild(index))
            {
                return index;
            }

            if (!HasRightChild(index))
            {
                return GetLeftChildIndex(index);
            }

            return GetLeftChild(index) > GetRightChild(index) ? GetLeftChildIndex(index) : GetRightChildIndex(index);
        }

        private bool HasLeftChild(int index)
        {
            return GetLeftChildIndex(index) <= size;
        }

        private bool HasRightChild(int index)
        {
            return GetRightChildIndex(index) <= size;
        }
        #endregion
    }

    public class PriorityQueueWithHeap
    {
        public CustomHeaps customHeaps;

        public PriorityQueueWithHeap(int capacity)
        {
            customHeaps = new CustomHeaps(capacity);
        }

        public void Enqueue(int item)
        {
            customHeaps.Insert(item);
        }

        public int Dequeue()
        {
            return customHeaps.Remove();
        }

        public bool IsEmpty()
        {
            return customHeaps.IsEmpty();
        }
    }

    public class HeapifyDemo
    {
        public static void Heapify(int[] input)
        {
            int lastParentIndex = input.Length / 2 - 1;
            for (int i = lastParentIndex; i >= 0; i--)
            {
                Heapify(input, i);
            }
        }

        private static void Heapify(int[] input, int index)
        {
            int largerIndex = index;

            int leftChildIndex = index * 2 + 1;
            if (leftChildIndex < input.Length && input[largerIndex] < input[leftChildIndex])
            {
                largerIndex = leftChildIndex;
            }

            int rightChildIndex = index * 2 + 2;
            if (rightChildIndex < input.Length && input[largerIndex] < input[rightChildIndex])
            {
                largerIndex = rightChildIndex;
            }

            if (index == largerIndex)
            {
                return;
            }

            Swap(input, index, largerIndex);
            Heapify(input, largerIndex);
        }

        private static void Swap(int[] array, int first, int second)
        {
            int temp = array[first];
            array[first] = array[second];
            array[second] = temp;
        }
    }

    public class KthLargest
    {
        CustomHeaps customHeaps;

        public KthLargest(int capacity)
        {
            this.customHeaps = new CustomHeaps(capacity);
        }

        public int getKthLargest(int[] array, int k)
        {
            if (k < 1 || k > array.Length)
            {
                throw new ArgumentException();
            }

            foreach (int item in array)
            {
                customHeaps.Insert(item);
            }

            for (int i = 0; i < k - 1; i++)
            {
                customHeaps.Remove();
            }

            return customHeaps.Max();
        }
    }
}
