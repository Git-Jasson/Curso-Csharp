using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_1_If
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            int numero = 0; // Donde guardamos el número
            string Valor = "";  // Para guardar la cadena dada por el usuario
            // Pedimos el número
            Console.Write("Dame un numero entero:");
            Valor = Console.ReadLine();
            numero = Convert.ToInt32(Valor);    // Convertimos la cadena a entero
            // Hacemos uso de if con la expresión para el caso de los positivos
            if (numero >= 0)
                Console.WriteLine("El numero {0} es positivo", numero); // se ejecuta si se cumple numero>=0
            // Hacemos uso de if con la expresión para el caso de los negativos
            if (numero < 0)
                Console.WriteLine("El numero {0} es negativo", numero); // se ejecuta si se cumple numero<0
        }
    }
}