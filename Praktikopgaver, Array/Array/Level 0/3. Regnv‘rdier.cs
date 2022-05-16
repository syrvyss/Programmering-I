// Regnværdier.cs
// Lav et array, der kan indeholde nedbøren i mm for 7 dage i 4 uger.
// Dagene skal vises som kolonner.
// Initialiser arrayet således at i den 
// første uge regner det 12.5 mm om mandagen
// anden uge regner det 2.3 mm om tirsdagen
// tredje uge regner det 4.7 mm om onsdagen
// fjerde uge regner det 17.3 mm om torsdagen
// Alle andre dage regner det 0.0 mm.
// Søndag er den første dag i ugen.
// Vigtigt: Lav en tegning af arrayet med værdier inden du koder det!

// Efter at arrayet er initialiseret, skal der endvidere skrives
// følgende værdier ind i arrayet:
// første uge regner det 22.5 mm om søndagen
// anden uge regner det 1.3 mm om tirsdagen og 3.2 om fredagen
// tredje uge regner det 5.7 mm om lørdagen
// fjerde uge regner det 7.3 mm om onsdagen
// Vigtigt: tegn videre på tegningen inden du koder!

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Regnværdier
{
    static void Main(string[] args)
    {
        double[,] regnArr = new double[4, 7] { { 0, 12.5, 0, 0, 0, 0, 0 }, { 0, 0, 2.3, 0, 0, 0, 0 }, { 0, 0, 0, 4.7, 0, 0, 0 }, { 0, 0, 0, 0, 17.3, 0, 0 } };
        regnArr[0,0] = 22.5;
        regnArr[1,2] = 1.3;
        regnArr[1,5] = 3.2;
        regnArr[2,6] = 5.7;
        regnArr[3,3] = 7.3;
    }
}

