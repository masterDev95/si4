using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3
{
    class Program
    {
        static void Main(string[] args)
        {
            int longueur_cote;
            bool eval_cote = false;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            longueur_cote = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < longueur_cote * longueur_cote; i++)
            {
                if (i % longueur_cote == 0 && i != 0) Console.WriteLine("");

                eval_cote = i == longueur_cote
                if (i == )
            }

            Console.WriteLine("\n");
        }

        private static void Exercice4()
        {
            int longueur_cote;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            longueur_cote = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < longueur_cote * longueur_cote; i++)
            {
                if (i % longueur_cote == 0 && i != 0) Console.WriteLine("");
                Console.Write("*");
            }

            Console.WriteLine("\n");
        }

        private static void Exercice3()
        {
            int nb_cara;
            bool affiche_etoile = true;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            nb_cara = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nb_cara; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine("");
                    affiche_etoile = !affiche_etoile;
                }

                if (affiche_etoile)
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write("$");
                }
            }

            Console.WriteLine("\n");
        }

        private static void Exercice2()
        {
            int nb_etoile;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            nb_etoile = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nb_etoile; i++)
            {
                if (i % 5 == 0 && i != 0) Console.WriteLine("");
                Console.Write("*");
            }

            Console.WriteLine("\n");
        }

        private static void Exercice1()
        {
            int nb_etoile;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            nb_etoile = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nb_etoile; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine("\n");
        }
    }
}
