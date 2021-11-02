using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_4_ForEjem2
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias 
            int n = 0;  // Variable de control
            int numero = 0; // Número al que sacamos factorial
            int factorial = 1;  // Factorial calculado
            string valor = "";
            // Pedimos el numero 
            Console.WriteLine("Dame el número al que se le saca el factorial:");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            // Calculamos el factorial en el ciclo
            for (n = numero; n >= 1; n--) factorial *= n;
            // Mostramos el resultado
            Console.WriteLine("El factorial de {0} es {1}", numero, factorial);
        }
    }
}
