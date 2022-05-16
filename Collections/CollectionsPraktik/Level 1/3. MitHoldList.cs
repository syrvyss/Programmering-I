// mitHoldArrayList.cs
// a) Lav en List<> kaldet mitHold, som du lægger nogle af dine
//    hold-kammeraterns navne ind i.
// b) Lav udskrift-metode, der kan modtage listen og udskrive den.
// c) Udvid programmet med en sortering og kald udskriftmetoden igen.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<???> mitHold = new List<???>();
        mitHold.Add("?");
        // flere oprettes

        UdskrivListe(???);

        mitHold.Sort();
        Console.WriteLine("--- Sorteret ---");
        UdskrivListe(???);
    }

    static void UdskrivListe(???)
    {
        foreach (???)
            Console.WriteLine(???);
    }
}
