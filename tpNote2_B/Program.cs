using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpNote2_B
{
    class Program
    {
        static void Main(string[] args)
        {
            int nbAccident, anciennete, distParcourue;
            decimal primeAnnuelle, primeDist, primeAnciennete = 0;

            Console.WriteLine("Combien d'accident ?");
            nbAccident = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNombre d'année d'ancienneté ?");
            anciennete = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDistance parcourue dans l'année (km)");
            distParcourue = Convert.ToInt32(Console.ReadLine());

            primeDist = 0.01m * distParcourue;
            primeDist = Math.Min(primeDist, 400);

            if (anciennete > 3)
            {
                primeAnciennete = 200 + ((anciennete - 4) * 20);
            }

            primeAnnuelle = primeAnciennete + primeDist;

            switch (nbAccident)
            {
                case 1:
                    primeAnnuelle /= 2;
                    break;
                case 2:
                    primeAnnuelle /= 3;
                    break;
                case 3:
                    primeAnnuelle /= 4;
                    break;
            }

            if (nbAccident > 3)
            {
                primeAnnuelle = 0;
            }

            Console.WriteLine("\n\nVotre prime s'élève à {0} euros", primeAnnuelle);
        }
    }
}
