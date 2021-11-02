/*   Hacer un programa que calcule el promedio de edad de un grupo de personas y diga cuál es la de edad más grande y cuál es la más joven. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap4_7_EjercicioPractico5 // Creamos un namespace de nombre Cap4_7_EjercicioPractico5 para identificar nuestro proyecto
{
    class Program                   // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            int n = 0;                      // Variable tipo int
            int NPersonas = 0;              // Variable tipo int
            int edad = 0;                   // Variable tipo int
            int mayor = 0;                  // Variable tipo int
            int menor = 200;                // Variable tipo int
            float promedio = 0;             // Variable tipo float
            string valor = "";              // Variable tipo string
            Console.WriteLine("Dame el numero de personas:");               // Mostramos un mensaje en consola con el comando WriteLine
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            NPersonas = Convert.ToInt32(valor);                             // Convertimos a int el String recibido con el comando ToInt32
            for (n = NPersonas; n >= 1; n = n - 1)                          // Usamos la estructura for indicando un ciclo de "NPersonas" repeticiones en pasos de 1
            {
                Console.WriteLine("Dame la edad de la persona {0}:", n);    // Mostramos un mensaje en consola con el comando WriteLine usando la variable n
                valor = Console.ReadLine();                                 // Usamos el comando ReadLine() para recibir informacion del teclado
                edad = Convert.ToInt32(valor);                              // Convertimos a int el String recibido con el comando ToInt32
                promedio = promedio + edad;                                 // Ejecutamos la operacion suma entre las variables promedio y edad
                if (mayor <= edad)                                          // Hacemos uso de if con la expresión mayor <= edad
                {
                    mayor = edad;                                           // Ponemos en la variable mayor el contenido de edad
                }
                else if (menor >= edad)                                     // Hacemos uso de else if con la expresión menor >= edad
                {
                    menor = edad;                                           // Ponemos en la variable menor el contenido de edad
                }
            }
            promedio = promedio / NPersonas;                                // Ejecutamos la operacion division entre las variables promedio y NPersonas
            Console.WriteLine("Promedio: {0}", promedio);                   // Mostramos un mensaje en consola con el comando WriteLine usando la variable promedio
            Console.WriteLine("Edad mayor: {0}", mayor);                    // Mostramos un mensaje en consola con el comando WriteLine usando la variable mayor
            Console.WriteLine("Edad menor: {0}", menor);                    // Mostramos un mensaje en consola con el comando WriteLine usando la variable menor
        }
    }
}