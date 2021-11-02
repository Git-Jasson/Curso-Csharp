/*  Hacer un programa que transforme de grados a radianes o de radianes a grados dependiendo de lo que necesite el usuario. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap3_9_EjercicioPractico2 // Creamos un namespace de nombre Cap3_9_EjercicioPractico2 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            double Pi = 3.1415926535897931; // Variable tipo double
            double Grados = 0.0f;           // Variable tipo double
            double Radianes = 0.0f;         // Variable tipo double
            string valor = "";              // Variable tipo string
            int opcion = 0;                 // Variable tipo int
                                            // Mostramos el menú 
            Console.WriteLine("1- Convertir de grados a radianes"); // Mostramos un mensaje en consola con el comando WriteLine
            Console.WriteLine("2- Convertir de radianes a grados"); // Mostramos un mensaje en consola con el comando WriteLine
            Console.Write("Que operación deseas hacer: ");          // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                             // Usamos el comando ReadLine() para recibir informacion del teclado
            opcion = Convert.ToInt32(valor);                        // Convertimos a int el String recibido con el comando ToInt32
            switch (opcion)                                         // Usamos la estructura switch
            {
                case 1:                                             // Verificamos la variable opcion = 1 para grados a radianes
                    // Pedimos el número en grados
                    Console.Write("Dame el valor en grados a convertir:");      // Mostramos un mensaje en consola con el comando Write
                    valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
                    Grados = Convert.ToSingle(valor);                           // Convertimos a float el String recibido con el comando ToSingle
                    Radianes = (Grados * Pi) / 180;                               // Ejecutamos las operaciones multiplicar y dividir entre las variables Grados y Pi
                    Console.WriteLine("El valor en radianes es: {0}", Radianes);// Mostramos un mensaje en consola con el comando WriteLine usando la variable Radianes
                    break;                                                      // Finalizamos la estructura switch
                case 2:                                             // Verificamos la variable opcion = 1 para grados a radianes                
                    // Pedimos el número en radianes
                    Console.Write("Dame el valor en radianes a convertir:");    // Mostramos un mensaje en consola con el comando Write
                    valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
                    Radianes = Convert.ToSingle(valor);                         // Convertimos a float el String recibido con el comando ToSingle
                    Grados = (Radianes * 180) / Pi;                             // Ejecutamos las operaciones multiplicar y dividir entre las variables Radianes y Pi
                    Console.WriteLine("El valor en grados es: {0}", Grados);    // Mostramos un mensaje en consola con el comando WriteLine usando la variable Grados
                    break;                                                      // Finalizamos la estructura switch

                default:                                                        // Verificamos que no se cumple ninguna opcion
                    Console.WriteLine("Opción no valida");                      // Mostramos un mensaje en consola con el comando WriteLine
                    break;                                                      // Finalizamos la estructura switch 
            }
        }
    }
}