using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            Console.WriteLine("\t-La plus petite valeur entre deux nombre(1)");
            Console.WriteLine("\t-Calcul de prime sur le chiffre d'affaire(2)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-2)");
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choix)
            {
                case 1:
                    petiteValeur();
                    break;
                case 2:
                    calculPrimeCA();
                    break;
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }
        }

        private static void calculPrimeCA()
        {
            decimal chiffreAffaire, montantPrime;
            const decimal prime = 4, minChiffreAffaire = 1000;

            Console.WriteLine("Quel est votre chiffre d'affaire réalisé ?");
            chiffreAffaire = Convert.ToDecimal(Console.ReadLine());

            if (chiffreAffaire >= minChiffreAffaire)
            {
                montantPrime = (prime / 100) * chiffreAffaire;
                Console.WriteLine("\nLe montant de la prime de votre chiffre d'affaire s'élève à {0} euros", montantPrime);
            }
            else
            {
                Console.WriteLine("\nLe montant de votre chiffre d'affaire n'est pas assez élevé pour obtenir une prime.");
            }
        }

        private static void petiteValeur()
        {
            decimal val1, val2;

            Console.WriteLine("Veuillez saisir un nombre:");
            val1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un deuxième nombre:");
            val2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n\nLe nombre le plus petit est {0}.", Math.Min(val1, val2));
        }
    }
}
