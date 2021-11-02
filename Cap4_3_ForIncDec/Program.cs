using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_3_IncDec
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            int numero = 5;
            Console.WriteLine("Valor inicial {0}", numero);
            // incrementamos 
            numero++;
            Console.WriteLine("Después del incremento {0}", numero);
            // Decrementamos 
            numero--;
            Console.WriteLine("Después del decremento {0}", numero);
            // Incremento en la sentencia 
            Console.WriteLine("Incremento en la sentencia {0}", numero++);
            Console.WriteLine("Valor después de la sentencia {0}", numero);
            // Incremento en la sentencia como prefijo
            Console.WriteLine("Incremento en la sentencia {0}", ++numero);
            Console.WriteLine("Valor después de la sentencia {0}", numero);
        }
    }
}
