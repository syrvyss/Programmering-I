// MetodeOverload.cs
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav en metode i Bil-klassen, som hedder IndlægData. Den skal findes i tre udgaver (overloadet). Første udgave 
//    kan tage imod alle tre parametre, nemlig farve, kmStand og hk. Den næste udgave kan kun tage imod farve og kmStand.
//    Den sidste udgave tager kun imod farve. Sørg for at alle tre metoder initialiserer de rigtige felter.
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes et bil-objekt og metoder (og varianterne) skal afprøves. Virker det som forventet?
// Reflektion: Hvad er den store fordel ved at benytte metode overload?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil bilObj = new Bil();
        bilObj.IndlægData("Sort", 120000, 130);
        Console.WriteLine(bilObj.HentData());
    }
}

class Bil
{
    string farve;
    int kmStand;
    int hk;

    public void IndlægData(string f)
    {
        farve = f;
    }

    public void IndlægData(string f, int k)
    {
        farve = f;
        kmStand = k;
    }

    public void IndlægData(string f, int k, int h)
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