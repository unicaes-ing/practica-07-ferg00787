using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7.Ejercicios
{
    class Ejercicio4
    {
        public static int[,] Numeros;
        public static void CargarDatos()
        {

            Numeros = new int[5, 5];
            Console.Write("Ingrese los numeros de la matriz: ");
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    string num;
                    num = Console.ReadLine();
                    Numeros[f, c] = int.Parse(num);

                }
            }
        }


        public static void MostrarDatos()
        {
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(Numeros[f, c] + " ");
                }
            }
            Console.WriteLine();
        }


        static void Main(string[] args)
        {
            CargarDatos();
            MostrarDatos();
            Console.ReadKey();
        }

    }
}
