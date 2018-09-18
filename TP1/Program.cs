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
            int choix;

            Console.WriteLine("\t-Calcul de moyenne(1)");
            Console.WriteLine("\t-Calcul de prix TTC(2)");
            Console.WriteLine("\t-Gestion de commande pour société(3)");
            Console.WriteLine("\t-Transformation du temps en secondes(4)");

            Console.WriteLine("Veuillez choisir la fonction que vous voulez (1-4)");
            choix = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            switch (choix)
            {
                case 1:
                    moyenne();
                    break;
                case 2:
                    calculPrixTTC();
                    break;
                case 3:
                    gestionCommande();
                    break;
                case 4:
                    tempsEnSecondes();
                    break;
                default:
                    Console.WriteLine("Désolé, je n'ai pas compris votre requête..");
                    break;
            }
        }

        private static void tempsEnSecondes()
        {
            //DECLARATION DE VARAIABLE
            int heures, minutes, secondes, secondesTotal;

            //INTERACTION
            Console.WriteLine("Saisir le nombre d'heure: ");
            heures = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSaisir le nombre de minutes: ");
            minutes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nSaisir le nombre de secondes: ");
            secondes = Convert.ToInt32(Console.ReadLine());

            //Affiche ce que l'utilisateur à saisie
            Console.WriteLine("\n\nVous avez saisie {0} heures, {1} minutes et {2} secondes.", heures, minutes, secondes);

            //AFFICHAGE FINAL
            secondesTotal = (heures * 60 * 60) + (minutes * 60) + secondes;
            Console.WriteLine("Ce qui correspond à {0} secondes.\n\n\n", secondesTotal);
        }

        private static void gestionCommande()
        {
            //DECLARATION DE VARIABLE
            decimal prixUnitaire, quantite, prixTotal, montantRemise, montantFDP, montantFinal;
            const decimal remise = 5, fdp = 2;

            //INTERACTION
            Console.WriteLine("Quel est le prix de votre article à l'unité ?");
            prixUnitaire = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPour quelle quantité ?");
            quantite = Convert.ToDecimal(Console.ReadLine());

            //AFFICHAGE FINAL
            //Affichage montant total sans remise et frais de port
            prixTotal = prixUnitaire * quantite;
            Console.WriteLine("\n\n\t- Prix sans frais: {0} euros", prixTotal);

            //Affichage remise
            montantRemise = (remise / 100) * prixTotal;
            Console.WriteLine("\t- Remise: {0} euros", montantRemise);

            //Affichage frais de port
            montantFDP = (fdp / 100) * prixTotal;
            Console.WriteLine("\t- Frais de port: {0} euros", montantFDP);

            //Affichage montant final
            montantFinal = prixTotal - montantRemise + montantFDP;
            Console.WriteLine("\t- Montant final: {0} euros\n\n\n", montantFinal);
        }

        private static void calculPrixTTC()
        {
            //DECLARATION DE VARIABLE
            decimal prixUnitaire, quantite, taux, prixTTC;

            //INTERACTION
            Console.WriteLine("Quel est le prix de votre article à l'unité ?");
            prixUnitaire = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nPour quelle quantité ?");
            quantite = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\nQuel est le taux de la valeur ajouté (pourcentage) ?");
            taux = Convert.ToDecimal(Console.ReadLine());

            //Calcul prix total TTC et affichage
            prixTTC = prixUnitaire * quantite;
            prixTTC = (taux / 100 * prixTTC) + prixTTC;
            Console.WriteLine("\nLe montant total TTC est de {0} euros\n\n\n", prixTTC);
        }

        static void moyenne() //Calcule la moyenne de 3 nombres saisis
        {
            //DECLARATION DE VARIABLE
            decimal val1, val2, val3, moyenne;

            //INTERACTION
            //PREMIER NOMBRE
            Console.WriteLine("Veuillez saisir un nombre:");
            val1 = Convert.ToDecimal(Console.ReadLine());

            //DEUXIEME NOMBRE
            Console.WriteLine("\nVeuillez saisir un deuxième nombre:");
            val2 = Convert.ToDecimal(Console.ReadLine());

            //TROISIEME NOMBRE
            Console.WriteLine("\nVeuille saisir un troisième nombre:");
            val3 = Convert.ToDecimal(Console.ReadLine());

            //CALCUL DE LA MOYENNE ET AFFICHAGE DU RESULTAT
            moyenne = (val1 + val2 + val3) / 3;
            Console.WriteLine("\nLa moyenne de ces trois nombre est {0}\n\n\n", moyenne);
        }
    }
}
