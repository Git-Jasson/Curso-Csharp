using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_5_DoWhile1
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias 
            float pies = 0.0f;  // Cantidad de pies
            float pulgadas = 0.0f;  // Cantidad de pulgadas
            float centimetros = 0.0f;  // Resultado en centímetros
            string respuesta = "";  // Respuesta para otro cálculo
            string valor = "";
            do
            {
                // Pedimos los pies 
                Console.WriteLine("Cuántos pies:");
                valor = Console.ReadLine();
                pies = Convert.ToSingle(valor);
                // Pedimos las pulgadas 
                Console.WriteLine("Cuántas pulgadas:");
                valor = Console.ReadLine();
                pulgadas = Convert.ToSingle(valor);
                // Convertimos a centimetros 
                centimetros = ((pies * 12) + pulgadas) * 2.54f;
                // Mostramos el resultado 
                Console.WriteLine("Son {0} centímetros", centimetros);
                // Preguntamos si otra conversión
                Console.WriteLine("Deseas hacer otra conversión(si/no)?"); respuesta = Console.ReadLine();
            } while (respuesta == "si");
        }
    }
}