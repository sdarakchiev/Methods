using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerCalculations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            Console.WriteLine("{0}\n{1}\n{2:F2}\n{3}\n{4}", GetMinNumber(numbers), GetMaxNumber(numbers), GetAverage(numbers), GetSum(numbers), GetProduct(numbers));
        }

        public static int GetMinNumber (int[] numbers)
        {
            int minimum = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < minimum)
                {
                    minimum = numbers[i];
                }
            }
            return minimum;
        }

        public static int GetMaxNumber (int[] numbers)
        {
            int maximum = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > maximum)
                {
                    maximum = numbers[i];
                }
            }
            return maximum;
        }

        public static int GetSum (int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static double GetAverage (int[] numbers)
        {
            double average = (double)GetSum(numbers) / (double)numbers.Length;
            return average;
        }

        public static long GetProduct (int[] numbers)
        {
            long product = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                product *= (long)numbers[i];
            }
            return product;
        }
    }
}
