// Validering.cs
// Opgaven bygger videre på den foregående.
// Nu skal der indbygges en validering i constructorerne, der forhindre ulovlige værdier:
//   - kmStand kan ikke være negativ og må ikke overstige 1 000 000 km. Udskriv fejlmeddelelse
//     hvis værdien falder udenfor.
//   - Programmet sørger selv for at runde kmStand værdien ned til nærmeste værdi delelig med 1000.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil bilObj1 = new Bil("Sort", 120999, 130);
        Console.WriteLine(bilObj1.HentData());

        Bil bilObj2 = new Bil("Sort", 121001);
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
        if (k > 0 && k < 1000000)
        {
            farve = f;
            kmStand = k / 1000 * 1000;
        }
        else
        {
            Console.WriteLine("Antal km skal være positiv og under 1 000 000");
        }
    }

    public Bil(string f, int k, int h)
    {
        if (k > 0 && k < 1000000)
        {
            farve = f;
            kmStand = k / 1000 * 1000;
            hk = h;
        }
        else
        {
            Console.WriteLine("Antal km skal være positiv og under 1 000 000");
        }
    }

    public string HentData()
    {
        return String.Format("Farve: {0} km stand: {1} HK: {2}", farve, kmStand, hk);
    }
}
