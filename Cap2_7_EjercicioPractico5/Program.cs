/*  Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.    */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap2_7_EjercicioPractico5 // Creamos un namespace de nombre Cap2_7_EjercicioPractico5 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Declaramos las variables que necesitamos
            float TasaCambio = 0.0f;        // Variable tipo float
            float Dolares = 0.0f;           // Variable tipo float
            float Euros = 0.0f;             // Variable tipo float
            string valor = "";              // Variable tipo string
            Console.Write("Ingrese la tasa de cambio actual: ");        // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
            TasaCambio = Convert.ToSingle(valor);                       // Convertimos a flotante el String recibido con el comando ToSingle
            Console.Write("Ingrese la cantidad en dolares: ");          // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
            Dolares = Convert.ToSingle(valor);                          // Convertimos a flotante el String recibido con el comando ToSingle
            Euros = TasaCambio * Dolares;                               // Ejecutamos la operacion multiplicar entre las variables TasaCambio y Dolares
            Console.WriteLine("La conversion a Euros es:{0}", Euros);   // Mostramos un mensaje en consola con el comando WriteLine usando la variable Euros
            Console.Write("Ingrese la cantidad en Euros: ");            // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
            Euros = Convert.ToSingle(valor);                            // Convertimos a flotante el String recibido con el comando ToSingle
            Dolares = Euros / TasaCambio;                               // Ejecutamos la operacion dividir entre las variables TasaCambio y Euros
            Console.WriteLine("La conversion a Dolares es:{0}", Dolares);// Mostramos un mensaje en consola con el comando WriteLine usando la variable Dolares
        }
    }
}