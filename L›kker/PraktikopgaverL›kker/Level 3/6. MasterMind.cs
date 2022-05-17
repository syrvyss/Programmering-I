// MasterMind.cs
// Lav et Mastermind-spil, der spiller efter følgende regler:
// Målet er at gætte den korrekte kode, som enten en modspiller eller programmet har lavet
// Koden indeholder 5 tilfældige tal fra 1 – 6
// Du har 8 forsøg
// Når du har afgivet dit gæt (5 cifre), viser programmet (måske) en 
// * for at markere at både nummeret og placeringen var korrekt
// o for at markere at nummeret var korrekt, men placeringen var ikke

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
            Console.Write("Guess the randomly generated number (5 numbers): ");
            MasterMind mastermind = new MasterMind();
            for (int i = 0; i < 8; i++)
            {
                if (mastermind.Guess(Console.ReadLine()))
                {
                    Console.WriteLine("You got it!");
                    break;
                }

                mastermind.PrintCode();
                Console.WriteLine("Sorry, try again. You are on try {0} out of 8: ", i+1);
            }
        }
    }

    class MasterMind {
        private char[] _code;
        private char[] _guess = {'x', 'x', 'x', 'x', 'x'}; 

        public MasterMind()
        {
            string str = "";
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
                str += rnd.Next(1, 7);

            _code = str.ToCharArray(); 
        }

        public bool Guess(string num) {
            if (num.ToCharArray() == _code) {
                return true;
            }

            _guess = new char[] {'x', 'x', 'x', 'x', 'x'};

            string a = new string(_code);
            Console.WriteLine("Code is {0}", a);
            
            _code
                .Where((item, i) => item == num[i])
                .Select((item, i) => this._guess[i] = '*');
            
            num
                .Where((item, i) => num.Contains(_code[i]))
                .Select((item, i) => this._guess[i] = 'o');

            /*
            for (int i = 0; i < num.Length; i++)
                for (int k = 0; k < num.Length; k++)
                {
                    if (this._code[k] == num[i])
                        this._guess[k] = '*';
                    else if (_code.Contains(_guess[i]))
                        this._guess[k] = 'o';
                }
            */

            return false;
        }

        public void PrintCode() {
            string a = new string(_guess);
            Console.WriteLine(a);
        }
    }
}
