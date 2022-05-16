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
        // ToDo: Lav et objekt af SportsVogn-klassen med farve, årgang og om der er hækspoiler (true/false)
        // ToDo: Kør metoden Udskriv vha. objektet
    }
}

class Bil
{
    protected string farve;     // protected er nødvendig for at en Derived-class kan få adgang til felter
    protected int årgang;       // nedarvet fra en Base-class
}

class SportsVogn : Bil
{
    bool hækspoiler;

    // ToDo: Lav en constructor, der initialiserer felterne farve, årgang og hækspoiler

    // ToDo: Lav metoden Udskriv(), der kan udskrive felterne farve, årgang og hækspoiler
}
