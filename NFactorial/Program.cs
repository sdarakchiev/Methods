using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(CalculateFactorial(number));
        }

        public static BigInteger CalculateFactorial(int number)
        {
            BigInteger result = 1;
            for (int i = number; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
    }
}
