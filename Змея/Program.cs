using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Змея
{
    internal class Program
    {
        public static int[,] land = new int[20, 20]
       {
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,2,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1 }
       };

        public static int walk = 0;
        public static int snake = 2;
        public static int x = 10;
        public static int y = 10;
        static void PrintMap()
        {

            Console.Clear();
            Console.WriteLine("\n\n");

            for (int i = 0; i < land.GetLength(0); i++) //стоблцы
            {
                Console.Write("\t");
                for (int j = 0; j < land.GetLength(1); j++) //строки
                {
                    if (land[i, j] == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("0>");
                        Console.ResetColor();

                    }
                    else if (land[i, j] == 1)
                    {

                        Console.Write("[]");


                    }

                    else if (land[i, j] == -1)
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


        static void SnakeGo()
        {

            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {







                }
            }




        }


        static void Main(string[] args)
        {
            PrintMap();

            //while (true)
            //{
            //    Thread.Sleep(200);
            //    SnakeGo();


            //}

            if (walk == 1)
            {
                if (x > 1)
                {
                    int x2 = x - 1;
                    land[x2, y] = snake;
                    x = x2;

                }
                else
                {
                    land[x, y] = snake;
                }

                for (int i = 0; i < land.GetLength(0); i++)
                {
                    for (int j = 0; j < land.GetLength(1); j++)
                    {


                        if (land[i, j] == snake)
                        {


                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("0^");
                            Console.ResetColor();



                        }
                        else if (land[i, j] == 1)
                        {
                            Console.Write("[]");

                        }
                        //else if (land[i, j] == -1)
                        //{

                        //    Console.ForegroundColor = ConsoleColor.Green;
                        //    Console.Write("()");
                        //    Console.ResetColor();

                        //}

                        else
                        {
                            Console.Write("  ");

                        }




                    }
                }

            }

            Console.ReadLine();
        }





        static void KeyWalk()
        {
            ConsoleKey keyRead = Console.ReadKey().Key;
            switch (keyRead)
            {
                case ConsoleKey.UpArrow:
                    walk = 1;
                    break;
                case ConsoleKey.RightArrow:
                    walk = 2;
                    break;
                case ConsoleKey.LeftArrow:
                    walk = 3;
                    break;
                case ConsoleKey.DownArrow:
                    walk = 4;
                    break;
                default:
                    walk = 0;
                    break;
            }

        }
    }
}
