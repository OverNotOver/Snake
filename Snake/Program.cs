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
                int xApple = rand.Next(1, land.GetLength(0) - 1);
                int yApple = rand.Next(1, land.GetLength(1) - 1);
                land[xApple, yApple] = -1;
            }


        }

        static void SnakeGo()
        {
            
            int xSnake = 0;
            int ySnake = 0;

            for(int i = 0; i < land.GetLength(0); i++)
            {
                for(int j = 0; j < land.GetLength(1); j++)
                {
                    if(land[i, j] == 2)
                    {
                        xSnake = i;
                        ySnake = j; 
                    }
                       
                }
            }



            if (Up && xSnake > 1)
            {
                land[xSnake, ySnake] = 0;
                xSnake--;
                land[xSnake, ySnake] = 2;

            }
            else if(Down && xSnake < land.GetLength(0) - 2)
            {
                land[xSnake, ySnake] = 0;
                xSnake++;
                land[xSnake, ySnake] = 2;
            }
            else if(Rigth && ySnake < land.GetLength(1) - 2)
            {
                land[xSnake, ySnake] = 0;
                ySnake++;
                land[xSnake, ySnake] = 2;
            }
            else if(Left && ySnake > 1)
            {
                land[xSnake, ySnake] = 0;
                ySnake--;
                land[xSnake, ySnake] = 2;
            }


        }


        static void Main(string[] args)
        {
            Console.SetWindowSize(41, 21);
            Console.SetBufferSize(41, 21);
            Console.CursorVisible = false;
            while (true)
            {
                SnakeGo();
                AppleSpayn();
                PrintLand();
                KeyGo();
                


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
                  
                    }                   
                    break;
                case ConsoleKey.RightArrow:
                    if(Left == false)
                    {
                        Rigth = true;
                        Up = false;
                        Down = false;
                    }
            
                    break;
                case ConsoleKey.LeftArrow:
                    if (Rigth == false)
                    {
                        Left = true;
                        Up = false;
                        Down = false;
                    }
              
                    break;
                case ConsoleKey.DownArrow:
                    if(Up == false)
                    {
                        Down = true;
                        Left = false;
                        Rigth = false;
                    }           
                    break;
              

            }
        }
    }
}
