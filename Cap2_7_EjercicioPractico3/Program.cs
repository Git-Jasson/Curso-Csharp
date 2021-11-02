using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap2_7_EjercicioPractico3 // Creamos un namespace de nombre Cap2_7_EjercicioPractico3 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Declaramos las variables que necesitamos
            double Pi = 3.1415926535897931; // Variable tipo double
            float Grados = 0.0f;            // Variable tipo float
            double Radianes = 0.0f;         // Variable tipo double
            string valor = "";              // Variable tipo string
            Console.Write("Dame un numero en grados: ");    // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                     // Usamos el comando ReadLine() para recibir informacion del teclado
            Grados = Convert.ToSingle(valor);               // Convertimos a flotante el String recibido con el comando ToSingle
            Radianes = (Grados * Pi) / 180;                   // Ejecutamos las operaciones multiplicar y dividir entre las variables Grados y Pi
            Console.WriteLine("El valor en radianes es: {0} unidades", Radianes);   // Mostramos un mensaje en consola con el comando WriteLine usando la variable Radianes
        }
    }
}