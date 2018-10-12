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
            int hauteur, caraTotal, caraLigne, ligneActuelle = 1;

            Console.WriteLine("Hauteur?");
            hauteur = Convert.ToInt32(Console.ReadLine());
            caraLigne = hauteur + hauteur - 1;
            caraTotal = caraLigne * hauteur;

            Console.WriteLine("\n");

            for (int i = 1; i <= caraTotal; i++)
            {
                
            }
        }
    }
}
