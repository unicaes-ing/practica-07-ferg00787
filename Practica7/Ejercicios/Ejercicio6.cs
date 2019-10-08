using System;


namespace Practica7.Ejercicios
{
    class Ejercicio6
    {
        public static Random r;
        public static int[,] numeros;

        public static void CargarDatos()
        {
            r = new Random();

            numeros = new int[10, 10];
            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                for (int c = 0; c < numeros.GetLength(1); c++)
                {
                    numeros[f, c] = r.Next(10, 99);

                }

            }
            Console.WriteLine();
            Console.WriteLine("La matriz se genero correctamente");
            Console.WriteLine("Presione <Enter> para regresar al menu");
            Console.ReadLine();

        }

        public static void MostrarDatos()
        {
            Console.WriteLine("+––-+–––+–––+–––+––––+––––");
            for (int f = 0; f < numeros.GetLength(0); f++)
            {
                Console.WriteLine("[");
                for (int c = 0; c < numeros.GetLength(0); c++)
                {
                    if (numeros[f, c] == 0)
                    {
                        Console.Write("00");
                    }
                    else
                    {
                        if ((numeros[f, c] != 0) && (numeros[f, c] % 2 == 0))
                        {

                            Console.ForegroundColor = ConsoleColor.Black;
                        }

                        Console.Write(numeros[f, c]);
                    }


                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.WriteLine("[");

                }

                Console.WriteLine();
                if (f < 9)
                {
                    Console.WriteLine("+––-+–––+–––+–––+––––+––––");
                }

            }

            Console.WriteLine("+––-+–––+–––+–––+––––+––––");
            Console.WriteLine();
            Console.WriteLine("Presione <Enter> para regresar al menu");
            Console.ReadLine();





        }

        static void Main(string[] args)
        {

            int op = 0;
            numeros = new int[6, 6];

            do
            {
                Console.Clear();
                Console.WriteLine("[1]. Generar matriz");
                Console.WriteLine("[2]. Ver matriz");
                Console.WriteLine("[3]. Salir");
                Console.WriteLine();
                op = Convert.ToInt32(Console.ReadLine());
                switch (op)
                {
                    case 1:
                        CargarDatos();
                        break;
                    case 2:
                        MostrarDatos();
                        break;
                }
            } while (op != 3);




        }

    }
}
