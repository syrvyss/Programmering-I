// Constructor.cs
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav en constructor i Bil-klassen, som kan tage imod alle tre parametre, nemlig farve, kmStand og hk. 
//    Sørg for at constructoren initialiserer de rigtige felter.
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes et bil-objekt, som får sine data sendt ind i klassen via constructoren.
//    Prøv at oprette et par biler med forskellige data og udlæs dem.
// e) Prøv at oprette et objekt uden argumenter. Kan det lade sig gøre? Kan du få det til at virke?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil bilObj = new Bil("Sort", 120000, 130);
        Console.WriteLine(bilObj.HentData());
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
