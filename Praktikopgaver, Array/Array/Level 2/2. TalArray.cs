// TalArray.cs
// a) Opret et array, der kan indeholde 3 decimal-tal. Initialiser arrayet samtidigt med at det oprettes.
// b) Udskriv det sidste element.
// c) Læg værdien 3.14 ind i element nr. 1 (i næste linje) og udskriv værdien.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        double[] numbers = { 9, 5, 10 };
        numbers[0] = 3.14;
        Console.WriteLine("First element: {0}", numbers[0]);
    }
}