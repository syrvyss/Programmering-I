// trycatch.cs
// a) Programmet kan ikke compilere, men giver fejlen: The name 'værdi' does not exist in the current context
// b) Når denne fejl er rettet, afprøves med en måleværdi på f.eks. 3000000000. Virker Exception Handling korrekt?
// c) Når brugeren ved en fejl indtaster f.eks. et bogstav, går programmet ned - selv om der er Exception Handling!
//    Ret programmet til så også denne type fejl kan fanges. Og nu vi er igang: Lav også en "Catch All" handler.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program {
    static void Main() {
        Console.Write("Write a value: ");
        int amount = 0;

        try {
            amount = Convert.ToInt32(Console.ReadLine());
        }
        catch (OverflowException e) {
            Console.WriteLine("The number was bigger than 2 000 000 000");
            Console.WriteLine(e.Message);
        }

        catch (FormatException e) {
            Console.WriteLine("Only for integers!");
            Console.WriteLine(e.Message);
        }

        catch (Exception e) {
            Console.WriteLine("Something went wrong!");
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("The amount is: {0}", amount);
    }
}