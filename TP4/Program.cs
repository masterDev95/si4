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
            //1
            int[] tableau = new int[10];
            int[] aEnlever = new int[10];
            string saisie;
            bool affiche = true;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau[i] = Convert.ToInt32(saisie);
            }

            //2
            Console.WriteLine("\nVoici ce que vous avez saisi:");

            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }

            //3
            Console.WriteLine("\nVoici ce que vous avez saisi (1 valeur sur 2):");

            for (int i = 0; i < tableau.Length; i++)
            {
                if (affiche) Console.WriteLine(tableau[i]);
                affiche = !affiche;
            }

            //4
            Console.WriteLine("\nVoici les paires de ce que vous avez saisi:");

            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] % 2 == 0) Console.WriteLine(tableau[i]);
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
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] == 1)
                {
                    continue;
                }
                else if (tableau[i] % 2 == 0 && tableau[i] != 2)
                {
                    continue;
                }
                else if (tableau[i] % 3 == 0 && tableau[i] != 3)
                {
                    continue;
                }
                else if (tableau[i] % 5 == 0 && tableau[i] != 5)
                {
                    continue;
                }
                else if (tableau[i] % 7 == 0 && tableau[i] != 7)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine(tableau[i]);
                }
            }

            Console.ReadLine();
        }
    }
}
