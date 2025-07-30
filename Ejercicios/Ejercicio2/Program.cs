using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int opcion;
            double cantidad;

            do
            {
                Console.WriteLine("\n\t--- Conversor de cocina ---");
                Console.WriteLine("\n\t1. Convertir gramos a libras");
                Console.WriteLine("\n\t2. Convertir mililitros a litros");
                Console.WriteLine("\n\t3. Convertir grados Celsius a Fahrenheit");
                Console.WriteLine("\n\t4. Salir");
                Console.Write("\n\tElige una opción (1-4): ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("\n\tIngresa los gramos: ");
                    cantidad = double.Parse(Console.ReadLine());
                    double libras = cantidad / 453.592;
                    Console.WriteLine("\n\tResultado: " + libras + " libras");
                }
                else if (opcion == 2)
                {
                    Console.Write("\n\tIngresa los mililitros: ");
                    cantidad = double.Parse(Console.ReadLine());
                    double litros = cantidad / 1000;
                    Console.WriteLine("\n\tResultado: " + litros + " litros");
                }
                else if (opcion == 3)
                {
                    Console.Write("\n\tIngresa los grados Celsius: ");
                    cantidad = double.Parse(Console.ReadLine());
                    double fahrenheit = (cantidad * 9 / 5) + 32;
                    Console.WriteLine("\n\tResultado: " + fahrenheit + " grados Fahrenheit");
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("\n\tSaliendo del programa...");
                }
                else
                {
                    Console.WriteLine("\n\tOpción no válida. Intenta otra vez.");
                }

            } while (opcion != 4);
        }
    }

} 
    
       
    

    

