using System;
using System.Linq;

namespace Punto2
{
    internal class Program
    {
        static int[] myArray = { 1, 2, 1, 3, 3, 1, 2, 1, 5, 1 };

        static void Main(string[] args)
        {
            var ListaAgrupada = myArray.ToList().GroupBy(x => x).ToList();
            foreach (var item in ListaAgrupada)
            {
                Console.WriteLine(item.Key + ": " + new string('*', item.ToList().Count()));
            }
        }
    }
}
