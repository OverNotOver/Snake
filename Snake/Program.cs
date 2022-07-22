using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static int counterApples = 0;
        static bool Up = false;
        static bool Rigth = true;
        static bool Left = false;
        static bool Down = false;
        static bool iLive = true;


        static bool bigger = false;


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
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
                {1,0,0,0,2,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1 },
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
                    else if (land[i, j] >= 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("* ");
                        Console.ResetColor();
                    }
                    else if (land[i, j] == -1)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{}");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
            Console.WriteLine(counterApples);
    

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
                counterApples++;
            }


        }


        static int MaxValue()
        {
            int max = 0;
            for(int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if(max < land[i, j])
                    {
                        max = land[i, j];
                    }
                }
            }

            return max;

        }

        static void MaxValueZero()
        {
            int max = 0;
            int x = 0;
            int y = 0;
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if (max < land[i, j])
                    {
                        max = land[i, j];
                        x = i;
                        y = j;
                       
                    }
                }
            }

            land[x, y] = 0;

        }

        static void SnakeAdd()
        {
         
            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if(land[i, j] > 1)
                    {
                        land[i, j]++;
                    }
                }
            }


        }

        static void SnakeGo()
        {

            int xSnake = 0;
            int ySnake = 0;

            for (int i = 0; i < land.GetLength(0); i++)
            {
                for (int j = 0; j < land.GetLength(1); j++)
                {
                    if (land[i, j] == 2)
                    {
                        xSnake = i;
                        ySnake = j;
                    }

                }
            }

            if (Up)
            {
                if (land[xSnake - 1, ySnake] > 0) iLive = false;              
                else
                {
                    if (MaxValue() > counterApples)
                    {
                        MaxValueZero();
                    }
                    SnakeAdd();
                    land[xSnake - 1, ySnake] = 2;
                }
            }
            else if (Down)
            {
                if(land[xSnake + 1, ySnake] > 0) iLive = false;               
                else
                {
                    if(MaxValue() > counterApples)
                    {
                        MaxValueZero();
                    }
                    SnakeAdd();
                    land[xSnake + 1, ySnake] = 2;
                }
            }
            else if (Rigth)
            {
                if(land[xSnake, ySnake + 1] > 0) iLive = false;               
                else
                {
                    if (MaxValue() > counterApples)
                    {
                        MaxValueZero();
                    }
                    SnakeAdd();
                    land[xSnake, ySnake + 1] = 2;
                }             
            }
            else if (Left)
            {
            
                if (land[xSnake, ySnake - 1] > 0) iLive = false;
                else
                {
                    if (MaxValue() > counterApples)
                    {
                        MaxValueZero();
                    }
                    SnakeAdd();
                    land[xSnake, ySnake - 1] = 2;
                }          
            }


         

        }
        static void TheEnd()
        {
            Console.SetWindowSize(61, 21);
            Console.SetBufferSize(61, 21);
            string theEnd = @" $$$$$$\                                          
$$  __$$\                                         
$$ /  \__| $$$$$$\  $$$$$$\$$$$\   $$$$$$\        
$$ |$$$$\  \____$$\ $$  _$$  _$$\ $$  __$$\       
$$ |\_$$ | $$$$$$$ |$$ / $$ / $$ |$$$$$$$$ |      
$$ |  $$ |$$  __$$ |$$ | $$ | $$ |$$   ____|      
\$$$$$$  |\$$$$$$$ |$$ | $$ | $$ |\$$$$$$$\       
 \______/  \_______|\__| \__| \__| \_______|      
                                                  
                                                  
                                                  
 $$$$$$\                                          
$$  __$$\                                         
$$ /  $$ |$$\    $$\  $$$$$$\   $$$$$$\           
$$ |  $$ |\$$\  $$  |$$  __$$\ $$  __$$\          
$$ |  $$ | \$$\$$  / $$$$$$$$ |$$ |  \__|         
$$ |  $$ |  \$$$  /  $$   ____|$$ |               
 $$$$$$  |   \$  /   \$$$$$$$\ $$ |               
 \______/     \_/     \_______|\__|               
                                        ";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(theEnd);
            Console.ReadKey();



        }


        static void SnakeSpeed()
        {
            if (counterApples <= 5)
            {
                Thread.Sleep(50);
            }
            else if (counterApples > 5 && counterApples <= 10)
            {
                Thread.Sleep(70);
            }
            else if (counterApples > 10 && counterApples <= 15)
            {
                Thread.Sleep(100);
            }
            else if (counterApples > 15 && counterApples <= 20)
            {
                Thread.Sleep(130);
            }
            else if (counterApples > 20 && counterApples <= 25)
            {
                Thread.Sleep(150);
            }
            else if (counterApples > 25 && counterApples <= 30)
            {
                Thread.Sleep(170);
            }
            else if (counterApples > 30 && counterApples <= 40)
            {
                Thread.Sleep(190);
            }
            else if (counterApples > 40)
            {
                Thread.Sleep(200);
            }
            else
            {
                Thread.Sleep(250);
            }
         



        }
        static void Main(string[] args)
        {
            Console.SetWindowSize(43, 22);
            Console.SetBufferSize(43, 22);
            Console.CursorVisible = false;

            Thread keyDown = new Thread(Potok);
            keyDown.Start();

            while (iLive)
            {
                SnakeSpeed();
                SnakeGo();
                AppleSpayn();
                PrintLand();



            }

            TheEnd();
        }


        static void KeyGo()
        {
            ConsoleKey keyRead = Console.ReadKey().Key;
            switch (keyRead)
            {
                case ConsoleKey.UpArrow:
                    if (Down == false)
                    {
                        Up = true;
                        Rigth = false;
                        Left = false;

                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (Left == false)
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
                    if (Up == false)
                    {
                        Down = true;
                        Left = false;
                        Rigth = false;
                    }
                    break;


            }
        }


        static void Potok()
        {
            while(true)
            {
                
                KeyGo();
                Thread.Sleep(70);
            }
        }
    }
}
