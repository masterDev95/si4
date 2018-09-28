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
