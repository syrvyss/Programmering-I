// Tabel.cs
// 5.	Skriv et program der indlæser et tal mellem 1 og 10 og udskriver den tilhørende tabel pænt 
// formateret på skærmen (her vist for 10-tabellen):
// Indtast tal: 10
// 10	20	30	40	50	60	70	80	90	100

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast et tal");
        int tal = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
            Console.Write("{0}\t", tal * i);
        Console.WriteLine();
    }
}
