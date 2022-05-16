// FyldArray.cs
// Lav et program, som opretter et array med plads til 10 heltal. Derefter fyldes arrayet op med tallene fra 1 - 10.
// Udskriv derefter arrayet forfra. Udskriv derefter arrayet bagfra.

using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        int[] array = new int[10];

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i + 1;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + "\t");
        }

        Console.WriteLine();

        for (int i = array.Length -1; i >= 0; i--)
        {
            Console.Write(array[i] + "\t");
        } 
    }
}
