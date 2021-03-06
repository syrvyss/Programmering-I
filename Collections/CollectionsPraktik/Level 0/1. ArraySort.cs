// ArraySort.cs
// a) Lav et Array kaldet mitHold, som du lægger 3 af dine
//    hold-kammeraterns navne ind i.
// b) Lav statisk udskrift-metode, der kan udskrive listen.
// c) Udvid programmet med en sortering af arrayet og kald udskriftmetoden igen.
// d) Afprøv nogle af Array-klassens andre metoder.

using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;   // Husk!

class Program
{
    static void Main(string[] args)
    {
        string[] mitHold = new string[] {"Christina", "Anders", "Carsten"};

        UdskrivListe(mitHold);

        Array.Sort(mitHold);
        Console.WriteLine("--- Sorteret ---");
        UdskrivListe(mitHold);
    }

    static void UdskrivListe(string[] liste)
    {
        foreach (string person in liste)
            Console.WriteLine(person);
    }
}
