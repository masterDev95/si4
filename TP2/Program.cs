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

            Console.WriteLine("\t-Exercice 1(1)");
            Console.WriteLine("\t-Exercice 2(2)");
            Console.WriteLine("\t-Exercice 3(3)");
            Console.WriteLine("\t-Exercice 4(4)");
            Console.WriteLine("\t-Exercice 5(5)");
            Console.WriteLine("\t-Exercice 6(6)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-6)");
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choix)
            {
                case 1:
                    Exercice1();
                    break;
                case 2:
                    Exercice2();
                    break;
                case 3:
                    Exercice3();
                    break;
                case 4:
                    Exercice4();
                    break;
                case 5:
                    Exercice5();
                    break;
                case 6:
                    Exercice6();
                    break;
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }
        }

        private static void Exercice6()
        {
            const decimal livre1 = 3, livre2 = 5, livre3 = 6.5m;
            const decimal reduction = 10, fdp = 2;
            int nbex, nbetoile;
            decimal montant = 0, montantReduction, montantFDP, montantTotal;
            string type_vente;

            Console.WriteLine("Quel est le nombre d'exemplaire ?");
            nbex = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nQuel est le nombre d'etoile ?");
            nbetoile = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nLa vente est-elle par magasin ou par correspondance? (M/C)");
            type_vente = Console.ReadLine();
            if (type_vente != "M" && type_vente != "C")
            {
                Console.WriteLine("Désolé je n'ai pas compris...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            switch (nbetoile)
            {
                case 1:
                    montant = livre1 * nbex;
                    break;
                case 2:
                    montant = livre2 * nbex;
                    break;
                case 3:
                    montant = livre3 * nbex;
                    break;
            }
            Console.WriteLine("\n\n\t-Montant de l'achat: {0}", montant);
            montantTotal = montant;

            if (nbex >= 20)
            {
                montantReduction = (reduction / 100) * montant;
                montantTotal -= montantReduction;
                Console.WriteLine("\t-Montant de la réduction: {0}", montantReduction);
            }

            if (type_vente == "C" && montant < 25)
            {
                montantFDP = (fdp / 100) * montant;
                montantTotal += montantFDP;
                Console.WriteLine("\t-Montant des frais de port: {0}", montantFDP);
            }

            Console.WriteLine("\t-Prix total: {0}", montantTotal);
        }

        private static void Exercice5()
        {
            decimal val1 = 0, val2 = 0, val3 = 0;

            Console.WriteLine("Veuillez saisir un nombre : ");
            val1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un deuxieme nombre : ");
            val2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un troisieme nombre : ");
            val3 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n");

            if (val1 < val2 && val1 < val3)
            {
                Console.WriteLine("La plus petite valeur est {0}", val1);
            }
            else if (val2 < val1 && val2 < val3)
            {
                Console.WriteLine("La plus petite valeur est {0}", val2);
            }
            else
            {
                Console.WriteLine("La plus petite valeur est {0}", val3);
            }
        }

        private static void Exercice4()
        {
            decimal note;
            const decimal noteOral = 8, noteAdmis = 10;

            Console.WriteLine("Quelle est votre note ?");
            note = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            if (note < noteOral)
            {
                Console.WriteLine("Ajourné");
            }
            else if (note < noteAdmis)
            {
                Console.WriteLine("Oral");
            }
            else
            {
                Console.WriteLine("Admis");
            }
        }

        private static void Exercice3()
        {
            decimal quantite = 0, prix = 0;

            Console.WriteLine("Veuillez saisir la quantité d'article: ");
            quantite = Convert.ToInt32(Console.ReadLine());

            if (quantite <= 10)
            {
                prix = quantite * 150;
            }
            else if (quantite < 49)
            {
                prix = quantite * 135;
            }
            else
            {
                prix = quantite * 110;
            }

            //AFFICHAGE PRIX
            Console.WriteLine("\nLe montant total est de {0} euros", prix);
        }

        private static void Exercice2()
        {
            decimal chiffreAffaire = 0, prime = 0.04m;

            Console.WriteLine("Veuillez saisir un chiffre d'affaire : ");
            chiffreAffaire = Convert.ToInt32(Console.ReadLine());

            if (chiffreAffaire < 1000)
            {
                Console.WriteLine("Désolé mais votre chiffre d'affaire est trop faible...");
                Console.ReadLine();
                Environment.Exit(0);
            }

            prime = chiffreAffaire * prime;
            Console.WriteLine("La prime à verser sera de {0} euros", prime);
        }

        private static void Exercice1()
        {
            decimal val1 = 0, val2 = 0;

            Console.WriteLine("Veuillez saisir un nombre : ");
            val1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Veuillez saisir un deuxieme nombre : ");
            val2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nLe plus petit nombre est {0}", Math.Min(val1, val2));
        }
    }
}
