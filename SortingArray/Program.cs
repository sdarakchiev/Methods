using System;
using System.Collections.Generic;
using System.Linq;

namespace SortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sortedArray = SortArray(numbers);
            PrintArray(sortedArray);
        }

        public static int GetMaxElement(int[] array, int index)
        {
            int maxElement = int.MinValue;
            for (int i = index; i < array.Length; i++)
            {
                if (array[i] > maxElement)
                {
                    maxElement = array[i];
                }
            }
            return maxElement;
        }
        public static int[] SortArray(int[] array)
        {
            List<int> arrayAsList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                arrayAsList.Add(array[i]);

            }
            List<int> sortedList = new List<int>();

            while (arrayAsList.Count > 0)
            {
                for (int i = 0; i < arrayAsList.Count; i++)
                {
                    int maxElement = GetMaxElement(arrayAsList.ToArray(), 0);
                    sortedList.Add(maxElement);
                    arrayAsList.Remove(maxElement);

                }
            }
            int[] sorted = new int[sortedList.Count];
            for (int i = 0; i < sortedList.Count; i++)
            {
                sorted[i] = sortedList[sortedList.Count - 1 - i];
            }
            return sorted;
        }

        public static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
