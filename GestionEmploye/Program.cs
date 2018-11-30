using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiEntreprise;

namespace GestionEmploye
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employe> collectionEmploye = Persistance.ChargeEmploye();

            if (collectionEmploye == null)
            { 
                collectionEmploye = new List<Employe>();
            }

            bool continuer = true;

            do
            {
                Console.WriteLine("Gestion des employés");
                Console.WriteLine("\t1 - Ajouter employé");
                Console.WriteLine("\t2 - Afficher la liste des employés");
                Console.WriteLine("\t0 - Fermer le programme");
                string choix = Console.ReadLine();

                #region Traitements associés (relatifs) au menu

                switch (choix)
                {
                    case "1":
                        Employe unEmploye = new Employe();

                        Console.WriteLine("Numero");
                        unEmploye.NumEmploye = Convert.ToInt64(Console.ReadLine());

                        Console.WriteLine("Nom");
                        unEmploye.NomEmploye = Console.ReadLine();

                        Console.WriteLine("Prenom");
                        unEmploye.PrenomEmploye = Console.ReadLine();

                        Console.WriteLine("Salaire");
                        unEmploye.SalaireEmploye = Convert.ToDecimal(Console.ReadLine());

                        collectionEmploye.Add(unEmploye);

                        break;
                    case "2":
                        foreach (Employe employeCourant in collectionEmploye)
                        {
                            Console.WriteLine(employeCourant.NumEmploye);
                            Console.WriteLine(employeCourant.NomEmploye);
                            Console.WriteLine(employeCourant.PrenomEmploye);
                            Console.WriteLine(employeCourant.SalaireEmploye);
                            Console.WriteLine();
                        }

                        break;
                    case "0":
                        continuer = false;
                        Persistance.Sauvegarde(collectionEmploye);

                        break;
                    default:
                        break;
                }

                #endregion
            } while (continuer == true);


        }
    }
}
