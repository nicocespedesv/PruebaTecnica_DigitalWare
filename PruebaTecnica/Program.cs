using System;

namespace PruebaTecnica
{
    internal class Program
    {
        static int[] myArray = { 1, 7, 3, 36, 22 };
        static void Main(string[] args)
        {
            Array.Sort(myArray);
            Console.WriteLine(myArray[myArray.Length - 1]);
        }
    }
}
