using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApiOuistreham;

namespace tpOuistreham
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuer = true;
            bool trouve;

            string noCIN, nomNavire, libelleFret;
            int quantiteFret;

            int numZoneStockage, capaciteStockageMaximale, capaciteStockageDisponible;

            Navire unNavire;
            ZoneDeStockage uneZoneDeStockage;

            List<Navire> collectionNavire = Persistance.ChargeNavire();
            List<ZoneDeStockage> collectionZoneDeStockage = Persistance.ChargeZoneDeStockage();

            if (collectionNavire == null)
            {
                collectionNavire = new List<Navire>();
            }

            if (collectionZoneDeStockage == null)
            {
                collectionZoneDeStockage = new List<ZoneDeStockage>();
            }

            do
            {
                Console.WriteLine("\t0. Sauvegarder et fermer l'application");
                Console.WriteLine();
                Console.WriteLine("\t1. Ajouter un navire");
                Console.WriteLine("\t2. Supprimer un navire");
                Console.WriteLine();
                Console.WriteLine("\t3. Ajouter une zone de fret");
                Console.WriteLine("\t4. Supprimer une zone de fret");
                Console.WriteLine();
                Console.WriteLine("\t5. Afficher les informations des navires");
                Console.WriteLine("\t6. Afficher les informations des zones de stockages");

                string choixUtilisateur = Console.ReadLine();

                Console.Clear();

                switch (choixUtilisateur)
                {
                    case "0":
                        Persistance.Sauvegarde(collectionNavire);
                        Persistance.Sauvegarde(collectionZoneDeStockage);

                        continuer = false;

                        break;

                    case "1":
                        Console.WriteLine("Quel est son numéro:");
                        noCIN = Console.ReadLine();

                        Console.WriteLine("\nQuel est son nom:");
                        nomNavire = Console.ReadLine();

                        Console.WriteLine("\nQuel est le nom de la marchandise:");
                        libelleFret = Console.ReadLine();

                        Console.WriteLine("\nQuel est la quantité de marchandise:");
                        quantiteFret = Convert.ToInt32(Console.ReadLine());

                        unNavire = new Navire(noCIN, nomNavire);
                        unNavire.LibelleFret = libelleFret;
                        unNavire.QuantiteFret = quantiteFret;

                        collectionNavire.Add(unNavire);

                        break;

                    case "2":
                        Console.WriteLine("Quel est le nom du navire à supprimer:");
                        nomNavire = Console.ReadLine();

                        Console.WriteLine();

                        trouve = false;

                        foreach (Navire navire in collectionNavire)
                        {
                            if (navire.NomNavire == nomNavire)
                            {
                                collectionNavire.Remove(navire);

                                Console.WriteLine($"Le navire \"{nomNavire}\" à bien été supprimé !");

                                trouve = true;

                                break;
                            }
                        }

                        if (!trouve)
                        {
                            Console.WriteLine("Le navire spécifié n'a pas été trouvé");
                        }

                        Console.ReadKey();

                        break;

                    case "3":
                        Console.WriteLine("Quel est son numéro de zone de stockage:");
                        numZoneStockage = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nQuel est sa capacité de stockage max:");
                        capaciteStockageMaximale = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nQuel est sa capacité de stockage disponible:");
                        capaciteStockageDisponible = Convert.ToInt32(Console.ReadLine());

                        uneZoneDeStockage = new ZoneDeStockage(numZoneStockage, capaciteStockageMaximale);
                        uneZoneDeStockage.CapaciteStockageDisponible = capaciteStockageDisponible;

                        collectionZoneDeStockage.Add(uneZoneDeStockage);

                        break;

                    case "4":
                        Console.WriteLine("Quel est le numéro de la zone de stockage à supprimer:");
                        numZoneStockage = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine();

                        trouve = false;

                        foreach (ZoneDeStockage zoneDeStockage in collectionZoneDeStockage)
                        {
                            if (zoneDeStockage.NumZoneStockage == numZoneStockage)
                            {
                                collectionZoneDeStockage.Remove(zoneDeStockage);

                                Console.WriteLine($"La zone de stockage \"{numZoneStockage}\" à bien été supprimé !");

                                trouve = true;

                                break;
                            }
                        }

                        if (!trouve)
                        {
                            Console.WriteLine("La zone de stockage spécifié n'a pas été trouvé");
                        }

                        Console.ReadKey();

                        break;

                    case "5":
                        foreach (Navire navire in collectionNavire)
                        {
                            Console.WriteLine($"\tNo {navire.NoCIN}\tNom: {navire.NomNavire}\tMarchandise: {navire.LibelleFret}\tQte March.: {navire.QuantiteFret}");
                        }

                        Console.ReadKey();

                        break;

                    case "6":
                        foreach (ZoneDeStockage zoneDeStockage in collectionZoneDeStockage)
                        {
                            Console.WriteLine($"\tNo {zoneDeStockage.NumZoneStockage}\tCapacité max: {zoneDeStockage.CapaciteStockageMaximale}\tCapacité dispo: {zoneDeStockage.CapaciteStockageDisponible}");
                        }

                        Console.ReadKey();

                        break;
                }

                Console.Clear();

            } while (continuer);
        }
    }
}
