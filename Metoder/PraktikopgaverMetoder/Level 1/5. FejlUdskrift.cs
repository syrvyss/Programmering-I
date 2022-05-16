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
            Console.WriteLine(UdskrivFejl(???));            //ToDo: mangler argument
        }
        while(fejlnr != 0);
    }

    static ??? UdskrivFejl(???)                             //ToDo: mangler parametre
    {
        string str;
        switch (fejlkode)
        {
            case 0:
                str = "Alt er OK og vi slutter";
                break;
         // Lav selv flere cases
        }
        return str;
    }
}
