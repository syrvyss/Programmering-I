// IncrementDecrement.cs
// Lav et program manipulerer med variablen count. Gør følgende på den smarteste måde:
// Læg 5 til count
// Træk 3 fra count
// Gang count med 10
// Læg en til count
// Sæt count lig med resten efter en division med 10
// Træk en fra count
// Udlæs resultatet

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int count = 0;
        count += 5;
        count -= 3;
        count *= 10;
        count++;
        count %= 10;
        count--;
        Console.WriteLine(count);
    }
}
