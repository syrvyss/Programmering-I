// Kodelaas.cs
// Lav et program, som beder brugeren om at indtaste en 4-cifret kode.
// Men brugeren har kun 3 forsøg. For hvert forsøg skal programmet skrive 
// hvor mange forsøg man har tilbage.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        string kode = "1234";

        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine("Indtast koden. Du har " + i + " forsøg tilbage!");
            string str = Console.ReadLine();
            if (str == kode)
            {
                Console.WriteLine("Du har adgang");
                break;
            }
            else
            {
                if(i == 1)
                Console.WriteLine("Den kendte du nok ikke, fister");
            }
        }
    }
}
