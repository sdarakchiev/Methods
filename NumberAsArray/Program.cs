using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstArraySize = sizes[0];
            int secondArraySize = sizes[1];

            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumArray = GetSumArray(firstArray, secondArray);

            PrintArray(sumArray);
        }

        public static int[] GetSumArray(int[] firstArray, int[] secondArray)
        {
            int minArraySize = Math.Min(firstArray.Length, secondArray.Length);
            int maxArraySize = Math.Max(firstArray.Length, secondArray.Length);

            int[] biggerArray = new int[maxArraySize];
            if (firstArray.Length == maxArraySize)
            {
                biggerArray = firstArray;
            }
            else
            {
                biggerArray = secondArray;
            }
            List<int> sumArray = new List<int>();
            int sumElement = 0;
            if ((firstArray[0] + secondArray[0]) > 9)
            {
                sumArray.Add((firstArray[0] + secondArray[0]) % 10);
            }
            else
            {
                sumArray.Add(firstArray[0] + secondArray[0]);

            }

            for (int i = 1; i < minArraySize; i++)
            {
                sumElement = firstArray[i] + secondArray[i];

                if ((firstArray[i - 1] + secondArray[i - 1]) > 9)
                {
                    sumElement = firstArray[i] + secondArray[i] + 1;
                }
                if (sumElement > 9)
                {
                    sumElement = sumElement % 10;
                }
                sumArray.Add(sumElement);
            }

            for (int j = minArraySize; j < biggerArray.Length; j++)
            {
                sumArray.Add(biggerArray[j]);
            }

            return sumArray.ToArray();
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
