// ObjectParameter.cs
// a) Her er vi tilbage til simpel Bil-klasse.
// b) Tilføj feltet nyVasket og lav en Property til det. Tilføj det også til constructoren og til HentData() metoden.
// c) Opret en klasse, der kaldes AutoVask
// d) AutoVask-klassen indeholder en instance metode, der kaldes VaskBil. Metoden skal tage imod et Bil-objekt. Metoden
//      skriver "Bilen vaskes" ud på skærmen og sætter Bil-objektets nyvasket-felt til true.
// e) I Main skal der nu oprettes et bil-objekt. Kald metoden HentData og udskriv bilens data. Bemærk at bilen ikke er nyvasket.
// f) Opret et objekt af AutoVask og send din bil med som parameter til metoden VaskBil. 
// g) Kald atter bilens HentData()-metode og bemærk om bilen er blevet nyvasket.
// h) Udfordring: Kan VaskBil-metoden gøres static og hvordan skal den i så fald kaldes? Prøv!

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil minBil = new Bil("Sort", 120000, 130, false);
        Console.WriteLine(minBil.HentData());

        /* WITHOUT STATIC
        AutoVask autovask = new AutoVask();
        autovask.VaskBil(minBil);
        */

        AutoVask.VaskBil(minBil);

        Console.WriteLine(minBil.HentData());
    }
}

class AutoVask 
{
    public static void VaskBil(Bil bil)
    { 
        Console.WriteLine("Bilen vaskes...");
        bil.nyVasket = true;
    }
}

class Bil
{
    string farve;
    int kmStand;
    int hk;
    public bool nyVasket { get; set; }

    public Bil(string f, int k, int h, bool i)
    {
        this.farve = f;
        this.kmStand = k;
        this.hk = h;
        this.nyVasket = i;
    }

    public string HentData()
    {
        return String.Format("Farve: {0} km stand: {1} HK: {2} Nyvasket: {3}", farve, kmStand, hk, nyVasket);
    }
}
