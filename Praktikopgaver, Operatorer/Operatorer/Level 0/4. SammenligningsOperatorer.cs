// SammenligningsOperatorer.cs
// Afprøv følgende statements og sammenlign med dit eget svar:

using System;
using System.Collections.Generic;
using System.Text;

namespace Operatorer
{
    class Program
    {
        static void Main(string[] args)
        {
            bool svar = (21 > 24) & (4 < 11);   // false
            svar = (21 > 24) && (4 < 12);       // false
            svar = !(20 > 25) && (3 < 12);	    // true
        }
    }
}
