using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static bool Up = false;
        static bool Rigth = false;
        static bool Left = false;
        static bool Down = false;

        public static int[,] land =
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


        static void PrintLand()
        {
            Console.Clear();
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if (land[i, j] == 1)
                    {
                        Console.Write("[]");


                    }
                    else if (land[i, j] == 2)
                    {
                        Console.Write("0>");
                    }
                    else if (land[i, j] == -1)
                    {
                        Console.Write("()");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }


        }
        static void AppleSpayn()
        {
            bool appleFind = false;
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if (land[i, j] == -1)
                    {
                        appleFind = true;
                    }
                }
            }

            if (appleFind == false)
            {
                Random rand = new Random();
                int xApple = rand.Next(1, land.GetLength(0));
                int yApple = rand.Next(1, land.GetLength(1));
                land[xApple, yApple] = -1;
            }


        }

        static void SnakeGo()
        {
           



        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(41, 21);
            Console.SetBufferSize(41, 21);
            Console.CursorVisible = false;
            while (true)
            {

                AppleSpayn();
                PrintLand();
                KeyGo();
                Console.ReadKey();
          
            }
        }


        static void KeyGo()
        {
            ConsoleKey keyRead = Console.ReadKey().Key;
            switch (keyRead)
            {
                case ConsoleKey.UpArrow:
                    if(Down == false)
                    {
                        Up = true;
                        Rigth = false;
                        Left = false;
                        Console.WriteLine("вверх");
                    }                   
                    break;
                case ConsoleKey.RightArrow:
                    if(Left == false)
                    {
                        Rigth = true;
                        Up = false;
                        Down = false;
                        Console.WriteLine("вправо");
                    }
            
                    break;
                case ConsoleKey.LeftArrow:
                    if (Rigth == false)
                    {
                        Left = true;
                        Up = false;
                        Down = false;
                        Console.WriteLine("влево");
                    }
              
                    break;
                case ConsoleKey.DownArrow:
                    if(Up == false)
                    {
                        Down = true;
                        Left = false;
                        Rigth = false;
                        Console.WriteLine("вниз");
                    }           
                    break;
              

            }
        }
    }
}
