using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Déclaration d'une collection de string
            List<string> listeCapitale;
            //Initialisation de la collection
            listeCapitale = new List<string>();

            //Ajout d'un élément à la collection
            string uneChaine = "Paris";
            listeCapitale.Add(uneChaine);
            listeCapitale.Add("Madrid");
            listeCapitale.Add("Stockholm");
            listeCapitale.Add("Londres");
            listeCapitale.Add("Anvers");

            bool suppression = listeCapitale.Remove("Madrid");

            foreach (string capitaleCourante in listeCapitale)
            {
                Console.WriteLine(capitaleCourante);
            }

            Console.WriteLine("Saisir une capitale européene");
            string capitaleSaisie = Console.ReadLine();

            foreach (string capitaleCourant in listeCapitale)
            {
                //Traitement(s)...
                break;
            }

            Console.WriteLine("Saisir une capitale européene");
            capitaleSaisie = Console.ReadLine();

            if (listeCapitale.Contains(capitaleSaisie))
            {
                int index = listeCapitale.IndexOf(capitaleSaisie);
                string capitalRecherche = listeCapitale[index];
            }

            bool trouve = listeCapitale.Contains("Rome");

        }
    }
}
