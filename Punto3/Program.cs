using System;

namespace Punto3
{
    internal class Program
    {
        static int[] myArray = { 1, 8, 6, 7, 2, 5 };

        static void Main(string[] args)
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray.Length; j++)
                {
                    if (myArray[i] + myArray[j] == 10 && myArray[i] != myArray[j])
                    {
                        Console.WriteLine(myArray[i].ToString() + " " + myArray[j].ToString());
                        break;
                    }
                }
            }
        }
    }
}
