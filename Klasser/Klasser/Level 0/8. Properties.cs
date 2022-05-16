// Properties.cs
// Opgaven bygger videre på den foregående.
// a) Du har en Bil-klasse med forskellige constructorer og en metode, der kan udlæse data.
//    Nu skal der laves properties til de tre felter, således at felterne kan læses/ændres fra Program-klassen.
// b) Afprøv de forskellige properties ved at lægge nye data ind i bilerne og ved at læse værdierne 
//    fra Program-klassen.
// c) Indbyg validering i kmStand property efter følgende regler:
//       - kmStand kan ikke være negativ og må ikke overstige 1 000 000 km. Udskriv fejlmeddelelse
//         hvis værdien falder udenfor.
//       - Programmet sørger selv for at runde kmStand værdien ned til nærmeste værdi delelig med 1000.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Bil bilObj1 = new Bil("Sort", 120000, 130);
        Console.WriteLine(bilObj1.HentData());

        bilObj1.Farve = "Grå";
        bilObj1.KmStand = 100200;
        bilObj1.Hk = 150;

        Console.WriteLine("Farve: {0} km stand: {1} HK: {2}", bilObj1.Farve, bilObj1.KmStand, bilObj1.Hk);
    }
}

class Bil
{
    string farve;
    int kmStand;
    int hk;

    public string Farve
    {
        get { return farve; }
        set { farve = value; }
    }

    public int KmStand
    {
        get { return kmStand; }
        set 
        {
            if (value > 0 && value < 1000000)
            {
                kmStand = value / 1000 * 1000;
            }
            else
                Console.WriteLine("Antal km skal være positiv og under 1 000 000"); 
        }
    }
   
     public int Hk
    {
        get { return hk; }
        set { hk = value; }
    }

    public Bil(string f)
    {
        farve = f;
    }

    public Bil(string f, int k)
    {
        farve = f;
        kmStand = k;
    }

    // Validering via constructoren er udeladt i dette eksempel
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
