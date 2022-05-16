// PrefixSuffix.cs
// I programmet herunder skal du forhøje var1 vha. prefix
// og var2 vha. suffix. Studer forskellen.
// Prøv også at udskrive værdien af var2 tilsidst.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int var1 = 10, var2 = 10, res = 0;
        res = 3 + ++var1;
        Console.WriteLine(res);     //Når res udskrives, er den 14
        res = 3 + var2++;
        Console.WriteLine(res);     //Når res udskrives, er den kun 13
        Console.WriteLine(var2);    //selv om var2 er forhøjet, men det skete efter at res blev beregnet!
    }
}
