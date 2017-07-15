using System;
using System.Linq;

namespace FirstLargerThanNeighbours
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine(GetFirstLargerElementIndex(arrayOfNumbers));
        }

        public static int GetFirstLargerElementIndex(int[] numbers)
        {
            bool hasLarger = false;
            int index = 0;
            for (int i = 1; i < numbers.Length - 1; i++)
            {
                if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
                {
                    hasLarger = true;
                    index = i;
                    break;
                }

            }
            if (hasLarger)
            {
                return index;
            }
            else
            {
                return -1;
            }
        }
    }
}
