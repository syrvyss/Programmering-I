// Advarselslamper.cs
// Lav et program, der kan styre en advarselseslampe i en bil. 
// •	Hvis ude-temperaturen er 0 eller derunder, skal den lyse rødt.
// •	Hvis ude-teperaturen er 3 eller derunder, skal den lyse gult.
// •	Hvis ude-temperaturen er over 3 skal den lyse grønt.

// Vigtigt: Lav en tegning (du ved: blyant og papir) af et termometer og tegn intervallerne ind!

// Inputtet består i at brugeren indtaster en temperatur. Udskriften skal bestå i at temperaturen udskrives med den rigtige farve..
// Du skifter farve således: Console.ForegroundColor = ConsoleColor.Red;

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast  temperatur i hele grader");
        int temp = Convert.ToInt32(Console.ReadLine());
        if (temp <= 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Temperaturen er: {0} grader", temp);
        }
        else
        {
            if (temp <= 3)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Temperaturen er: {0} grader", temp);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Temperaturen er: {0} grader", temp);
            }
        }
    }
}
