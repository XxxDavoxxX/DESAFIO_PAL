using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("\n\tElige una opción:");
                Console.WriteLine("\n\t1. Imprimir los números del 1 al 50 que sean divisibles por 3");
                Console.WriteLine("\n\t2. Imprimir los números del 50 al 100 que sean múltiplos de 7");

                Console.Write("\n\tOpción: ");

                Console.Write("\t");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.WriteLine("\n\tNúmeros del 1 al 50 divisibles por 3:");
                    for (int i = 1; i <= 50; i++)
                    {
                        if (i % 3 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else if (opcion == "2")
                {
                    Console.WriteLine("\n\tNúmeros del 50 al 100 múltiplos de 7:");
                    for (int i = 50; i <= 100; i++)
                    {
                        if (i % 7 == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("\n\tOpción no válida.");
                }
        }
    }
    
}

