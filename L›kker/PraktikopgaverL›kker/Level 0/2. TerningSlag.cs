// TerningSlag.cs
// Lav et program, der slår 5 terningeslag efter hinanden og udlæser øjnene. 
// Lidt hjælp: Random randomObj = new Random() og randomObj.Next(1,7)

using System;
using System.Collections.Generic;
using System.Text;

namespace Loekker
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomObj = new Random();

            for(int i = 1; i <= 5; i++)
            Console.WriteLine("Terning nr. {0} = {1}", i, randomObj.Next(1,7));
        }
    }
}
