using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_2_ForContAcum
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias 
            int n = 0;
            // variable de control 
            int contador = 0, acumulador = 0;
            Console.WriteLine("—- Antes del ciclo —-");
            for (n = 10; n >= 1; n = n - 1)
            {
                contador = contador + 1;
                acumulador = acumulador + contador;
                Console.WriteLine("{0}, {1}", contador, acumulador);
            }
            Console.WriteLine("—- Después del ciclo —-");
        }
    }
}