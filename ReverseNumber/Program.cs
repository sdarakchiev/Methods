using System;
using System.Text;

namespace ReverseNumber
{
    class Program
    {
        static void Main()
        {
            string numberAsAString = Console.ReadLine();
            Console.WriteLine(ReverseDigits(numberAsAString));
        }

        public static string ReverseDigits(string number)
        {
            StringBuilder reversedNumber = new StringBuilder();
            for (int i = 0; i < number.Length; i++)
            {
                reversedNumber.Append(number[number.Length - i - 1]);
            }

            return reversedNumber.ToString();
        }
    }
}
