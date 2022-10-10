using System;

namespace Burbuja
{
    internal class Program
    {
        static int[] myArray = { 1, 3, 7, 2, 3, 8, 9, 40, 32, 22, 11, 86 };
        static void Main(string[] args)
        {
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                for (int j = 0; j < myArray.Length - 1 - i; j++)
                {
                    if (myArray[j] > myArray[j + 1])
                    {
                        int temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
            for (int k = 0; k < myArray.Length; k++)
            {
                Console.WriteLine(myArray[k] + ",");
            }
        }
    }
}

