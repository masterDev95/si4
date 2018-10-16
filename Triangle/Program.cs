using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int hauteur;

            Console.WriteLine("Hauteur?");
            hauteur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n");

            for (int i = 1; i <= hauteur; i++)
            {
                for (int j = 0; j < hauteur - i; j++)
                {
                    Console.Write("-");
                }

                for (int k = 0; k < i * 2 - 1; k++)
                {
                    Console.Write("*");
                }

                for (int l = 0; l < hauteur - i; l++)
                {
                    Console.Write("-");
                }

                Console.WriteLine("\n");
            }

            Console.WriteLine("\n");
        }
    }
}
