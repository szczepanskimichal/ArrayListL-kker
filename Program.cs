using System;

namespace ArrayListLøkker;

class Program
{
    static void Main(string[] args)
    {
        // 1. Lag en for-løkke som printer "Terje er kul" til konsollen 5 ganger
        Console.WriteLine("Dette er oppgave 1!!!");
        for (int i = 0; i < 5; i++) 
        {
            Console.WriteLine("Michal studerer hardt for å oppnå suksess ");
        }
        Console.WriteLine("--------------------------------------------------");

        // 2. Foreach-løkke gjennom en string
        Console.WriteLine("Dette er oppgave 2!!!");
        string text = "Hei, jeg heter Michal";
        foreach (char symbol in text)
        {
            Console.WriteLine(symbol);
        }

        Console.WriteLine("--------------------------------------------------------");

        // 3. Lag en while-løkke som printer ut "Runde nummer:" + et tall som øker med 1 per runde, så lenge rundetelleren er mindre enn 10

        Console.WriteLine("dette er oppgave 3");
        int runde = 0;
        while (runde < 10)
        {
            Console.WriteLine("Runde"+ runde);
            runde++;
        }
        Console.WriteLine("\n Ferdig");
    }
}