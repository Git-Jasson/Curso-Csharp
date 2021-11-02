using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_3_Else
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            int numero = 0; // Donde guardamos el número
            string valor = "";  // Para guardar la cadena dada por el usuario 
            // Pedimos el numero
            Console.Write("Dame un número entero:");
            valor = Console.ReadLine();
            numero = Convert.ToInt32(valor);
            // Convertimos la cadena a entero 
            // Hacemos uso de if con la expresión para el caso de los positivos
            if (numero >= 0)
                Console.WriteLine("El número {0} es positivo", numero);
            // se ejecuta si se cumple numero>=0
            else
                Console.WriteLine("El numero {0} es negativo", numero);
            // se ejecuta si NO se cumple numero>=0
        }
    }
}