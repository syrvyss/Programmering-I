// StaticBil.cs
// a) Opret en klasse Bil.
// b) Klassen skal have en enkelt static metode, der hedder Distance. Den tager imod en integer kaldet hastighed og 
//    en integer kaldet timer. Metoden returnerer en integer med antal kørt km.
// c) I Main kaldes metoden Distance og returparameteren udskrives.
// Prøv eventuelt at oprette en metode, som du selv finder på.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Distance: {0} km", Bil.Distance(80, 2));
    }
}

class Bil
{            
    public static int Distance(int hastighed, int timer)     
    {
        return hastighed * timer;
    }
}

