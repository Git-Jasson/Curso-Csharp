/*  Hacer un programa que muestre la tabla de multiplicar del 1 al 10 de cualquier número.  */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap4_7_EjercicioPractico1 // Creamos un namespace de nombre Cap4_7_EjercicioPractico1 para identificar nuestro proyecto
{
    class Program                   // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            int numero = 0;                 // Variable tipo int
            int Multiplo = 0;               // Variable tipo int
            string Valor = "";              // Variable tipo string
            int n = 0;                      // Variable tipo int
            int contador = 0;               // Variable tipo int
            Console.Write("Dame un numero entero: ");       // Mostramos un mensaje en consola con el comando Write
            Valor = Console.ReadLine();                     // Usamos el comando ReadLine() para recibir informacion del teclado
            numero = Convert.ToInt32(Valor);                // Convertimos a int el String recibido con el comando ToInt32
            for (n = 10; n >= 1; n = n - 1)                 // Usamos la estructura for indicando un ciclo de 10 repeticiones en pasos de 1
            {
                contador++;                                 // La variable contador se incremente en 1
                Multiplo = numero * contador;               // Ejecutamos la operacion multiplicar entre las variables numero y contador
                Console.WriteLine("{0}", Multiplo);         // Mostramos un mensaje en consola con el comando WriteLine usando la variable Multiplo
            }
        }
    }
}