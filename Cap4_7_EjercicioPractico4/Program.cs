/*  Hacer un programa que encuentre los números primos que existen entre el 1 y el 1000.    */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap4_7_EjercicioPractico4 // Creamos un namespace de nombre Cap4_7_EjercicioPractico4 para identificar nuestro proyecto
{
    class Program                   // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            int n = 0, m = 0;               // Variable tipo int
            int primo = 0;                  // Variable tipo int
            int acumulador = 0;             // Variable tipo int
            for (n = 1000; n >= 1; n = n - 1)       // Usamos la estructura for indicando un ciclo de 1000 repeticiones en pasos de 1
            {
                for (m = 1000; m >= 1; m = m - 1)   // Usamos la estructura for indicando un ciclo de 1000 repeticiones en pasos de 1
                {
                    primo = n % m;                    // Ejecutamos la operacion modulo entre las variables n y m
                    if (primo == 0)                 // Hacemos uso de if con la expresión primo == 0
                    {
                        acumulador++;               // La variable acumulador se incremente en 1
                    }
                }
                if (acumulador <= 2)                // Hacemos uso de if con la expresión acumulador <= 2
                {
                    Console.WriteLine("{0}", n);    // Mostramos un mensaje en consola con el comando WriteLine usando la variable n
                }
                acumulador = 0;                     // La variable acumulador la hacemos 0
            }
        }
    }
}