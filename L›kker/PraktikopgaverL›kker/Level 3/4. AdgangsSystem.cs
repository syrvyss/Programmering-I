// AdgangsSystem.cs
// Lav et adgangssystem, hvor brugeren skal indtaste et brugerID og en 4-cifret kode for at få adgang. 
// Systemet tester om antallet af cifre passer og udskriver passende fejlmeddelelser. 
// Når koden er korrekt, får brugeren at vide at han har access til system.
// Opgaven udvides med en funktion, der kun giver lov til at lave 3 forkerte forsøg.

using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Loekker
{
    class Program
    {
        static void Main() 
        {
            Console.WriteLine("New account!");
            Console.Write("Enter userID: ");
            string userID = Console.ReadLine();

            Console.Write("Enter password (len: 4): ");
            string passwordStr = Console.ReadLine();

            if (passwordStr.Length != 4) {
                Console.WriteLine("Password not 4 chars, exiting program.");
                System.Environment.Exit(1);
            }

            int[] password = passwordStr.ToCharArray().Select(i => Int32.Parse(i.ToString())).ToArray();

            Bank bank1 = new Bank(userID, password);

            Console.WriteLine("Login:");
            for( int i = 0; i < 3; i++) 
            {
                Console.Write("Enter userID: ");
                string id = Console.ReadLine();

                Console.Write("Enter password: ");
                passwordStr = Console.ReadLine();
                password = passwordStr.ToCharArray().Select(i => Int32.Parse(i.ToString())).ToArray();

                bool logIn = bank1.EntryCheck(id, password);

                if (logIn == true)
                {
                    Console.WriteLine("You're in!");
                    break;
                }
                else {
                    Console.WriteLine("Sorry, try again. You are on try {0}.", i+1);
                }
            }
        }
    }

    class Bank 
    {
        public string userID;
        private int[] password = new int[4];

        public Bank(string id, int[] pass) {
            userID = id;
            password = pass;
        }

        public bool EntryCheck(string id, int[] pass) 
        {
            if (id == this.userID && pass.SequenceEqual(password)) 
            {
                return true;
            }
            return false;
        }
    }
}