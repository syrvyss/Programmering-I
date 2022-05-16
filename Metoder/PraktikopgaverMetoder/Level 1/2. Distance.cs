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

        double distancen = Distance(???, ???);          //ToDo: her mangler argumenter
        Console.WriteLine(???);                         //ToDo: her udskrives tid, hastighed og distance
    }

    static ??? Distance(???, ????)                      //ToDo: her mangler argumenter
    {           
        return ???;                                     //ToDo: beregning af distance. Omregn hastighed til km/min og gang det med tiden.
    }                                                   //ToDo: fortsat: husk at typecaste til returtypen
}
