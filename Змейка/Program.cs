using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Змейка
{
    internal class Program
    {
        public static int going = 0;
        public static int counterApples = 0;
        public static int playerPoint = 2;
        //public static int applePoint = 3;
        public static int x = 10;
        public static int y = 10;
        public static int[,] land = new int[20, 20]
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





        static void CleanAfterPlayer(int playerPoint, int x, int y)
        {

            for (int i = 0; i < land.GetLength(0); i++) //стоблцы
            {
                for (int j = 0; j < land.GetLength(1); j++) //строки
                {
                    land[x, y] = 0;
                }
            }
        }



        static void KydaGoing()
        {

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    going = 1;
                    break;
                case ConsoleKey.RightArrow:
                    going = 2;
                    break;
                case ConsoleKey.LeftArrow:
                    going = 3;
                    break;
                case ConsoleKey.DownArrow:
                    going = 4;
                    break;
                default:
                    going = 0;
                    break;


            }


        }

        // Рисует поле с играком в стартовой позиции
        static void PrintLand()
        {

            Console.Clear();
            Console.WriteLine("\n\n");

            for (int i = 0; i < land.GetLength(0); i++) //стоблцы
            {
                Console.Write("\t");
                for (int j = 0; j < land.GetLength(1); j++) //строки
                {
                    if (land[i, j] == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("0>");
                        Console.ResetColor();

                    }
                    else if (land[i, j] == 1)
                    {

                        Console.Write("[]");


                    }
                    
                    else if (land[i,j] == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
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

        //static void RandPointApple()
        //{
        //    Random rand = new Random();
        //    land[5, 5] = applePoint;

        //}

        static void WaitClick()
        {
            KydaGoing();

            if (going == 1)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                CleanAfterPlayer(playerPoint, x, y);
            

                if (x > 1)
                {
                    int x2 = x - 1;
                    land[x2, y] = playerPoint;
                    x = x2;

                }
                else
                {
                    land[x, y] = playerPoint;
                }


                for (int i = 0; i < land.GetLength(0); i++) //стоблцы
                {
                    Console.Write("\t");
                    for (int j = 0; j < land.GetLength(1); j++) //строки
                    {


                        if (land[i, j] == 3)
                        {
                             
                            // думаю тут надо писать условие ))) 

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("0^");
                            Console.ResetColor();
                        


                        }
                        else if (land[i, j] == 1)
                        {
                            Console.Write("[]");

                        }
                        else if (land[i, j] == -1)
                        {

                            Console.ForegroundColor = ConsoleColor.Green;
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
            else if (going == 2)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                CleanAfterPlayer(playerPoint, x, y);
                if (y < 18)
                {
                    int y2 = y + 1;
                    land[x, y2] = playerPoint;
                    y = y2;

                }
                else
                {
                    land[x, y] = playerPoint;
                }




                for (int i = 0; i < land.GetLength(0); i++) //стоблцы
                {
                    Console.Write("\t");
                    for (int j = 0; j < land.GetLength(1); j++) //строки
                    {


                        if (land[i, j] == playerPoint)
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
                            Console.ForegroundColor = ConsoleColor.Green;
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
            else if (going == 3)
            {

                Console.Clear();
                Console.WriteLine("\n\n");
                CleanAfterPlayer(playerPoint, x, y);
                if (y > 1)
                {
                    int y2 = y - 1;
                    land[x, y2] = playerPoint;
                    y = y2;

                }
                else
                {
                    land[x, y] = playerPoint;
                }













                for (int i = 0; i < land.GetLength(0); i++) //стоблцы
                {
                    Console.Write("\t");
                    for (int j = 0; j < land.GetLength(1); j++) //строки
                    {



                        if (land[i, j] == playerPoint)
                        {

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("<0");
                            Console.ResetColor();

                        }
                        else if (land[i, j] == 1)
                        {
                            Console.Write("[]");
                        }
                        else if (land[i, j] == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
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
            else if (going == 4)
            {
                Console.Clear();
                Console.WriteLine("\n\n");
                CleanAfterPlayer(playerPoint, x, y);

                if (x < 18)
                {
                    int x2 = x + 1;
                    land[x2, y] = playerPoint;
                    x = x2;

                }
                else
                {
                    land[x, y] = playerPoint;
                }





                for (int i = 0; i < land.GetLength(0); i++) //стоблцы
                {
                    Console.Write("\t");
                    for (int j = 0; j < land.GetLength(1); j++) //строки
                    {



                        if (land[i, j] == playerPoint)
                        {

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("0|");
                            Console.ResetColor();

                        }
                        else if (land[i, j] == 1)
                        {
                            Console.Write("[]");
                        }
                        else if (land[i, j] == -1)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
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
















            ////

        }

        static void Apples()
        {
            Random rand = new Random();
            land[rand.Next(1, 19), rand.Next(1, 19)] = applePoint;

            for (int i = 0; i < land.GetLength(0); i++) //стоблцы
            {
                Console.Write("\t");
                for (int j = 0; j < land.GetLength(1); j++) //строки
                {
                    if (land[i, j] == applePoint)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("@");
                        Console.ResetColor();
                    }
                }
                Console.WriteLine();
            }

        }



        static void Main(string[] args)
        {
            PrintLand();


            bool gameStart = true;

            int appleYes = 0;


            while (gameStart)
            {
                if (appleYes == 0)
                {
                    //RandPointApple();
                    appleYes = 1;
                }
                else
                {
                    WaitClick();

                }











                Console.WriteLine();
                Console.WriteLine("\t\t\tЯблук собрано " + counterApples);
            }


        }
    }
}
