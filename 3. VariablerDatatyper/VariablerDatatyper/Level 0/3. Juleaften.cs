// Juleaften.cs
// Opret en variabel, som initialiseres med datoen for næste juleaften. 
// Ogret også en ny variabel, som initialiseres med systemets dato og tid.
// Find ud af hvor mange dage, der er til næste juleaften, ved at trække de
// to variabler fra hinanden (eller brug en Subtract-metode). Inden tallet
// kan udskrives, skal dagene udtrækkes som en int-type ved at benytte .Days

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        DateTime juleaften = DateTime.Parse("24.12.2010");

        DateTime datoNu = DateTime.Now;

        Console.WriteLine("Antal dage til juleaften: {0}", (juleaften - datoNu).Days);

        Console.WriteLine("Antal dage til juleaften: {0}", juleaften.Subtract(datoNu).Days); // alternativ
    }
}
