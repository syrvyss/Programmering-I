// FejlUdskrift.cs
// Lav metoden UdskrivFejl, der kan modtage en fejlkode (heltal) og returnere en fejlmeddelelse, som udskrives 
// af Main-metoden. Main-metoden skal blive ved med at spørge brugeren, indtil fejlkoden bliver 0.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        int fejlnr = 0;
        do
        {
            Console.WriteLine("Indtast fejlkode");
            fejlnr = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(UdskrivFejl(fejlnr));
        }
        while(fejlnr != 0);
    }

    static string UdskrivFejl(int fejlkode)
    {
        string str;
        switch (fejlkode)
        {
            case 0:
                str = "Alt er OK og vi slutter";
                break;
            case 1:
                str = "Der er problemer i område A";
                break;
            case 2:
                str = "Ild i hovedcomputeren";
                break;
            case 40:
                str = "Det er en fejl 40, fister";
                break;
            default:
                str = "Fejl er ukendt";
                break;
        }
        return str;
    }
}
