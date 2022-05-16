// SimpelNedarv.cs
// a)Opret en klasse, der hedder BaseClass, som indeholder metoden void Date() og
//   som udskriver dagsdato som en ShortDateString.
// b)Opret ligeledes en klasse, der hedder DerivedClass, som indeholder metoden void Time() og
//   som udskriver aktuel tid som en ShortTimeString.
// c)I Main oprettes et objekt af BaseClass og Date()-metoden kaldes.
//   Opret et objekt af DerivedClass ogkald Time(). Kan du også få fat i Date()?
// d)Lad nu DerivedClass nedarve fra BaseClass.
//   Giver det en ny mulighed? Hvilken? Afprøv den!

using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        // ToDo: Opret et BaseClass-objekt, som hedder baseObjekt
        // ToDo: Vha. baseObject kaldes metoden Date();

        // ToDo: opret et DerivedClass-objekt, som hedder derivedObject
        // ToDo: Vha. derivedObject kaldes metoden Time()
        // ToDo: Vha. derivedObject kaldes metoden Date(). Virker kun hvis der nedarves fra BaseClass!
    }
}

class BaseClass
{
    public void Date()
    {
        // ToDo: Udskriv aktuel dato vha. DateTime.Now.ToShortDateString());
    }
}

class DerivedClass : BaseClass
{
    public void Time()
    {
        // Udskriv aktuel tid vha. DateTime.Now.ToShortTimeString());
    }
}

