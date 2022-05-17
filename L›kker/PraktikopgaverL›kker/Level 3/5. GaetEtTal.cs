// GaetEtTal.cs
// a) Lav et ”gæt et tal” program, hvor programmet laver et tilfældigt tal mellem 1 og 10, som brugeren skal gættes. 
//    Programmet skal fortælle om dit gæt er rigtigt, for højt eller for lavt. 
// b) Udvid ovenstående program således at man kan vælge om vil prøve et nyt spil når tallet er gættet. 
//    Kun ’n’, ’N’, ’j’ og ’J’ er gyldige indtastninger.
// c) Udbyg spillet således at det meddeler brugeren hvor mange forsøg han har tilbage, før tallet skal være gættet.

using System;
using System.Collections.Generic;
using System.Text;

namespace Loekker
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Rolling random..");
            int roll = Roll();

            while(true) {
                Console.Write("Guess number (1-10): ");
                int guess = int.Parse(Console.ReadLine());

                var a = guess switch {
                    int n when (roll == n) => "You guessed it! Try again? (y/n)",
                    int n when (roll < n) => "Too high, guess lower",
                    int n when (roll > n) => "Too low, guess higher",
                    _ => "..."
                };

                Console.WriteLine(a);

                if (guess == roll && Console.ReadLine() == "y") {
                    roll = Roll();
                }
                
                else if (guess == roll && Console.ReadLine() == "n") {
                    Console.WriteLine("Exiting program..");
                    break;
                }
            }
        }

        static int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, 11);
        }
    }
}
