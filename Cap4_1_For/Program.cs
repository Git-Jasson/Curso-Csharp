using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_1_For
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias 
            int n = 0;  // variable de control
            Console.WriteLine("—- Antes del ciclo —-");
            for (n = 1; n <= 10; n = n + 1)
                Console.WriteLine("{0}", n);
            Console.WriteLine("—- Después del ciclo —-");
        }
    }
}

