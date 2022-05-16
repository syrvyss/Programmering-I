// StringArray.cs
// a) Opret et array, der kan indeholde 3 strenge. Initialiser arrayet samtidigt med at det oprettes med 3 navne fra holdet.
// b) Udskriv det midterste navn.
// c) Læg nu et nyt navn ind i det sidste element (i næste linje) og udskriv navnet.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Program
{
    static void Main()
    {
        string[] names = { "Nikolaj", "Thomas", "Adrian" };
        names[2] = "Johnny";
        Console.WriteLine("Second element: {0}", names[1]);
        Console.Write("Last element: {0}", names.Last());
    }
}
