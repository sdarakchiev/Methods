using System;
using System.Linq;

namespace AddingPolinomials
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] firstPolinomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondPolinomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int[] sumPolinomial = AddPolinomials(firstPolinomial, secondPolinomial);
            PrintArray(sumPolinomial);
        }

        public static int[] AddPolinomials(int[] firstPolinomialCoefficients, int[] secondPolinomialCoefficients)
        {
            int[] result = new int[firstPolinomialCoefficients.Length];
            for (int i = 0; i < firstPolinomialCoefficients.Length; i++)
            {
                result[i] = firstPolinomialCoefficients[i] + secondPolinomialCoefficients[i];
            }
            return result;
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
