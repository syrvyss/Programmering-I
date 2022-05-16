// ArvEnBil.cs
// a)Opret en klasse, der hedder Bil, som indeholder felterne farve og årgang, typerne
//   er string og int.
// b)Opret desuden en klasse, der hedder SportsVogn, som nedarver fra Bil-klassen. Den skal 
//   desuden indeholde feltet hækspoiler af typen bool.
//   Lav en ny constructor, som kan initialisere alle tre felter.
//   Lav også en metode kaldet Udskriv, der kan udskrive alle tre felter.
// c)I Main oprettes et objekt af SportsVogn-klassen og Udskriv-metoden kaldes.


using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        SportsVogn minSportsVogn = new SportsVogn("Sort", 2001, true);
        minSportsVogn.Udskriv();
    }
}

class Bil
{
    protected string farve;
    protected int årgang;
}

class SportsVogn : Bil
{
    bool hækspoiler;

    public SportsVogn(string farve, int årgang, bool hækspoiler)
    {
        this.farve = farve;
        this.årgang = årgang;
        this.hækspoiler = hækspoiler;
    }

    public void Udskriv()
    {
        Console.WriteLine("Farve: {0} årgang: {1} hækspoiler {2}", farve, årgang, hækspoiler);
    }
}
