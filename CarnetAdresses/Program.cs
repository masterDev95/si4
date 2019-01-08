using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lecteurFichier
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string[]> contacts = new List<string[]>();

            string fichier = "../../carnetAdresses";
            StreamReader lecteurFichier = new StreamReader(fichier);
            string ligne = lecteurFichier.ReadLine();

            while (ligne != null)
            {
                char[] tabCaractere = { ';' };
                string[] unContact = ligne.Split(tabCaractere);
                contacts.Add(unContact);
                ligne = lecteurFichier.ReadLine();
            }

            bool continuer = true;

            do
            {
                lecteurFichier.Close();

                Console.WriteLine("1 - Fermer le programme");
                Console.WriteLine("2 - Afficher les contacts");
                Console.WriteLine("3 - Ajouter un contact");
                Console.WriteLine();

                byte choix = Convert.ToByte(Console.ReadLine());

                Console.Clear();

                switch (choix)
                {
                    case 1:
                        StreamWriter redacteurFichier = new StreamWriter(fichier);

                        foreach (string[] contact in contacts)
                        {
                            redacteurFichier.WriteLine(contact[0] + ";" + contact[1] + ";" + contact[2]);
                        }

                        redacteurFichier.Close();

                        continuer = false;
                        break;
                    case 2:
                        foreach (string[] contact in contacts)
                        {
                            Console.WriteLine("Nom: " + contact[0]);
                            Console.WriteLine("Tel: " + contact[1]);
                            Console.WriteLine("Adresse: " + contact[2]);
                            Console.WriteLine();
                        }

                        break;
                    case 3:
                        string[] unContact = new string[3];

                        Console.WriteLine("Nom:");

                        unContact[0] = Console.ReadLine();

                        Console.WriteLine("Tel:");
                        unContact[1] = Console.ReadLine();

                        Console.WriteLine("Adresse:");
                        unContact[2] = Console.ReadLine();

                        contacts.Add(unContact);

                        break;
                }
            } while (continuer);
        }
    }
}
