// InstanceBil.cs
// a) Opret en klasse Bil, som faktisk er en kopi af forrige opgave.
// b) Klassen skal have en enkelt INSTANCE metode, der hedder Distance. Den tager imod en integer kaldet hastighed og 
//    en integer kaldet timer. Metoden returnerer en integer med antal kørt km.
// c) I Main oprettes et objekt af Bil, som kaldes minBil. Metoden Distance kaldes og returparameteren udskrives.
// Reflektion: Tænk over forskellen på denne og forrige opgave.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Bil minBil = new Bil();
        Console.WriteLine("Distance: {0} km", minBil.Distance(80, 2));
    }
}

class Bil
{            
    public int Distance(int hastighed, int timer)     
    {
        return hastighed * timer;
    }
}

