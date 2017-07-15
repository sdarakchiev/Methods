using System;
using System.Linq;

namespace LargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetLargerThanNeighboursElements(numbers));
        }

        public static int GetLargerThanNeighboursElements(int[] array)
        {
            int count = 0;
            for (int i = 1; i < array.Length - 1; i++)
            {

                if (array[i] > array[i - 1] && array[i] > array[i + 1])
                {
                    count++;
                }

            }
            return count;
        }
    }
}
