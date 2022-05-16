// GyldigeTimer.cs
// Lav et program, som bliver ved at læse et heltal fra keyboardet 
// indtil der tastes et tal mellem 1 og 23 (begge inklusive).

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int hour;
        do
        {
            hour = Convert.ToInt32(Console.ReadLine());
        }
        while (hour < 1 || hour > 23);          // Gentag sålænge man er udenfor det gyldige område
        Console.WriteLine("Så lykkedes det");
    }
}
