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
            List<Service> collectionService = Persistance.ChargeService();

            if (collectionEmploye == null)
            { 
                collectionEmploye = new List<Employe>();
            }

            if (collectionService == null)
            {
                collectionService = new List<Service>();
            }

            bool continuer = true;

            do
            {
                Console.WriteLine("Gestion des employés");
                Console.WriteLine("\t1 - Ajouter employé");
                Console.WriteLine("\t2 - Afficher la liste des employés");
                Console.WriteLine("\t3 - Modifier employé");
                Console.WriteLine("\t4 - Ajouter un service");
                Console.WriteLine("\t5 - Afficher la liste de service");
                Console.WriteLine("\t6 - Supprimer employé");
                Console.WriteLine("\t0 - Fermer le programme");
                string choix = Console.ReadLine();

                Console.Clear();

                #region Traitements associés (relatifs) au menu

                switch (choix)
                {
                    case "1":
                        AjouterEmploye(collectionEmploye);
                        break;
                    case "2":
                        AfficherEmploye(collectionEmploye);
                        break;
                    case "3":
                        ModifierEmploye(collectionEmploye);
                        break;
                    case "4":
                        AjouterService(collectionService);
                        break;
                    case "5":
                        AfficherService(collectionService);
                        break;
                    case "6":
                        SupprimerEmploye(collectionEmploye);
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

        private static void AfficherService(List<Service> collectionService)
        {
            foreach (Service serviceCourant in collectionService)
            {
                Console.WriteLine(serviceCourant.NomService);
                Console.WriteLine();
            }
        }

        private static void AjouterService(List<Service> collectionService)
        {
            Service unService = new Service();

            Console.WriteLine("Service:");
            unService.NomService = Console.ReadLine();

            collectionService.Add(unService);
        }

        private static void SupprimerEmploye(List<Employe> collectionEmploye)
        {
            Employe suprEmploye = new Employe();

            Console.WriteLine("Nom:");
            suprEmploye.NomEmploye = Console.ReadLine();

            Console.WriteLine("\nPrenom");
            suprEmploye.PrenomEmploye = Console.ReadLine();

            foreach (Employe employeCourant in collectionEmploye)
            {
                if (employeCourant.NomEmploye == suprEmploye.NomEmploye
                    && employeCourant.PrenomEmploye == suprEmploye.PrenomEmploye)
                {
                    collectionEmploye.Remove(employeCourant);
                    Console.WriteLine("Supr");
                    break;
                }
            }
        }

        private static void ModifierEmploye(List<Employe> collectionEmploye)
        {
            Employe modEmploye = new Employe();

            Console.WriteLine("Nom");
            modEmploye.NomEmploye = Console.ReadLine();

            Console.WriteLine("\nPrenom");
            modEmploye.PrenomEmploye = Console.ReadLine();

            foreach (Employe employeCourant in collectionEmploye)
            {
                if (employeCourant.NomEmploye == modEmploye.NomEmploye
                    && employeCourant.PrenomEmploye == modEmploye.PrenomEmploye)
                {
                    collectionEmploye.Remove(employeCourant);
                    AjouterEmploye(collectionEmploye);
                    break;
                }
            }
        }

        private static void AfficherEmploye(List<Employe> collectionEmploye)
        {
            foreach (Employe employeCourant in collectionEmploye)
            {
                Console.WriteLine(employeCourant.NumEmploye);
                Console.WriteLine(employeCourant.NomEmploye);
                Console.WriteLine(employeCourant.PrenomEmploye);
                Console.WriteLine(employeCourant.SalaireEmploye);
                Console.WriteLine();
            }
        }

        private static void AjouterEmploye(List<Employe> collectionEmploye)
        {
            Employe unEmploye = new Employe();

            Console.WriteLine("\nNumero:");
            unEmploye.NumEmploye = Convert.ToInt64(Console.ReadLine());

            Console.WriteLine("\nNom");
            unEmploye.NomEmploye = Console.ReadLine();

            Console.WriteLine("\nPrenom");
            unEmploye.PrenomEmploye = Console.ReadLine();

            Console.WriteLine("\nSalaire");
            unEmploye.SalaireEmploye = Convert.ToDecimal(Console.ReadLine());

            collectionEmploye.Add(unEmploye);
        }
    }
}
