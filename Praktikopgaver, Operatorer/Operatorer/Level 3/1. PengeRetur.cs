// PengeRetur.cs
// Lav et program, der beder brugeren om at indtaste et beløb, f.eks. kr. 27.75. 
// Programmet skal regne ud hvor mange 10-kroner, 5-kroner, 1-kroner, 50-ører og 25-ører 
// der skal gives tilbage på beløbet.

using System;
using System.Collections.Generic;
using System.Text;

namespace Operatorer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write amount: ");
            double amount = double.Parse(Console.ReadLine());
            int[] result = Calculate(amount);

            Console.WriteLine("10kr: {0} \n5kr {1} \n1kr {2} \n0.5kr {3} \n0.25 {4}", 
                result[0], result[1], result[2], result[3], result[4]);
        }

        static int[] Calculate(double amount)
        {
            double[] currencyValues = { 10, 5, 1, 0.5, 0.25 };
            int[] result = { 0, 0, 0, 0, 0 };

            for (int i = 0; i < currencyValues.Length; i++) {
                while (true) {
                    if (currencyValues[i] > amount) {
                        break;
                    }

                    amount -= currencyValues[i];
                    result[i]++;
                }
            }

            return result;
        }
    }
}