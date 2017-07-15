using System;
using System.Linq;

namespace AppearanceCount
{
    class Program
    {
        static void Main()
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] arrayOfNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());

            int appearanceCount = GetAppearanceCount(arrayOfNumbers, searchedNumber);
            Console.WriteLine(appearanceCount);
        }

        public static int GetAppearanceCount(int[] numbers, int searchedNumber)
        {
            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == searchedNumber)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
