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
            Exercice4();
        }

        private static void Exercice4()
        {
            List<int> tableau = new List<int>();
            string saisie;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau.Add(Convert.ToInt32(saisie));
            }

            Console.WriteLine("\nVoici ce que vous avez saisie (que les paires):");

            foreach (int valeur in tableau)
            {
                if (valeur % 2 == 0) Console.WriteLine(valeur);
            }
        }

        private static void Exercice3()
        {
            List<int> tableau = new List<int>();
            string saisie;
            bool affiche = true;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau.Add(Convert.ToInt32(saisie));
            }

            Console.WriteLine("\nVoici ce que vous avez saisie (1 valeur sur 2):");

            foreach (int valeur in tableau)
            {
                if (affiche) Console.WriteLine(valeur);
                affiche = !affiche;
            }
        }

        private static void Exercice2()
        {
            List<int> tableau = new List<int>();
            string saisie;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau.Add(Convert.ToInt32(saisie));
            }

            Console.WriteLine("\nVoici ce que vous avez saisie:");

            foreach (int valeur in tableau)
            {
                Console.WriteLine(valeur);
            }
        }

        private static void Exercice1()
        {
            List<int> tableau = new List<int>();
            string saisie;

            Console.WriteLine("Veuillez saisir dix valeurs numériques :");

            for (int i = 0; i < 10; i++)
            {
                saisie = Console.ReadLine();
                tableau.Add(Convert.ToInt32(saisie));
            }
        }
    }
}
