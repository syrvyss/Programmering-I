// ReelleTal.cs
// Gem tallet 3.14159265358979323846264338327950 i variabler af typerne float, double og decimal og udskriv dem enkeltvist. 
// Sammenlign nøjagtigheden og optæl antal cifre.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        float floatTal = 3.14159265358979323846264338327950F;
        double doubleTal = 3.14159265358979323846264338327950;
        decimal decimalTal = 3.14159265358979323846264338327950M;

        Console.WriteLine(floatTal);    // kun nøjagtig på 7 cifre
        Console.WriteLine(doubleTal);   // nøjagtig på 15 cifre
        Console.WriteLine(decimalTal);  // nøjagtig på 28 cifre
    }
}
