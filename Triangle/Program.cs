using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int hauteur, caraTotal, caraLigne, ligneActuelle = -1;

            Console.WriteLine("Hauteur?");
            hauteur = Convert.ToInt32(Console.ReadLine());
            caraLigne = hauteur + hauteur - 1;
            caraTotal = caraLigne * hauteur;

            Console.WriteLine("\n");

            for (int i = 1; i <= caraTotal; i++)
            {
                if (i % (hauteur * 2) - 1 == 0)
                {
                    Console.WriteLine("");
                    ligneActuelle++;
                }

                bool eval1 = i < hauteur || i > hauteur && i < hauteur * 2;
                bool eval2 = i > hauteur * (ligneActuelle + 1) && i < (hauteur * 2 * (ligneActuelle + 1)) - 1;
                bool eval3 = i > hauteur * 2 * (ligneActuelle + 1) && i < (hauteur * 3 * (ligneActuelle + 1)) - 1;

                if (eval1)
                {
                    Console.Write("-");
                }
                else if (eval2 || eval3)
                {
                    Console.Write("-");
                }
                else
                {
                    Console.Write("*");
                }
            }
        }
    }
}
