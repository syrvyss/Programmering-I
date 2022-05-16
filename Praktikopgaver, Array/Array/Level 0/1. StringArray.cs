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
        string[] mitArray = new string[] { "Christian", "Beate", "Anna" };
        Console.WriteLine("Element 1 = " + mitArray[1]);

        mitArray[2] = "Kristin";
        Console.WriteLine("Element 2 = " + mitArray[2]);
    }
}

