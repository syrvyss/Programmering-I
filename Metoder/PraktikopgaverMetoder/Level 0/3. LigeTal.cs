// LigeTal.cs
// Lav metoden LigeTal, der kan modtage et tal og returnerer true hvis det er lige og false hvis det er ulige.
// Main-metoden udskriver resultatet.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast et tal");
        int tal = Convert.ToInt32(Console.ReadLine());

        if (LigeTal(tal))
            Console.WriteLine(tal + " er et lige tal");
        else
            Console.WriteLine(tal + " er et ulige tal");
    }

    static bool LigeTal(int tal)
    {
        if (tal % 2 == 0)
            return true;
        else
            return false;
    }
}
