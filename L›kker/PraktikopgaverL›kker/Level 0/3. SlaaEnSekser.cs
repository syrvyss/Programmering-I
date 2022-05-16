// SlaaEnSekser.cs
// Lav et program, der bliver ved med at slå en terning, indtil en sekser slås.
// De enkelte slag skal udlæses undervejs.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        Random randomObj = new Random();
        int øjne;

        do
        {
            øjne = randomObj.Next(1, 7);
            Console.WriteLine("Terning viste: " + øjne);
        }
        while (øjne < 6);
    }
}
