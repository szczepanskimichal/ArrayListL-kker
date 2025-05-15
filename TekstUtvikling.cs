using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLøkker
{
    internal class TekstUtvikling
    {
        public void StartEndringer()
        {
            Console.WriteLine("Velg et alternativ:");
            Console.WriteLine("1. Roter tekst");
            Console.WriteLine("2. Bytt `e´ til `a`");
            string choice = Console.ReadLine();

            Console.WriteLine("Skriv inn et ord");
            string input = Console.ReadLine();

            if (choice == "1")
            {
                string resultat = RoterText(input);
                Console.WriteLine($"Result: {resultat}");
            }
            else if (choice == "2")
            {
            string resultat = ByttEtilA(input);
                Console.WriteLine($"Result: {resultat}");
            }
            else
            {
                Console.WriteLine("Ugyldig valg");
            }
        }

        // Oppgave 1: Lag en metode som roterer teksten i motsatt retning!!!!!!
        private string RoterText(string input)
        {
            string output = "";
            for (int i = input.Length -1; i >= 0; i--)
            {
                output += input[i];
            }
            return output;
        }

        /*private string RoterText(string input)
        {
            char[] bokstaver = input.ToCharArray();
            Array.Reverse(bokstaver);
            return new string(bokstaver);
        }*/

        private string ByttEtilA(string input)
        {
            return input.Replace('e', 'a');
        }
    }
}
