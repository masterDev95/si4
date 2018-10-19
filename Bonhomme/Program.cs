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
                " ", " ", "*", " ", " ",
                " ", "*", " ", "*", " ",
                " ", "*", " ", "*", " ",
                " ", " ", "*", " ", " ",
                " ", " ", "*", " ", " ",
                "*", "*", "*", "*", "*",
                " ", " ", "*", " ", " ",
                " ", " ", "*", " ", " ",
                " ", " ", "*", " ", " ",
                " ", "*", " ", "*", " ",
                "*", " ", " ", " ", "*",
            };
            const int bonhomme_largeur = 5, bonhomme_longueur = 11;
            int x = Console.WindowWidth / 2 - bonhomme_largeur / 2;
            int y = (Console.WindowHeight / 2 - bonhomme_longueur / 2) - 1;

            Console.SetCursorPosition(x, y);

            for (int i = 0; i < bonhomme.Length; i++)
            {
                if (i % bonhomme_largeur == 0)
                {
                    Console.WriteLine("");
                }

                Console.Write(bonhomme[i]);
            }

            Console.ReadLine();
        }
    }
}