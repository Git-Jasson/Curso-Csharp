/*  Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap3_9_EjercicioPractico1 // Creamos un namespace de nombre Cap3_9_EjercicioPractico1 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            int numero = 0;                             // Variable tipo int
            string valor = "";                          // Variable tipo string 
            Console.Write("Dame un número entero:");    // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                 // Usamos el comando ReadLine() para recibir informacion del teclado
            numero = Convert.ToInt32(valor);            // Convertimos a int el String recibido con el comando ToInt32
            int Residuo = numero % 2;                   //Dividimos el numero en 2 usando modulo para encontrar su residuo                 
            if (Residuo == 0)                           // Hacemos uso de if con la expresión Residuo == 0 para el caso de los pares
                Console.WriteLine("El número {0} es par", numero);  // Mostramos un mensaje en consola con el comando WriteLine usando la variable numero
            else                                                    // se ejecuta si no se cumple numero par
                Console.WriteLine("El numero {0} es inpar", numero);// Mostramos un mensaje en consola con el comando WriteLine usando la variable numero
        }
    }
}