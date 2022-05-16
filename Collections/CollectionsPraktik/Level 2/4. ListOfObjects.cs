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
