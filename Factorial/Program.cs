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
            while (true)
            {
                try
                {
                    Console.WriteLine("Digite un número del 1 al 10: ");
                    int number = Int32.Parse(Console.ReadLine());
                    if (number >= 1 && number <= 10)
                    {
                        Console.WriteLine("El factorial de " + number + " es: " + Factorial(number).ToString());
                        break;
                    }
                    else
                    {
                        Console.WriteLine("La entrada debe ser un número entre el 1 y el 10.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("La entrada debe ser un número entre el 1 y el 10.");
                }
            }
        }
    }
}
