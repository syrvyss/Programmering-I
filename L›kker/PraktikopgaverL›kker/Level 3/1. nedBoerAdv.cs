// NedboerAdv.cs
// Lav et program, som indlæser 7 nedbørsmænger fra brugeren og beregner gennemsnittet til sidst.
// Desuden skal programmet udlæse minimum og maksimum nedbørsværdi.
// Der skal kunne angives decimaltal. Husk at benytte dansk komma ved indtastning i consol-vinduet.


using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Loekker
{
    class Program
    {
        static void Main(string[] args)
        {   
            double[] rainValues = new double[7];
            Console.WriteLine("Enter rain values (7 times) (ml / int): ");
            for (int i = 0; i < 7; i++) {
                rainValues[i] = double.Parse((Console.ReadLine()));
            }

            Console.WriteLine("Max value: {0}, Min value: {1}", rainValues.Max(), rainValues.Min());
        }
    }
}
