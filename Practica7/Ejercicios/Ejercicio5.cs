using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7.Ejercicios
{
    class Ejercicio5
    {
        public static int[,] Numeros;
        public static int[,] Numeros2;

        static int sumar(int[,] datos)
        {
            int suma = 0;


            for (int ff = 0; ff < datos.GetLength(0); ff++)
            {
                for (int cf = 0; cf < datos.GetLength(1); cf++)
                {
                    suma += datos[ff, cf];
                }
            }


            return suma;
        }
        static int sumar2(int[,] datos)
        {
            int suma = 0;


            for (int ff = 0; ff < datos.GetLength(0); ff++)
            {
                for (int cf = 0; cf < datos.GetLength(1); cf++)
                {
                    suma += datos[ff, cf];
                }
            }


            return suma;
        }





        static void Main(string[] args)
        {
            int total = 0;
            Numeros = new int[3, 3];
            Console.Write("Ingrese los numeros de la matriz 1: ");
            for (int f1 = 0; f1 < Numeros.GetLength(0); f1++)
            {
                for (int c1 = 0; c1 < Numeros.GetLength(1); c1++)
                {
                    string num;
                    num = Console.ReadLine();
                    Numeros[f1, c1] = int.Parse(num);

                }
            }


            Numeros2 = new int[3, 3];
            Console.Write("Ingrese los numeros de la matriz 2: ");
            for (int f2 = 0; f2 < Numeros.GetLength(0); f2++)
            {
                for (int c2 = 0; c2 < Numeros.GetLength(1); c2++)
                {
                    string num;
                    num = Console.ReadLine();
                    Numeros2[f2, c2] = int.Parse(num);

                }
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.Clear();
            total = sumar(Numeros) + sumar(Numeros2);
            Console.WriteLine("La suma de la matrices es {0:N0}", total);
            Console.ReadKey();
        }

    }
}
