using System;
using System.Collections.Generic;
using System.Text;

namespace Cap2_6_Rectangulo
{
    class Rectangulo
    {
        static void Main(string[] args)
        {
            // Declaramos las variables que necesitamos
            float area = 0.0f;
            float perimetro = 0.0f;
            float ancho = 1.0f;
            float alto = 1.0f;
            string valor = "";
            Console.Write("Dame el ancho del rectángulo: "); valor = Console.ReadLine();
            ancho = Convert.ToSingle(valor); // Convertimos a flotante
            Console.Write("Dame el alto del rectángulo: "); valor = Console.ReadLine();
            alto = Convert.ToSingle(valor); // Convertimos a flotante
            area = ancho * alto;
            perimetro = (ancho + alto) * 2;
            Console.WriteLine("El área es : {0} unidades cuadradas", area);
            Console.WriteLine("El perímetro es: {0} unidades", perimetro);
        }
    }
}