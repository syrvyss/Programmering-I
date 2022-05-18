// ArrayParameter.cs
// Lav et Array kaldet rainWeek i hovedprogrammet og initialiser
// det med 7 værdier af typen double.
// Lav en metode, der kaldes Average, og som kan modtage det 
// førnævnte array, beregne gennemsnittet og returnere resultatet
// til hovedprogrammet, som så udskriver gennemsnittet.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        double[] rainWeek = { 10.5, 10.3, 16.7, 0.5, 5.9, 1.5, 7.8 };
        Console.WriteLine(Average(rainWeek));
    }

    static double Average(double[] a) => a.Average();
}
