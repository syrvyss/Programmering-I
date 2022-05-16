// Børnepriser.cs
// Lav et program, der på baggrund af af variablen alder kan tilpasse prisen
// for en pizza. Er kunden under 12 år koster den 45 kr. ellers koster den 60 kr.
// Lav den simpleste løsning.

using System;
using System.Collections.Generic;
using System.Text;

class Person
{
    static void Main(string[] args)
    {
        Console.WriteLine("Indtast din alder");
        int alder = Convert.ToInt32(Console.ReadLine());
        int pris = alder < 12 ? 45 : 60;
        Console.WriteLine("Prisen for en pizza er: {0:c}", pris);
    }
}
