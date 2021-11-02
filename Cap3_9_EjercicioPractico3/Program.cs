using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap3_9_EjercicioPractico3 // Creamos un namespace de nombre Cap3_9_EjercicioPractico3 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            double numero = 0;              // Variable tipo double
            double resultado = 0;           // Variable tipo double
            string valor = "";              // Variable tipo string
                                            // Pedimos el numero
            Console.WriteLine("Asumiendo un impuesto del 19% a los productos:");    // Mostramos un mensaje en consola con el comando WriteLine
            Console.Write("Ingrese el valor del producto:");                        // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                             // Usamos el comando ReadLine() para recibir informacion del teclado
            numero = Convert.ToInt32(valor);                                        // Convertimos a int el String recibido con el comando ToInt32
            Console.WriteLine("El producto es medicina? si/no");                    // Mostramos un mensaje en consola con el comando WriteLine
            valor = Console.ReadLine();                                             // Usamos el comando ReadLine() para recibir informacion del teclado
            // Hacemos uso de if con la expresión para determinar si es medicina
            if (valor == "no")                                                      // Hacemos uso de if con la expresión valor == "no"
            {
                resultado = numero * 0.19;                                          // Ejecutamos la operacion multiplicar entre la variable numero
                Console.WriteLine("El impuesto al producto es:{0}", resultado);     // Mostramos un mensaje en consola con el comando WriteLine usando la variable resultado
            }
            else                                                                    // se ejecuta si no se cumple valor == "no"
                Console.WriteLine("El impuesto al producto es: 0");                 // Mostramos un mensaje en consola con el comando WriteLine
        }
    }
}