using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica7.Ejercicios
{
    class Ejercicio3
    {
        public static string[][] datos;

        public static void Datos()
        {
            int equipos, integrantes;

            Console.Write("Ingrese la cantidad de equipos: ");
            equipos = Convert.ToInt32(Console.ReadLine());
            datos = new string[equipos][];

            for (int e = 0; e < datos.Length; e++)
            {

                Console.Write("Ingrese la cantidad de integrantes del equipo " + (e + 1) + ":");
                integrantes = Convert.ToInt32(Console.ReadLine());
                datos[e] = new string[integrantes];


                for (int i = 0; i < datos[e].Length; i++)
                {
                    Console.Write("Ingrese el nombre del integrante " + (i + 1) + ":");
                    datos[e][i] = Console.ReadLine();

                }

            }

        }

        public static void Mostrar()
        {
            Console.WriteLine();
            Console.WriteLine("Informacion de los equipos: ");
            for (int e = 0; e < datos.Length; e++)
            {
                Console.Write("Equipo " + (e + 1) + ":");
                for (int i = 0; i < datos[e].Length; i++)
                {
                    Console.Write(datos[e][i] + " ");
                }
                Console.WriteLine();

            }
        }



        static void Main(string[] args)
        {
            Datos();
            Mostrar();
            Console.ReadKey();
        }

    }
}
