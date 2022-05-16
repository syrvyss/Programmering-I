// Fødselsdag.cs
// Lav et program, der kan indlæse datoen for din næste fødselsdag. 
// Programmet skal kunne beregne hvor mange dage der er til og udskrive det til skærmen.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast datoen for din næste fødselsdag <dd.mm.yyyy>");
        DateTime fødselsdag = DateTime.Parse(Console.ReadLine());

        Console.WriteLine("Du har fødselsdag om " + fødselsdag.Subtract(DateTime.Now).Days + " dage");
    }
}
