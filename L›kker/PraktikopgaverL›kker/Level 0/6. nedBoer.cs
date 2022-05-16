// Nedboer.cs
// Lav et program, som indlæser 7 nedbørsmænger fra brugeren i et array. Derefter udskrives nedbørsmængde for
// ugens 7 dage samt gennemsnittet.
// Der skal kunne angives decimaltal. Husk at benytte dansk komma ved indtastning i consol-vinduet.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        double[] nedboer = new double[7];

        for (int i = 0; i < nedboer.Length; i++)
        {
            Console.WriteLine("Indtast nedbør for dag " + (i + 1));
            nedboer[i] = Convert.ToDouble(Console.ReadLine());
        }

        double sum = 0;
        for (int i = 0; i < nedboer.Length; i++)
        {
            sum += nedboer[i];
            Console.WriteLine("Dag {0} = {1} mm", i + 1, nedboer[i]);
        }
        Console.WriteLine("Ugens gennemsnitlige nedbør er: {0} mm", sum/nedboer.Length); 
    }
}
