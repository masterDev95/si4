using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpNote1_A
{
    class Program
    {
        static void Main(string[] args)
        {
            int choix;

            Console.WriteLine("\t-Exercice 2 (exercice sur le voyage au Futuroscope)(1)");
            Console.WriteLine("\t-Exercice 3 (exercice sur le voyage scolaire)(2)");

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
            decimal coutTrajet, coutHebergement, coutNourriture = 3.5m;
            decimal coutParEleve, coutTotal;
            int nbEleve, nbJour;

            Console.WriteLine("Combien d'élève vont participer au voyage?");
            nbEleve = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPendant combien de jours?");
            nbJour = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n\n");

            if (nbEleve > 25)
            {
                coutTrajet = 61 * nbEleve;
            }
            else
            {
                coutTrajet = 67.30m * nbEleve;
            }

            if (nbEleve > 35)
            {
                coutHebergement = 3.5m * nbEleve;
            }
            else
            {
                coutHebergement = 4.75m * nbEleve;
            }

            coutNourriture = coutNourriture * nbJour * nbEleve;
            coutHebergement *= nbEleve;
            coutTotal = coutTrajet + coutHebergement + coutNourriture;

            //COUT PAR ELEVE
            coutParEleve = coutTrajet / nbEleve;
            coutParEleve += coutHebergement / nbEleve;
            coutParEleve += coutNourriture / nbEleve;

            Console.WriteLine("\t-Prix de revient par élève: {0} euros", coutParEleve);
            Console.WriteLine("\t-Cout global ({0} élève): {1} euros", nbEleve, coutTotal);
        }

        private static void Exercice2()
        {
            int nbEnfant, reduction;

            Console.WriteLine("Combien d'enfant(s) doit embarquer pour aller au Futuroscope?");
            nbEnfant = Convert.ToInt32(Console.ReadLine());

            //CALCUL REDUCTION
            switch (nbEnfant)
            {
                case 2:
                    reduction = 10;
                    break;
                case 3:
                    reduction = 15;
                    break;
                case 4:
                    reduction = 18;
                    break;
                default:
                    reduction = 0;
                    break;
            }

            if (nbEnfant > 4)
            {
                reduction = 18;
                reduction += nbEnfant - 4;
            }

            Console.WriteLine("Vous avez le droit a une réduction de {0}%", reduction);
        }
    }
}
