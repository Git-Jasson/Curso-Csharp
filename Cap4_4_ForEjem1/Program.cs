using System;
using System.Collections.Generic;
using System.Text;
namespace Cap4_4_ForEjem1
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación 
        static void Main(string[] args)
        {
            // Variables necesarias
            int n = 0;  // Control ciclo
            int cantidad;   // Cantidad alumnos
            float calif = 0.0f; // Calificación del alumno
            float suma = 0.0f;  // Sumatoria de calificaciones
            float promedio = 0.0f;   // Promedio final
            string valor = "";
            Console.WriteLine("Dame la cantidad de alumnos:");
            valor = Console.ReadLine();
            cantidad = Convert.ToInt32(valor);
            // Ciclo para la captura de calificaciones
            for (n = 1; n <= cantidad; n++)
            {
                Console.WriteLine("Dame la calificacion del alumno");
                valor = Console.ReadLine();
                calif = Convert.ToSingle(valor);
                // Llevamos a cabo la suma de calificaciones
                suma += calif;
            }
            // Calculamos el promedio
            promedio = suma / cantidad;
            // Mostramos el promedio 
            Console.WriteLine("El promedio es {0}", promedio);
        }
    }
}