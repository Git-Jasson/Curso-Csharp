using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_5_IfAnidado
{
    class Program
    {
        // Esta es la función principal del programa 
        // Aqui inicia la aplicacion
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            // Mostramos el menu
            Console.WriteLine("1- Suma");
            Console.WriteLine("2- Resta");
            Console.WriteLine("3- División");
            Console.WriteLine("4- Multiplicación");
            Console.Write("Que operación deseas hacer: ");
            valor = Console.ReadLine();
            opcion = Convert.ToInt32(valor);
            // Pedimos el primer número
            Console.Write("Dame el primer numero:");
            valor = Console.ReadLine();
            a = Convert.ToSingle(valor);
            // Pedimos el segundo número
            Console.Write("Dame el segundo numero:");
            valor = Console.ReadLine();
            b = Convert.ToSingle(valor);
            // Verificamos para suma
            if (opcion == 1) resultado = a + b;
            // Verificamos para resta
            if (opcion == 2) resultado = a - b;
            // Verificamos para division
            if (opcion == 3)
                if (b != 0)
                    // este if esta anidado
                    resultado = a / b;
                else
                    // Este else pertenece al segundo if
                    Console.WriteLine("Divisor no valido");
            // Verificamos para la multiplicacion
            if (opcion == 4) resultado = a * b;
            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}