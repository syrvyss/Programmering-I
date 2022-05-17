// Karakter.cs
// Lav et program, der kan beregne den korrekte karakter i forhold til procent
// korrekt besvarelse. Programmet skal spørge brugeren efter et antal procent og udlæse
// tilhørende karakter. Omregningen foregår efter følgende nøgle:

// 92 - 100 %   =   12
// 75 - 91 %    =   10
// 67 - 74 %    =   7
// 58 - 66 %    =   4
// 50 - 57 %    =   02
// 20 - 49 %    =   00
// 0 - 19 %     =   -3


using System;
using System.Collections.Generic;
using System.Text;

namespace Beslutninger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your score?: ");
            int score = int.Parse(Console.ReadLine());

            Console.WriteLine("Your grade is: {0}", Grade(score));
        }

        static string Grade(int score) 
        {
            string result = score switch {
                int n when (n >= 92) => "12",
                int n when (n >= 75) => "10",
                int n when (n >= 67) => "7",
                int n when (n >= 58) => "4",
                int n when (n >= 50) => "02",
                int n when (n >= 20) => "00",
                _ => "-3",
            };

            return result;
        }
    }
}
