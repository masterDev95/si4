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
                Console.WriteLine();
                Console.WriteLine("\t4 - Ajouter un service");
                Console.WriteLine("\t5 - Afficher la liste de service");
                Console.WriteLine();
                Console.WriteLine("\t6 - Supprimer employé");
                Console.WriteLine("\t7 - Affichage employé par service");
                Console.WriteLine("\t8 - Affichage employé par salaire");
                Console.WriteLine();
                Console.WriteLine("\t0 - Fermer le programme");
                string choix = Console.ReadLine();

                Console.Clear();

                #region Traitements associés (relatifs) au menu

                switch (choix)
                {
                    case "1":
                        AjouterEmploye(collectionEmploye, collectionService);
                        break;
                    case "2":
                        AfficherEmploye(collectionEmploye);
                        break;
                    case "3":
                        ModifierEmploye(collectionEmploye, collectionService);
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
                    case "7":
                        AffichageEmployeService(collectionEmploye, collectionService);
                        break;
                    case "8":

                        break;
                    case "0":
                        continuer = false;
                        Persistance.Sauvegarde(collectionEmploye);
                        Persistance.Sauvegarde(collectionService);
                        break;
                    default:
                        break;
                }

                #endregion
            } while (continuer == true);


        }

        //-- AFFICHAGE EMPLOYE PAR SALAIRE
        private static void AffichageEmployeSalaire(List<Employe> collectionEmploye)
        {

        }

        //-- AFFICHAGE EMPLOYE PAR SERVICE
        private static void AffichageEmployeService(List<Employe> collectionEmploye, List<Service> collectionService)
        {
            int i = 0;

            foreach (Service serviceCourant in collectionService)
            {
                Console.WriteLine(serviceCourant.NomService + ":");

                foreach (Employe employeCourant in collectionEmploye)
                {
                    if (serviceCourant.NomService == employeCourant.ServiceEmploye.NomService)
                    {
                        Console.WriteLine("\t - " + employeCourant.NomEmploye + " " + employeCourant.PrenomEmploye);
                    }
                }

                Console.WriteLine();
                i++;
            }
        }

        //-- AFFICHAGE SERVICES
        private static void AfficherService(List<Service> collectionService)
        {
            int i = 1;

            foreach (Service serviceCourant in collectionService)
            {
                Console.WriteLine(i + " - " + serviceCourant.NomService);
                i++;
            }

            Console.WriteLine();
        }

        //-- AJOUT SERVICE
        private static void AjouterService(List<Service> collectionService)
        {
            Service unService = new Service();

            Console.WriteLine("Service:");
            unService.NomService = Console.ReadLine();

            collectionService.Add(unService);
        }

        //-- SUPPRESSION EMPLOYE
        private static void SupprimerEmploye(List<Employe> collectionEmploye)
        {
            AfficherEmploye(collectionEmploye);

            Console.WriteLine("Nom:");
            string nomEmploye = Console.ReadLine();

            Console.WriteLine("\nPrenom");
            string prenomEmploye = Console.ReadLine();

            foreach (Employe employeCourant in collectionEmploye)
            {
                if (employeCourant.NomEmploye == nomEmploye
                    && employeCourant.PrenomEmploye == prenomEmploye)
                {
                    collectionEmploye.Remove(employeCourant);
                    break;
                }
            }
        }

        //-- MODIFICATION EMPLOYE
        private static void ModifierEmploye(List<Employe> collectionEmploye, List<Service> collectionService)
        {
            Console.WriteLine("Nom");
            string nomEmploye = Console.ReadLine();

            Console.WriteLine("\nPrenom");
            string prenomEmploye = Console.ReadLine();

            foreach (Employe employeCourant in collectionEmploye)
            {
                if (employeCourant.NomEmploye == nomEmploye
                    && employeCourant.PrenomEmploye == prenomEmploye)
                {
                    collectionEmploye.Remove(employeCourant);
                    AjouterEmploye(collectionEmploye, collectionService);
                    break;
                }
            }
        }

        //-- AFFICHAGE EMPLOYE
        private static void AfficherEmploye(List<Employe> collectionEmploye)
        {
            foreach (Employe employeCourant in collectionEmploye)
            {
                Console.WriteLine(employeCourant.NumEmploye);
                Console.WriteLine(employeCourant.NomEmploye);
                Console.WriteLine(employeCourant.PrenomEmploye);
                Console.WriteLine(employeCourant.SalaireEmploye);
                Console.WriteLine(employeCourant.ServiceEmploye.NomService);
                Console.WriteLine();
            }
        }

        //--AJOUT EMPLOYE
        private static void AjouterEmploye(List<Employe> collectionEmploye, List<Service> collectionService)
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

            AfficherService(collectionService);

            Console.WriteLine("\nService");
            int selectService = Convert.ToInt32(Console.ReadLine());

            unEmploye.ServiceEmploye = collectionService[selectService-1];
          

            collectionEmploye.Add(unEmploye);
        }
    }
}
