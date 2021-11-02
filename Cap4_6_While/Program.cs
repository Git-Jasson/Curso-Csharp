using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_6_While
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias 
            int temperatura = 0;
            string valor = "";
            // Pedimos la temperatura 
            Console.WriteLine("Dame la temperatura actual:");
            valor = Console.ReadLine();
            temperatura = Convert.ToInt32(valor);
            // El ciclo reduce la temperatura 
            while (temperatura > 20)
            {
                // Disminuimos la temperatura 
                temperatura--;
                Console.WriteLine("Temperatura->{0}", temperatura);
            }
            // Mostramos la temperatura final
            Console.WriteLine("La temperatura final es {0}", temperatura);
        }
    }
}
