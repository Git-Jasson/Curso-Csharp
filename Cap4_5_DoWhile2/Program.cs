using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_5_DoWhile2
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            // Tenemos el ciclo
            do
            {
                // Mostramos el menú 
                Console.WriteLine("1 - Suma");
                Console.WriteLine("2 - Resta");
                Console.WriteLine("3 - División");
                Console.WriteLine("4 - Multiplicación");
                Console.WriteLine("5 - Salir");
                Console.Write("Que operación deseas hacer: ");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);
                if (opcion != 5)
                {
                    // Pedimos el primer número 
                    Console.Write("Dame el primer número:");
                    valor = Console.ReadLine();
                    a = Convert.ToSingle(valor);
                    // Pedimos el segundo número
                    Console.Write("Dame el segundo número:");
                    valor = Console.ReadLine();
                    b = Convert.ToSingle(valor);
                    switch (opcion)
                    {
                        // Verificamos para suma 
                        case 1: resultado = a + b; break;
                        // Verificamos para resta 
                        case 2: resultado = a - b; break;
                        // Verificamos para división 
                        case 3:
                            if (b != 0)
                                // este if esta anidado
                                resultado = a / b;
                            else
                                // Este else pertenece al segundo if
                                Console.WriteLine("Divisor no válido"); break;
                        // Verificamos para la multiplicación
                        case 4: resultado = a * b; break;
                        // Si no se cumple ninguno de los casos anteriores
                        default: Console.WriteLine("Opción no válida"); break;
                    }
                    // Mostramos el resultado 
                    Console.WriteLine("El resultado es: {0}", resultado);
                }
            } while (opcion != 5);
        }
    }
}

