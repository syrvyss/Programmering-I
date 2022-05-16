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

        if (LigeTal(???))       //ToDo: her mangler argumentet. Hvis der returneres true, er tallet lige
            Console.WriteLine(tal + " er et lige tal");
        else
            Console.WriteLine(tal + " er et ulige tal");
    }

    static ??? LigeTal(???)     //ToDo: her mangler en parameter til tage imod tallet og en returparameter
    {
        if (tal % 2 == 0)
            return true;
        else
            return false;
    }
}
