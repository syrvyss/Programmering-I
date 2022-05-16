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
        DateTime dateOnly = new DateTime(DateTime.Now.Year, 2, 1);
        DateTime currentDate = DateTime.Now;

        int result = (currentDate - dateOnly).Days;
        Console.WriteLine("{0} days until birthday!", result);
    }
}
