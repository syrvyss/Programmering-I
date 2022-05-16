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
        decimal[] mitArray = new decimal[] { 7.0M, 9.0M, 13.0M };
        Console.WriteLine("Element 2 = " + mitArray[2]);

        mitArray[1] = 3.14M;
        Console.WriteLine("Element 1 = " + mitArray[1]);
    }
}


