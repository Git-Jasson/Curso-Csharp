/*  Hacer un programa que transforme de grados centígrados a grados Fahrenheit. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap2_7_EjercicioPractico4 // Creamos un namespace de nombre Cap2_7_EjercicioPractico4 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Declaramos las variables que necesitamos
            float Celsius = 0.0f;           // Variable tipo float
            double Fahrenheit = 0.0f;       // Variable tipo double
            string valor = "";              // Variable tipo string
            Console.Write("Dame un valor en grados celsius: ");     // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                             // Usamos el comando ReadLine() para recibir informacion del teclado
            Celsius = Convert.ToSingle(valor);                      // Convertimos a flotante el String recibido con el comando ToSingle
            Fahrenheit = ((1.8) * Celsius) + 32.0;                  // Ejecutamos las operaciones multiplicar y suma entre la variable Celsius
            Console.WriteLine("El valor en grados Fahrenheit es: {0} unidades", Fahrenheit);    // Mostramos un mensaje en consola con el comando WriteLine usando la variable Fahrenheit
        }
    }
}