using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonhomme
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bonhomme = new string[]
            {
                " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "0", ")", " ", "\\", " ", " ", " ", " ",
                " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "[", "]", "\\", "_", " ", "\\", " ", " ", " ",
                " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "_", "_", "_", "[", "}", "_", "_", "/", "-", " ", " ", " ",
                " ", " ", " ", " ", " ", " ", " ", " ", " ", "/", "-", "-", "-", "-", "\\", "\\", " ", "=", "/", "\\", "_", " ",
                "O", "O", "0", "0", "o", "o", ".", ".", ".", "=", "/", "_", "\\", "_", "#", "|", "[", "_", "]", "/", "\\", "\\",
                " ", " ", " ", " ", " ", " ", " ", " ", " ", " ", "\\", "_", "/", " ", " ", " ", " ", " ", " ", "\\", "_", "/",
            };

            ConsoleKeyInfo toucheAppuye;
            const int bonhomme_largeur = 22, bonhomme_longueur = 7;
            int xx = Console.WindowWidth / 2 - bonhomme_largeur / 2;
            int yy = Console.WindowHeight / 2 - bonhomme_longueur / 2;
            int x = xx, y = yy;

            Console.CursorVisible = false;
            Console.BackgroundColor = ConsoleColor.DarkRed;

            do
            {
                for (int i = 0; i < bonhomme.Length; i++, x++)
                {
                    if (i % bonhomme_largeur == 0)
                    {
                        y++;
                        x = xx;
                    }

                    Console.SetCursorPosition(x, y);
                    Console.Write(bonhomme[i]);
                }

                toucheAppuye = Console.ReadKey();

                switch (toucheAppuye.Key)
                {
                    case ConsoleKey.Escape:
                        Environment.Exit(500);
                        break;
                    case ConsoleKey.LeftArrow:
                        xx--;
                        break;
                    case ConsoleKey.RightArrow:
                        xx++;
                        break;
                    case ConsoleKey.UpArrow:
                        yy--;
                        break;
                    case ConsoleKey.DownArrow:
                        yy++;
                        break;
                }

                //Limiter la position du bonhomme
                if (xx < 0)
                {
                    xx = 0;
                }
                else if (xx > Console.WindowWidth - bonhomme_largeur)
                {
                    xx = Console.WindowWidth - bonhomme_largeur;
                }

                if (yy < -1)
                {
                    yy = -1;
                }
                else if (yy > Console.WindowHeight - bonhomme_longueur)
                {
                    yy = Console.WindowHeight - bonhomme_longueur;
                }

                //Mise à Jour Position
                y = yy;

                //Nettoyer l'écran
                Console.Clear();
            } while (true);
        }
    }
}