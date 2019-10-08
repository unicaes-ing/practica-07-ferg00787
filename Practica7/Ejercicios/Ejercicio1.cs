using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7
{
    class Ejercicio1
    {
        static void Main(string[] args)
        {

            int num, edad;
            int menores = 0, mayores = 0;

            Console.Write("Ingrese la cantidad de personas que agregara: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] Cantidades = new int[num];

            for (int i = 0; i < Cantidades.Length; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese la edad de la persona numero " + (i + 1) + ":");
                edad = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {

                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;

                }

            }


            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.Write("La cantidad de personas menores de edad son: " + (menores));
            Console.SetCursorPosition(10, 3);
            Console.Write("La cantidad de personas mayores de edad son: " + (mayores));



            Console.ReadKey();








        }
    }
}
