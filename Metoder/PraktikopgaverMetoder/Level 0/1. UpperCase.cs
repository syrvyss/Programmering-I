// UpperCase.cs
// Lav et program, der beder brugeren om at indtaste en streng. Strengen sendes til en Static metode LavUpper, 
// der returnerer strengen i upper case. 
// Udskriv den omdannede streng.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine("Indtast en streng");
        Console.WriteLine(LavUpper(Console.ReadLine()));
    }

    static string LavUpper(string str)
    {
        return str.ToUpper();
    }
}
