// KarakterTekst.cs
// Lav et program, der beder brugeren indtaste en karakter. Man skal kunne indtast f.eks. 00.
// Programmet skal omregne karakteren til en beskrivende tekst efter følgende nøgle:

//•	12 gives for den fremragende præstation
//•	10 gives for den fortrinlige præstation
//•	7 gives for den gode præstation
//•	4 gives for den jævne præstation
//•	02 gives for den tilstrækkelige præstation
//•	00 gives for den utilstrækkelige præstation
//•	-3 gives for den ringe præstation

// Karakter-teksten udskrives på skærmen

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast karakter");
        string kar = Console.ReadLine();
        switch (kar)
        {
            case "12": Console.WriteLine("12 gives for den fremragende præstation");
                break;
            case "10": Console.WriteLine("10 gives for den fortrinlige præstation");
                break;
            case "7": Console.WriteLine("7 gives for den gode præstation");
                break;
            case "4": Console.WriteLine("4 gives for den jævne præstation");
                break;
            case "02": Console.WriteLine("02 gives for den tilstrækkelige præstation");
                break;
            case "00": Console.WriteLine("00 gives for den utilstrækkelige præstation");
                break;
            case "-3": Console.WriteLine("-3 gives for den ringe præstation");
                break;
            default: Console.WriteLine("Forkert karakter");
                break;
        }
    }
}
