using System;

namespace Punto2
{
    internal class Program
    {
        static int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };

        static void Main(string[] args)
        {
            Array.Sort(myArray);
            string number = string.Empty;

            for (int i = 0; i < myArray.Length; i++)
            {
                if (i == myArray.Length - 1)
                {

                }
                if (myArray[i] == myArray[i + 1])
                {
                    if (i == 0)
                    {
                        number = myArray[i] + ": " + "**";
                    }
                    else
                    {
                        if (myArray[i] == myArray[i - 1])
                        {
                            number += "*";
                        }
                        else
                        {
                            number = myArray[i] + ": " + "**";
                        }
                    }
                }
                else
                {
                    Console.WriteLine(number);
                }

            }
        }
    }
}
