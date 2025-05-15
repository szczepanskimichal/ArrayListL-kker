using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace ArrayListLøkker
{
    public class Krokodillespillet
    {
        public static void Play()
        {
            var random = new Random();
            int score = 0;

            while (true)
            {
                int tall1 = random.Next(1, 12);
                int tall2 = random.Next(1, 12);

                Console.WriteLine($"{tall1} _ {tall2}");
                Console.WriteLine("Skriv inn <, > eller =");
                string? svar = Console.ReadLine();

                if (svar != "<" && svar != ">" && svar != "=")
                {
                    Console.WriteLine("Feil input. Avslutter spillet.");
                    break;
                }

                if ((svar == "<" && tall1 < tall2) || (svar == ">" && tall1 > tall2) || (svar == "=" && tall1 == tall2))
                {
                    score++;
                    Console.WriteLine("Riktig! Poeng: " + score);
                }
                else
                {
                    score--;
                    Console.WriteLine("Feil! Poeng: " + score);
                }
            }
        }
    }
}
