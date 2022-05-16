// Årsløn.cs
// Lav et program, der indlæser din årsløn, trækker 33 % fra i skat og udlæser din resterende løn. 
// Resultatet skal formateres så det passer til operativsystemets måde at angive valuta på.
// Eksperimentér med forskellige måder at konvertere datatyper på.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        Console.Write("Write your montly wage: ");
        double monthWage = double.Parse(Console.ReadLine());

        double result = ((monthWage * 12) * 0.67);
        Console.WriteLine("{0:C2}", result);
    }
}