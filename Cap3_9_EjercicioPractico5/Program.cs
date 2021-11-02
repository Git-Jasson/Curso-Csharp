using System;                       // Namespace predeterminado que requiere nuestro proyecto para funcionar
using System.Collections.Generic;   // Namespace adicionales para nuestro proyecto
using System.Text;                  // Namespace adicionales para nuestro proyecto

namespace Cap3_9_EjercicioPractico5 // Creamos un namespace de nombre Cap3_9_EjercicioPractico5 para identificar nuestro proyecto
{
    class Program                // Creamos una clase publica asociada a nuestro namespace llamada Rectangulo
    {
        static void Main(string[] args)     // Metodo principal del proyecto con indicador Main
        {
            double perimetro = 0.0f;        // Variable tipo double
            double area = 0.0f;             // Variable tipo double
            double ap = 0.0f;               // Variable tipo double
            int Nlados = 0;                 // Variable tipo int
            int opcion = 0;                 // Variable tipo int
            float longitud = 0;             // Variable tipo float
            string valor = "";              // Variable tipo string
            Console.Write("Ingrese el numero de lados del poligono: ");     // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            Nlados = Convert.ToInt32(valor);                                // Convertimos a int el String recibido con el comando ToInt32
            Console.Write("Ingrese la longitud del lado del poligono: ");   // Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            longitud = Convert.ToSingle(valor);                             // Convertimos a float el String recibido con el comando ToSingle
            Console.Write("Ingrese la longitud del apotema del poligono: ");// Mostramos un mensaje en consola con el comando Write
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            ap = Convert.ToSingle(valor);                                   // Convertimos a float el String recibido con el comando ToSingle
            Console.WriteLine("1- Calcular el perimetro.");                 // Mostramos un mensaje en consola con el comando WriteLine
            Console.WriteLine("2- Calcular el area.");                      // Mostramos un mensaje en consola con el comando WriteLine
            perimetro = Nlados * longitud;                                  // Ejecutamos la operacion multiplicar entre las variables Nlados y longitud
            valor = Console.ReadLine();                                     // Usamos el comando ReadLine() para recibir informacion del teclado
            opcion = Convert.ToInt32(valor);                                // Convertimos a int el String recibido con el comando ToInt32
            switch (opcion)                                                 // Usamos la estructura switch
            {
                case 1:                                                                 // Verificamos la variable opcion = 1
                    Console.WriteLine("El perimetro del poligono es: {0}", perimetro);   // Mostramos un mensaje en consola con el comando WriteLine usando la variable perimetro
                    break;                                                              // Finalizamos la estructura switch
                case 2:                                                                 // Verificamos la variable opcion = 2
                    area = (perimetro * ap) / 2;                                            // Ejecutamos las operaciones multiplicar y dividir entre las variables perimetro y ap
                    Console.WriteLine("El area del poligono es: {0}", area);            // Mostramos un mensaje en consola con el comando WriteLine usando la variable area
                    break;                                                              // Finalizamos la estructura switch

                default: Console.WriteLine("Opción no valida"); break;                  // Verificamos que no se cumple ninguna opcion y mostramos un mensaje en consola con el comando WriteLine
            }
        }
    }
}