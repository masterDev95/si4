using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DST2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tab = new int[4];
            string[] tabString = { "a", "b", "produit", "somme" };

            Console.Write("Sasir a: ");
            tab[0] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saisir b: ");
            tab[1] = Convert.ToInt32(Console.ReadLine());

            tab[2] = tab[0] * tab[1];
            tab[3] = tab[0] + tab[1];

            for (int i = 0; i < tab.Length; i++)
            {
                for (int j = 0; j < tab.Length - 1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        int temp = tab[j];

                        tab[j] = tab[j + 1];
                        tab[j + 1] = temp;

                        string tempString = tabString[j];

                        tabString[j] = tabString[j + 1];
                        tabString[j + 1] = tempString;
                    }
                }
            }

            for (int i = 0; i < tabString.Length; i++)
            {
                Console.Write(tabString[i]);

                if (i < tabString.Length - 1)
                {
                    Console.Write(" < ");
                }
            }

            Console.WriteLine();

            for (int i = 0; i < tab.Length; i++)
            {
                Console.Write(tab[i]);

                if (i < tab.Length - 1)
                {
                    Console.Write(" < ");
                }
            }

            Console.WriteLine();
        }
    }
}
