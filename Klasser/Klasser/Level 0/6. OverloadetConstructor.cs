// OverloadetConstructor.cs
// Opgaven bygger videre på den foregående.
// a) Lav en klasse kaldet Bil med tre felter: farve, kmStand og hk.
// b) Lav passende contructorer i tre udgaver (overloadet). Første udgave kan tage imod alle tre parametre, 
//    nemlig farve, kmStand og hk (som i forrige opgave). 
//    Den næste udgave kan kun tage imod farve og kmStand. Den sidste udgave tager kun imod farve. 
// c) Lav en metode i Bil-klassen, som hedder HentData. Den returnerer en streng med værdierne for alle tre felter.
// d) I Main skal der nu oprettes nogle bil-objekt således at alle måderne afprøves. Virker det som forventet?

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil bilObj1 = new Bil("Sort", 120000, 130);
        Console.WriteLine(bilObj1.HentData());

        Bil bilObj2 = new Bil("Sort", 120000);
        Console.WriteLine(bilObj2.HentData());

        Bil bilObj3 = new Bil("Sort");
        Console.WriteLine(bilObj3.HentData());
    }
}

class Bil
{
    string farve;
    int kmStand;
    int hk;

    public Bil(string f)
    {
        farve = f;
    }

    public Bil(string f, int k)
    {
        farve = f;
        kmStand = k;
    }

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
