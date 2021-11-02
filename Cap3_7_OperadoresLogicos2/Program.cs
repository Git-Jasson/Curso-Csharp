using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_7_OperadoresLogicos2
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Variables necesarias
            int edad = 0;
            bool permiso = false;
            string valor = "";
            // Obtenemos los datos
            Console.Write("Dame la edad: ");
            valor = Console.ReadLine();
            edad = Convert.ToInt32(valor);
            Console.Write("Tiene permiso de los padres(true/false) : ");
            valor = Console.ReadLine();
            permiso = Convert.ToBoolean(valor);
            // Verificamos que se cumpla la regla
            if (edad > 18 || (edad > 15 && permiso == true))
                Console.WriteLine("Es posible conducir");
            else
                Console.WriteLine("No puedes conducir");
        }
    }
}