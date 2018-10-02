using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpNote1
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            Console.WriteLine("\t-Exercice 2 (exercice sur les micro-processeurs)(1)");
            Console.WriteLine("\t-Exercice 3 (exercice sur l'assurance automobile)(2)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-2)");
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choix)
            {
                case 1:
                    Exercice2();
                    break;
                case 2:
                    Exercice3();
                    break;
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }

            Console.ReadLine();
        }

        private static void Exercice3()
        {
            string sexe;
            int age, anneePermis;
            bool doitPayer = false;

            Console.WriteLine("Civilité (H/F):");
            sexe = Console.ReadLine();

            Console.WriteLine("\nAge:");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNombre d'année de permis:");
            anneePermis = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            //CONDITION SUR LE SEXE ET L'AGE
            if (sexe == "H" && age > 22)
            {
                doitPayer = true;
            }
            else if (sexe == "F" && (age >= 20 && age <= 30))
            {
                doitPayer = true;
            }

            //CONDITION SUR LE NB D'ANNEE DE PERMIS
            if (anneePermis > 5)
            {
                doitPayer = false;
            }

            //CONDITION FINAL QUI DETERMINE
            //SI L'UTILISATEUR DOIT PAYER LA SURTAXE OU NON
            if (doitPayer)
            {
                Console.WriteLine("Vous devez payer la surprime.");
            }
            else
            {
                Console.WriteLine("Vous ne devez pas payer la surprime");
            }
        }

        private static void Exercice2()
        {
            string nom;
            decimal qteComposant, reduction;

            Console.WriteLine("Bonjour, comment vous vous appelez ?");
            nom = Console.ReadLine();

            Console.WriteLine("\nCombien de micro-processeur avez-vous commandé ?");
            qteComposant = Convert.ToDecimal(Console.ReadLine());

            //CONDITION QUANTITE COMPOSANTS
            if (qteComposant > 40000)
            {
                reduction = 20;
            }
            else if (qteComposant <= 40000 && qteComposant > 20000)
            {
                reduction = 15;
            }
            else if (qteComposant <= 20000 && qteComposant >= 10000)
            {
                reduction = 10;
            }
            else
            {
                reduction = 0;
            }

            //CONDITION NOM
            if (nom == "COMMAQ")
            {
                reduction -= 2;
            }
            else if (nom == "BEL")
            {
                reduction += 1;
            }

            Console.WriteLine("\n\nLe taux de votre réduction est de: {0}%", reduction);
        }
    }
}
