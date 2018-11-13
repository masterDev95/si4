using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            string snake = "*";
            ConsoleKeyInfo toucheAppuye;
            int x = Console.WindowWidth / 2, y = Console.WindowHeight / 2;
            int dir = 0, timer = 1, alarm = timer; // direction: 0 gauche, 1 droite, 2 haut, 3 bas
            int time1 = DateTime.Now.Millisecond, time2;

            Console.CursorVisible = false;
            Console.SetCursorPosition(x, y);
            Console.Write(snake);

            do
            {
                if (Console.KeyAvailable)
                {
                    toucheAppuye = Console.ReadKey();
                    switch (toucheAppuye.Key)
                    {
                        case ConsoleKey.Escape:
                            Environment.Exit(0x1F4);
                            break;
                        case ConsoleKey.LeftArrow:
                            dir = 0;
                            break;
                        case ConsoleKey.RightArrow:
                            dir = 1;
                            break;
                        case ConsoleKey.UpArrow:
                            dir = 2;
                            break;
                        case ConsoleKey.DownArrow:
                            dir = 3;
                            break;
                    }
                }

                time2 = DateTime.Now.Millisecond;
                //Console.WriteLine(DateTime.Now.Second);

                if (time2 == (time1 + 250) % 1000)
                {
                    alarm--;
                    time1 = DateTime.Now.Millisecond;
                }

                bool eval = x > 0 && y > 0;

                if (alarm <= 0 && eval)
                {
                    switch (dir)
                    {
                        case 0:
                            x--;
                            break;
                        case 1:
                            x++;
                            break;
                        case 2:
                            y--;
                            break;
                        case 3:
                            y++;
                            break;
                    }

                    Console.Clear();
                    Console.SetCursorPosition(x, y);
                    Console.Write(snake);

                    alarm = timer;
                }
            } while (true);
        }
    }
}
