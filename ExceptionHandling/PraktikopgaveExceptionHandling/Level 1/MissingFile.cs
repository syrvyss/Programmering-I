// MissingFile.cs
// a) Afprøv nedenstående program. Studér hvilken exception der kastes.
// b) Indbyg Exception Handling, der både håndterer den situation at filen
//    måske ikke findes samt at hvis (og kun hvis) den findes, så altid lukkes.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

class Program
{
    static void Main()
    {
        TextReader tr = File.OpenText("text.txt"); // anbringes indenfor en try-blok
                                                   // Dog skal TextReader reference-variablen anbringes
                                                   // øverst og udenfor af hensyn til scope
        Console.WriteLine(tr.ReadToEnd());         // anbringes indenfor en try-blok
        // Her laves en Catch-blok, der matcher på FileNotFoundException
        // Her laves en Catch-blok, der matcher på Exception generelt
        tr.Close(); // anbringes i en Finally-blok. Men Close må kun køres, hvis tr-objektet findes.
    }
}


