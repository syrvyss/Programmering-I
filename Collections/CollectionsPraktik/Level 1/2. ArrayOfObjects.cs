// ArrayOfObjects.cs
// a) Lav et array kaldet bilArray, som du lægger nogle bil-objekter ind i.
// b) Lav en static udskrift-metode, der kan tage imod listen og udskrive den.

using System;
using System.Collections.Generic;
using System.Text;

using System.Collections;   // Husk!

class Program
{
    static void Main()
    {
        Bil[] bilArray = new Bil[] { new Bil("Rød", 10000, 115), new Bil("Grå", 22000, 95), new Bil("Blå", 35000, 120) };
        // Alternativ kan man lave et tomt array først og så tilføje bilobjekter bil for bil: bilArray[0] = new Bil("Rød", 10000, 115)
        Udskriv(bilArray);
    }

    static void Udskriv(???)
    {
        foreach (???)
        {
            Console.WriteLine(???);
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
