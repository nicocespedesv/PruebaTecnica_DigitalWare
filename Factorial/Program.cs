using System;

namespace Factorial
{
    internal class Program
    {
        public static int Factorial(int number)
        {
            int fact = 0;
            if (number == 0 || number == 1)
            {
                return 1;
            }
            else
            {
                fact = number * Factorial(number - 1);
            }
            return fact;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(10).ToString());
        }
    }
}
