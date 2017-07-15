using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberAsArray2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int[] GetSumArray (int[] firstArray, int[] secondArray)
        {
            List<int> equalSizedArray = new List<int>();

            if (firstArray.Length > secondArray.Length)
            {
                for (int i = 0; i < secondArray.Length; i++)
                {
                    equalSizedArray.Add(secondArray[i]);
                }
                for (int i = secondArray.Length; i < firstArray.Length; i++)
                {
                    equalSizedArray.Add(0);
                }
            }
        }
    }
}
