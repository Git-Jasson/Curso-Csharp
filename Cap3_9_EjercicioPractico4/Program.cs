/*  Hacer un programa que le pida al usuario un número del 1 al 7 y escriba el nombre del día que corresponde ese número en la semana. */

using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap3_9_EjercicioPractico4 // Creamos un namespace de nombre Cap3_9_EjercicioPractico4 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            string valor = "";              // Variable tipo string
            int opcion = 0;                 // Variable tipo int
                                            // Mostramos el menú 
            Console.Write("Ingrese un numero del 1 al 7: ");    // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                         // Usamos el comando ReadLine() para recibir informacion del teclado
            opcion = Convert.ToInt32(valor);                    // Convertimos a int el String recibido con el comando ToInt32
            switch (opcion)                                     // Usamos la estructura switch
            {
                case 1: Console.WriteLine("Lunes"); break;      // Verificamos la variable opcion = 1 y mostramos un mensaje en consola con el comando WriteLine
                case 2: Console.WriteLine("Martes"); break;     // Verificamos la variable opcion = 2 y mostramos un mensaje en consola con el comando WriteLine
                case 3: Console.WriteLine("Miercoles"); break;  // Verificamos la variable opcion = 3 y mostramos un mensaje en consola con el comando WriteLine
                case 4: Console.WriteLine("Jueves"); break;     // Verificamos la variable opcion = 4 y mostramos un mensaje en consola con el comando WriteLine
                case 5: Console.WriteLine("Viernes"); break;    // Verificamos la variable opcion = 5 y mostramos un mensaje en consola con el comando WriteLine
                case 6: Console.WriteLine("Sabado"); break;     // Verificamos la variable opcion = 6 y mostramos un mensaje en consola con el comando WriteLine
                case 7: Console.WriteLine("Domingo"); break;    // Verificamos la variable opcion = 7 y mostramos un mensaje en consola con el comando WriteLine
                default: Console.WriteLine("Opción no valida"); break;  // Verificamos que no se cumple ninguna opcion y mostramos un mensaje en consola con el comando WriteLine
            }
        }
    }
}