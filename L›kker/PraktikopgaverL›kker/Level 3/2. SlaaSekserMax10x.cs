// SlaaSekserMax10x.cs
// Lav et program, der giver 10 forsøg til at slå en sekser. Når en sekser slås, skal programmet standse.
// De enkelte slag skal udlæses undervejs.

using System;
using System.Collections.Generic;
using System.Text;

namespace Loekker
{
    class Program
    {
        static void Main() {
            Console.WriteLine("Get a 6 to win, newline to try your luck");

            Console.ReadLine();
            for (int i = 0; i < 10; i++) {
                int result = rollDice();
                if (result == 6) {
                    Console.WriteLine("Congratulations!");
                    break;
                }
                Console.WriteLine("Sorry, you got a {0}. You are on try {1}", result, i+1);
                Console.ReadLine();
            }
        }

        static int rollDice() {
            Random rand = new Random();
            return rand.Next(1, 7);
        }
    }
}
