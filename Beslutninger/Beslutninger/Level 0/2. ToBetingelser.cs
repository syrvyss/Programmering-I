// ToBetingelser.cs
// Lav et program, som tester om en int-variabel kaldet hour er større end eller lig med 0 
// og mindre end 24. Hvis det ikke er tilfældet, skal hour resettes til 0. Udskriv passende tekster

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast værdien for timer");
        int hour = Convert.ToInt32(Console.ReadLine());
        if (hour >= 0 && hour < 24)
            Console.WriteLine("Timer er gyldige");
        else
        {
            hour = 0;
            Console.WriteLine("Timer er nulstillet");
        }
    }
}
