using System;
using System.Collections.Generic;
using System.Text;
namespace Cap2_3_MostrarVariable
{
    class Program
    { // Esta es la función principal del programa // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Declaramos variables
            int costo; int valor, precio;
            // Inicializamos las variables
            costo = 50; valor = 75; precio = 125;
            // Declaramos e inicializamos
            int impuesto = 10;
            // Mostramos un valor
            Console.WriteLine("El valor adentro de costo es {0}", costo);
            // Varias variables
            Console.WriteLine("Valor es {0} y precio es {1}", valor, precio);
            // Dos veces la misma variable
            Console.WriteLine("Valor es {0} y precio es {1} con valor de {0}", valor, precio);
            /* No olvidemos mostrar el valor de la variable impuesto */
            Console.WriteLine("Y el valor que nos faltaba mostrar {0}", impuesto);
        }
    }
}