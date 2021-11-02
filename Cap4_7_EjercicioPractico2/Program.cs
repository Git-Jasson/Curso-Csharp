using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap4_7_EjercicioPractico2 // Creamos un namespace de nombre Cap4_7_EjercicioPractico2 para identificar nuestro proyecto
{
    class Program                   // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            // Variables necesarias 
            int numero = 0;                 // Variable tipo int
            int potencia = 0;               // Variable tipo int
            int resultado = 1;              // Variable tipo int
            string Valor = "";              // Variable tipo string
            int contador = 0;               // Variable tipo int
            int n = 0;                      // Variable tipo int
            Console.Write("Dame un numero entero: ");               // Mostramos un mensaje en consola con el comando Write
            Valor = Console.ReadLine();                             // Usamos el comando ReadLine() para recibir informacion del teclado
            numero = Convert.ToInt32(Valor);                        // Convertimos a int el String recibido con el comando ToInt32
            Console.Write("Dame la potencia del numero entero: ");  // Mostramos un mensaje en consola con el comando Write
            Valor = Console.ReadLine();                             // Usamos el comando ReadLine() para recibir informacion del teclado
            potencia = Convert.ToInt32(Valor);                      // Convertimos a int el String recibido con el comando ToInt32
            for (n = potencia; n >= 1; n = n - 1)                   // Usamos la estructura for indicando un ciclo de "potencia" repeticiones en pasos de 1
            {
                contador++;                                         // La variable contador se incremente en 1
                resultado = resultado * numero;                     // Ejecutamos la operacion multiplicar entre las variables resultado y numero

            }
            Console.WriteLine("El resultado es: {0}", resultado);   // Mostramos un mensaje en consola con el comando WriteLine usando la variable resultado
        }
    }
}