using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Polybe
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] alphabet = {
                "a","b","c","d","e",
                "f","g","h","ij","k",
                "l","m","n","o","p",
                "q","r","s","t","u",
                "v","w","x","y","z"
            };
            string total_word = "hello world", word, translate = "";
            string[] split = total_word.Split();

            for (int i = 0; i < split.Length; i++)
            {
                word = split[i];

                for (int j = 0; j < word.Length; j++)
                {
                    for (int k = 0; k < alphabet.Length; k++)
                    {
                        if (alphabet[k].Contains(word[j]))
                        {
                            translate += Convert.ToString(k % 5 + 1);
                            translate += Convert.ToString(k / 5 + 1);
                            translate += " ";
                        }
                    }
                }

                translate += "\n";
            }

            Console.WriteLine(translate);
        }
    }
}
