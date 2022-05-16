// Distance.cs
// Lav metoden Distance, der kan modtage parametrene hastighed (heltal km/t) og tid (heltal minutter) og 
// returnerer antal km (kommatal), der er kørt.
// Main-metoden prompter brugeren for hastighed og tid, kalder metoden og udskriver resultatet.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast en hastighed i km/t");
        int hastighed = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Indtast antal minutter");
        int tid = Convert.ToInt32(Console.ReadLine());

        double distancen = Distance(hastighed, tid);
        Console.WriteLine("På {0} min. med hastigheden {1} km/t har du kørt {2:N2} km", tid, hastighed, distancen);
    }

    static double Distance(int hastighed, int tid)
    {
        return (double)hastighed / 60 * tid;
    }
}
