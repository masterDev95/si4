using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Programme d'introduction
            //DECLARATION DE VARIABLE
            string chaineSaisie = "";

            //INTERACTION
            Console.WriteLine("Bonjour quel est votre nom ?");
            chaineSaisie = Console.ReadLine();
            Console.WriteLine("Enchanté {0}",chaineSaisie);
            */

            //===================================================================================================

            /*
            //Exercice 1
            //DECLARATION DE VARIABLE
            decimal val1, val2, val3, resultat = 0;

            //INTERACTION
            Console.WriteLine("Bonjour, ce programme consiste à calculer la moyenne de 3 nombres saisis");

            //Valeur 1
            Console.WriteLine("\nVeuillez saisir le premier nombre :");
            val1 = Convert.ToDecimal(Console.ReadLine());

            //Valeur 2
            Console.WriteLine("\nVeuillez saisir le deuxième nombre :");
            val2 = Convert.ToDecimal(Console.ReadLine());

            //Valeur 3
            Console.WriteLine("\nVeuillez saisir le troisième nombre :");
            val3 = Convert.ToDecimal(Console.ReadLine());

            //Calcul final
            resultat = (val1 + val2 + val3) / 3;
            Console.WriteLine("\nVoici la moyenne des trois valeurs : {0}", resultat);
            */

            //===================================================================================================

            /*
            //Exercice 2
            //DECLARATION DE VARIABLE
            decimal prixUnitaire, quantite, taux, resultat = 0;

            //INTERACTION
            Console.WriteLine("Bonjour, ce programme consiste à calculer le prix total d'un article TTC");

            //Prix unitaire
            Console.WriteLine("\nVeuillez saisir le prix à l'unité de l'article :");
            prixUnitaire = Convert.ToDecimal(Console.ReadLine());

            //Quantité
            Console.WriteLine("\nVeuillez saisir la quantité :");
            quantite = Convert.ToDecimal(Console.ReadLine());

            //Taux
            Console.WriteLine("\nVeuillez saisir le pourcentage du taux :");
            taux = Convert.ToDecimal(Console.ReadLine())/100;

            //Montant TTC
            resultat = (prixUnitaire * quantite);
            resultat = (resultat * taux) + resultat;
            Console.WriteLine("\nVoici le montant TTC à payer : {0}", resultat);
            */

            //===================================================================================================

            //Exercice 3
            //DECLARATION DE VARIABLE
            decimal prixUnitaire, quantite, prixTotal, prixRemise, prixFDP, resultat = 0;
            decimal remise = 0.05;
            decimal fdp = 0.02;

            //INTERACTION
            Console.WriteLine("Bonjour, ce programme consiste à calculer le prix total pour une société");

            //Prix unitaire
            Console.WriteLine("\nVeuillez saisir le prix à l'unité de l'article :");
            prixUnitaire = Convert.ToDecimal(Console.ReadLine());

            //Quantité
            Console.WriteLine("\nVeuillez saisir la quantité :");
            quantite = Convert.ToDecimal(Console.ReadLine());

            //Affichage montant sans frais
            prixTotal = prixUnitaire * quantite;
            Console.WriteLine("\nPrix total HT: {0} euros", prixTotal);

            //Affichage montant remise
            prixRemise = (prixTotal / remise);
            Console.WriteLine("Remise: {0}", prixRemise);

            //Affichage montant frais de port
            prixFDP = (prixTotal * fdp);

            


            //Montant final
            resultat = (prixUnitaire * quantite);
            resultat = (resultat * taux) + resultat;
            Console.WriteLine("\nVoici le montant TTC à payer : {0}", resultat);

            //===================================================================================================

            Console.WriteLine("\nAppuyez sur Entrée pour fermer le programme...");
            Console.ReadLine();
        }
    }
}
