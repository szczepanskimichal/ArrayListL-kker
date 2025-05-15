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
        }
    }
}
