using System;
using System.Collections.Generic;
using System.Text;
namespace Cap2_4_OpAritmeticas
{
    class Program
    { // Esta es la función principal del programa 
      // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Declaramos las variables, ahora de tipo flotante
            float a, b, resultado;
            // Inicializamos las variables
            a = 7; b = 8;
            resultado = 0;
            // Sumas
            Console.WriteLine("Sumas");
            resultado = 3 + 5; Console.WriteLine("Resultado = {0}", resultado);
            resultado = a + 3; Console.WriteLine("Resultado = {0}", resultado);
            resultado = a + b; Console.WriteLine("Resultado = {0}", resultado);
            // Restas
            Console.WriteLine("Restas");
            resultado = a - b; Console.WriteLine("Resultado = {0}", resultado);
            resultado = b - 5; Console.WriteLine("Resultado = {0}", resultado);
            resultado = b - a;
            // A la variable b se le resta a
            Console.WriteLine("Resultado = {0}", resultado);
            // Multiplicaciones
            Console.WriteLine("Multiplicaciones");
            resultado = a * 5; Console.WriteLine("Resultado = {0}", resultado);
            resultado = a * 3.5f; Console.WriteLine("Resultado = {0}", resultado);
            resultado = a * b; Console.WriteLine("Resultado = {0}", resultado);
            // Divisiones
            Console.WriteLine("Divisiones");
            resultado = a / 3; Console.WriteLine("Resultado = {0}", resultado);
            resultado = a / b; Console.WriteLine("Resultado = {0}", resultado);
            resultado = b / 2.5f; Console.WriteLine("Resultado = {0}", resultado);
            // Modulo
            Console.WriteLine("Modulo");
            resultado = a % b; Console.WriteLine("Resultado = {0}", resultado);
        }
    }
}