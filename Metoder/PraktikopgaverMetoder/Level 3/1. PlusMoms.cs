// PlusMoms.cs
// Lav et program, der modtager 3 priser, anbringer dem i et array og kalder en metode
// som lægger 25 % moms oveni priserne. Når arrayet med de forhøjede priser er returneret
// tilbage til hovedprogrammet, skal priserne både uden og med moms udskrives.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Write three prices (space seperated): ");

        int[] prices = Console.ReadLine()
            .Split(" ")
            .Select(x => int.Parse(x))
            .ToArray();

        Console.Write("Prices without moms: {0}\n", String.Join(" ", prices));
        Console.Write("Prices with moms: {0}", String.Join(" ", Moms(prices)));
    }

    static double[] Moms(int[] prices) => prices.Select(x => x * 1.25).ToArray();
}
