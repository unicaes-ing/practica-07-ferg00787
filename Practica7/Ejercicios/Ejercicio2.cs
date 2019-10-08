using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7.Ejercicios
{
    class Ejercicio2
    {

        static void Main(string[] args)
        {


            int num, n;
            int pares = 0, impares = 0;

            Console.Write("Ingrese la cantidad de numeros que desea ingresar: ");
            num = Convert.ToInt32(Console.ReadLine());
            int[] Numeros = new int[num];

            for (int i = 0; i < Numeros.Length; i++)
            {
                Console.WriteLine();
                Console.Write("Ingrese el numero: ");
                n = Convert.ToInt32(Console.ReadLine());


                if (n % 2 == 0)
                {
                    pares = pares + 1;

                }
                else
                {
                    impares = impares + 1;

                }



            }
            Console.Clear();
            Console.SetCursorPosition(10, 2);
            Console.Write("Los cantidad de numeros pares son: " + pares);
            Console.SetCursorPosition(10, 3);
            Console.Write("Los cantidad de numeros impares son: " + impares);


        }

    }
}
