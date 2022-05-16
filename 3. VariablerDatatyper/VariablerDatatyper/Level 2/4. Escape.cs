// Escape.cs
// Opret en streng-variabel og initialiser den med ”C:\ndisk\ati.ini”. 
// Udskriv strengen lydløst, så den står på én linie. Hvad er problemet?

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string path = "C:\ndisk\ati.ini";
        Console.WriteLine(path); // \n and \a are both (almost)universally built-in string functions
    }
}
