// Delelig.cs
// Lav metoden Delelig, der kan modtage to heltal fra brugeren og returnerer true hvis det ene går op i det andet
// og false hvis det ikke er tilfældet.
// Main-metoden udskriver resultatet.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast det ene tal");
        int tal1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indtast det andet tal");
        int tal2 = Convert.ToInt32(Console.ReadLine());

        if (Delelig(???, ???))      // ToDo: mangler de to argumenter. Hvis metoden returnerer true, går tal op
            Console.WriteLine(tal2 + " går op i " + tal1);
        else
            Console.WriteLine(tal2 + " går ikke op i " + tal1);
    }

    static ??? Delelig(???, ???)    // ToDo: mangler de to parametre samt returparameteren
    {
        if (???)            // ToDo: her laves en Modulus-division og hvis den giver 0, er tallene gået op
            return true;    // Derfor returneres der true
        else
            return false;   // De gik ikke op i hinanden, derfor returneres false
    }
}
