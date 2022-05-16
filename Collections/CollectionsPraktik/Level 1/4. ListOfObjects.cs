// ListOfObjects.cs
// a) Lav List<> kaldet bilList, som du lægger nogle bil-objekter ind i.
// b) Lav en static udskrift-metode, der kan tage imod listen og udskrive den.
// c) Fjern et af bil-objekterne fra listen vha. bilListe.RemoveAt(). Virker det?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        // Opret billiste med typen <Bil>
        // Benyt bilListens Add-metode til at tilføje et nyt 

        Udskriv(bilListe);
        Console.WriteLine("--- Efter at have fjernet bil ---");
        bilListe.RemoveAt(1);
        Udskriv(bilListe);
    }

    static void Udskriv(List<Bil> minBilListe)
    {
        foreach (Bil enBil in minBilListe)
        {
            Console.WriteLine(enBil.HentData());
        }
    }
}

class Bil
{
    string farve;
    int kmStand;
    int hk;

    public Bil(string f, int k, int h)
    {
        farve = f;
        kmStand = k;
        hk = h;
    }

    public string HentData()
    {
        return String.Format("Farve: {0} km stand: {1} HK: {2}", farve, kmStand, hk);
    }
}
