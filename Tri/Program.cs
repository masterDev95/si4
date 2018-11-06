using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableau = new int[] { 50, 49, 48, 47, 46 };

            for (int i = 0; i < tableau.Length - 1; i++)
            {
                for (int j = 0; j < tableau.Length - 1; j++)
                {
                    if (tableau[j] > tableau[j + 1])
                    {
                        int a = tableau[j], b = tableau[j + 1];

                        tableau[j] = b;
                        tableau[j + 1] = a;
                    }
                }
            }
            
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);
            }
        }
    }
}
