using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp4NoteA
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            Console.WriteLine("\t-Exercice 1 (1)");
            Console.WriteLine("\t-Exercice 2 (2)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-2)");
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
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }
        }

        private static void Exercice2()
        {
            int[] tab1 = { 2, 7, 8, 9, 10 };
            int[] tab2 = { 1, 2, 3, 4, 5 };
            int calcul, somme = 0;

            for (int i = 0; i < tab1.Length; i++)
            {
                int temp = tab2.Length - i - 1;
                calcul = tab1[i] * tab2[temp];
                somme += calcul;
                Console.WriteLine("tab1[{0}] * tab2[{1}] = {2}", i, temp, calcul);
            }

            Console.WriteLine("La somme des produits croisés est égale à {0}", somme);
            Console.ReadLine();
        }

        private static void Exercice1()
        {
            decimal saisieUtilisateur, resultat = 0, multiplication = 0;

            Console.WriteLine("Veuillez saisir un nombre:");
            saisieUtilisateur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");

            for (int i = 0; i < saisieUtilisateur; i++)
            {
                if (i == 0)
                {
                    Console.Write("1 + 1/1 ");
                    resultat += 2;
                }
                else
                {
                    Console.Write("+ 1/(");

                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0)
                        {
                            Console.Write("{0}", j + 1);
                            multiplication = 1;
                        }
                        else
                        {
                            Console.Write("*{0}", j + 1);
                            multiplication *= j + 1;
                        }
                    }

                    Console.Write(") ");

                    resultat += 1 / multiplication;
                }
            }

            Console.WriteLine("\nLe resultat est {0}", resultat);
            Console.ReadLine();
        }
    }
}
