using System;
using System.Collections.Generic;
using System.Text;
namespace Cap3_7_OperadoresLogicos1
{
    class Program
    {
        // Esta es la función principal del programa
        // Aquí inicia la aplicación
        static void Main(string[] args)
        {
            // Variables necesarias
            float a = 0.0f;
            float b = 0.0f;
            float resultado = 0.0f;
            string valor = "";
            int opcion = 0;
            // Mostramos el menú
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
            if (opcion == 1)
                resultado = a + b;
            // Verificamos para resta
            else if (opcion == 2)
                resultado = a - b;
            // Verificamos para división
            else if (opcion == 3 && b != 0) // Aquí usamos una expresión lógica
                resultado = a / b;
            // Verificamos para la multiplicación
            else if (opcion == 4) resultado = a * b;
            // Mostramos el resultado
            Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}