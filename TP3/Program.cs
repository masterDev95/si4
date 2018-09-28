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
            int choix;

            Console.WriteLine("\t-Exercice 1 (nb étoile)(1)");
            Console.WriteLine("\t-Exercice 2 (5 étoiles par ligne)(2)");
            Console.WriteLine("\t-Exercice 3 (5 étoiles/5 dollars)(3)");
            Console.WriteLine("\t-Exercice 4 (Carré plein)(4)");
            Console.WriteLine("\t-Exercice 5 (Carré non rempli)(5)");
            Console.WriteLine("\t-Exercice 6 (Calcul factoriel)(6)");
            Console.WriteLine("\t-Exercice 7 (Fibonacci)(7)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-7)");
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
                case 7:
                    Exercice7();
                    break;
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }
        }

        private static void Exercice7()
        {
            int val0 = 0, val1 = 1, n;

            Console.WriteLine("Saisissez un nombre: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int temp = val0;
                val0 = val1;
                val1 = temp + val0;
            }

            Console.WriteLine("\n\nF({0}) = {1}", n, val0);
        }

        private static void Exercice6()
        {
            int facteur, resultat = 0;

            Console.WriteLine("Saisissez un nombre: ");
            facteur = Convert.ToInt32(Console.ReadLine());

            Console.Write("\n\nFact({0}) = ", facteur);

            for (int i = facteur; i > 0; i--)
            {
                if (i == facteur)
                {
                    Console.Write(i);
                    resultat = facteur;
                }
                else
                {
                    Console.Write("*" + i);
                    resultat = resultat * i;
                }
            }

            Console.Write(" = " + resultat + "\n\n");
        }

        private static void Exercice5()
        {
            int longueur_cote;

            Console.WriteLine("Combien d'étoile(s) voulez-vous ?");
            longueur_cote = Convert.ToInt32(Console.ReadLine());

            //BOUCLE X
            for (int y = 0; y < longueur_cote; y++)
            {
                //BOUCLE Y
                for (int x = 0; x < longueur_cote; x++)
                {
                    if (y == 0 || y == longueur_cote - 1)
                    {
                        Console.Write("*");
                    }
                    else if (x == 0 || x == longueur_cote - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                } //FIN BOUCLE Y

                Console.WriteLine("");
            } //FIN BOUCLE X

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
