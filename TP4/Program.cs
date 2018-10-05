using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> tableau = new List<int>();
            List<int> aEnlever = new List<int>();
            string saisie;
            bool affiche = true;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau.Add(Convert.ToInt32(saisie));
            }

            //2
            Console.WriteLine("\nVoici ce que vous avez saisi:");

            foreach (int valeur in tableau)
            {
                Console.WriteLine(valeur);
            }

            //3
            Console.WriteLine("\nVoici ce que vous avez saisi (1 valeur sur 2):");

            foreach (int valeur in tableau)
            {
                if (affiche) Console.WriteLine(valeur);
                affiche = !affiche;
            }

            //4
            Console.WriteLine("\nVoici les paires de ce que vous avez saisi:");

            foreach (int valeur in tableau)
            {
                if (valeur % 2 == 0) Console.WriteLine(valeur);
            }

            //5
            Console.WriteLine("\nVoici la valeur maximale de ce que vous avez saisi:");
            Console.WriteLine(tableau.Max());

            //6
            Console.WriteLine("\nVoici la valeur minimale de ce que vous avez saisi:");
            Console.WriteLine(tableau.Min());

            //7
            Console.WriteLine("\nVoici la somme des valeurs que vous avez saisi:");
            Console.WriteLine(tableau.Sum());

            //8
            Console.WriteLine("\nVoici la moyenne des valeurs que vous avez saisi:");
            Console.WriteLine(tableau.Average());

            //9
            Console.WriteLine("\nVoici les nombres premiers que vous avez saisi:");

            //SUPPRESSION VALEURES NON PREMIERES
            foreach (int valeur in tableau)
            {
                if (valeur % 2 == 0 && valeur != 2)
                {
                    aEnlever.Add(valeur);
                }
                else if (valeur % 3 == 0 && valeur != 3)
                {
                    aEnlever.Add(valeur);
                }
                else if (valeur % 5 == 0 && valeur != 5)
                {
                    aEnlever.Add(valeur);
                }
                else if (valeur % 7 == 0 && valeur != 7)
                {
                    aEnlever.Add(valeur);
                }
            }

            foreach (int valeur in aEnlever)
            {
                tableau.Remove(valeur);
            }

            //AFFICHAGE
            foreach (int valeur in tableau)
            {
                Console.WriteLine(valeur);
            }

            Console.ReadLine();
        }
    }
}
