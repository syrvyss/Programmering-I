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
        BaseClass date = new BaseClass();
        date.Date();

        DerivedClass derivedDate = new DerivedClass();
        derivedDate.Time();
        derivedDate.Date();
    }
}

class BaseClass {
    public void Date() => Console.WriteLine(DateTime.Today.ToShortDateString());
}

class DerivedClass : BaseClass {
    public void Time() => Console.WriteLine(DateTime.Now.ToShortDateString());
}