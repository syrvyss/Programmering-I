// SimpelNedarv.cs
// a) Opret en klasse, der hedder BaseClass, som indeholder metoden void Date() og
//    som udskriver dagsdato som en ShortDateString.
// b) Opret ligeledes en klasse, der hedder DerivedClass, som indeholder metoden void Time() og
//    som udskriver aktuel tid som en ShortTimeString.
// c) I Main oprettes et objekt af BaseClass og Date()-metoden kaldes.
//    Opret et objekt af DerivedClass og kald Time(). Kan du også få fat i Date()?
// d) Lad nu DerivedClass nedarve fra BaseClass.
//    Giver det en ny mulighed? Hvilken? Afprøv den!

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        BaseClass baseObject = new BaseClass();
        baseObject.Date();

        DerivedClass derivedObject = new DerivedClass();
        derivedObject.Date();
        derivedObject.Time();
    }
}

class BaseClass
{
    public void Date()
    {
        Console.WriteLine("Datoen er {0}", DateTime.Now.ToShortDateString());
    }
}

class DerivedClass : BaseClass
{
    public void Time()
    {
        Console.WriteLine("Klokken er {0}", DateTime.Now.ToShortTimeString());
    }
}
