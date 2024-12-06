using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Road();
        }

        static void Road()
        {
            int height = 50;
            int width = 30;
            bool keepPlaying = true;
            char[,] hurdle = new char[height, width];

            while (keepPlaying)
            {
                const int roadWidth = 10;
                int leftEdge = (width - roadWidth) / 2;
                int rightEdge = leftEdge + roadWidth + 1;
                hurdle = new char[height, width];

                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < width; j++)
                    {
                        if (j < leftEdge || j > rightEdge)
                        {
                            hurdle[i, j] = '■';
                            Console.Write(hurdle[i,j]);
                        }
                        else
                        {
                            hurdle[i, j] = ' ';
                            Console.Write(hurdle[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
        void HandleInput()
        {
            bool running;
            bool playing;
            int carMove;

            while (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(true);
                switch (key.Key) 
                {                   
                    case ConsoleKey.A: case ConsoleKey.LeftArrow:
                        carMove = -1;
                        break;
                    case ConsoleKey.D: case ConsoleKey.RightArrow:
                        carMove = +1;
                        break;
                    case ConsoleKey.W: case ConsoleKey.UpArrow: case ConsoleKey.S: case ConsoleKey.DownArrow:
                        carMove = 0;
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        playing = false;
                        break;
                    case ConsoleKey.Enter:
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
