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
        List<string> mitHold = new List<string>();
        mitHold.Add("Christina");
        mitHold.Add("Anders");
        mitHold.Add("Carsten");

        UdskrivListe(mitHold);

        mitHold.Sort();
        Console.WriteLine("--- Sorteret ---");
        UdskrivListe(mitHold);
    }

    static void UdskrivListe(List<string> liste)
    {
        foreach (string person in liste)
            Console.WriteLine(person);
    }
}
