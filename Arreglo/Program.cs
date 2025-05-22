using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10];

            Console.WriteLine("Ingrese 10 numeros desorenados: ");

            for (int x = 0; x < numeros.Length; x++)
            {
                Console.WriteLine($"Número {x + 1}");
                while(!int.TryParse(Console.ReadLine(), out numeros[x]))
                {
                    Console.WriteLine("Entrada invalida, ingrese numeros enteros");
                }
            }

            Array.Sort(numeros);
            Console.WriteLine("\nNúmeros ordenados de menor a mayor:");

            foreach (int numero in numeros)
            {
                Console.WriteLine(numero);
            }
        }
    }
}
