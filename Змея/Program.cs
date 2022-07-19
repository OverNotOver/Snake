using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Змея
{
    internal class Program
    {
        public static int[,] map = new int[20, 20]
       {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,-1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,3,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
       };

        static void PrintMap()
        {

            Console.Clear();
            Console.WriteLine("\n\n");

            for (int i = 0; i < map.GetLength(0); i++) //стоблцы
            {
                Console.Write("\t");
                for (int j = 0; j < map.GetLength(1); j++) //строки
                {
                    if (map[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("0>");
                        Console.ResetColor();

                    }
                    else if (map[i, j] == 1)
                    {

                        Console.Write("[]");


                    }

                    else if (map[i, j] == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.Write("()");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }

        }


        static void Main(string[] args)
        {
            PrintMap();
            Console.ReadKey();
        }
    }
}
