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
        res = 3 + var1;                     //ToDo: forhøj var1 med prefix
        Console.WriteLine(res);
        res = 3 + var2;                     //ToDo: forhøj var2 med suffix
        Console.WriteLine(res); 
    }
}
