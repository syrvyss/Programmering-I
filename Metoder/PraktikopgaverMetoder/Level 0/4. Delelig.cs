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

        if (Delelig(tal1, tal2))
            Console.WriteLine(tal2 + " går op i " + tal1);
        else
            Console.WriteLine(tal2 + " går ikke op i " + tal1);
    }

    static bool Delelig(int tal1, int tal2)
    {
        if (tal1 % tal2 == 0)
            return true;
        else
            return false;
    }
}
