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
            decimal coutTrajet, coutHebergement,coutNourriture = 3.5m;
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
