/*  Hacer un programa que calcule el perímetro de cualquier polígono regular. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap2_7_EjercicioPractico1 // Creamos un namespace de nombre Cap2_7_EjercicioPractico1 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Declaramos las variables que necesitamos
            float perimetro = 0.0f;         // Variable tipo float 
            float Nlados = 1.0f;            // Variable tipo float
            float Largo = 1.0f;             // Variable tipo float
            string valor = "";              // Variable tipo string

            Console.Write("Dame el numero de lados del poligono: ");        // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            Nlados = Convert.ToSingle(valor);                               // Convertimos a flotante el String recibido con el comando ToSingle
            Console.Write("Dame el largo del lado: ");                      // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            Largo = Convert.ToSingle(valor);                                // Convertimos a flotante el String recibido con el comando ToSingle
            perimetro = Nlados * Largo;                                     // Ejecutamos la operacion multiplicar entre las variables NLados y Largo
            Console.WriteLine("El perímetro es: {0} unidades", perimetro);  // Mostramos un mensaje en consola con el comando WriteLine usando la variable perimetro
        }
    }
}