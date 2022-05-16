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
        float num1 = 3.14159265358979323846264338327950F;
        double num2 = 3.14159265358979323846264338327950;
        decimal num3 = 3.14159265358979323846264338327950M;

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(num3);
    }
}
