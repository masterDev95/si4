using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //--
        }

        private static void petiteValeur()
        {
            decimal val1, val2;

            Console.WriteLine("Veuillez saisir un nombre:");
            val1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Veuillez saisir un deuxième nombre:");
            val2 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("\n\nLe nombre le plus petit est {0}.", Math.Min(val1, val2));
        }
    }
}
