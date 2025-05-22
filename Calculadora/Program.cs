using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            while (opcion != 6)
            {
                Console.Clear();
                Console.WriteLine("=== Calculadora Básica ===");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Multiplicación");
                Console.WriteLine("4. División");
                Console.WriteLine("5. Elevar un número a la potencia");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción (1-6): ");

                try
                {
                    opcion = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Entrada inválida. Por favor, ingrese un número del 1 al 6.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                    continue;
                }

                if (opcion >= 1 && opcion <= 5)
                {
                    double num1, num2;

                    Console.Write("Ingrese el primer número: ");
                    if (!double.TryParse(Console.ReadLine(), out num1))
                    {
                        Console.WriteLine("Entrada inválida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    }

                    Console.Write("Ingrese el segundo número: ");
                    if (!double.TryParse(Console.ReadLine(), out num2))
                    {
                        Console.WriteLine("Entrada inválida. Presione cualquier tecla para continuar...");
                        Console.ReadKey();
                        continue;
                    }

                    double resultado = 0;

                    switch (opcion)
                    {
                        case 1:
                            resultado = num1 + num2;
                            Console.WriteLine($"Resultado: {num1} + {num2} = {resultado}");
                            break;
                        case 2:
                            resultado = num1 - num2;
                            Console.WriteLine($"Resultado: {num1} - {num2} = {resultado}");
                            break;
                        case 3:
                            resultado = num1 * num2;
                            Console.WriteLine($"Resultado: {num1} * {num2} = {resultado}");
                            break;
                        case 4:
                            if (num2 == 0)
                            {
                                Console.WriteLine("Error: División por cero no permitida.");
                            }
                            else
                            {
                                resultado = num1 / num2;
                                Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                            }
                            break;
                        case 5:
                            resultado = Math.Pow(num1, num2);
                            Console.WriteLine($"Resultado: {num1} ^ {num2} = {resultado}");
                            break;
                    }

                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("Gracias por usar la calculadora. ¡Hasta luego!");
                }
                else
                {
                    Console.WriteLine("Opción inválida. Por favor, seleccione una opción del 1 al 6.");
                    Console.WriteLine("Presione cualquier tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
