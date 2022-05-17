// Fibonacci.cs
// Lav et program, der kan udskrive Fibonacci-tallene under 100

using System;
using System.Collections.Generic;
using System.Text;

namespace Loekker
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write max number of fibonacci sequence: ");
            int fiboNum = int.Parse(Console.ReadLine());

            Fibonacci(fiboNum).ForEach(i => Console.Write("{0}\t", i));
        }

        static List<ulong> Fibonacci(int fiboNum) 
        {
            List<ulong> list = new List<ulong>() { 1, 1 };
            for (int i = 0; i < fiboNum; i++)
                list.Add((ulong)list[i] + (ulong)list[i+1]);
            return list;
        }
    }
}
