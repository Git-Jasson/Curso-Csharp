using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_2_BloqueIf
{
    class Program
    { // Esta es la función principal del programa
      // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Variables necesarias
            float dividendo = 0.0f;
            float divisor = 1.0f;
            float resultado = 0.0f;
            string valor = "";
            // Pedimos el dividendo
            Console.WriteLine("Dame el dividendo:");
            valor = Console.ReadLine();
            dividendo = Convert.ToInt32(valor);
            // Pedimos el divisor
            Console.WriteLine("Dame el divisor:");
            valor = Console.ReadLine();
            divisor = Convert.ToInt32(valor);
            // Si el divisor es válido, entonces hacemos la división
            if (divisor != 0.0f)
            {
                // Hacemos la operación
                resultado = dividendo / divisor;
                // Mostramos el resultado
                Console.WriteLine("El resultado de la división es {0}", resultado);
            }
        }
    }
}