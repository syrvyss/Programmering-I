// trycatch.cs
// a) Programmet kan ikke compilere, men giver fejlen: The name 'værdi' does not exist in the current context
// b) Når denne fejl er rettet, afprøves med en måleværdi på f.eks. 3000000000. Virker Exception Handling korrekt?
// c) Når brugeren ved en fejl indtaster f.eks. et bogstav, går programmet ned - selv om der er Exception Handling!
//    Ret programmet til så også denne type fejl kan fanges. Og nu vi er igang: Lav også en "Catch All" handler.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        int værdi = 0;
        Console.WriteLine("Indtast venligst en måleværdi");
        try
        {
            værdi = Convert.ToInt32(Console.ReadLine());
        }
        catch (OverflowException e)
        {
            Console.WriteLine("Tallet var større end 2 000 000 000");
            Console.WriteLine(e.Message);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Indtast kun tal");
            Console.WriteLine(e.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine("Der er opstået en fejl");
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("Måleværdien er: {0}", værdi);
    }
}
